namespace Interfaces
{
  public interface ICharacterClass
  {
    string Spell_Modifier { get; }
    string Spell_Attack { get; }
    string Spell_Save { get; }

    void LevelUp();
  }
}
