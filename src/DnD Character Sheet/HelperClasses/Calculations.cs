using Interfaces.HelperClasses;
using System;
using LIB = DnD_Character_Sheet.Library;

namespace DnD_Character_Sheet.HelperClasses
{
  public class Calculations
  {
    /// <summary>
    /// This method calculates the characters Proficiency Bonus for skills
    /// </summary>
    /// <param name="proficient">Is this Skill proficient</param>
    /// <param name="currentModifier">Current Modifier of Skill</param>
    /// <returns>Updated Modifier</returns>
    public static string Bonus(bool proficient, string currentModifier, int baseStat = 0)
    {
      string[] splitMod = currentModifier.Split(' ');
      string sign = splitMod[0];
      int bonus = int.Parse(splitMod[1]);
      if (sign == "-")
      {
        bonus *= -1;
      }
      bonus += baseStat;

      if (proficient)
      {
        bonus += LIB.MainCharacterInfo.ProficiencyBonus;
      }
      else
      {
        bonus -= LIB.MainCharacterInfo.ProficiencyBonus;
      }

      if (bonus >= 0)
      {
        sign = "+ ";
      }
      else
      {
        sign = "- ";
        bonus *= -1;
      }

      return sign + bonus;
    }

    /// <summary>
    /// This method calculates the characters level based on XP
    /// </summary>
    /// <returns></returns>
    public static int Level()
    {
      int XP = LIB.MainCharacterInfo.ExperiencePoints;
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
      LIB.MainCharacterInfo.CarryingWeight = 0;
      foreach (Item item in LIB.MainCharacterInfo.Items)
      {
        LIB.MainCharacterInfo.CarryingWeight += item.Weight * item.Quantity;
      }

      foreach (Weapon weapon in LIB.MainCharacterInfo.Weapons)
      {
        LIB.MainCharacterInfo.CarryingWeight += weapon.Weight * weapon.Quantity;
      }

      foreach (Armor armor in LIB.MainCharacterInfo.Armors)
      {
        LIB.MainCharacterInfo.CarryingWeight += armor.Weight * armor.Quantity;
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
