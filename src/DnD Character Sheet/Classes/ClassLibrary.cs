using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC = DnD_Character_Sheet.Constants;
using CALC = DnD_Character_Sheet.Calculations;
using LIB = DnD_Character_Sheet.Library;

namespace DnD_Character_Sheet.Classes
{
    public class ClassLibrary
    {
        #region Items / Weapons / Armor
        public class Item_Class
        {
            public string Style;
            public string Cost;
            public double Weight;
            public string Description;
            public int Quantity = 1;
        }

        public class Weapon_Class : Item_Class
        {
            public string Damage;
            public List<string> Properties;
            public bool Equipped;
        }

        public class Armor_Class :Item_Class
        {
            public string ArmorClass;
            public int StrengthReq;
            public bool Disadvantage;
            public bool Equipped;
        }
        #endregion

        #region Skills
        public class Skills
        {
            public string AcrobaticsLabel { get; set; }
            public bool Acrobatics { get; set; }
            public string AnimalHandlingLabel { get; set; }
            public bool AnimalHandling { get; set; }
            public string ArcanaLabel { get; set; }
            public bool Arcana { get; set; }
            public string AthleticsLabel { get; set; }
            public bool Athletics { get; set; }
            public string DeceptionLabel { get; set; }
            public bool Deception { get; set; }
            public string HistoryLabel { get; set; }
            public bool History { get; set; }
            public string InsightLabel { get; set; }
            public bool Insight { get; set; }
            public string IntimidationLabel { get; set; }
            public bool Intimidation { get; set; }
            public string InvestigationLabel { get; set; }
            public bool Investigation { get; set; }
            public string MedicineLabel { get; set; }
            public bool Medicine { get; set; }
            public string NatureLabel { get; set; }
            public bool Nature { get; set; }
            public string PerceptionLabel { get; set; }
            public bool Perception { get; set; }
            public string PerformanceLabel { get; set; }
            public bool Performance { get; set; }
            public string PersuassionLabel { get; set; }
            public bool Persuassion { get; set; }
            public string ReligionLabel { get; set; }
            public bool Religion { get; set; }
            public string SlightOfHandLabel { get; set; }
            public bool SlightOfHand { get; set; }
            public string StealthLabel { get; set; }
            public bool Stealth { get; set; }
            public string SurvivalLabel { get; set; }
            public bool Survival { get; set; }

            public void Calculate(Attributes attributes)
            {
                SetModifiers(attributes);
            }

            private void SetModifiers(Attributes attributes)
            {
                AcrobaticsLabel = CALC.Bonus(Acrobatics, attributes.DexterityModifier);
                AnimalHandlingLabel = CALC.Bonus(AnimalHandling, attributes.WisdomModifier);
                ArcanaLabel = CALC.Bonus(Arcana, attributes.IntelligenceModifier);
                AthleticsLabel = CALC.Bonus(Athletics, attributes.StrengthModifier);
                DeceptionLabel = CALC.Bonus(Deception, attributes.CharismaModifier);
                HistoryLabel = CALC.Bonus(History, attributes.IntelligenceModifier);
                InsightLabel = CALC.Bonus(Insight, attributes.WisdomModifier);
                IntimidationLabel = CALC.Bonus(Intimidation, attributes.CharismaModifier);
                InvestigationLabel = CALC.Bonus(Investigation, attributes.IntelligenceModifier);
                MedicineLabel = CALC.Bonus(Medicine, attributes.WisdomModifier);
                NatureLabel = CALC.Bonus(Nature, attributes.IntelligenceModifier);
                PerceptionLabel = CALC.Bonus(Nature, attributes.IntelligenceModifier);
                PerformanceLabel = CALC.Bonus(Performance, attributes.CharismaModifier);
                PersuassionLabel = CALC.Bonus(Persuassion, attributes.CharismaModifier);
                ReligionLabel = CALC.Bonus(Religion, attributes.IntelligenceModifier);
                SlightOfHandLabel = CALC.Bonus(SlightOfHand, attributes.DexterityModifier);
                StealthLabel = CALC.Bonus(Stealth, attributes.DexterityModifier);
                SurvivalLabel = CALC.Bonus(Survival, attributes.WisdomModifier);
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

            /// <summary>
            /// This method converts the currency provided
            /// </summary>
            /// <param name="CurrencyFrom">Currency Converting From</param>
            /// <param name="CurrencyTo">Currency Converting To</param>
            /// <param name="value">Value of Currency that is being converted</param>
            public static void Convert(string CurrencyFrom, string CurrencyTo, int value)
            {
                switch (CurrencyFrom)
                {
                    case (LC.Copper):
                        {
                            LIB.m_MainCharacterInfo.Money.Copper -= value;
                            switch (CurrencyTo)
                            {
                                case (LC.Silver):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Silver += value / 10;
                                        LIB.m_MainCharacterInfo.Money.Copper += value % 10;
                                        break;
                                    }
                                case (LC.Electrum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Electrum += value / 50;
                                        LIB.m_MainCharacterInfo.Money.Copper += value % 50;
                                        break;
                                    }
                                case (LC.Gold):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Gold += value / 100;
                                        LIB.m_MainCharacterInfo.Money.Copper += value % 100;
                                        break;
                                    }
                                case (LC.Platinum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Platinum += value / 1000;
                                        LIB.m_MainCharacterInfo.Money.Copper += value % 1000;
                                        break;
                                    }
                                default:
                                    LIB.m_MainCharacterInfo.Money.Copper += value;
                                    break;
                            }
                            break;
                        }
                    case (LC.Silver):
                        {
                            LIB.m_MainCharacterInfo.Money.Silver -= value;
                            switch (CurrencyTo)
                            {
                                case (LC.Copper):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Copper += value * 10;
                                        break;
                                    }
                                case (LC.Electrum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Electrum += value / 5;
                                        LIB.m_MainCharacterInfo.Money.Silver += value % 5;
                                        break;
                                    }
                                case (LC.Gold):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Gold += value / 10;
                                        LIB.m_MainCharacterInfo.Money.Silver += value % 10;
                                        break;
                                    }
                                case (LC.Platinum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Platinum += value / 100;
                                        LIB.m_MainCharacterInfo.Money.Silver += value % 100;
                                        break;
                                    }
                                default:
                                    LIB.m_MainCharacterInfo.Money.Silver += value;
                                    break;
                            }
                            break;
                        }
                    case (LC.Electrum):
                        {
                            LIB.m_MainCharacterInfo.Money.Electrum -= value;
                            switch (CurrencyTo)
                            {
                                case (LC.Copper):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Copper += value * 50;
                                        break;
                                    }
                                case (LC.Silver):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Silver += value * 5;
                                        break;
                                    }
                                case (LC.Gold):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Gold += value / 2;
                                        LIB.m_MainCharacterInfo.Money.Electrum += value % 2;
                                        break;
                                    }
                                case (LC.Platinum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Platinum += value / 20;
                                        LIB.m_MainCharacterInfo.Money.Electrum += value % 20;
                                        break;
                                    }
                                default:
                                    LIB.m_MainCharacterInfo.Money.Electrum += value;
                                    break;
                            }
                            break;
                        }
                    case (LC.Gold):
                        {
                            LIB.m_MainCharacterInfo.Money.Gold -= value;
                            switch (CurrencyTo)
                            {
                                case (LC.Copper):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Copper += value * 100;
                                        break;
                                    }
                                case (LC.Silver):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Silver += value * 10;
                                        break;
                                    }
                                case (LC.Electrum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Electrum += value * 2;
                                        break;
                                    }
                                case (LC.Platinum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Platinum += value / 10;
                                        LIB.m_MainCharacterInfo.Money.Gold += value % 10;
                                        break;
                                    }
                                default:
                                    LIB.m_MainCharacterInfo.Money.Gold += value;
                                    break;
                            }
                            break;
                        }
                    case (LC.Platinum):
                        {
                            switch (CurrencyTo)
                            {
                                case (LC.Copper):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Copper += value * 1000;
                                        break;
                                    }
                                case (LC.Silver):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Silver += value * 100;
                                        break;
                                    }
                                case (LC.Electrum):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Electrum += value * 20;
                                        break;
                                    }
                                case (LC.Gold):
                                    {
                                        LIB.m_MainCharacterInfo.Money.Gold += value * 10;
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
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
            public bool StrengthSave { get; set; }
            public string Dexterity { get; set; }
            public bool DexteritySave { get; set; }
            public string Constitution { get; set; }
            public bool ConstitutionSave { get; set; }
            public string Intelligence { get; set; }
            public bool IntelligenceSave { get; set; }
            public string Wisdom { get; set; }
            public bool WisdomSave { get; set; }
            public string Charisma { get; set; }
            public bool CharismaSave { get; set; }

            public void Calculate(Attributes attributes)
            {
                SetModifiers(attributes);
            }

            private void SetModifiers(Attributes attributes)
            {
                Strength = CALC.Bonus(StrengthSave, attributes.StrengthModifier);
                Dexterity = CALC.Bonus(DexteritySave, attributes.DexterityModifier);
                Constitution = CALC.Bonus(ConstitutionSave, attributes.ConstitutionModifier);
                Intelligence = CALC.Bonus(IntelligenceSave, attributes.IntelligenceModifier);
                Wisdom = CALC.Bonus(WisdomSave, attributes.WisdomModifier);
                Charisma = CALC.Bonus(CharismaSave, attributes.CharismaModifier);
            }
        }

        #endregion
    }
}
