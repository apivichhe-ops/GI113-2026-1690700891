/*
* Student ID :1690700891
* Name       :Apivich-he
* Section    :129A
* No.        :32
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        const string MaterialName = "Iron";
        const double SmeltRate = 0.2500;
        const double SalvageRate = 0.3000;
        const double MaxBatch = 500.0;

        static void Main(string[] args)
        {
            System.Console.WriteLine($"--- {MaterialName} Forge (Smelt: {SmeltRate} / Salvage: {SalvageRate}) ---");
            System.Console.Write("Choose Menu (S: Smelt, B: Breakdown): ");
            bool isMenuValid = char.TryParse(System.Console.ReadLine(), out char menu);

            System.Console.Write("How much would you like: ");
            bool isAmountValid = double.TryParse(System.Console.ReadLine(), out double amount);

            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                if (isMenuValid && (menu == 'S' || menu == 's'))
                {
                    System.Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {amount * SmeltRate:F2} {MaterialName} Ingot");
                }
                else if (isMenuValid && (menu == 'B' || menu == 'b'))
                {
                    System.Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {amount / SalvageRate:F2} {MaterialName} Ore");
                }
                else
                {
                    System.Console.WriteLine("Error: Invalid menu selection.");
                }
            }
            else
            {
                System.Console.WriteLine($"Error: Invalid amount (Must be > 0 and <= {MaxBatch:F2}).");
            }
        }
    }
}