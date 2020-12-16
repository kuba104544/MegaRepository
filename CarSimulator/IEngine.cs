using System;

namespace CarSimulator
{
    public interface IEngine
    {
        //returns current speed in range -20 - 180 km/h
        int Speed { get; }

        //is raised every time when speed was changed
        event EventHandler<SpeedChangedArgs> SpeedChanged;

        void SpeedUp(int value);
        void SpeedDown(int value);
    }
}
