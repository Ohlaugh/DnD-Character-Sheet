using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CALC = DnD_Character_Sheet.HelperClasses.Calculations;
using LC = DnD_Character_Sheet.Constants;

namespace DnD_Character_Sheet.Classes
{
  public class SavingThrows : INotifyPropertyChanged
  {
    #region Private Members
    private string m_StrengthSave_Modifier = LC.DefaultModifier;
    private bool m_StrengthSave_Proficient = false;
    private string m_DexteritySave_Modifier = LC.DefaultModifier;
    private bool m_DexteritySave_Proficient = false;
    private string m_ConstitutionSave_Modifier = LC.DefaultModifier;
    private bool m_ConstitutionSave_Proficient = false;
    private string m_IntelligenceSave_Modifier = LC.DefaultModifier;
    private bool m_IntelligenceSave_Proficient = false;
    private string m_WisdomSave_Modifier = LC.DefaultModifier;
    private bool m_WisdomSave_Proficient = false;
    private string m_CharismaSave_Modifier = LC.DefaultModifier;
    private bool m_CharismaSave_Proficient = false;

    #endregion Private Members

    #region Public Members

    public string StrengthSave_Modifier
    {
      get { return m_StrengthSave_Modifier; }

      set
      {
        if (value != m_StrengthSave_Modifier)
        {
          m_StrengthSave_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool StrengthSave_Proficient
    {
      get { return m_StrengthSave_Proficient; }

      set
      {
        if (value != m_StrengthSave_Proficient)
        {
          m_StrengthSave_Proficient = value;
          StrengthSave_Modifier = CALC.Bonus(m_StrengthSave_Proficient, StrengthSave_Modifier);
          NotifyPropertyChanged();
        }
      }
    }
    public string DexteritySave_Modifier
    {
      get { return m_DexteritySave_Modifier; }

      set
      {
        if (value != m_DexteritySave_Modifier)
        {
          m_DexteritySave_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool DexteritySave_Proficient
    {
      get { return m_DexteritySave_Proficient; }

      set
      {
        if (value != m_DexteritySave_Proficient)
        {
          m_DexteritySave_Proficient = value;
          DexteritySave_Modifier = CALC.Bonus(m_DexteritySave_Proficient, DexteritySave_Modifier);
          NotifyPropertyChanged();
        }
      }
    }
    public string ConstitutionSave_Modifier
    {
      get { return m_ConstitutionSave_Modifier; }

      set
      {
        if (value != m_ConstitutionSave_Modifier)
        {
          m_ConstitutionSave_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool ConstitutionSave_Proficient
    {
      get { return m_ConstitutionSave_Proficient; }

      set
      {
        if (value != m_ConstitutionSave_Proficient)
        {
          m_ConstitutionSave_Proficient = value;
          ConstitutionSave_Modifier = CALC.Bonus(m_ConstitutionSave_Proficient, ConstitutionSave_Modifier);
          NotifyPropertyChanged();
        }
      }
    }
    public string IntelligenceSave_Modifier
    {
      get { return m_IntelligenceSave_Modifier; }

      set
      {
        if (value != m_IntelligenceSave_Modifier)
        {
          m_IntelligenceSave_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool IntelligenceSave_Proficient
    {
      get { return m_IntelligenceSave_Proficient; }

      set
      {
        if (value != m_IntelligenceSave_Proficient)
        {
          m_IntelligenceSave_Proficient = value;
          IntelligenceSave_Modifier = CALC.Bonus(m_IntelligenceSave_Proficient, IntelligenceSave_Modifier);
          NotifyPropertyChanged();
        }
      }
    }
    public string WisdomSave_Modifier
    {
      get { return m_WisdomSave_Modifier; }

      set
      {
        if (value != m_WisdomSave_Modifier)
        {
          m_WisdomSave_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool WisdomSave_Proficient
    {
      get { return m_WisdomSave_Proficient; }

      set
      {
        if (value != m_WisdomSave_Proficient)
        {
          m_WisdomSave_Proficient = value;
          WisdomSave_Modifier = CALC.Bonus(m_WisdomSave_Proficient, WisdomSave_Modifier);
          NotifyPropertyChanged();
        }
      }
    }
    public string CharismaSave_Modifier
    {
      get { return m_CharismaSave_Modifier; }

      set
      {
        if (value != m_CharismaSave_Modifier)
        {
          m_CharismaSave_Modifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool CharismaSave_Proficient
    {
      get { return m_CharismaSave_Proficient; }

      set
      {
        if (value != m_CharismaSave_Proficient)
        {
          m_CharismaSave_Proficient = value;
          CharismaSave_Modifier = CALC.Bonus(m_CharismaSave_Proficient, CharismaSave_Modifier);
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
