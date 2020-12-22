namespace CarSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.lSpeed = new System.Windows.Forms.Label();
            this.lOdo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bSpeedometer = new System.Windows.Forms.Button();
            this.bOdometer = new System.Windows.Forms.Button();
            this.GB_Engine = new System.Windows.Forms.GroupBox();
            this.gb_MetersDriven = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSpeedDown = new System.Windows.Forms.Button();
            this.bSpeedUp = new System.Windows.Forms.Button();
            this.GB_Meters = new System.Windows.Forms.GroupBox();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.GB_Engine.SuspendLayout();
            this.gb_MetersDriven.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GB_Meters.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(6, 28);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(91, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lSpeed
            // 
            this.lSpeed.AutoSize = true;
            this.lSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSpeed.Location = new System.Drawing.Point(5, 26);
            this.lSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSpeed.Name = "lSpeed";
            this.lSpeed.Size = new System.Drawing.Size(20, 24);
            this.lSpeed.TabIndex = 1;
            this.lSpeed.Text = "0";
            // 
            // lOdo
            // 
            this.lOdo.AutoSize = true;
            this.lOdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOdo.Location = new System.Drawing.Point(5, 26);
            this.lOdo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOdo.Name = "lOdo";
            this.lOdo.Size = new System.Drawing.Size(20, 24);
            this.lOdo.TabIndex = 2;
            this.lOdo.Text = "0";
            // 
            // bSpeedometer
            // 
            this.bSpeedometer.Location = new System.Drawing.Point(22, 28);
            this.bSpeedometer.Margin = new System.Windows.Forms.Padding(2);
            this.bSpeedometer.Name = "bSpeedometer";
            this.bSpeedometer.Size = new System.Drawing.Size(120, 23);
            this.bSpeedometer.TabIndex = 3;
            this.bSpeedometer.Text = "Speedometer";
            this.bSpeedometer.UseVisualStyleBackColor = true;
            this.bSpeedometer.Click += new System.EventHandler(this.button1_Click);
            // 
            // bOdometer
            // 
            this.bOdometer.Location = new System.Drawing.Point(146, 28);
            this.bOdometer.Margin = new System.Windows.Forms.Padding(2);
            this.bOdometer.Name = "bOdometer";
            this.bOdometer.Size = new System.Drawing.Size(127, 23);
            this.bOdometer.TabIndex = 4;
            this.bOdometer.Text = "Odometer";
            this.bOdometer.UseVisualStyleBackColor = true;
            this.bOdometer.Click += new System.EventHandler(this.button2_Click);
            // 
            // GB_Engine
            // 
            this.GB_Engine.Controls.Add(this.gb_MetersDriven);
            this.GB_Engine.Controls.Add(this.groupBox1);
            this.GB_Engine.Controls.Add(this.bSpeedDown);
            this.GB_Engine.Controls.Add(this.bSpeedUp);
            this.GB_Engine.Controls.Add(this.bStart);
            this.GB_Engine.Location = new System.Drawing.Point(42, 56);
            this.GB_Engine.Name = "GB_Engine";
            this.GB_Engine.Size = new System.Drawing.Size(302, 169);
            this.GB_Engine.TabIndex = 5;
            this.GB_Engine.TabStop = false;
            this.GB_Engine.Text = "Engine";
            // 
            // gb_MetersDriven
            // 
            this.gb_MetersDriven.Controls.Add(this.lOdo);
            this.gb_MetersDriven.Location = new System.Drawing.Point(103, 72);
            this.gb_MetersDriven.Name = "gb_MetersDriven";
            this.gb_MetersDriven.Size = new System.Drawing.Size(193, 66);
            this.gb_MetersDriven.TabIndex = 7;
            this.gb_MetersDriven.TabStop = false;
            this.gb_MetersDriven.Text = "Meters driven";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lSpeed);
            this.groupBox1.Location = new System.Drawing.Point(30, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(67, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Km/h";
            // 
            // bSpeedDown
            // 
            this.bSpeedDown.Location = new System.Drawing.Point(206, 28);
            this.bSpeedDown.Name = "bSpeedDown";
            this.bSpeedDown.Size = new System.Drawing.Size(90, 23);
            this.bSpeedDown.TabIndex = 4;
            this.bSpeedDown.Text = "Speed Down";
            this.bSpeedDown.UseVisualStyleBackColor = true;
            this.bSpeedDown.Click += new System.EventHandler(this.bSpeedDown_Click);
            this.bSpeedDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bSpeedDown_MouseDown);
            this.bSpeedDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bSpeedDown_MouseUp);
            // 
            // bSpeedUp
            // 
            this.bSpeedUp.Location = new System.Drawing.Point(103, 28);
            this.bSpeedUp.Name = "bSpeedUp";
            this.bSpeedUp.Size = new System.Drawing.Size(97, 23);
            this.bSpeedUp.TabIndex = 3;
            this.bSpeedUp.Text = "Speed Up";
            this.bSpeedUp.UseVisualStyleBackColor = true;
            this.bSpeedUp.Click += new System.EventHandler(this.bSpeedUp_Click);
            this.bSpeedUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bSpeedUp_MouseDown);
            this.bSpeedUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bSpeedUp_MouseUp);
            // 
            // GB_Meters
            // 
            this.GB_Meters.Controls.Add(this.bSpeedometer);
            this.GB_Meters.Controls.Add(this.bOdometer);
            this.GB_Meters.Location = new System.Drawing.Point(350, 56);
            this.GB_Meters.Name = "GB_Meters";
            this.GB_Meters.Size = new System.Drawing.Size(292, 73);
            this.GB_Meters.TabIndex = 6;
            this.GB_Meters.TabStop = false;
            this.GB_Meters.Text = "External Speedometer and Odometer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB_Meters);
            this.Controls.Add(this.GB_Engine);
            this.Name = "Form1";
            this.Text = "Car Simulator";
            this.GB_Engine.ResumeLayout(false);
            this.gb_MetersDriven.ResumeLayout(false);
            this.gb_MetersDriven.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_Meters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label lSpeed;
        private System.Windows.Forms.Label lOdo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bSpeedometer;
        private System.Windows.Forms.Button bOdometer;
        private System.Windows.Forms.GroupBox GB_Engine;
        private System.Windows.Forms.GroupBox GB_Meters;
        private System.Windows.Forms.Button bSpeedUp;
        private System.Windows.Forms.Button bSpeedDown;
        private System.Windows.Forms.GroupBox gb_MetersDriven;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerSpeed;
    }
}

