using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CALC = DnD_Character_Sheet.HelperClasses.Calculations;
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
          Acrobatics_Modifier = CALC.Bonus(Acrobatics_Proficient, Acrobatics_Modifier);
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
          AnimalHandling_Modifier = CALC.Bonus(m_AnimalHandling_Proficient, AnimalHandling_Modifier);
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
          Arcana_Modifier = CALC.Bonus(m_Arcana_Proficient, Arcana_Modifier);
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
          Athletics_Modifier = CALC.Bonus(m_Athletics_Proficient, Athletics_Modifier);
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
          Deception_Modifier = CALC.Bonus(m_Deception_Proficient, Deception_Modifier);
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
          History_Modifier = CALC.Bonus(m_History_Proficient, History_Modifier);
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
          Insight_Modifier = CALC.Bonus(m_Insight_Proficient, Insight_Modifier);
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
          Intimidation_Modifier = CALC.Bonus(m_Intimidation_Proficient, Intimidation_Modifier);
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
          Investigation_Modifier = CALC.Bonus(m_Investigation_Proficient, Investigation_Modifier);
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
          Medicine_Modifier = CALC.Bonus(m_Medicine_Proficient, Medicine_Modifier);
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
          Nature_Modifier = CALC.Bonus(m_Nature_Proficient, Nature_Modifier);
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
          Perception_Modifier = CALC.Bonus(m_Perception_Proficient, Perception_Modifier);
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
          Performance_Modifier = CALC.Bonus(m_Performance_Proficient, Performance_Modifier);
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
          Persuassion_Modifier = CALC.Bonus(m_Persuassion_Proficient, Persuassion_Modifier);
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
          Religion_Modifier = CALC.Bonus(m_Religion_Proficient, Religion_Modifier);
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
          SlightOfHand_Modifier = CALC.Bonus(m_SlightOfHand_Proficient, SlightOfHand_Modifier);
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
          Stealth_Modifier = CALC.Bonus(m_Stealth_Proficient, Stealth_Modifier);
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
          Survival_Modifier = CALC.Bonus(m_Survival_Proficient, Survival_Modifier);
          NotifyPropertyChanged();
        }
      }
    }

    #endregion Public Members

    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion IPropertyChanged
  }
}
