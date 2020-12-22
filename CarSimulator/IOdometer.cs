using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    public interface IOdometer
    {
        //implementation should probably have private set
        //returns number of meters driven from start
        int Odo { get; }

        event EventHandler<OdoChangedArgs> OdoChanged;
    }
}
