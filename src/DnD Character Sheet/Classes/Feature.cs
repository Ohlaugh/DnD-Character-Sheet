using System.Xml.Serialization;

namespace DnD_Character_Sheet.Classes
{
  public class Feature
  {
    [XmlAttribute]
    public string Name { get; set; }
    [XmlAttribute]
    public string Description { get; set; }
  }
}
