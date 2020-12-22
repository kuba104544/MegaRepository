using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Engine : IEngine
    {
        private int _speed;
        public int Speed 
        {
           
            get { return this._speed; }
            private set
            {
                int newValue = Math.Max(-20, Math.Min(value, 180));
                this._speed = newValue;
                OnSpeedChanged(this._speed);
            }
        }

        public event EventHandler<SpeedChangedArgs> SpeedChanged;

        public void SpeedDown(int value)
        {
            Speed -= value;
        }
        public void SpeedUp(int value)
        {
            Speed += value;
        }

        protected virtual void OnSpeedChanged(int newSpeed)
        {
            SpeedChanged?.Invoke(this, new SpeedChangedArgs(newSpeed));
        }
    }
}
