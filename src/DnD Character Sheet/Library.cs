using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DnD_Character_Sheet;
using LC = DnD_Character_Sheet.Constants;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    class Library
    {
        #region Read in Data

        /// <summary>
        /// This holds all information read in from the character sheet
        ///     Key: Character Data
        ///     Value: Character Value
        /// </summary>
        public static Dictionary<string, string> m_CharData = new Dictionary<string, string>();

        /// <summary>
        /// This contains all skills the current character is proficient in
        ///     Key: Character Data
        ///     Value: Character Value
        /// </summary>
        public static Dictionary<string, bool> m_ProficientData = new Dictionary<string, bool>();

        /// <summary>
        /// This contains all Items the current character has
        ///     Key: Item Name
        ///     Value: New Item
        /// </summary>
        public static Dictionary<string, CLIB.Item> m_ItemData = new Dictionary<string, CLIB.Item>();

        /// <summary>
        /// This contains all Weapons the current character has
        ///     Key: Weapon Name
        ///     Value: New Weapon
        /// </summary>
        public static Dictionary<string, CLIB.Weapon> m_WeaponData = new Dictionary<string, CLIB.Weapon>();

        /// <summary>
        /// This contains all Armor the current character has
        ///     Key: Armor Name
        ///     Value: New Armor
        /// </summary>
        public static Dictionary<string, CLIB.Armor> m_ArmorData = new Dictionary<string, CLIB.Armor>();

        #endregion

        #region Main Libraries

        /// <summary>
        /// This holds the current characters name
        /// This is also the main Key used in dictionaries
        /// </summary>
        public static string m_CharacterName;

        /// <summary>
        /// This Holds all information on the current character
        /// </summary>
        public static MainCharacterInfo m_MainCharacterInfo = new MainCharacterInfo();

        /// <summary>
        /// This dictionary holds all information on which book the user has selected
        /// Key: Book Name
        /// Value: True = Using / False = Not Using
        /// </summary>
        public static Dictionary<string, bool> m_BookUtilization = new Dictionary<string, bool>();

        /// <summary>
        /// This dictionary holds all information on each race
        /// Key: Race
        /// Value: New List<string>
        ///     Value: Subrace
        /// </summary>
        public static Dictionary<string, List<string>> m_RaceLibrary = new Dictionary<string, List<string>>();


        /// <summary>
        /// This dictionary holds all information on Armor from selected manuals
        /// Key: Armor Name
        /// Value: New Armor
        /// </summary>
        public static Dictionary<string, CLIB.Armor> m_ArmorLibrary = new Dictionary<string, CLIB.Armor>();

        /// <summary>
        /// This dictionary holds all information on Weapons from selected manuals
        /// Key: Weapon Name
        /// Value: New Weapon
        /// </summary>
        public static Dictionary<string, CLIB.Weapon> m_WeaponLibrary = new Dictionary<string, CLIB.Weapon>();

        /// <summary>
        /// This dictionary holds all information on Items from selected manuals
        /// Key: Item Name
        /// Value: New Item
        /// </summary>
        public static Dictionary<string, CLIB.Item> m_ItemLibrary = new Dictionary<string, CLIB.Item>();

        /// <summary>
        /// This dictionary holds all information on Spells from selected manuals
        /// Key: Spell Name
        /// Value: New Spell
        /// </summary>
        public static Dictionary<string, CLIB.Spell> m_SpellLibrary = new Dictionary<string, CLIB.Spell>();

        #endregion

        /// <summary>
        /// This bool indicates if a character has been loaded
        /// </summary>
        public static bool m_CharacterLoaded = false;

        /// <summary>
        /// This method clears all Libraries
        /// USE ONLY WHEN NEW CHARACTER IS LOADED/CREATED
        /// </summary>
        public static void ClearLibrary()
        {
            m_CharData.Clear();
            m_ProficientData.Clear();
            m_ItemData.Clear();
            m_WeaponData.Clear();
            m_ArmorData.Clear();

            m_BookUtilization.Clear();

            m_RaceLibrary.Clear();
            m_ArmorLibrary.Clear();
            m_WeaponLibrary.Clear();
            m_ItemLibrary.Clear();
        }

        /// <summary>
        /// Update the Skills for the main character
        /// </summary>
        /// <param name="skillName">Name of the Changed Skill</param>
        /// <param name="skillBonus">New value for the skill</param>
        /// <param name="check">If the skill has proficiency</param>
        public static void UpdateLibrary(string skillName, string skillBonus, bool check)
        {
            switch (skillName)
            {
                case (LC.Acrobatics):
                    {
                        m_MainCharacterInfo.Skills.AcrobaticsLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Acrobatics = check;
                        break;
                    }
                case (LC.AnimalHandling_Spaced):
                    {
                        m_MainCharacterInfo.Skills.AnimalHandlingLabel = skillBonus;
                        m_MainCharacterInfo.Skills.AnimalHandling = check;
                        break;
                    }
                case (LC.Arcana):
                    {
                        m_MainCharacterInfo.Skills.ArcanaLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Arcana = check;
                        break;
                    }
                case (LC.Athletics):
                    {
                        m_MainCharacterInfo.Skills.AthleticsLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Athletics = check;
                        break;
                    }
                case (LC.Deception):
                    {
                        m_MainCharacterInfo.Skills.DeceptionLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Deception = check;
                        break;
                    }
                case (LC.History):
                    {
                        m_MainCharacterInfo.Skills.HistoryLabel = skillBonus;
                        m_MainCharacterInfo.Skills.History = check;
                        break;
                    }
                case (LC.Insight):
                    {
                        m_MainCharacterInfo.Skills.InsightLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Insight = check;
                        break;
                    }
                case (LC.Intimidation):
                    {
                        m_MainCharacterInfo.Skills.IntimidationLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Intimidation = check;
                        break;
                    }
                case (LC.Investigation):
                    {
                        m_MainCharacterInfo.Skills.InvestigationLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Investigation = check;
                        break;
                    }
                case (LC.Medicine):
                    {
                        m_MainCharacterInfo.Skills.MedicineLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Medicine = check;
                        break;
                    }
                case (LC.Nature):
                    {
                        m_MainCharacterInfo.Skills.NatureLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Nature = check;
                        break;
                    }
                case (LC.Perception):
                    {
                        m_MainCharacterInfo.Skills.PerceptionLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Perception = check;
                        break;
                    }
                case (LC.Performance):
                    {
                        m_MainCharacterInfo.Skills.PerformanceLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Performance = check;
                        break;
                    }
                case (LC.Persuassion):
                    {
                        m_MainCharacterInfo.Skills.PersuassionLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Persuassion = check;
                        break;
                    }
                case (LC.Religion):
                    {
                        m_MainCharacterInfo.Skills.ReligionLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Religion = check;
                        break;
                    }
                case (LC.SlightOfHand_Spaced):
                    {
                        m_MainCharacterInfo.Skills.SlightOfHandLabel = skillBonus;
                        m_MainCharacterInfo.Skills.SlightOfHand = check;
                        break;
                    }
                case (LC.Stealth):
                    {
                        m_MainCharacterInfo.Skills.StealthLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Stealth = check;
                        break;
                    }
                case (LC.Survival):
                    {
                        m_MainCharacterInfo.Skills.SurvivalLabel = skillBonus;
                        m_MainCharacterInfo.Skills.Survival = check;
                        break;
                    }
                case (LC.Strength):
                    {
                        m_MainCharacterInfo.SavingThrows.Strength = skillBonus;
                        m_MainCharacterInfo.SavingThrows.StrengthSave = check;
                        break;
                    }
                case (LC.Dexterity):
                    {
                        m_MainCharacterInfo.SavingThrows.Dexterity = skillBonus;
                        m_MainCharacterInfo.SavingThrows.DexteritySave = check;
                        break;
                    }
                case (LC.Constitution):
                    {
                        m_MainCharacterInfo.SavingThrows.Constitution = skillBonus;
                        m_MainCharacterInfo.SavingThrows.ConstitutionSave = check;
                        break;
                    }
                case (LC.Intelligence):
                    {
                        m_MainCharacterInfo.SavingThrows.Intelligence = skillBonus;
                        m_MainCharacterInfo.SavingThrows.IntelligenceSave = check;
                        break;
                    }
                case (LC.Wisdom):
                    {
                        m_MainCharacterInfo.SavingThrows.Wisdom = skillBonus;
                        m_MainCharacterInfo.SavingThrows.WisdomSave = check;
                        break;
                    }
                case (LC.Charisma):
                    {
                        m_MainCharacterInfo.SavingThrows.Charisma = skillBonus;
                        m_MainCharacterInfo.SavingThrows.CharismaSave = check;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
