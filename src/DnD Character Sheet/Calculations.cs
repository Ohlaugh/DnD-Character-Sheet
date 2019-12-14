using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Sheet
{
    class Calculations : Library
    {
        public string CalcBonus(bool proficient, int modifier)
        {
            int bonus = modifier;
            if (proficient)
            {
                bonus += m_MainCharacterInfo.ProficiencyBonus;
            }

            if (bonus >= 0)
            {
                return "+ " + bonus;
            }

            return "- " + bonus;
        }
    }
}
