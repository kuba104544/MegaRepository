namespace CarSimulator
{
    public class OdoChangedArgs
    {
        public int Odo { get; private set; }

        public OdoChangedArgs(int odo)
        {
            Odo = odo;
        }
    }
}