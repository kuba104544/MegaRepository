using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSimulator
{
    public partial class SpeedometerForm : Form
    {
        Label speedResult;
        Label kilometerUnit;
       
        public SpeedometerForm(IEngine engine)
        {
            InitializeComponent();

            speedResult = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                Height = this.Height-38,
                Width = this.Width-13
            };
      


           this.Controls.Add(speedResult);
            engine.SpeedChanged += Engine_SpeedChanged;
            CheckSpeed(engine.Speed);
            
        }

        private void Engine_SpeedChanged(object sender, SpeedChangedArgs e)
        {
            CheckSpeed(e.Speed);
        }
        private void CheckSpeed(double speed)
        {
            this.speedResult.Text = Convert.ToString(speed+" km/h");
            if (speed <= 20)
            {
                this.speedResult.Font = new Font("Arial", 25);
                this.speedResult.Width = this.Width - 13;
                this.speedResult.Height = this.Height - 38;
                this.BackColor = Color.FromArgb(124, 252, 0);
            }
            else if (speed > 20 && speed <= 100)
            {
                this.speedResult.Font = new Font("Arial", 45);
                this.speedResult.Width = this.Width - 25;
                this.speedResult.Height = this.Height - 75;
                this.BackColor = Color.FromArgb(255, 165, 0);
            }
            else
            {
                this.speedResult.Font = new Font("Arial", 65);
        
                this.BackColor = Color.FromArgb(255, 0, 0);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
