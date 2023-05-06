using System.Xml.Serialization;

namespace Interfaces.HelperClasses
{
  public class Weapon : Item
  {
    [XmlAttribute]
    public string Damage { get; set; }
    public List<string> Properties { get; set; }
    [XmlIgnore]
    public string Properties_Display
    {
      get
      {
        return string.Join(System.Environment.NewLine, Properties.ToArray());
      }
    }
  }
}
