using System;

namespace CarSimulator
{
    public class SpeedChangedArgs : EventArgs
    {
        public int Speed { get; private set; }

        public SpeedChangedArgs(int speed)
        {
            Speed = speed;
        }
    }
}