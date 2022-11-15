using BlazorServerDataGridSampleWithDataChart.Data.Models;

namespace BlazorServerDataGridSampleWithDataChart.Data.DataSource
{
    public class EnergyDataSource : List<EnergyProduction>
    {
        public EnergyDataSource()
        {
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(0), Region = "America", Country = "CAN", Coal = 625, Oil = 100, Gas = 0, Nuclear = 0, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(1), Region = "Asia", Country = "CHN", Coal = 0, Oil = 200, Gas = 750, Nuclear = 0, Hydro = 625 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(2), Region = "Europe", Country = "RUS", Coal = 1050, Oil = 200, Gas = 0, Nuclear = 0, Hydro = 425 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(3), Region = "Asia", Country = "AUS", Coal = 0, Oil = 100, Gas = 550, Nuclear = 0, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(4), Region = "America", Country = "USA", Coal = 1400, Oil = 250, Gas = 0, Nuclear = 0, Hydro = 750 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(5), Region = "Europe", Country = "FRA", Coal = 0, Oil = 150, Gas = 750, Nuclear = 0, Hydro = 325 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(6), Region = "America", Country = "CAN", Coal = 400, Oil = 100, Gas = 0, Nuclear = 225, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(7), Region = "Asia", Country = "CHN", Coal = 0, Oil = 200, Gas = 750, Nuclear = 0, Hydro = 625 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(8), Region = "Europe", Country = "RUS", Coal = 550, Oil = 200, Gas = 0, Nuclear = 475, Hydro = 425 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(9), Region = "Asia", Country = "AUS", Coal = 0, Oil = 100, Gas = 550, Nuclear = 0, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(10), Region = "America", Country = "USA", Coal = 450, Oil = 250, Gas = 0, Nuclear = 575, Hydro = 750 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(11), Region = "Europe", Country = "FRA", Coal = 0, Oil = 150, Gas = 750, Nuclear = 0, Hydro = 325 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(12), Region = "Europe", Country = "RUS", Coal = 375, Oil = 200, Gas = 0, Nuclear = 475, Hydro = 425 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(13), Region = "Asia", Country = "AUS", Coal = 0, Oil = 100, Gas = 550, Nuclear = 0, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(14), Region = "America", Country = "USA", Coal = 450, Oil = 250, Gas = 0, Nuclear = 575, Hydro = 750 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(15), Region = "Europe", Country = "FRA", Coal = 0, Oil = 150, Gas = 750, Nuclear = 0, Hydro = 325 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(16), Region = "America", Country = "CAN", Coal = 0, Oil = 100, Gas = 0, Nuclear = 625, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(17), Region = "Asia", Country = "CHN", Coal = 0, Oil = 200, Gas = 750, Nuclear = 0, Hydro = 625 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(18), Region = "Europe", Country = "RUS", Coal = 0, Oil = 200, Gas = 0, Nuclear = 875, Hydro = 425 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(19), Region = "Asia", Country = "AUS", Coal = 0, Oil = 100, Gas = 550, Nuclear = 0, Hydro = 350 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(20), Region = "America", Country = "USA", Coal = 0, Oil = 250, Gas = 0, Nuclear = 900, Hydro = 750 });
            Add(new EnergyProduction { Date = DateTime.Today.AddHours(21), Region = "Europe", Country = "FRA", Coal = 0, Oil = 150, Gas = 750, Nuclear = 0, Hydro = 325 });
        }
    }
}
