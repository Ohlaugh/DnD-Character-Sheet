using Interfaces;
using Interfaces.HelperClasses;
using PHBC = Books.Player_Handbook.PHB_Constants;


namespace Books.Player_Handbook
{
  public class PlayerHandbook : IBook
  {
    public List<string> Races { get { return PHBC.Races; } }
    public List<string> SubRaces { get { return PHBC.Subraces; } }
    public List<string> Classes { get { return PHBC.Classes; } }
    public List<string> SubClasses { get { return new List<string>(); } }
    public List<Armor> Armors { get { return PHBC.Armors; } }
    public List<Weapon> Weapons { get { return PHBC.Weapons; } }
    public List<Item> Items { get { return PHBC.Items; } }
    public List<Spell> Spells { get { return PHBC.Spells; } }
  }
}
