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
    public partial class Form1 : Form
    {
        IEngine engine = null;
        IOdometer odometer = null;
        bool isOpenSpeedWindow = true;
        SpeedometerForm speedometer;
        private bool btnSpeedUpPressed = false;
        private bool btnSpeedDownPressed = false;

        public Form1()
        {
            InitializeComponent();

            engine = new Engine();
            odometer = new Odometer(engine);
            timerSpeed.Interval = 50;
            timerSpeed.Tick += TimerSpeed_Tick;
        }

        private void TimerSpeed_Tick(object sender, EventArgs e)
        {
            if (btnSpeedUpPressed)
                engine.SpeedUp(1);
            else if (btnSpeedDownPressed)
                engine.SpeedDown(2);
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            odometer.OdoChanged += Odometer_OdoChanged;
            engine.SpeedChanged += Engine_SpeedChanged;
            engine.SpeedUp(10);

            bStart.Enabled = false;
        }

        private void Engine_SpeedChanged(object sender, SpeedChangedArgs e)
        {
            lSpeed.Text = e.Speed.ToString();
        }

        private void Odometer_OdoChanged(object sender, OdoChangedArgs e)
        {
            lOdo.Invoke((Action) delegate { lOdo.Text = e.Odo.ToString(); });
        }

        private void button1_Click(object sender, EventArgs e)
        {

    
                speedometer = new SpeedometerForm(engine);
                speedometer.Show();
       
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  new OdometerForm(odometer).Show();

        }

        private void bSpeedUp_MouseDown(object sender, MouseEventArgs e)
        {
            btnSpeedUpPressed = true;
            timerSpeed.Enabled = true;
            timerSpeed.Start();
        }

        private void bSpeedUp_MouseUp(object sender, MouseEventArgs e)
        {
            timerSpeed.Stop();
            timerSpeed.Enabled = false;
            btnSpeedUpPressed = false;
        }

        private void bSpeedDown_MouseDown(object sender, MouseEventArgs e)
        {
            btnSpeedDownPressed = true;
            timerSpeed.Enabled = true;
            timerSpeed.Start();
        }

        private void bSpeedDown_MouseUp(object sender, MouseEventArgs e)
        {
            timerSpeed.Stop();
            timerSpeed.Enabled = false;
            btnSpeedDownPressed = false;
        }
    }
}
