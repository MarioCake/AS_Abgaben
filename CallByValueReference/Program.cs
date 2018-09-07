using System;

namespace CallByValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterAnalyzer analyzer = new WaterAnalyzer();
            WaterCustomer customer = new WaterCustomer()
            {
                Address = "Dorfstraße 1, Berlin",
                Name = "Hans Meier",
                HasGardenWaterConnection = true,
                WaterUsage = 103994.53
            };
            WaterDatabaseConnection db = new WaterDatabaseConnection();

            Console.WriteLine("Water Quality: {0}", analyzer.CalculateWaterQuality());
            Console.WriteLine("Water Ph Value: {0}", analyzer.GetPhMeasurement());
            Console.WriteLine("Save Water Analyzer: {0}", db.SaveWaterAnalysis(analyzer));
            Console.WriteLine("Save Water Customer: {0}", db.SaveCustomer(customer));

            analyzer.SetFilterFanSpeed(42);

            Console.ReadKey();
        }
    }
}
