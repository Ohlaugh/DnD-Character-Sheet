using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC = DnD_Character_Sheet.Constants;
using CALC = DnD_Character_Sheet.Calculations;

namespace DnD_Character_Sheet.Classes
{
    public class ClassLibrary
    {
        #region Items / Weapons / Armor
        public class Item_Class
        {
            public string Cost;
            public double Weight;
            public string Description;
        }

        public class Weapon_Class
        {
            public string Style;
            public string Cost;
            public string Damage;
            public double Weight;
            public List<string> Properties;
            public bool Equipped;
        }

        public class Armor_Class
        {
            public string Style;
            public string Cost;
            public string ArmorClass;
            public int StrengthReq;
            public bool Disadvantage;
            public double Weight;
            public bool Equipped;
        }
        #endregion

        #region Skills
        public class Skills
        {
            public string Acrobatics { get; set; }
            public bool _Acrobatics { get; set; }
            public string AnimalHandling { get; set; }
            public bool _AnimalHandling { get; set; }
            public string Arcana { get; set; }
            public bool _Arcana { get; set; }
            public string Athletics { get; set; }
            public bool _Athletics { get; set; }
            public string Deception { get; set; }
            public bool _Deception { get; set; }
            public string History { get; set; }
            public bool _History { get; set; }
            public string Insight { get; set; }
            public bool _Insight { get; set; }
            public string Intimidation { get; set; }
            public bool _Intimidation { get; set; }
            public string Investigation { get; set; }
            public bool _Investigation { get; set; }
            public string Medicine { get; set; }
            public bool _Medicine { get; set; }
            public string Nature { get; set; }
            public bool _Nature { get; set; }
            public string Perception { get; set; }
            public bool _Perception { get; set; }
            public string Performance { get; set; }
            public bool _Performance { get; set; }
            public string Persuassion { get; set; }
            public bool _Persuassion { get; set; }
            public string Religion { get; set; }
            public bool _Religion { get; set; }
            public string SlightOfHand { get; set; }
            public bool _SlightOfHand { get; set; }
            public string Stealth { get; set; }
            public bool _Stealth { get; set; }
            public string Survival { get; set; }
            public bool _Survival { get; set; }

            public void Calculate(Attributes attributes)
            {
                SetModifiers(attributes);
            }

            private void SetModifiers(Attributes attributes)
            {
                Acrobatics = CALC.CalcBonus(_Acrobatics, attributes.DexterityModifier);
                AnimalHandling = CALC.CalcBonus(_AnimalHandling, attributes.WisdomModifier);
                Arcana = CALC.CalcBonus(_Arcana, attributes.IntelligenceModifier);
                Athletics = CALC.CalcBonus(_Athletics, attributes.StrengthModifier);
                Deception = CALC.CalcBonus(_Deception, attributes.CharismaModifier);
                History = CALC.CalcBonus(_History, attributes.IntelligenceModifier);
                Insight = CALC.CalcBonus(_Insight, attributes.WisdomModifier);
                Intimidation = CALC.CalcBonus(_Intimidation, attributes.CharismaModifier);
                Investigation = CALC.CalcBonus(_Investigation, attributes.IntelligenceModifier);
                Medicine = CALC.CalcBonus(_Medicine, attributes.WisdomModifier);
                Nature = CALC.CalcBonus(_Nature, attributes.IntelligenceModifier);
                Perception = CALC.CalcBonus(_Nature, attributes.IntelligenceModifier);
                Performance = CALC.CalcBonus(_Performance, attributes.CharismaModifier);
                Persuassion = CALC.CalcBonus(_Persuassion, attributes.CharismaModifier);
                Religion = CALC.CalcBonus(_Religion, attributes.IntelligenceModifier);
                SlightOfHand = CALC.CalcBonus(_SlightOfHand, attributes.DexterityModifier);
                Stealth = CALC.CalcBonus(_Stealth, attributes.DexterityModifier);
                Survival = CALC.CalcBonus(_Survival, attributes.WisdomModifier);
            }
        }

        #endregion

        #region Money

        public class Money
        {
            public int Copper { get; set; }
            public int Silver { get; set; }
            public int Electrum { get; set; }
            public int Gold { get; set; }
            public int Platinum { get; set; }
        }

        #endregion

        #region Attributes

        public class Attributes
        {
            public int Strength { get; set; }
            public int StrengthModifier { get; set; }
            public string StrengthSign { get; set; }
            public int Dexterity { get; set; }
            public int DexterityModifier { get; set; }
            public string DexteritySign { get; set; }
            public int Constitution { get; set; }
            public int ConstitutionModifier { get; set; }
            public string ConstitutionSign { get; set; }
            public int Intelligence { get; set; }
            public int IntelligenceModifier { get; set; }
            public string IntelligenceSign { get; set; }
            public int Wisdom { get; set; }
            public int WisdomModifier { get; set; }
            public string WisdomSign { get; set; }
            public int Charisma { get; set; }
            public int CharismaModifier { get; set; }
            public string CharismaSign { get; set; }

            public void Calculate()
            {
                StrengthModifier = CalcModifier(Strength, out string sign);
                StrengthSign = sign;
                DexterityModifier = CalcModifier(Dexterity, out sign);
                DexteritySign = sign;
                ConstitutionModifier = CalcModifier(Constitution, out sign);
                ConstitutionSign = sign;
                IntelligenceModifier = CalcModifier(Intelligence, out sign);
                IntelligenceSign = sign;
                WisdomModifier = CalcModifier(Wisdom, out sign);
                WisdomSign = sign;
                CharismaModifier = CalcModifier(Charisma, out sign);
                CharismaSign = sign;
            }

            private int CalcModifier(int score, out string sign)
            {
                sign = "+";
                int modifier = 0;
                switch (score)
                {
                    case (1):
                        modifier = 5;
                        sign = "-";
                        break;
                    case (2):
                    case (3):
                        modifier = 4;
                        sign = "-";
                        break;
                    case (4):
                    case (5):
                        modifier = 3;
                        sign = "-";
                        break;
                    case (6):
                    case (7):
                        modifier = 2;
                        sign = "-";
                        break;
                    case (8):
                    case (9):
                        modifier = 1;
                        sign = "-";
                        break;
                    case (10):
                    case (11):
                        modifier = 0;
                        break;
                    case (12):
                    case (13):
                        modifier = 1;
                        break;
                    case (14):
                    case (15):
                        modifier = 2;
                        break;
                    case (16):
                    case (17):
                        modifier = 3;
                        break;
                    case (18):
                    case (19):
                        modifier = 4;
                        break;
                    case (20):
                    case (21):
                        modifier = 5;
                        break;
                    case (22):
                    case (23):
                        modifier = 6;
                        break;
                    case (24):
                    case (25):
                        modifier = 7;
                        break;
                    case (26):
                    case (27):
                        modifier = 8;
                        break;
                    case (28):
                    case (29):
                        modifier = 9;
                        break;
                    case (30):
                        modifier = 10;
                        break;

                    default:
                        break;
                }
                return modifier;
            }
        }

        #endregion

        #region Saving Throws

        public class SavingThrows
        {
            public string Strength { get; set; }
            public bool _Strength { get; set; }
            public string Dexterity { get; set; }
            public bool _Dexterity { get; set; }
            public string Constitution { get; set; }
            public bool _Constitution { get; set; }
            public string Intelligence { get; set; }
            public bool _Intelligence { get; set; }
            public string Wisdom { get; set; }
            public bool _Wisdom { get; set; }
            public string Charisma { get; set; }
            public bool _Charisma { get; set; }

            public void Calculate(Attributes attributes)
            {
                SetModifiers(attributes);
            }

            private void SetModifiers(Attributes attributes)
            {
                Strength = CALC.CalcBonus(_Strength, attributes.StrengthModifier);
                Dexterity = CALC.CalcBonus(_Dexterity, attributes.DexterityModifier);
                Constitution = CALC.CalcBonus(_Constitution, attributes.ConstitutionModifier);
                Intelligence = CALC.CalcBonus(_Intelligence, attributes.IntelligenceModifier);
                Wisdom = CALC.CalcBonus(_Wisdom, attributes.WisdomModifier);
                Charisma = CALC.CalcBonus(_Charisma, attributes.CharismaModifier);
            }
        }

        #endregion
    }
}
