using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Sheet
{
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
}
