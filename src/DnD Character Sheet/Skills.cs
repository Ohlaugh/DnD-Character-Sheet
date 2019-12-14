using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC = DnD_Character_Sheet.Constants;
using DnD_Character_Sheet;


namespace DnD_Character_Sheet
{
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


        //private List<bool> proficiencyList = new List<bool>();

        //private List<Tuple<string, bool>> skillList_Str = new List<Tuple<string, bool>>();
        //private List<Tuple<string, bool>> skillList_Dex = new List<Tuple<string, bool>>();
        //private List<Tuple<string, bool>> skillList_Con = new List<Tuple<string, bool>>();
        //private List<Tuple<string, bool>> skillList_string = new List<Tuple<string, bool>>();
        //private List<Tuple<string, bool>> skillList_Wis = new List<Tuple<string, bool>>();
        //private List<Tuple<string, bool>> skillList_Cha = new List<Tuple<string, bool>>();

        //private List<List<Tuple<string, bool>>> skillLists = new List<List<Tuple<string, bool>>>();
        public void Calculate(Attributes attributes)
        {
            //CreateLists();
            SetModifiers(attributes);
        }

        //private void CreateLists()
        //{
        //    skillList_Str.Add(new Tuple<string, bool>(LC.Athletics, _Athletics));
        //    skillLists.Add(skillList_Str);

        //    skillList_Dex.Add(new Tuple<string, bool>(LC.Acrobatics, _Acrobatics));
        //    skillList_Dex.Add(new Tuple<string, bool>(LC.SlightOfHand, _SlightOfHand));
        //    skillList_Dex.Add(new Tuple<string, bool>(LC.Stealth, _Stealth));
        //    skillLists.Add(skillList_Dex);

        //    skillList_string.Add(new Tuple<string, bool>(LC.Arcana, _Arcana));
        //    skillList_string.Add(new Tuple<string, bool>(LC.History, _History));
        //    skillList_string.Add(new Tuple<string, bool>(LC.Investigation, _Investigation));
        //    skillList_string.Add(new Tuple<string, bool>(LC.Nature, _Nature));
        //    skillList_string.Add(new Tuple<string, bool>(LC.Religion, _Religion));
        //    skillLists.Add(skillList_string);

        //    skillList_Wis.Add(new Tuple<string, bool>(LC.AnimalHandling, _AnimalHandling));
        //    skillList_Wis.Add(new Tuple<string, bool>(LC.Insight, _Insight));
        //    skillList_Wis.Add(new Tuple<string, bool>(LC.Medicine, _Medicine));
        //    skillList_Wis.Add(new Tuple<string, bool>(LC.Perception, _Perception));
        //    skillList_Wis.Add(new Tuple<string, bool>(LC.Survival, _Survival));
        //    skillLists.Add(skillList_Wis);

        //    skillList_Cha.Add(new Tuple<string, bool>(LC.Deception, _Deception));
        //    skillList_Cha.Add(new Tuple<string, bool>(LC.stringimidation, _stringimidation));
        //    skillList_Cha.Add(new Tuple<string, bool>(LC.Performance, _Performance));
        //    skillList_Cha.Add(new Tuple<string, bool>(LC.Persuassion, _Persuassion));
        //    skillLists.Add(skillList_Cha);
        //}


        private void SetModifiers(Attributes attributes)
        {
            Calculations calc = new Calculations();
            Acrobatics = calc.CalcBonus(_Acrobatics, attributes.DexterityModifier);
            AnimalHandling = calc.CalcBonus(_AnimalHandling, attributes.WisdomModifier);
            Arcana = calc.CalcBonus(_Arcana, attributes.IntelligenceModifier);
            Athletics = calc.CalcBonus(_Athletics, attributes.StrengthModifier);
            Deception = calc.CalcBonus(_Deception, attributes.CharismaModifier);
            History = calc.CalcBonus(_History, attributes.IntelligenceModifier);
            Insight = calc.CalcBonus(_Insight, attributes.WisdomModifier);
            Intimidation = calc.CalcBonus(_Intimidation, attributes.CharismaModifier);
            Investigation = calc.CalcBonus(_Investigation, attributes.IntelligenceModifier);
            Medicine = calc.CalcBonus(_Medicine, attributes.WisdomModifier);
            Nature = calc.CalcBonus(_Nature, attributes.IntelligenceModifier);
            Perception = calc.CalcBonus(_Nature, attributes.IntelligenceModifier);
            Performance = calc.CalcBonus(_Performance, attributes.CharismaModifier);
            Persuassion = calc.CalcBonus(_Persuassion, attributes.CharismaModifier);
            Religion = calc.CalcBonus(_Religion, attributes.IntelligenceModifier);
            SlightOfHand = calc.CalcBonus(_SlightOfHand, attributes.DexterityModifier);
            Stealth = calc.CalcBonus(_Stealth, attributes.DexterityModifier);
            Survival = calc.CalcBonus(_Survival, attributes.WisdomModifier);
        }
    }
}
