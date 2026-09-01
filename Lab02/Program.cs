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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //----------------------------------------------------------------------------------------------
            //Part 2
            // โครงพิมพ์ผล 1 ตัวละคร (ปรับ label ตามธีมของตัวเอง)
            // Console.WriteLine($"Name: {name}");
            // Console.WriteLine($"HP: {hp}");
            // Console.WriteLine($"Speed: {speed}");
            // ทำซ้ำแบบนี้ให้ครบ 4 ตัวละคร ตัวละ 5 stat
            //----------------------------------------------------------------------------------------------


            // 1
            string Member1 = "John";
            int m_1_maxHp = 15;
            int m_1_level = 19;
            float m_1_atk = 25.6f;
            double m_1_crit = 25;

            //2
            string Member2 = "Lisa";
            int m_2_maxHp = 45;
            int m_2_level = 16;
            float m_2_atk = 55.7f;
            double m_2_crit = -1;

            //3
            string Member3 = "Rose";
            int m_3_maxHp = 20;
            int m_3_level = 14;
            float m_3_atk = 7.1f;
            double m_3_crit = 5;

            //4
            string miniBoss = "Raja";
            char mini_Danger = 'B';
            int mini_level = 20;
            int mini_maxHp = 240;
            float mini_atk = 12.5f;
            double mini_crit = 7.25;
            bool isminiBoss = true;


            Console.WriteLine("WARNING! WARNING MINI BOSS AHEAD! WARNING! WARNING!");
            Console.WriteLine($"Name: {miniBoss}");
            Console.WriteLine($"Rank: {mini_Danger}");
            Console.WriteLine($"Level: {mini_level}");
            Console.WriteLine($"Max Hp: {mini_maxHp}");
            Console.WriteLine($"Attack Power: {mini_atk}");
            Console.WriteLine($"Crit Multiplier: {mini_crit}");
            Console.WriteLine($"Is Boss: {isminiBoss}");
            Console.WriteLine();

            Console.WriteLine("Parth Member");
            Console.WriteLine($"Name: {Member1}");
            Console.WriteLine($"Level:  {m_1_level}");
            Console.WriteLine($"Max Hp: {m_1_maxHp}");
            Console.WriteLine($"Attack Power: {m_1_atk}");
            Console.WriteLine($"Crit Multiplier: {m_1_crit}");
            Console.WriteLine();

            Console.WriteLine($"Name: {Member2}");
            Console.WriteLine($"Level:  {m_2_level}");
            Console.WriteLine($"Max Hp: {m_2_maxHp}");
            Console.WriteLine($"Attack Power: {m_2_atk}");
            Console.WriteLine($"Crit Multiplier: {m_2_crit}");
            Console.WriteLine();

            Console.WriteLine($"Name: {Member3}");
            Console.WriteLine($"Level:  {m_3_level}");
            Console.WriteLine($"Max Hp: {m_3_maxHp}");
            Console.WriteLine($"Attack Power: {m_3_atk}");
            Console.WriteLine($"Crit Multiplier: {m_3_crit}");
            Console.WriteLine();

            Console.WriteLine("     ENGAGE!");



        }
    }
}
