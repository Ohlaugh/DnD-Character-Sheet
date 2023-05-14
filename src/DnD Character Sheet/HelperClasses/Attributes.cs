using LC = DnD_Character_Sheet.Constants;

namespace DnD_Character_Sheet.HelperClasses
{
  public class Attributes : NotifyProperty
  {
    #region Private Members

    private int m_Strength = 0;
    private string m_StrengthModifier = LC.DefaultModifier;
    private int m_Dexterity = 0;
    private string m_DexterityModifier = LC.DefaultModifier;
    private int m_Constitution = 0;
    private string m_ConstitutionModifier = LC.DefaultModifier;
    private int m_Intelligence = 0;
    private string m_IntelligenceModifier = LC.DefaultModifier;
    private int m_Wisdom = 0;
    private string m_WisdomModifier = LC.DefaultModifier;
    private int m_Charisma = 0;
    private string m_CharismaModifier = LC.DefaultModifier;

    #endregion Private Members

    #region Public Members

    public int Strength
    {
      get { return m_Strength; }

      set
      {
        if (value != m_Strength)
        {
          m_Strength = value;
          NotifyPropertyChanged();
          StrengthModifier = CalcModifier(m_Strength);
        }
      }
    }

    public string StrengthModifier
    {
      get { return m_StrengthModifier; }

      set
      {
        if (value != m_StrengthModifier)
        {
          m_StrengthModifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Dexterity
    {
      get { return m_Dexterity; }

      set
      {
        if (value != m_Dexterity)
        {
          m_Dexterity = value;
          NotifyPropertyChanged();
          DexterityModifier = CalcModifier(m_Dexterity);
        }
      }
    }
    public string DexterityModifier
    {
      get { return m_DexterityModifier; }

      set
      {
        if (value != m_DexterityModifier)
        {
          m_DexterityModifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Constitution
    {
      get { return m_Constitution; }

      set
      {
        if (value != m_Constitution)
        {
          m_Constitution = value;
          NotifyPropertyChanged();
          ConstitutionModifier = CalcModifier(m_Constitution);
        }
      }
    }
    public string ConstitutionModifier
    {
      get { return m_ConstitutionModifier; }

      set
      {
        if (value != m_ConstitutionModifier)
        {
          m_ConstitutionModifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Intelligence
    {
      get { return m_Intelligence; }

      set
      {
        if (value != m_Intelligence)
        {
          m_Intelligence = value;
          NotifyPropertyChanged();
          IntelligenceModifier = CalcModifier(m_Intelligence);
        }
      }
    }
    public string IntelligenceModifier
    {
      get { return m_IntelligenceModifier; }

      set
      {
        if (value != m_IntelligenceModifier)
        {
          m_IntelligenceModifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Wisdom
    {
      get { return m_Wisdom; }

      set
      {
        if (value != m_Wisdom)
        {
          m_Wisdom = value;
          NotifyPropertyChanged();
          WisdomModifier = CalcModifier(m_Wisdom);
        }
      }
    }
    public string WisdomModifier
    {
      get { return m_WisdomModifier; }

      set
      {
        if (value != m_WisdomModifier)
        {
          m_WisdomModifier = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Charisma
    {
      get { return m_Charisma; }

      set
      {
        if (value != m_Charisma)
        {
          m_Charisma = value;
          NotifyPropertyChanged();
          CharismaModifier = CalcModifier(m_Charisma);
        }
      }
    }
    public string CharismaModifier
    {
      get { return m_CharismaModifier; }

      set
      {
        if (value != m_CharismaModifier)
        {
          m_CharismaModifier = value;
          NotifyPropertyChanged();
        }
      }
    }

    #endregion Public Members

    #region Private Methods

    private string CalcModifier(int score)
    {
      int modifier = 0;
      string sign = score >= 10 ? "+ " : "- ";
      switch (score)
      {
        case 1:
          modifier = 5;
          break;
        case 2:
        case 3:
          modifier = 4;
          break;
        case 4:
        case 5:
          modifier = 3;
          break;
        case 6:
        case 7:
          modifier = 2;
          break;
        case 8:
        case 9:
          modifier = 1;
          break;
        case 10:
        case 11:
          modifier = 0;
          break;
        case 12:
        case 13:
          modifier = 1;
          break;
        case 14:
        case 15:
          modifier = 2;
          break;
        case 16:
        case 17:
          modifier = 3;
          break;
        case 18:
        case 19:
          modifier = 4;
          break;
        case 20:
        case 21:
          modifier = 5;
          break;
        case 22:
        case 23:
          modifier = 6;
          break;
        case 24:
        case 25:
          modifier = 7;
          break;
        case 26:
        case 27:
          modifier = 8;
          break;
        case 28:
        case 29:
          modifier = 9;
          break;
        case 30:
          modifier = 10;
          break;
      }
      return sign + modifier;
    }

    #endregion Private Methods
  }
}
