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
      StrengthSave_Modifier = CALC.Bonus(StrengthSave_Proficient, attributes.StrengthModifier);
      DexteritySave_Modifier = CALC.Bonus(DexteritySave_Proficient, attributes.DexterityModifier);
      ConstitutionSave_Modifier = CALC.Bonus(ConstitutionSave_Proficient, attributes.ConstitutionModifier);
      IntelligenceSave_Modifier = CALC.Bonus(IntelligenceSave_Proficient, attributes.IntelligenceModifier);
      WisdomSave_Modifier = CALC.Bonus(WisdomSave_Proficient, attributes.WisdomModifier);
      CharismaSave_Modifier = CALC.Bonus(CharismaSave_Proficient, attributes.CharismaModifier);
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
