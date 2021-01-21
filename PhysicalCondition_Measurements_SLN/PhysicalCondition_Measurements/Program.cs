using System;

namespace PhysicalCondition_Measurements
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal weight = 0;
            decimal restHR = 0;
            decimal maxHR = 0;

            #region User types in Data, Input.
            do
            {
                Console.WriteLine("Please enter your Weight in KG:");
            } while (!decimal.TryParse(Console.ReadLine(), out weight));
            
            do
            {
                Console.WriteLine("Please enter your Resting Heart Rate per minute:");

            } while (!decimal.TryParse(Console.ReadLine(), out restHR));
            
            do
            {
                Console.WriteLine("Please enter your Maximum Heart Rate per minute:");
            } while (!decimal.TryParse(Console.ReadLine(), out maxHR));
            #endregion

            PhysicalCondition physicalCondition = new PhysicalCondition(maxHR, restHR, weight);
            Console.WriteLine($"Your Physical Condition is: {physicalCondition.CalcPhyCondition()}");

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Weight: {weight}.\nResting Heart Rate: {restHR}.\nMaximum Heart Rate: {maxHR}");
            Console.WriteLine();
            Console.WriteLine("Press enter to exit the program.");
            Console.ReadLine();
        }
    }
}
