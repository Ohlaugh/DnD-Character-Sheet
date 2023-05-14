using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Spell : INotifyPropertyChanged, ICloneable
  {
    #region Private Members

    private string m_Name = string.Empty;
    private int m_Level = 0;
    private string m_Class = string.Empty;
    private string m_School = string.Empty;
    private string m_CastingTime = string.Empty;
    private string m_Range = string.Empty;
    private string m_Components = string.Empty;
    private string m_Duration = string.Empty;
    private string m_Description = string.Empty;
    private bool m_Ritual = false;

    #endregion Private Members

    #region Public Members

    [XmlAttribute]
    public string Name
    {
      get { return m_Name; }

      set
      {
        if (value != m_Name)
        {
          m_Name = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public int Level
    {
      get { return m_Level; }

      set
      {
        if (value != m_Level)
        {
          m_Level = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Class
    {
      get { return m_Class; }

      set
      {
        if (value != m_Class)
        {
          m_Class = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string School
    {
      get { return m_School; }

      set
      {
        if (value != m_School)
        {
          m_School = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string CastingTime
    {
      get { return m_CastingTime; }

      set
      {
        if (value != m_CastingTime)
        {
          m_CastingTime = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Range
    {
      get { return m_Range; }

      set
      {
        if (value != m_Range)
        {
          m_Range = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Components
    {
      get { return m_Components; }

      set
      {
        if (value != m_Components)
        {
          m_Components = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Duration
    {
      get { return m_Duration; }

      set
      {
        if (value != m_Duration)
        {
          m_Duration = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Description
    {
      get { return m_Description; }

      set
      {
        if (value != m_Description)
        {
          m_Description = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public bool Ritual
    {
      get { return m_Ritual; }

      set
      {
        if (value != m_Ritual)
        {
          m_Ritual = value;
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

    #region ICloneable

    public object Clone()
    {
      var clonedItem = new Spell()
      {
        Name = Name,
        Level = Level,
        Class = Class,
        School = School,
        CastingTime = CastingTime,
        Range = Range,
        Components = Components,
        Duration = Duration,
        Description = Description,
        Ritual = Ritual
      };

      return clonedItem;
    }

    #endregion ICloneable
  }
}
