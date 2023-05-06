using Interfaces.HelperClasses;

namespace Interfaces
{
  public interface IBook
  {
    public List<string> Races { get; }
    public List<string> SubRaces { get; }
    public List<string> Classes { get; }
    public List<string> SubClasses { get; }
    public List<Armor> Armors { get; }
    public List<Weapon> Weapons { get; }
    public List<Item> Items { get; }
    public List<Spell> Spells { get; }
  }
}