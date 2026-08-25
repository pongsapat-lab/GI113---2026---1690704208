/*
 * Student ID : 1690704208
 * Name       : Lab02
 * Section    : 129D
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
            //Part 1
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL ====="); 
            Console.WriteLine("Name: " + bossName);
            Console.WriteLine("Rank: " + rank);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Max Hp: " + currentHp+ "/" +maxHp);
            Console.WriteLine("Attack Power: " + attackPower);
            Console.WriteLine("Crit Multiplier: " + critMultiplier);
            Console.WriteLine("Is Boss: " + isBoss);
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine("Hp Percent: " + hpPercent+"%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            currentHp = currentHp - 60;

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine("Hp: " + currentHp + "/" + maxHp);
            Console.WriteLine("Hp Percent: " + hpPercent+ "%");

            //----------------------------------------------------------------------------------------------
            //Part 2
            // โครงพิมพ์ผล 1 ตัวละคร (ปรับ label ตามธีมของตัวเอง)
            // Console.WriteLine($"Name: {name}");
            // Console.WriteLine($"HP: {hp}");
            // Console.WriteLine($"Speed: {speed}");
            // ทำซ้ำแบบนี้ให้ครบ 4 ตัวละคร ตัวละ 5 stat
        }
    }
}
