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
                CLIB.Item_Class item = LIB.m_MainCharacterInfo.Items[key];
                LIB.m_MainCharacterInfo.CarryingWeight += item.Weight * item.Quantity;
            }

            foreach (var key in LIB.m_MainCharacterInfo.Weapons.Keys)
            {
                CLIB.Weapon_Class weapon = LIB.m_MainCharacterInfo.Weapons[key];
                LIB.m_MainCharacterInfo.CarryingWeight += weapon.Weight * weapon.Quantity;
            }

            foreach (var key in LIB.m_MainCharacterInfo.Armor.Keys)
            {
                CLIB.Armor_Class armor = LIB.m_MainCharacterInfo.Armor[key];
                LIB.m_MainCharacterInfo.CarryingWeight += armor.Weight * armor.Quantity;
            }
        }
      
      
        public static int dice(string arg) //accepts strings in formats like "d6", "6d10", "3d12 + 15", "3d3 - 3", etc
        {
            
            int loop; //how many dice
            int diceValue = 1; //number of dice sides
            int modifier; //+5, -5, etc
            int result = 0;

            loop = Int32.Parse(arg.Substring(0, arg.IndexOf("d")));
            if (loop == 0) loop = 1; //if the format is "d6" or similar, assume only one die
            if (loop < 0) return -1; //if roll is impossible return -1

            if (arg.IndexOf(" ") == -1) modifier = 0; //if there is no modifier, set it to 0, else set it to the positive or negative value
            else
            {
                String modifierText = arg.Substring(arg.IndexOf(" ") + 1);
                modifier = Int32.Parse(arg.Substring(arg.IndexOf(" ") + 3));
                if (arg[0].Equals('-')) modifier = modifier * -1;
            }

            String diceString = arg.Substring(arg.IndexOf("d") + 1);
            if (arg.IndexOf(" ") == -1)
                diceValue = Int32.Parse(diceString);
            else
                diceValue = Int32.Parse(diceString.Substring(0, diceString.IndexOf(" ")));
            if (diceValue < 0) return -1; //if impossible diceValue return -1
            //Console.WriteLine(loop + "," + diceValue + "," + modifier);

            for (int i = 0; i < loop; i++)
            {
                Random rnd = new Random();
                int roll = rnd.Next(1, diceValue);
                result += roll;
            }
            result += modifier; //modify the final result
            return result;
        }

    }
}
