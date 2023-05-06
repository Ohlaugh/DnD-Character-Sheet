namespace Books
{
  internal class Constants
  {
    #region Weapon/Armor Properties

    /// <summary>
    /// List of all weapon properties
    /// (Property, Description)
    /// </summary>
    readonly Dictionary<string, string> WeaponProperties = new Dictionary<string, string>
        {
            {Ammunition,
                "You can use a weapon that has the ammunition property to make a ranged attack only if you have ammunition to " +
                "fire from the weapon. Each time you attack with the weapon, you expend one piece of ammunition. Drawing the " +
                "ammunition from a quiver, case, or other container is part of the attack (you need a free hand to load a " +
                "one-handed weapon). At the end of the battle you can recover half your expended ammunition by taking a minute " +
                "to search the battlefield. If you use a weapon that has the ammunition property to make a melee attack, you " +
                "treat the weapon as an Improvised weapon. A sling must be loaded to deal any damage when used in this way."},

            {Finesse,
                "When making an attack with a finesse weapon, you use your choice of your Strength or Dexterity modifier for the " +
                "attack and damage rolls. You must use the same modifier for both rolls."},

            {Heavy,
                "Small creatures have disadvantage on attack rolls with heavy weapons. A heavy weapon's size and bulk make it too " +
                "heavy for a Small creature to use effectively."},

            {Light,
                "A light weapon is small and easy to handle, making it ideal for use when fighting with two weapons."},

            {Loading,
                "Because of the time required to load this weapon, you can fire only one piece of ammunition from it when you use " +
                "an action, bonus action, or reaction to fire it, regardless of the number of attacks you can normally make."},

            {Range,
                "A weapon that can be used to make a ranged attack has a range in parentheses after the ammunition or thrown " +
                "property. The range lists two numbers. The first is the weapon's normal range in feet, and the second indicates " +
                "the weapon's long range. When attacking a target beyond normal range, you have disadvantage on the attack roll. " +
                "You can't attack a target beyond the weapon's long range."},

            {Reach,
                "This weapon adds 5 feet to your reach when you attack with it, as well as when determining your reach for " +
                "opportunity attacks with it."},

            {Special,
                "A weapon with the special property has unusual rules governing its use."},

            {Thrown,
                "If a weapon has the thrown property, you can throw the weapon to make a ranged attack. If the weapon is a melee " +
                "weapon, you use the same ability modifier for the attack roll and damage roll that you would use for a melee " +
                "attack with the weapon. For example, if you throw a handaxe, you use your Strength but if you throw a dagger, " +
                "you can use either your Strength or Dexterity, since the dagger has the finesse property."},

            {Two_Handed,
                "This weapon requires two hands when you attack with it."},

            {Versatile,
                "This weapon can be used with one or two hands. A damage value in parentheses appears with the property - the " +
                "damage when the weapon is used with two hands to make a melee attack."},

            {Improvised, ""},

            {Silvered,
                "Some monsters that have immunity or resistance to nonmagical weapons are susceptible to silver weapons, " +
                "so cautious adventurers invest extra coin to plate their weapons with silver. You can silver a single weapon " +
                "or ten pieces of ammunition for 100 gp. This cost represents not only the price of the silver, but the time " +
                "and expertise needed to add silver to the weapon without making it less effective."},

            {"Special Weapon", ""}

        };

    public const string Ammunition = "Ammunition (range {0}/{1})";
    public const string Finesse = "Finesse";
    public const string Heavy = "Heavy";
    public const string Light = "Light";
    public const string Loading = "Loading";
    public const string Range = "Range";
    public const string Reach = "Reach";
    public const string Special = "Special";
    public const string Thrown = "Thrown (range {0}/{1})";
    public const string Two_Handed = "Two-Handed";
    public const string Versatile = "Versatile {0}";
    public const string Improvised = "Improvised Weapon";
    public const string Silvered = "Silvered";

    public const string Bludgeoning = "{0} bludgeoning";
    public const string Piercing = "{0} piercing";
    public const string Slashing = "{0} slashing";

    public const string MeleeSimple = "Simple Melee Weapon";
    public const string MeleeMartial = "Martial Melee Weapon";
    public const string RangedSimple = "Simple Ranged Weapon";
    public const string RangedMartial = "Martial Ranged Weapon";
    public const string LightArmor = "Light Armor";
    public const string MediumArmor = "Medium Armor";
    public const string HeavyArmor = "Heavy Armor";
    public const string Shield = "Shield";

    public const string AdventuringGear = "Adventuring Gear";
    public const string ArcaneFocus = "Arcane Focus";
    public const string Ammo = "Ammunition";
    public const string DruidicFocus = "Druidic Focus";
    public const string HolySymbol = "Holy Symbol";
    public const string EquipmentPack = "Equipment Pack";
    public const string Tool = "Tool";

    #endregion Weapon/Armor Properties
  }
}
