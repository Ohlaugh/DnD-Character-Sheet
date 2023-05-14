using Interfaces;
using System.Reflection;
using CALC = DnD_Character_Sheet.HelperClasses.Calculations;

namespace DnD_Character_Sheet.HelperClasses
{
  public class SavingThrows : NotifyProperty, IRefresh
  {
    #region Private Members

    private bool m_StrengthSave_Proficient = false;
    private bool m_DexteritySave_Proficient = false;
    private bool m_ConstitutionSave_Proficient = false;
    private bool m_IntelligenceSave_Proficient = false;
    private bool m_WisdomSave_Proficient = false;
    private bool m_CharismaSave_Proficient = false;

    #endregion Private Members

    #region Public Members

    public string StrengthSave_Modifier
    {
      get { return CALC.Modifier(m_StrengthSave_Proficient, Library.MainCharacterInfo.Attributes.StrengthModifier); }
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
          NotifyPropertyChanged("StrengthSave_Modifier");
        }
      }
    }
    public string DexteritySave_Modifier
    {
      get { return CALC.Modifier(m_DexteritySave_Proficient, Library.MainCharacterInfo.Attributes.DexterityModifier); }
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
          NotifyPropertyChanged("DexteritySave_Modifier");
        }
      }
    }
    public string ConstitutionSave_Modifier
    {
      get { return CALC.Modifier(m_ConstitutionSave_Proficient, Library.MainCharacterInfo.Attributes.ConstitutionModifier); }
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
          NotifyPropertyChanged("ConstitutionSave_Modifier");
        }
      }
    }
    public string IntelligenceSave_Modifier
    {
      get { return CALC.Modifier(m_IntelligenceSave_Proficient, Library.MainCharacterInfo.Attributes.IntelligenceModifier); }
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
          NotifyPropertyChanged("IntelligenceSave_Modifier");
        }
      }
    }
    public string WisdomSave_Modifier
    {
      get { return CALC.Modifier(m_WisdomSave_Proficient, Library.MainCharacterInfo.Attributes.WisdomModifier); }
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
          NotifyPropertyChanged("WisdomSave_Modifier");
        }
      }
    }
    public string CharismaSave_Modifier
    {
      get { return CALC.Modifier(m_CharismaSave_Proficient, Library.MainCharacterInfo.Attributes.CharismaModifier); }
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
          NotifyPropertyChanged("CharismaSave_Modifier");
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
