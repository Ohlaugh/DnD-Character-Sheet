using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Character_Sheet;
using LC = DnD_Character_Sheet.Constants;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    public class MainCharacterInfo
    {
        public string CharacterName { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string SubClass1 { get; set; }
        public string SubClass2 { get; set; }
        public int Level1 { get; set; }
        public int Level2 { get; set; }
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
        public bool Inspiration { get; set; }
        private int _ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HP_Max { get; set; }
        public int HP_Current { get; set; }
        public int HP_Temp { get; set; }
        public string HitDice1 { get; set; }
        public string HitDice2 { get; set; }
        public int HitDiceTotal1 { get; set; }
        public int HitDiceTotal2 { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public double CarryingWeight { get; set; }
        public string Backstory { get; set; }


        public bool Multiclass { get => Class2 != ""; }
        public int TotalLevel { get => Level1 + Level2; }
        public int ProficiencyBonus { get => _ProficiencyBonus; }
        public int Perception { get => 10 + Attributes.WisdomModifier; }
        public double CarryingCapacity { get => Attributes.Strength * 15; }


        public List<string> Proficiencies { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Features { get; set; }
        public List<string> Traits { get; set; }


        public CLIB.Money Money { get; set; }
        public CLIB.Attributes Attributes { get; set; }
        public CLIB.Skills Skills { get; set; }
        public CLIB.SavingThrows SavingThrows { get; set; }


        public Dictionary<string, CLIB.Item> Items { get; set; }
        public Dictionary<string, CLIB.Weapon> Weapons { get; set; }
        public Dictionary<string, CLIB.Armor> Armor { get; set; }

        public void Calculate()
        {
            SetProfBonus();
            Attributes.Calculate();
            Skills.Calculate(Attributes);
            SavingThrows.Calculate(Attributes);
        }

        private void SetProfBonus()
        {
            int bonus = 0;
            switch (TotalLevel)
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

        public List<Tuple<string, bool>> GetSkills()
        {
            return new List<Tuple<string, bool>>
            {
                new Tuple<string, bool>(Skills.AcrobaticsLabel+" Acrobatics", Skills.Acrobatics),
                new Tuple<string, bool>(Skills.AnimalHandlingLabel+" Animal Handling", Skills.AnimalHandling),
                new Tuple<string, bool>(Skills.ArcanaLabel+" Arcana", Skills.Arcana),
                new Tuple<string, bool>(Skills.AthleticsLabel+" Athletics", Skills.Athletics),
                new Tuple<string, bool>(Skills.DeceptionLabel+" Deception", Skills.Deception),
                new Tuple<string, bool>(Skills.HistoryLabel+" History", Skills.History),
                new Tuple<string, bool>(Skills.InsightLabel+" Insight", Skills.Insight),
                new Tuple<string, bool>(Skills.IntimidationLabel+" Intimidation", Skills.Intimidation),
                new Tuple<string, bool>(Skills.InvestigationLabel+" Investigation", Skills.Investigation),
                new Tuple<string, bool>(Skills.MedicineLabel+" Medicine", Skills.Medicine),
                new Tuple<string, bool>(Skills.NatureLabel+" Nature", Skills.Nature),
                new Tuple<string, bool>(Skills.PerceptionLabel+" Perception", Skills.Perception),
                new Tuple<string, bool>(Skills.PerformanceLabel+" Performance", Skills.Performance),
                new Tuple<string, bool>(Skills.PersuassionLabel+" Persuassion", Skills.Persuassion),
                new Tuple<string, bool>(Skills.ReligionLabel+" Religion", Skills.Religion),
                new Tuple<string, bool>(Skills.SlightOfHandLabel+" Slight of Hand", Skills.SlightOfHand),
                new Tuple<string, bool>(Skills.StealthLabel+" Stealth", Skills.Stealth),
                new Tuple<string, bool>(Skills.SurvivalLabel+" Survival", Skills.Survival)
            };
        }

        public List<Tuple<string, bool>> GetSaves()
        {
            return new List<Tuple<string, bool>>
            {
                new Tuple<string, bool>(SavingThrows.Strength+" Strength", SavingThrows.StrengthSave),
                new Tuple<string, bool>(SavingThrows.Dexterity+" Dexterity",SavingThrows.DexteritySave),
                new Tuple<string, bool>(SavingThrows.Constitution+" Constitution",SavingThrows.ConstitutionSave),
                new Tuple<string, bool>(SavingThrows.Intelligence+" Intelligence",SavingThrows.IntelligenceSave),
                new Tuple<string, bool>(SavingThrows.Wisdom+" Wisdom",SavingThrows.WisdomSave),
                new Tuple<string, bool>(SavingThrows.Charisma+" Charisma",SavingThrows.CharismaSave)
            };
        }
    }

}
