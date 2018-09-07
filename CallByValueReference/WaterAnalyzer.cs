
using School;
using System;
using System.Linq;

namespace CallByValueReference
{
    public class WaterAnalyzer
    {
        private readonly Grade ammoniacValue;
        private readonly Grade ammoniumValue;
        private readonly Grade nitriteValue;
        private readonly Grade nitrateValue;
        private readonly Grade phosphateValue;

        private Com1Interface com1;

        public WaterAnalyzer()
        {
            ammoniacValue = Helper.RandomEnumValue<Grade>();
            ammoniumValue = Helper.RandomEnumValue<Grade>();
            nitriteValue = Helper.RandomEnumValue<Grade>();
            nitrateValue = Helper.RandomEnumValue<Grade>();
            phosphateValue = Helper.RandomEnumValue<Grade>();

            com1 = new Com1Interface();
        }


        public Grade GetAmmoniacMeasurement()
        {
            return ammoniacValue;
        }

        public Grade GetAmmoniumMeasurement()
        {
            return ammoniumValue;
        }

        public Grade GetNitriteMeasurement()
        {
            return nitrateValue;
        }

        public Grade GetNitrateMeasurement()
        {
            return nitrateValue;
        }

        public Grade GetPhosphateMeasurement()
        {
            return phosphateValue;
        }

        public Grade CalculateWaterQuality()
        {
            Grade[] qualities =
            {
                GetAmmoniacMeasurement(),
                GetAmmoniumMeasurement(),
                GetNitriteMeasurement(),
                GetNitrateMeasurement(),
                GetPhosphateMeasurement()
            };

            Grade gradeAvg = (Grade)(int)Math.Round(qualities.Average(grade => (decimal)grade));

            return gradeAvg;

        }

        public int GetPhMeasurement()
        {
            using (com1)
            {
                if (!com1.IsOpen())
                    com1.Open();

                double voltage = com1.Read();

                return (int)Math.Round(voltage * 14);
            }
        }

        public void SetFilterFanSpeed(byte strength)
        {
            // Use com interface to set Fan speed
        }
    }
}
