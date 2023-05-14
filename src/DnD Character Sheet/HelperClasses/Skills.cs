using Interfaces;
using System.Reflection;
using CALC = DnD_Character_Sheet.HelperClasses.Calculations;

namespace DnD_Character_Sheet.HelperClasses
{
  public class Skills : NotifyProperty, IRefresh
  {
    #region Private Members

    private bool m_Acrobatics_Proficient = false;
    private bool m_AnimalHandling_Proficient = false;
    private bool m_Arcana_Proficient = false;
    private bool m_Athletics_Proficient = false;
    private bool m_Deception_Proficient = false;
    private bool m_History_Proficient = false;
    private bool m_Insight_Proficient = false;
    private bool m_Intimidation_Proficient = false;
    private bool m_Investigation_Proficient = false;
    private bool m_Medicine_Proficient = false;
    private bool m_Nature_Proficient = false;
    private bool m_Perception_Proficient = false;
    private bool m_Performance_Proficient = false;
    private bool m_Persuassion_Proficient = false;
    private bool m_Religion_Proficient = false;
    private bool m_SlightOfHand_Proficient = false;
    private bool m_Stealth_Proficient = false;
    private bool m_Survival_Proficient = false;

    #endregion Private Members

    #region Public Members

    public string Acrobatics_Modifier
    {
      get { return CALC.Modifier(m_Acrobatics_Proficient, Library.MainCharacterInfo.Attributes.DexterityModifier); }
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
          NotifyPropertyChanged("Acrobatics_Modifier");
        }
      }
    }
    public string AnimalHandling_Modifier
    {
      get { return CALC.Modifier(m_AnimalHandling_Proficient, Library.MainCharacterInfo.Attributes.WisdomModifier); }
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
          NotifyPropertyChanged("AnimalHandling_Modifier");
        }
      }
    }
    public string Arcana_Modifier
    {
      get { return CALC.Modifier(m_Arcana_Proficient, Library.MainCharacterInfo.Attributes.IntelligenceModifier); }
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
          NotifyPropertyChanged("Arcana_Modifier");
        }
      }
    }
    public string Athletics_Modifier
    {
      get { return CALC.Modifier(m_Athletics_Proficient, Library.MainCharacterInfo.Attributes.StrengthModifier); }
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
          NotifyPropertyChanged("Athletics_Modifier");
        }
      }
    }
    public string Deception_Modifier
    {
      get { return CALC.Modifier(m_Deception_Proficient, Library.MainCharacterInfo.Attributes.CharismaModifier); }
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
          NotifyPropertyChanged("Deception_Modifier");
        }
      }
    }
    public string History_Modifier
    {
      get { return CALC.Modifier(m_History_Proficient, Library.MainCharacterInfo.Attributes.IntelligenceModifier); }
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
          NotifyPropertyChanged("History_Modifier");
        }
      }
    }
    public string Insight_Modifier
    {
      get { return CALC.Modifier(m_Insight_Proficient, Library.MainCharacterInfo.Attributes.WisdomModifier); }
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
          NotifyPropertyChanged("Insight_Modifier");
        }
      }
    }
    public string Intimidation_Modifier
    {
      get { return CALC.Modifier(m_Intimidation_Proficient, Library.MainCharacterInfo.Attributes.CharismaModifier); }
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
          NotifyPropertyChanged("Intimidation_Modifier");
        }
      }
    }
    public string Investigation_Modifier
    {
      get { return CALC.Modifier(m_Investigation_Proficient, Library.MainCharacterInfo.Attributes.IntelligenceModifier); }
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
          NotifyPropertyChanged("Investigation_Modifier");
        }
      }
    }
    public string Medicine_Modifier
    {
      get { return CALC.Modifier(m_Medicine_Proficient, Library.MainCharacterInfo.Attributes.WisdomModifier); }
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
          NotifyPropertyChanged("Medicine_Modifier");
        }
      }
    }
    public string Nature_Modifier
    {
      get { return CALC.Modifier(m_Nature_Proficient, Library.MainCharacterInfo.Attributes.IntelligenceModifier); }
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
          NotifyPropertyChanged("Nature_Modifier");
        }
      }
    }
    public string Perception_Modifier
    {
      get { return CALC.Modifier(m_Perception_Proficient, Library.MainCharacterInfo.Attributes.WisdomModifier); }
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
          NotifyPropertyChanged("Perception_Modifier");
        }
      }
    }
    public string Performance_Modifier
    {
      get { return CALC.Modifier(m_Performance_Proficient, Library.MainCharacterInfo.Attributes.CharismaModifier); }
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
          NotifyPropertyChanged("Performance_Modifier");
        }
      }
    }
    public string Persuassion_Modifier
    {
      get { return CALC.Modifier(m_Persuassion_Proficient, Library.MainCharacterInfo.Attributes.CharismaModifier); }
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
          NotifyPropertyChanged("Persuassion_Modifier");
        }
      }
    }
    public string Religion_Modifier
    {
      get { return CALC.Modifier(m_Religion_Proficient, Library.MainCharacterInfo.Attributes.IntelligenceModifier); }
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
          NotifyPropertyChanged("Religion_Modifier");
        }
      }
    }
    public string SlightOfHand_Modifier
    {
      get { return CALC.Modifier(m_SlightOfHand_Proficient, Library.MainCharacterInfo.Attributes.DexterityModifier); }
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
          NotifyPropertyChanged("SlightOfHand_Modifier");
        }
      }
    }
    public string Stealth_Modifier
    {
      get { return CALC.Modifier(m_Stealth_Proficient, Library.MainCharacterInfo.Attributes.DexterityModifier); }
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
          NotifyPropertyChanged("Stealth_Modifier");
        }
      }
    }
    public string Survival_Modifier
    {
      get { return CALC.Modifier(m_Survival_Proficient, Library.MainCharacterInfo.Attributes.WisdomModifier); }
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
          NotifyPropertyChanged("Survival_Modifier");
        }
      }
    }

    #endregion Public Members

    #region IRefresh

    public void Refresh()
    {
      foreach (PropertyInfo item in this.GetType().GetProperties())
      {
        NotifyPropertyChanged(item.Name);
      }
    }

    #endregion IRefresh
  }
}
