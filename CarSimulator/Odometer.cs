using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CarSimulator
{
    class Odometer : IOdometer
    {
        private IEngine _engine;
        private Timer timer = new Timer();
        private int lastSpeed = 0;
        private DateTime lastTime = DateTime.Now;

        private double odo;

        public int Odo
        {
            get
            {
                return (int) odo;
            }

            private set
            {
                odo = value;
            }
        }

        public Odometer(IEngine engine)
        {
            _engine = engine;
            lastSpeed = engine.Speed;
            lastTime = DateTime.Now;
            Odo = 0;

            timer.AutoReset = true;
            timer.Interval = 100;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;
            odo += lastSpeed * (now - lastTime).TotalMilliseconds / 1000;

            lastSpeed = _engine.Speed;
            lastTime = DateTime.Now;

            OdoChanged?.Invoke(this, new OdoChangedArgs(Odo));
        }

        private int KmPerHourToMPerSec(int kmPerh)
        {
            return kmPerh * 1000 / 3600;
        }

        public event EventHandler<OdoChangedArgs> OdoChanged;
    }
}
