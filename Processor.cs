namespace Lab3_WinForms_Processor
{
    public class Processor
    {
        public string Brand;
        public string Model;
        public int Generation;
        public double Frequency;
        public int Cores;
        public bool HasIntegratedGraphics;
        public int Year;
        public int Cache;

        public double CalculatePerformance()
        {
            return (Frequency * Cores) * (1 + Cache / 100.0);
        }

        public override string ToString()
        {
            return $"{Brand} {Model}, {Cores} cores @ {Frequency}GHz, Year: {Year}, Cache: {Cache}MB, Integrated Graphics: {(HasIntegratedGraphics ? "Yes" : "No")}";
        }
    }
}
