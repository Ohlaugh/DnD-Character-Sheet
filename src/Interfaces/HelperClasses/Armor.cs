using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Armor : Item
  {
    [XmlAttribute]
    public string ArmorClass { get; set; }
    [XmlAttribute]
    public int StrengthReq { get; set; }
    [XmlAttribute]
    public bool Disadvantage { get; set; }
  }
}
