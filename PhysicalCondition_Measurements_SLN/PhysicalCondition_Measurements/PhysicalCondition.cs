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
        public static decimal CalcPhyCondition(decimal maxHR, decimal restHR)
        {
            decimal phyCond = 0;

            phyCond = maxHR / restHR * (decimal)15.3;

            return Decimal.Round(phyCond);
        }

        /// <summary>
        /// This is where we calculate the Maximum 02 Consumption, using the User's input.
        /// </summary>
        /// <returns></returns>
        public static decimal CalcO2Consumption(decimal restHR, decimal maxHR, decimal weight)
        {
            decimal oxyCons = 0;

            oxyCons = PhysicalCondition.CalcPhyCondition(maxHR, restHR) * weight / 1000;

            return Decimal.Round(oxyCons, 1);
        }
    }
}
