using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Odometer : IOdometer
    {
        private IEngine _engine;
        

        public int Odo
        {
            get; private set;
        }

        Odometer(IEngine engine)
        {
            _engine = engine;
        }

        public event EventHandler<OdoChangedArgs> OdoChanged;
    }
}
