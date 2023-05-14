using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Weapon : Item
  {

    #region Private Members

    private string m_Damage = string.Empty;
    private string m_HitMod = string.Empty;
    private string m_DamageMod = string.Empty;
    private List<string> m_Properties = new List<string>();

    #endregion Private Members

    #region Public Members

    [XmlAttribute]
    public string Damage
    {
      get { return m_Damage; }

      set
      {
        if (value != m_Damage)
        {
          m_Damage = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string HitMod
    {
      get { return m_HitMod; }

      set
      {
        if (value != m_HitMod)
        {
          m_HitMod = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlAttribute]
    public string DamageMod
    {
      get { return m_DamageMod; }

      set
      {
        if (value != m_DamageMod)
        {
          m_DamageMod = value;
          NotifyPropertyChanged();
        }
      }
    }
    public List<string> Properties
    {
      get { return m_Properties; }

      set
      {
        if (value != m_Properties)
        {
          m_Properties = value;
          NotifyPropertyChanged();
        }
      }
    }
    [XmlIgnore]
    public string Properties_Display
    {
      get
      {
        return string.Join(System.Environment.NewLine, Properties.ToArray());
      }
    }

    #endregion Public Members

    #region ICloneable

    public new object Clone()
    {

      var clonedItem = new Weapon()
      {
        BuySell = BuySell,
        Equipped = Equipped,
        Name = Name,
        Style = Style,
        Cost = Cost,
        Weight = Weight,
        Description = Description,
        Quantity = Quantity,
        Damage = Damage,
        Properties = Properties
      };

      return clonedItem;
    }

    #endregion ICloneable
  }
}
