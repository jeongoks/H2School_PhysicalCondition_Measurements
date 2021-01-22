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
            } while (!decimal.TryParse(Console.ReadLine(), out weight));                    // This is where the User types in their Data.
            
            do
            {
                Console.WriteLine("Please enter your Resting Heart Rate per minute:");

            } while (!decimal.TryParse(Console.ReadLine(), out restHR));                    // This is where the User types in their Data.

            do
            {
                Console.WriteLine("Please enter your Maximum Heart Rate per minute:");
            } while (!decimal.TryParse(Console.ReadLine(), out maxHR));                     // This is where the User types in their Data.
            #endregion

            Console.Clear();

            #region Showing what was typed in, Output.
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("This is what you've entered into the Calculator:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Weight: {weight}.\nResting Heart Rate: {restHR}.\nMaximum Heart Rate: {maxHR}");
            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region End result of the Calculations, Output.
            Console.WriteLine();
            Console.WriteLine("This is your results:");
            Console.WriteLine($"Your Physical Condition is: {PhysicalCondition.CalcPhyCondition(maxHR, restHR)}");
            Console.WriteLine($"Your Maximum 02 Consumption is: {PhysicalCondition.CalcO2Consumption(restHR, maxHR, weight)}");
            Console.WriteLine();
            #endregion

            Console.WriteLine("Press enter to exit the program.");
            Console.ReadLine();
        }
    }
}
