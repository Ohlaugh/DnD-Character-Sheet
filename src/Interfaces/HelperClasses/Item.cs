using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Item : INotifyPropertyChanged, ICloneable
  {
    #region Private Members

    private bool m_BuySell = false;
    private bool m_Equipped = false;
    private string m_Name = string.Empty;
    private string m_Style = string.Empty;
    private string m_Cost = string.Empty;
    private double m_Weight = 0;
    private string m_Description = string.Empty;
    private int m_Quantity = 0;

    #endregion Private Members

    #region Public Members

    [XmlIgnore]
    public bool BuySell
    {
      get { return m_BuySell; }

      set
      {
        if (value != m_BuySell)
        {
          m_BuySell = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public bool Equipped
    {
      get { return m_Equipped; }

      set
      {
        if (value != m_Equipped)
        {
          m_Equipped = value;
          NotifyPropertyChanged();
        }
      }
    }
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
    public string Style
    {
      get { return m_Style; }

      set
      {
        if (value != m_Style)
        {
          m_Style = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string Cost
    {
      get { return m_Cost; }

      set
      {
        if (value != m_Cost)
        {
          m_Cost = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public double Weight
    {
      get { return m_Weight; }

      set
      {
        if (value != m_Weight)
        {
          m_Weight = value;
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
        if (string.IsNullOrEmpty(value))
        {
          value = string.Empty;
        }
        if (m_Description != value)
        {
          m_Description = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public int Quantity
    {
      get { return m_Quantity; }

      set
      {
        if (value != m_Quantity)
        {
          m_Quantity = value;
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

    #region ICloneable

    public object Clone()
    {
      var clonedItem = new Item()
      {
        BuySell = BuySell,
        Equipped = Equipped,
        Name = Name,
        Style = Style,
        Cost = Cost,
        Weight = Weight,
        Description = Description,
        Quantity = Quantity
      };

      return clonedItem;
    }

    #endregion ICloneable
  }
}