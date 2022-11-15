namespace BlazorServerDataGridSampleWithDataChart.Data.Models
{

    public class EnergyProduction
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public DateTime Date { get; set; }

        // Non-Renewable Energy Sources
        public double Nuclear { get; set; }
        public double Coal { get; set; }
        public double Oil { get; set; }
        public double Gas { get; set; }
        // Renewable Energy Sources
        public double Hydro { get; set; }

    }
}
