/*
* Student ID :1690700891
* Name       :Apivich-he
* Section    :129A
* No.        :32
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Shadow Dungeon: Shadow Knight Encounter ===");
            Console.WriteLine("A menacing Shadow Knight blocks your path!");
            Console.WriteLine("1) Slash with Sunsword");
            Console.WriteLine("2) Cast Holy Light");
            Console.WriteLine("3) Use Smoke Bomb");
            Console.Write("\nEnter your choice (1-3): ");

            bool isParsed = int.TryParse(Console.ReadLine(), out int choice);

            if (!isParsed)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("You strike with your Sunsword! The knight receives 40 holy damage.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You cast Holy Light! It blinds the knight and restores 25 HP to you.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You throw a Smoke Bomb and successfully retreat to safety!");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please select an option between 1 and 3.");
            }
        }
    }
}
