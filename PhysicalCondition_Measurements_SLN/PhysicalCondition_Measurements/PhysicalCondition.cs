using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalCondition_Measurements
{
    class PhysicalCondition
    {
        public decimal Weight { get; set; }
        public decimal MaxHR { get; set; }
        public decimal RestHR { get; set; }

        public PhysicalCondition(decimal maxHR, decimal restHR, decimal weight)
        {
            Weight = weight;
            MaxHR = maxHR;
            RestHR = restHR;
        }

        /// <summary>
        /// This is where we calculate the Physical Condition, using the Users input.
        /// </summary>
        /// <returns></returns>
        public decimal CalcPhyCondition()
        {
            decimal phyCond = 0;

            phyCond = MaxHR / RestHR * (decimal)15.3;

            return Decimal.Round(phyCond);
        }

        public static void CalcO2Consumption()
        {

        }
    }
}
