using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CALC = DnD_Character_Sheet.Calculations;
using LC = DnD_Character_Sheet.Constants;

namespace DnD_Character_Sheet.Classes
{
  public class Skills : INotifyPropertyChanged
  {
    #region Private Members

    private string m_Acrobatics_Modifier = LC.DefaultModifier;
    private bool m_Acrobatics_Proficient = false;
    private string m_AnimalHandling_Modifier = LC.DefaultModifier;
    private bool m_AnimalHandling_Proficient = false;
    private string m_Arcana_Modifier = LC.DefaultModifier;
    private bool m_Arcana_Proficient = false;
    private string m_Athletics_Modifier = LC.DefaultModifier;
    private bool m_Athletics_Proficient = false;
    private string m_Deception_Modifier = LC.DefaultModifier;
    private bool m_Deception_Proficient = false;
    private string m_History_Modifier = LC.DefaultModifier;
    private bool m_History_Proficient = false;
    private string m_Insight_Modifier = LC.DefaultModifier;
    private bool m_Insight_Proficient = false;
    private string m_Intimidation_Modifier = LC.DefaultModifier;
    private bool m_Intimidation_Proficient = false;
    private string m_Investigation_Modifier = LC.DefaultModifier;
    private bool m_Investigation_Proficient = false;
    private string m_Medicine_Modifier = LC.DefaultModifier;
    private bool m_Medicine_Proficient = false;
    private string m_Nature_Modifier = LC.DefaultModifier;
    private bool m_Nature_Proficient = false;
    private string m_Perception_Modifier = LC.DefaultModifier;
    private bool m_Perception_Proficient = false;
    private string m_Performance_Modifier = LC.DefaultModifier;
    private bool m_Performance_Proficient = false;
    private string m_Persuassion_Modifier = LC.DefaultModifier;
    private bool m_Persuassion_Proficient = false;
    private string m_Religion_Modifier = LC.DefaultModifier;
    private bool m_Religion_Proficient = false;
    private string m_SlightOfHand_Modifier = LC.DefaultModifier;
    private bool m_SlightOfHand_Proficient = false;
    private string m_Stealth_Modifier = LC.DefaultModifier;
    private bool m_Stealth_Proficient = false;
    private string m_Survival_Modifier = LC.DefaultModifier;
    private bool m_Survival_Proficient = false;

    #endregion Private Members

    #region Public Members

    public string Acrobatics_Modifier
    {
      get { return m_Acrobatics_Modifier; }

      set
      {
        if (value != m_Acrobatics_Modifier)
        {
          m_Acrobatics_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Acrobatics_Proficient
    {
      get { return m_Acrobatics_Proficient; }

      set
      {
        if (value != m_Acrobatics_Proficient)
        {
          m_Acrobatics_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string AnimalHandling_Modifier
    {
      get { return m_AnimalHandling_Modifier; }

      set
      {
        if (value != m_AnimalHandling_Modifier)
        {
          m_AnimalHandling_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool AnimalHandling_Proficient
    {
      get { return m_AnimalHandling_Proficient; }

      set
      {
        if (value != m_AnimalHandling_Proficient)
        {
          m_AnimalHandling_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Arcana_Modifier
    {
      get { return m_Arcana_Modifier; }

      set
      {
        if (value != m_Arcana_Modifier)
        {
          m_Arcana_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Arcana_Proficient
    {
      get { return m_Arcana_Proficient; }

      set
      {
        if (value != m_Arcana_Proficient)
        {
          m_Arcana_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Athletics_Modifier
    {
      get { return m_Athletics_Modifier; }

      set
      {
        if (value != m_Athletics_Modifier)
        {
          m_Athletics_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Athletics_Proficient
    {
      get { return m_Athletics_Proficient; }

      set
      {
        if (value != m_Athletics_Proficient)
        {
          m_Athletics_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Deception_Modifier
    {
      get { return m_Deception_Modifier; }

      set
      {
        if (value != m_Deception_Modifier)
        {
          m_Deception_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Deception_Proficient
    {
      get { return m_Deception_Proficient; }

      set
      {
        if (value != m_Deception_Proficient)
        {
          m_Deception_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string History_Modifier
    {
      get { return m_History_Modifier; }

      set
      {
        if (value != m_History_Modifier)
        {
          m_History_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool History_Proficient
    {
      get { return m_History_Proficient; }

      set
      {
        if (value != m_History_Proficient)
        {
          m_History_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Insight_Modifier
    {
      get { return m_Insight_Modifier; }

      set
      {
        if (value != m_Insight_Modifier)
        {
          m_Insight_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Insight_Proficient
    {
      get { return m_Insight_Proficient; }

      set
      {
        if (value != m_Insight_Proficient)
        {
          m_Insight_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Intimidation_Modifier
    {
      get { return m_Intimidation_Modifier; }

      set
      {
        if (value != m_Intimidation_Modifier)
        {
          m_Intimidation_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Intimidation_Proficient
    {
      get { return m_Intimidation_Proficient; }

      set
      {
        if (value != m_Intimidation_Proficient)
        {
          m_Intimidation_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Investigation_Modifier
    {
      get { return m_Investigation_Modifier; }

      set
      {
        if (value != m_Investigation_Modifier)
        {
          m_Investigation_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Investigation_Proficient
    {
      get { return m_Investigation_Proficient; }

      set
      {
        if (value != m_Investigation_Proficient)
        {
          m_Investigation_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Medicine_Modifier
    {
      get { return m_Medicine_Modifier; }

      set
      {
        if (value != m_Medicine_Modifier)
        {
          m_Medicine_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Medicine_Proficient
    {
      get { return m_Medicine_Proficient; }

      set
      {
        if (value != m_Medicine_Proficient)
        {
          m_Medicine_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Nature_Modifier
    {
      get { return m_Nature_Modifier; }

      set
      {
        if (value != m_Nature_Modifier)
        {
          m_Nature_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Nature_Proficient
    {
      get { return m_Nature_Proficient; }

      set
      {
        if (value != m_Nature_Proficient)
        {
          m_Nature_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Perception_Modifier
    {
      get { return m_Perception_Modifier; }

      set
      {
        if (value != m_Perception_Modifier)
        {
          m_Perception_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Perception_Proficient
    {
      get { return m_Perception_Proficient; }

      set
      {
        if (value != m_Perception_Proficient)
        {
          m_Perception_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Performance_Modifier
    {
      get { return m_Performance_Modifier; }

      set
      {
        if (value != m_Performance_Modifier)
        {
          m_Performance_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Performance_Proficient
    {
      get { return m_Performance_Proficient; }

      set
      {
        if (value != m_Performance_Proficient)
        {
          m_Performance_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Persuassion_Modifier
    {
      get { return m_Persuassion_Modifier; }

      set
      {
        if (value != m_Persuassion_Modifier)
        {
          m_Persuassion_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Persuassion_Proficient
    {
      get { return m_Persuassion_Proficient; }

      set
      {
        if (value != m_Persuassion_Proficient)
        {
          m_Persuassion_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Religion_Modifier
    {
      get { return m_Religion_Modifier; }

      set
      {
        if (value != m_Religion_Modifier)
        {
          m_Religion_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Religion_Proficient
    {
      get { return m_Religion_Proficient; }

      set
      {
        if (value != m_Religion_Proficient)
        {
          m_Religion_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string SlightOfHand_Modifier
    {
      get { return m_SlightOfHand_Modifier; }

      set
      {
        if (value != m_SlightOfHand_Modifier)
        {
          m_SlightOfHand_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool SlightOfHand_Proficient
    {
      get { return m_SlightOfHand_Proficient; }

      set
      {
        if (value != m_SlightOfHand_Proficient)
        {
          m_SlightOfHand_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Stealth_Modifier
    {
      get { return m_Stealth_Modifier; }

      set
      {
        if (value != m_Stealth_Modifier)
        {
          m_Stealth_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Stealth_Proficient
    {
      get { return m_Stealth_Proficient; }

      set
      {
        if (value != m_Stealth_Proficient)
        {
          m_Stealth_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Survival_Modifier
    {
      get { return m_Survival_Modifier; }

      set
      {
        if (value != m_Survival_Modifier)
        {
          m_Survival_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Survival_Proficient
    {
      get { return m_Survival_Proficient; }

      set
      {
        if (value != m_Survival_Proficient)
        {
          m_Survival_Proficient = value;
          NotifyPropertyChanged();
        }
      }
    }

    #endregion Public Members

    #region Public Methods

    public void Calculate(Attributes attributes)
    {
      SetModifiers(attributes);
    }

    #endregion Public Methods

    #region Private Methods

    private void SetModifiers(Attributes attributes)
    {
      Acrobatics_Modifier = CALC.Bonus(Acrobatics_Proficient, attributes.DexterityModifier);
      AnimalHandling_Modifier = CALC.Bonus(AnimalHandling_Proficient, attributes.WisdomModifier);
      Arcana_Modifier = CALC.Bonus(Arcana_Proficient, attributes.IntelligenceModifier);
      Athletics_Modifier = CALC.Bonus(Athletics_Proficient, attributes.StrengthModifier);
      Deception_Modifier = CALC.Bonus(Deception_Proficient, attributes.CharismaModifier);
      History_Modifier = CALC.Bonus(History_Proficient, attributes.IntelligenceModifier);
      Insight_Modifier = CALC.Bonus(Insight_Proficient, attributes.WisdomModifier);
      Intimidation_Modifier = CALC.Bonus(Intimidation_Proficient, attributes.CharismaModifier);
      Investigation_Modifier = CALC.Bonus(Investigation_Proficient, attributes.IntelligenceModifier);
      Medicine_Modifier = CALC.Bonus(Medicine_Proficient, attributes.WisdomModifier);
      Nature_Modifier = CALC.Bonus(Nature_Proficient, attributes.IntelligenceModifier);
      Perception_Modifier = CALC.Bonus(Perception_Proficient, attributes.WisdomModifier);
      Performance_Modifier = CALC.Bonus(Performance_Proficient, attributes.CharismaModifier);
      Persuassion_Modifier = CALC.Bonus(Persuassion_Proficient, attributes.CharismaModifier);
      Religion_Modifier = CALC.Bonus(Religion_Proficient, attributes.IntelligenceModifier);
      SlightOfHand_Modifier = CALC.Bonus(SlightOfHand_Proficient, attributes.DexterityModifier);
      Stealth_Modifier = CALC.Bonus(Stealth_Proficient, attributes.DexterityModifier);
      Survival_Modifier = CALC.Bonus(Survival_Proficient, attributes.WisdomModifier);
    }

    #endregion Private Methods

    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion IPropertyChanged
  }
}
