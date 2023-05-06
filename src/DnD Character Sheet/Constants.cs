using System;

namespace DnD_Character_Sheet
{
  public class Constants
  {

    #region General Constants

    public const string FileFilter = "DnD Character Files (*.DnD)|*.DnD";

    public static readonly string ProfAndLangFormat = "Languages: {0}" + Environment.NewLine +
      "Armor: {1}" + Environment.NewLine +
      "Weapons: {2}" + Environment.NewLine +
      "Tools: {3}";

    public const string DefaultModifier = "+ 0";

    // Money
    public const string Copper = "Copper";
    public const string Silver = "Silver";
    public const string Electrum = "Electrum";
    public const string Gold = "Gold";
    public const string Platinum = "Platinum";

    #endregion General Constants
  }
}
