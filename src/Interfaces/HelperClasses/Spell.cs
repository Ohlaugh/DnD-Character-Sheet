namespace Interfaces.HelperClasses
{
  public class Spell
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string Class { get; set; }
    public string School { get; set; }
    public string CastingTime { get; set; }
    public string Range { get; set; }
    public string Components { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
    public bool Ritual { get; set; }
  }
}
