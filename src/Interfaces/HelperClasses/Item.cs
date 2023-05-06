using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Item
  {
    private string m_Description = string.Empty;

    [XmlAttribute]
    public bool Equipped { get; set; }
    [XmlAttribute]
    public string Name { get; set; }
    [XmlAttribute]
    public string Style { get; set; }
    [XmlAttribute]
    public string Cost { get; set; }
    [XmlAttribute]
    public double Weight { get; set; }
    [XmlAttribute]
    public string Description
    {
      get
      {
        return m_Description;
      }
      set
      {
        if (string.IsNullOrEmpty(value))
        {
          value = string.Empty;
        }
        m_Description = value;
      }
    }
    [XmlAttribute]
    public int Quantity { get; set; }
  }
}
