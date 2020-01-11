using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB = DnD_Character_Sheet.Library;
using LC = DnD_Character_Sheet.Constants;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    public class Calculations
    {
        /// <summary>
        /// This method calculates the characters Proficiency Bonus for skills
        /// </summary>
        /// <param name="proficient"></param>
        /// <param name="modifier"></param>
        /// <returns></returns>
        public static string Bonus(bool proficient, int modifier)
        {
            int bonus = modifier;
            if (proficient)
            {
                bonus += LIB.m_MainCharacterInfo.ProficiencyBonus;
            }

            if (bonus >= 0)
            {
                return "+ " + bonus;
            }

            return "- " + bonus;
        }

        /// <summary>
        /// This method calculates the characters level based on XP
        /// </summary>
        /// <returns></returns>
        public static int Level()
        {
            int XP = LIB.m_MainCharacterInfo.ExperiencePoints;
            if (XP < 300)
            {
                return 1;
            }
            else if (XP >= 300 && XP < 900)
            {
                return 2;
            }
            else if (XP >= 900 && XP < 2700)
            {
                return 3;
            }
            else if (XP >= 2700 && XP < 6500)
            {
                return 4;
            }
            else if (XP >= 6500 && XP < 14000)
            {
                return 5;
            }
            else if (XP >= 14000 && XP < 23000)
            {
                return 6;
            }
            else if (XP >= 23000 && XP < 34000)
            {
                return 7;
            }
            else if (XP >= 34000 && XP < 48000)
            {
                return 8;
            }
            else if (XP >= 48000 && XP < 64000)
            {
                return 9;
            }
            else if (XP >= 64000 && XP < 85000)
            {
                return 10;
            }
            else if (XP >= 85000 && XP < 100000)
            {
                return 11;
            }
            else if (XP >= 100000 && XP < 120000)
            {
                return 12;
            }
            else if (XP >= 120000 && XP < 140000)
            {
                return 13;
            }
            else if (XP >= 140000 && XP < 165000)
            {
                return 14;
            }
            else if (XP >= 165000 && XP < 195000)
            {
                return 15;
            }
            else if (XP >= 195000 && XP < 225000)
            {
                return 16;
            }
            else if (XP >= 225000 && XP < 265000)
            {
                return 17;
            }
            else if (XP >= 265000 && XP < 305000)
            {
                return 18;
            }
            else if (XP >= 305000 && XP < 355000)
            {
                return 19;
            }
            else
            {
                return 20;
            }
        }

        /// <summary>
        /// This method calculates the characters carrying weight
        /// </summary>
        public static void CarryWeight()
        {
            LIB.m_MainCharacterInfo.CarryingWeight = 0;
            foreach (var key in LIB.m_MainCharacterInfo.Items.Keys)
            {
                CLIB.Item item = LIB.m_MainCharacterInfo.Items[key];
                LIB.m_MainCharacterInfo.CarryingWeight += item.Weight * item.Quantity;
            }

            foreach (var key in LIB.m_MainCharacterInfo.Weapons.Keys)
            {
                CLIB.Weapon weapon = LIB.m_MainCharacterInfo.Weapons[key];
                LIB.m_MainCharacterInfo.CarryingWeight += weapon.Weight * weapon.Quantity;
            }

            foreach (var key in LIB.m_MainCharacterInfo.Armor.Keys)
            {
                CLIB.Armor armor = LIB.m_MainCharacterInfo.Armor[key];
                LIB.m_MainCharacterInfo.CarryingWeight += armor.Weight * armor.Quantity;
            }
        }

        /// <summary>
        /// This method calculates random dice roll values
        /// </summary>
        /// <param name="diceInput">Format = "6d10", "3d12 + 15", "3d3 - 3", etc.</param>
        /// <returns>Roll Value</returns>
        public static int Dice(string diceInput)
        {
            int result = 0;

            char[] charArg = new char[] { 'd', 'D', '-', '+' };
            var diceSplit = diceInput.Split(charArg);
            int diceMultiplyer = int.Parse(diceSplit[0]);
            int diceType = int.Parse(diceSplit[1]);
            int modifier = diceSplit.Length == 2 ? 0 : int.Parse(diceSplit[2]);

            Random rnd = new Random();
            for (int i = 0; i < diceMultiplyer; i++)
            {
                result += rnd.Next(1, diceType);
            }
            result += modifier;
            return result;
        }
    }
}
