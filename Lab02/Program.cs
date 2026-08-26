/*
* Student ID :1690700990
* Name       :teeratap_yote
* Section    :129A
* No.        :
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: 47%");

            //Lab02 Part 02
            // === Character 1: Traveler (Anemo) ===
            string name1 = "Aether";      // 1. string
            int level1 = 90;              // 2. int
            float atk1 = 1850.5f;         // 3. float
            char element1 = 'A';          // 4. char (A = Anemo)
            bool isAlive1 = true;         // 5. bool

            // === Character 2: Zhongli (Geo) ===
            string name2 = "Zhongli";     // string
            int level2 = 90;              // int
            double hp2 = 45000.75;        // 6. double (ครบ 6 ชนิดข้อมูลแล้ว)
            char element2 = 'G';          // char (G = Geo)
            bool isAlive2 = true;         // bool

            // === Character 3: Hu Tao (Pyro) ===
            string name3 = "Hu Tao";      // string
            int level3 = 90;              // int
            float atk3 = 3200.0f;         // float
            double critRate3 = 75.25;     // double
            bool isAlive3 = false;        // bool

            // === Character 4: Raiden Shogun (Electro) ===
            string name4 = "Raiden";      // string
            int level4 = 90;              // int
            double er4 = 270.80;          // double (Energy Recharge)
            char element4 = 'E';          // char (E = Electro)
            bool isAlive4 = true;         // bool

            // === Display Stats ===
            Console.WriteLine($"--- Character 1: {name1} ---");
            Console.WriteLine($"Level: {level1}");
            Console.WriteLine($"ATK: {atk1}");
            Console.WriteLine($"Element: {element1}");
            Console.WriteLine($"Is Alive: {isAlive1}\n");

            Console.WriteLine($"--- Character 2: {name2} ---");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"Max HP: {hp2}");
            Console.WriteLine($"Element: {element2}");
            Console.WriteLine($"Is Alive: {isAlive2}\n");

            Console.WriteLine($"--- Character 3: {name3} ---");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine($"ATK: {atk3}");
            Console.WriteLine($"CRIT Rate: {critRate3}%");
            Console.WriteLine($"Is Alive: {isAlive3}\n");

            Console.WriteLine($"--- Character 4: {name4} ---");
            Console.WriteLine($"Level: {level4}");
            Console.WriteLine($"Energy Recharge: {er4}%");
            Console.WriteLine($"Element: {element4}");
            Console.WriteLine($"Is Alive: {isAlive4}");
        }
    }
}