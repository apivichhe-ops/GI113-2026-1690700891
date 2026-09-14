/*
* Student ID :1690700891
* Name       :Apivich-he
* Section    :129A
* No.        :32
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. const (PascalCase) — ชื่อองค์กร/เกมที่ไม่เปลี่ยน
            const string GameTitle = "Honkai Impact 3rd";
            const string Organization = "Schicksal HQ";

            // 2. var — อย่างน้อย 2 ตัว (มี string และ char)
            var valkyrieName = "Kiana Kaslana";  // var บน string
            var valkyrieRank = 'S';              // var บน char

            // 3. ชนิดข้อมูลพื้นฐานครบ 6 ชนิด ตามธีม Honkai
            // string : valkyrieName (ผ่าน var)
            // char   : valkyrieRank (ผ่าน var)
            int valkyrieLevel = 80;               // int
            float critRate = 0.65f;               // float
            double spRegenPrecise = 95.8;         // double (เลขหลังจุด >= .5 เพื่อทดสอบการแปลงชนิด)
            bool isHerrscherMode = true;          // bool

            // 4. Output: จัดรูปแบบ Stat Card สไตล์เกม Honkai
            Console.WriteLine("==============================================");
            Console.WriteLine($"       <<< {GameTitle} >>>");
            Console.WriteLine($"       Command: {Organization}");
            Console.WriteLine("==============================================");
            Console.WriteLine($" Valkyrie Name: {valkyrieName}");
            Console.WriteLine($" Rank Grade   : Rank [{valkyrieRank}]");
            Console.WriteLine($" Level        : Lv. {valkyrieLevel}");
            Console.WriteLine($" Crit Rate    : {critRate}");
            Console.WriteLine($" SP Regen     : {spRegenPrecise}%");
            Console.WriteLine($" Herrscher    : Active ({isHerrscherMode})");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            // 5. Implicit Conversion (int -> double) โดยไม่มี Cast
            double levelAsDouble = valkyrieLevel;
            Console.WriteLine($"[Hyperion Log] Level converted implicitly : {levelAsDouble}");

            // 6. Explicit Cast vs Convert.ToInt32() บนค่า 95.8
            int spTruncated = (int)spRegenPrecise;               // Cast ตัดเศษ -> 95
            int spRounded = Convert.ToInt32(spRegenPrecise);      // Convert ปัดเศษ -> 96

            Console.WriteLine($"[Hyperion Log] SP Regen (int) cast       : {spTruncated}");
            Console.WriteLine($"[Hyperion Log] SP Regen Convert.ToInt    : {spRounded}");
            Console.WriteLine("==============================================");
        }
    }
}