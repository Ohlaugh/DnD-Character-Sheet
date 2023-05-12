using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Armor : Item
  {
    #region Private Members

    private string m_ArmorClass = string.Empty;
    private int m_StrengthReq = 0;
    private bool m_Disadvantage = false;

    #endregion Private Members

    #region Public Members

    [XmlAttribute]
    public string ArmorClass
    {
      get { return m_ArmorClass; }

      set
      {
        if (value != m_ArmorClass)
        {
          m_ArmorClass = value;
          NotifyPropertyChanged();
        }
      }
    }

    [XmlAttribute]
    public int StrengthReq
    {
      get { return m_StrengthReq; }

      set
      {
        if (value != m_StrengthReq)
        {
          m_StrengthReq = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public bool Disadvantage
    {
      get { return m_Disadvantage; }

      set
      {
        if (value != m_Disadvantage)
        {
          m_Disadvantage = value;
          NotifyPropertyChanged();
        }
      }
    }

    #endregion Public Members

    #region ICloneable

    public new object Clone()
    {

      var clonedItem = new Armor()
      {
        BuySell = BuySell,
        Equipped = Equipped,
        Name = Name,
        Style = Style,
        Cost = Cost,
        Weight = Weight,
        Description = Description,
        Quantity = Quantity,
        ArmorClass = ArmorClass,
        StrengthReq = StrengthReq,
        Disadvantage = Disadvantage
      };

      return clonedItem;
    }

    #endregion ICloneable
  }
}
