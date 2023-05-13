using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class CombatAction : INotifyPropertyChanged
  {
    #region Private Members

    private string m_Name = string.Empty;
    private bool m_Bonus = false;
    private bool m_Reaction = false;
    private bool m_OtherActionType = false;
    private string m_Source = string.Empty;
    private string m_Description = string.Empty;

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
    public bool Bonus
    {
      get { return m_Bonus; }

      set
      {
        if (value != m_Bonus)
        {
          m_Bonus = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public bool Reaction
    {
      get { return m_Reaction; }

      set
      {
        if (value != m_Reaction)
        {
          m_Reaction = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public bool OtherActionType
    {
      get { return m_OtherActionType; }

      set
      {
        if (value != m_OtherActionType)
        {
          m_OtherActionType = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Source
    {
      get { return m_Source; }

      set
      {
        if (value != m_Source)
        {
          m_Source = value;
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

    #endregion Public Members

    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion IPropertyChanged

  }
}
