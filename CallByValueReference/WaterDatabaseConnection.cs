using School;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallByValueReference
{
    public class WaterDatabaseConnection
    {
        public bool SaveWaterAnalysis(WaterAnalyzer analyzer)
        {
            // Call Stored Procedure (st_verschmutzungsgrad) to save in Database ...
            
            Grade grade = analyzer.CalculateWaterQuality();

            return Helper.RandomBool((double)grade / 6.0d);
        }

        public bool SaveCustomer(WaterCustomer customer)
        {
            // Call Stored Procedure (st_kunden) to save in Database ...

            return Helper.RandomBool(0.9d);
        }

    }
}
