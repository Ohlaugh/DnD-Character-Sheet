using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Sheet
{
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
            Calculations calc = new Calculations();
            Strength = calc.CalcBonus(_Strength, attributes.StrengthModifier);
            Dexterity = calc.CalcBonus(_Dexterity, attributes.DexterityModifier);
            Constitution = calc.CalcBonus(_Constitution, attributes.ConstitutionModifier);
            Intelligence = calc.CalcBonus(_Intelligence, attributes.IntelligenceModifier);
            Wisdom = calc.CalcBonus(_Wisdom, attributes.WisdomModifier);
            Charisma = calc.CalcBonus(_Charisma, attributes.CharismaModifier);
        }
    }
}
