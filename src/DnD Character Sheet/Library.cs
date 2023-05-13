using Interfaces;
using Interfaces.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnD_Character_Sheet
{
  class Library
  {
    #region Private Members

    /// <summary>
    /// This Holds all information on the current character
    /// </summary>
    private static MainCharacterInfo m_MainCharacterInfo = new MainCharacterInfo();

    /// <summary>
    /// This dictionary holds all information on each race
    /// Key: Race
    /// Value: New List<string>
    ///     Value: Subrace
    /// </summary>
    private static Dictionary<string, List<string>> m_RaceLibrary = new Dictionary<string, List<string>>();

    /// <summary>
    /// This dictionary holds all information on each class
    /// Key: Class
    /// Value: New List<string>
    ///     Value: Subclass
    /// </summary>
    private static Dictionary<string, List<string>> m_ClassLibrary = new Dictionary<string, List<string>>();

    /// <summary>
    /// This list holds all information on Armor from selected manuals
    /// </summary>
    private static List<Armor> m_ArmorLibrary = new List<Armor>();

    /// <summary>
    /// This list holds all information on Weapons from selected manuals
    /// </summary>
    private static List<Weapon> m_WeaponLibrary = new List<Weapon>();

    /// <summary>
    /// This dictionary holds all information on Items from selected manuals
    /// </summary>
    private static List<Item> m_ItemLibrary = new List<Item>();

    /// <summary>
    /// This dictionary holds all information on Spells from selected manuals
    /// </summary>
    private static List<Spell> m_SpellLibrary = new List<Spell>();

    /// <summary>
    /// This dictionary holds all information on Actions from selected manuals
    /// </summary>
    private static List<CombatAction> m_ActionLibrary = new List<CombatAction>();

    #endregion Private Members

    #region Public Members

    /// <summary>
    /// This Holds all information on the current character
    /// </summary>
    public static MainCharacterInfo MainCharacterInfo { get { return m_MainCharacterInfo; } }

    /// <summary>
    /// This dictionary holds all information on each race
    /// Key: Race
    /// Value: New List<string>
    ///     Value: Subrace
    /// </summary>
    public static Dictionary<string, List<string>> RaceLibrary { get { return m_RaceLibrary; } }

    /// <summary>
    /// This dictionary holds all information on each class
    /// Key: Class
    /// Value: New List<string>
    ///     Value: Subclass
    /// </summary>
    public static Dictionary<string, List<string>> ClassLibrary { get { return m_ClassLibrary; } }

    /// <summary>
    /// This list holds all information on Armor from selected manuals
    /// </summary>
    public static List<Armor> ArmorLibrary { get { return m_ArmorLibrary; } }

    /// <summary>
    /// This list holds all information on Weapons from selected manuals
    /// </summary>
    public static List<Weapon> WeaponLibrary { get { return m_WeaponLibrary; } }

    /// <summary>
    /// This dictionary holds all information on Items from selected manuals
    /// Key: Item Name
    /// Value: New Item
    /// </summary>
    public static List<Item> ItemLibrary { get { return m_ItemLibrary; } }

    /// <summary>
    /// This dictionary holds all information on Spells from selected manuals
    /// Key: Spell Name
    /// Value: New Spell
    /// </summary>
    public static List<Spell> SpellLibrary { get { return m_SpellLibrary; } }

    /// <summary>
    /// This dictionary holds all information on Actions from selected manuals
    /// </summary>
    public static List<CombatAction> ActionLibrary { get { return m_ActionLibrary; } }

    #endregion Public Members

    #region Public Methods

    /// <summary>
    /// This method will add the loaded character into the main Library
    /// </summary>
    /// <param name="mainCharacter">Serialized Main Character Info</param>
    public static bool AddCharacter(MainCharacterInfo mainCharacter)
    {
      bool characterLoaded = false;
      try
      {
        ClearLibrary();
        m_MainCharacterInfo = mainCharacter;

        foreach (string assemblyName in MainCharacterInfo.Books)
        {
          Type? test = Type.GetType(assemblyName);
          if (test != null)
          {
            IBook? book = Activator.CreateInstance(test) as IBook;
            AddRaces(book.Races);
            AddSubRaces(book.SubRaces);
            AddClasses(book.Classes);
            AddSubClasses(book.SubClasses);
            AddArmors(book.Armors);
            AddWeapons(book.Weapons);
            AddItems(book.Items);
            AddSpells(book.Spells);
            AddActions(book.CombatActions);
          }
        }
        characterLoaded = true;
      }
      catch (Exception)
      {

      }
      return characterLoaded;
    }

    #endregion Public Methods




    /// <summary>
    /// Import Races to the main Library
    /// </summary>
    /// <param name="races">List of Races</param>
    private static void AddRaces(List<string> races)
    {
      foreach (string race in races)
      {
        if (!m_RaceLibrary.ContainsKey(race))
        {
          m_RaceLibrary.Add(race, new List<string>());
        }
      }
    }

    /// <summary>
    /// Import Subraces to the main Library.
    /// </summary>
    /// <param name="subraces">List of subraces in the format of: "Race:Subrace"
    /// </param>
    private static void AddSubRaces(List<string> subraces)
    {
      foreach (string unSplitPair in subraces)
      {
        string[] splitPair = unSplitPair.Split(':');

        if (splitPair.Length == 2)
        {
          string race = splitPair[0];
          string subRace = splitPair[1];

          // Add the Subrace if Race exists and Subrace does not
          if (m_RaceLibrary.ContainsKey(race) &&
            !m_RaceLibrary[race].Contains(subRace))
          {
            m_RaceLibrary[race].Add(subRace);
          }
          // Unlikely but add just in case...
          else
          {
            m_RaceLibrary.Add(race, new List<string> { subRace });
          }
        }
      }
    }

    /// <summary>
    /// Import classes to the main Library
    /// </summary>
    /// <param name="classes">List of classes</param>
    private static void AddClasses(List<string> classes)
    {
      foreach (string _class in classes)
      {
        // Add class if it does not Exist
        if (!m_ClassLibrary.ContainsKey(_class))
        {
          m_ClassLibrary.Add(_class, new List<string>());
        }
      }
    }

    /// <summary>
    /// Import Subclasses to the main Library.
    /// </summary>
    /// <param name="subclasses">List of subclasses in the format of: "class:Subclass"
    /// </param>
    private static void AddSubClasses(List<string> subclasses)
    {
      foreach (string unSplitPair in subclasses)
      {
        string[] splitPair = unSplitPair.Split(':');

        if (splitPair.Length == 2)
        {
          string _class = splitPair[0];
          string subclass = splitPair[1];

          // Add the Subclass if class exists and Subclass does not
          if (m_ClassLibrary.ContainsKey(_class) &&
            !m_ClassLibrary[_class].Contains(subclass))
          {
            m_ClassLibrary[_class].Add(subclass);
          }
          // Unlikely but add just in case...
          else
          {
            m_ClassLibrary.Add(_class, new List<string> { subclass });
          }
        }
      }
    }

    /// <summary>
    /// Import Armors to the main Library
    /// </summary>
    /// <param name="armors">List of Armor</param>
    private static void AddArmors(List<Armor> armors)
    {
      m_ArmorLibrary.AddRange(armors.Where(armor => !m_ArmorLibrary.Contains(armor)));
    }

    /// <summary>
    /// Import Weapons to the main Library
    /// </summary>
    /// <param name="weapons">List of Weapons</param>
    private static void AddWeapons(List<Weapon> weapons)
    {
      m_WeaponLibrary.AddRange(weapons.Where(weapon => !m_WeaponLibrary.Contains(weapon)));
    }

    /// <summary>
    /// Import Items to the main Library
    /// </summary>
    /// <param name="items">List of Items</param>
    private static void AddItems(List<Item> items)
    {
      m_ItemLibrary.AddRange(items.Where(item => !m_ItemLibrary.Contains(item)));
    }

    /// <summary>
    /// Import Spells to the main Library
    /// </summary>
    /// <param name="spells">List of Spells</param>
    private static void AddSpells(List<Spell> spells)
    {
      m_SpellLibrary.AddRange(spells.Where(spell => !m_SpellLibrary.Contains(spell)));
    }

    /// <summary>
    /// Import Actions to the main Library
    /// </summary>
    /// <param name="actions">List of Actions</param>
    private static void AddActions(List<CombatAction> actions)
    {
      m_ActionLibrary.AddRange(actions.Where(action => !m_ActionLibrary.Contains(action)));
    }

    /// <summary>
    /// This method clears all Libraries
    /// USE ONLY WHEN NEW CHARACTER IS LOADED/CREATED
    /// </summary>
    private static void ClearLibrary()
    {
      m_RaceLibrary.Clear();
      m_ClassLibrary.Clear();
      m_ArmorLibrary.Clear();
      m_WeaponLibrary.Clear();
      m_ItemLibrary.Clear();
      m_SpellLibrary.Clear();
    }















    ///// <summary>
    ///// Update the Skills for the main character
    ///// </summary>
    ///// <param name="skillName">Name of the Changed Skill</param>
    ///// <param name="skillBonus">New value for the skill</param>
    ///// <param name="check">If the skill has proficiency</param>
    //public static void UpdateLibrary(string skillName, string skillBonus, bool check)
    //{
    //  switch (skillName)
    //  {
    //    case LC.Acrobatics:
    //      {
    //        MainCharacterInfo.Skills.Acrobatics_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Acrobatics_Proficient = check;
    //        break;
    //      }
    //    case LC.AnimalHandling_Spaced:
    //      {
    //        MainCharacterInfo.Skills.AnimalHandling_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.AnimalHandling_Proficient = check;
    //        break;
    //      }
    //    case LC.Arcana:
    //      {
    //        MainCharacterInfo.Skills.Arcana_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Arcana_Proficient = check;
    //        break;
    //      }
    //    case LC.Athletics:
    //      {
    //        MainCharacterInfo.Skills.Athletics_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Athletics_Proficient = check;
    //        break;
    //      }
    //    case LC.Deception:
    //      {
    //        MainCharacterInfo.Skills.Deception_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Deception_Proficient = check;
    //        break;
    //      }
    //    case LC.History:
    //      {
    //        MainCharacterInfo.Skills.History_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.History_Proficient = check;
    //        break;
    //      }
    //    case LC.Insight:
    //      {
    //        MainCharacterInfo.Skills.Insight_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Insight_Proficient = check;
    //        break;
    //      }
    //    case LC.Intimidation:
    //      {
    //        MainCharacterInfo.Skills.Intimidation_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Intimidation_Proficient = check;
    //        break;
    //      }
    //    case LC.Investigation:
    //      {
    //        MainCharacterInfo.Skills.Investigation_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Investigation_Proficient = check;
    //        break;
    //      }
    //    case LC.Medicine:
    //      {
    //        MainCharacterInfo.Skills.Medicine_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Medicine_Proficient = check;
    //        break;
    //      }
    //    case LC.Nature:
    //      {
    //        MainCharacterInfo.Skills.Nature_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Nature_Proficient = check;
    //        break;
    //      }
    //    case LC.Perception:
    //      {
    //        MainCharacterInfo.Skills.Perception_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Perception_Proficient = check;
    //        break;
    //      }
    //    case LC.Performance:
    //      {
    //        MainCharacterInfo.Skills.Performance_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Performance_Proficient = check;
    //        break;
    //      }
    //    case LC.Persuassion:
    //      {
    //        MainCharacterInfo.Skills.Persuassion_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Persuassion_Proficient = check;
    //        break;
    //      }
    //    case LC.Religion:
    //      {
    //        MainCharacterInfo.Skills.Religion_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Religion_Proficient = check;
    //        break;
    //      }
    //    case LC.SlightOfHand_Spaced:
    //      {
    //        MainCharacterInfo.Skills.SlightOfHand_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.SlightOfHand_Proficient = check;
    //        break;
    //      }
    //    case LC.Stealth:
    //      {
    //        MainCharacterInfo.Skills.Stealth_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Stealth_Proficient = check;
    //        break;
    //      }
    //    case LC.Survival:
    //      {
    //        MainCharacterInfo.Skills.Survival_Modifier = skillBonus;
    //        MainCharacterInfo.Skills.Survival_Proficient = check;
    //        break;
    //      }
    //    case LC.Strength:
    //      {
    //        MainCharacterInfo.SavingThrows.StrengthSave_Modifier = skillBonus;
    //        MainCharacterInfo.SavingThrows.StrengthSave_Proficient = check;
    //        break;
    //      }
    //    case LC.Dexterity:
    //      {
    //        MainCharacterInfo.SavingThrows.DexteritySave_Modifier = skillBonus;
    //        MainCharacterInfo.SavingThrows.DexteritySave_Proficient = check;
    //        break;
    //      }
    //    case LC.Constitution:
    //      {
    //        MainCharacterInfo.SavingThrows.ConstitutionSave_Modifier = skillBonus;
    //        MainCharacterInfo.SavingThrows.ConstitutionSave_Proficient = check;
    //        break;
    //      }
    //    case LC.Intelligence:
    //      {
    //        MainCharacterInfo.SavingThrows.IntelligenceSave_Modifier = skillBonus;
    //        MainCharacterInfo.SavingThrows.IntelligenceSave_Proficient = check;
    //        break;
    //      }
    //    case LC.Wisdom:
    //      {
    //        MainCharacterInfo.SavingThrows.WisdomSave_Modifier = skillBonus;
    //        MainCharacterInfo.SavingThrows.WisdomSave_Proficient = check;
    //        break;
    //      }
    //    case LC.Charisma:
    //      {
    //        MainCharacterInfo.SavingThrows.CharismaSave_Modifier = skillBonus;
    //        MainCharacterInfo.SavingThrows.CharismaSave_Proficient = check;
    //        break;
    //      }
    //    default:
    //      break;
    //  }
    //}
  }
}
