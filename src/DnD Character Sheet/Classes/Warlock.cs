using DnD_Character_Sheet.HelperClasses;
using Interfaces;

namespace DnD_Character_Sheet.Classes
{
  public class Warlock : ICharacterClass
  {
    public string Spell_Modifier
    {
      get
      {
        return Library.MainCharacterInfo.Attributes.CharismaModifier;
      }
    }
    public string Spell_Attack
    {
      get
      {
        return Calculations.Modifier(true, Library.MainCharacterInfo.Attributes.CharismaModifier);
      }
    }
    public string Spell_Save
    {
      get
      {
        return Calculations.Modifier(true, Library.MainCharacterInfo.Attributes.CharismaModifier, 8).Split()[1];
      }
    }

    public void LevelUp()
    {

    }

  }
}
