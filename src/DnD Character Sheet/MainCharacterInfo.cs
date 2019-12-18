using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Character_Sheet;

namespace DnD_Character_Sheet
{
    public partial class MainCharacterInfo
    {
        // Top Level Info
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int Level { get => _Level; }
        private int _Level { get; set; }
        public string Background { get; set; }
        public string PlayerName { get; set; }
        public string Race { get; set; }
        public string Subrace { get; set; }
        public string Alignment { get; set; }
        public int ExperiencePoints { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public double Weight { get; set; }
        public string EyeColor { get; set; }
        public string SkinColor { get; set; }
        public string HairColor { get; set; }

        // Left Column Info
        public Attributes Attributes { get; set; }
        public Skills Skills { get; set; }
        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get => _ProficiencyBonus; }
        private int _ProficiencyBonus { get; set; }
        public SavingThrows SavingThrows { get; set; }
        public int Perception { get => _Perception; }
        private int _Perception { get; set; }
        public List<string> Proficiencies { get; set; }
        public List<string> Languages { get; set; }

        // Middle Column Info
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HP_Max { get; set; }
        public int HP_Current { get; set; }
        public int HP_Temp { get; set; }
        public string HitDice { get; set; }
        public int HitDiceTotal { get; set; }
        // Death Saves?
        // Attacks and Spellcasting
        public Money Money { get; set; }
        public List<string> Equipment { get; set; }

        // Right Column Info
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public List<string> Features { get; set; }
        public List<string> Traits { get; set; }

        public string Backstory { get; set; }

        public void Calculate()
        {
            SetLevel();
            SetProfBonus();
            Attributes.Calculate();
            SetPerception();
            Skills.Calculate(Attributes);
            SavingThrows.Calculate(Attributes);
        }

        private void SetProfBonus()
        {
            int bonus = 0;
            switch (Level)
            {
                case (1):
                case (2):
                case (3):
                case (4):
                    bonus = 2;
                    break;
                case (5):
                case (6):
                case (7):
                case (8):
                    bonus = 3;
                    break;
                case (9):
                case (10):
                case (11):
                case (12):
                    bonus = 4;
                    break;
                case (13):
                case (14):
                case (15):
                case (16):
                    bonus = 5;
                    break;
                case (17):
                case (18):
                case (19):
                case (20):
                    bonus = 6;
                    break;
                default:
                    break;
            }
            _ProficiencyBonus = bonus;
        }

        private void SetLevel()
        {
            int level = 0;
            if (ExperiencePoints < 300)
            {
                level = 1;
            }
            else if (ExperiencePoints >= 300 && ExperiencePoints < 900)
            {
                level = 2;
            }
            else if (ExperiencePoints >= 900 && ExperiencePoints < 2700)
            {
                level = 3;
            }
            else if (ExperiencePoints >= 2700 && ExperiencePoints < 6500)
            {
                level = 4;
            }
            else if (ExperiencePoints >= 6500 && ExperiencePoints < 14000)
            {
                level = 5;
            }
            else if (ExperiencePoints >= 14000 && ExperiencePoints < 23000)
            {
                level = 6;
            }
            else if (ExperiencePoints >= 23000 && ExperiencePoints < 34000)
            {
                level = 7;
            }
            else if (ExperiencePoints >= 34000 && ExperiencePoints < 48000)
            {
                level = 8;
            }
            else if (ExperiencePoints >= 48000 && ExperiencePoints < 64000)
            {
                level = 9;
            }
            else if (ExperiencePoints >= 64000 && ExperiencePoints < 85000)
            {
                level = 10;
            }
            else if (ExperiencePoints >= 85000 && ExperiencePoints < 100000)
            {
                level = 11;
            }
            else if (ExperiencePoints >= 100000 && ExperiencePoints < 120000)
            {
                level = 12;
            }
            else if (ExperiencePoints >= 120000 && ExperiencePoints < 140000)
            {
                level = 13;
            }
            else if (ExperiencePoints >= 140000 && ExperiencePoints < 165000)
            {
                level = 14;
            }
            else if (ExperiencePoints >= 165000 && ExperiencePoints < 195000)
            {
                level = 15;
            }
            else if (ExperiencePoints >= 195000 && ExperiencePoints < 225000)
            {
                level = 16;
            }
            else if (ExperiencePoints >= 225000 && ExperiencePoints < 265000)
            {
                level = 17;
            }
            else if (ExperiencePoints >= 265000 && ExperiencePoints < 305000)
            {
                level = 18;
            }
            else if (ExperiencePoints >= 305000 && ExperiencePoints < 355000)
            {
                level = 19;
            }
            else
            {
                level = 20;
            }

            _Level = level;
        }

        private void SetPerception()
        {
            _Perception = 10 + Attributes.WisdomModifier;
        }

        public List<Tuple<string, bool>> GetSkills()
        {
            return new List<Tuple<string, bool>>
            {
                new Tuple<string, bool>(Skills.Acrobatics+" Acrobatics", Skills._Acrobatics),
                new Tuple<string, bool>(Skills.AnimalHandling+" Animal Handling", Skills._AnimalHandling),
                new Tuple<string, bool>(Skills.Arcana+" Arcana", Skills._Arcana),
                new Tuple<string, bool>(Skills.Athletics+" Athletics", Skills._Athletics),
                new Tuple<string, bool>(Skills.Deception+" Deception", Skills._Deception),
                new Tuple<string, bool>(Skills.History+" History", Skills._History),
                new Tuple<string, bool>(Skills.Insight+" Insight", Skills._Insight),
                new Tuple<string, bool>(Skills.Intimidation+" Intimidation", Skills._Intimidation),
                new Tuple<string, bool>(Skills.Investigation+" Investigation", Skills._Investigation),
                new Tuple<string, bool>(Skills.Medicine+" Medicine", Skills._Medicine),
                new Tuple<string, bool>(Skills.Nature+" Nature", Skills._Nature),
                new Tuple<string, bool>(Skills.Perception+" Perception", Skills._Perception),
                new Tuple<string, bool>(Skills.Performance+" Performance", Skills._Performance),
                new Tuple<string, bool>(Skills.Persuassion+" Persuassion", Skills._Persuassion),
                new Tuple<string, bool>(Skills.Religion+" Religion", Skills._Religion),
                new Tuple<string, bool>(Skills.SlightOfHand+" Slight of Hand", Skills._SlightOfHand),
                new Tuple<string, bool>(Skills.Stealth+" Stealth", Skills._Stealth),
                new Tuple<string, bool>(Skills.Survival+" Survival", Skills._Survival)
            };
        }

        public List<Tuple<string,bool>> GetSaves()
        {
            return new List<Tuple<string, bool>>
            {
                new Tuple<string, bool>(SavingThrows.Strength+" Strength", SavingThrows._Strength),
                new Tuple<string, bool>(SavingThrows.Dexterity+" Dexterity",SavingThrows._Dexterity),
                new Tuple<string, bool>(SavingThrows.Constitution+" Constitution",SavingThrows._Constitution),
                new Tuple<string, bool>(SavingThrows.Intelligence+" Intelligence",SavingThrows._Intelligence),
                new Tuple<string, bool>(SavingThrows.Wisdom+" Wisdom",SavingThrows._Wisdom),
                new Tuple<string, bool>(SavingThrows.Charisma+" Charisma",SavingThrows._Charisma)
            };
        }
    }

}
