using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Sheet.Books.Player_Handbook
{
    class PHB_Constants
    {
        public static readonly List<string> Classes =
            new List<string> { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk",
                "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };

        public static readonly List<string> Races =
            new List<string> {"Dwarf", "Elf", "Halfling", "Human", "Dragonborn",
                "Gnome", "Half-Elf", "Half-Orc", "Tiefling"};

        public static readonly List<string> Subraces =
            new List<string> {
                "Dwarf:Hill Dwarf", "Dwarf:Mountain Dwarf",
                "Elf:High Elf", "Elf:Wood Elf", "Elf:Dark Elf (Drow)",
                "Halfling:Lightfoot", "Halfling:Stout",
                "Dragonborn:Black", "Dragonborn:Blue", "Dragonborn:Brass", "Dragonborn:Bronze", "Dragonborn:Copper",
                "Dragonborn:Gold", "Dragonborn:Green", "Dragonborn:Red", "Dragonborn:Silver", "Dragonborn:White",
                "Gnome:Forest Gnome", "Gnome:Rock Gnome"};
    }
}
