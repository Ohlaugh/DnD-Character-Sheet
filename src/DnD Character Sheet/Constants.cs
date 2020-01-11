using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Sheet
{
    public class Constants
    {
        #region Weapon/Armor Properties
        /// <summary>
        /// List of all weapon properties
        /// (Property, Description)
        /// </summary>
        readonly List<Tuple<string, string>> WeaponProperties = new List<Tuple<string, string>>
        {
            new Tuple<string, string>(Ammunition,
                "You can use a weapon that has the ammunition property to make a ranged attack only if you have ammunition to " +
                "fire from the weapon. Each time you attack with the weapon, you expend one piece of ammunition. Drawing the " +
                "ammunition from a quiver, case, or other container is part of the attack (you need a free hand to load a " +
                "one-handed weapon). At the end of the battle you can recover half your expended ammunition by taking a minute " +
                "to search the battlefield. If you use a weapon that has the ammunition property to make a melee attack, you " +
                "treat the weapon as an Improvised weapon. A sling must be loaded to deal any damage when used in this way."),

            new Tuple<string, string>(Finesse,
                "When making an attack with a finesse weapon, you use your choice of your Strength or Dexterity modifier for the " +
                "attack and damage rolls. You must use the same modifier for both rolls."),

            new Tuple<string, string>(Heavy,
                "Small creatures have disadvantage on attack rolls with heavy weapons. A heavy weapon's size and bulk make it too " +
                "heavy for a Small creature to use effectively."),

            new Tuple<string, string>(Light,
                "A light weapon is small and easy to handle, making it ideal for use when fighting with two weapons."),

            new Tuple<string, string>(Loading,
                "Because of the time required to load this weapon, you can fire only one piece of ammunition from it when you use " +
                "an action, bonus action, or reaction to fire it, regardless of the number of attacks you can normally make."),

            new Tuple<string, string>(Range,
                "A weapon that can be used to make a ranged attack has a range in parentheses after the ammunition or thrown " +
                "property. The range lists two numbers. The first is the weapon's normal range in feet, and the second indicates " +
                "the weapon's long range. When attacking a target beyond normal range, you have disadvantage on the attack roll. " +
                "You can't attack a target beyond the weapon's long range."),

            new Tuple<string, string>(Reach,
                "This weapon adds 5 feet to your reach when you attack with it, as well as when determining your reach for " +
                "opportunity attacks with it."),

            new Tuple<string, string>(Special,
                "A weapon with the special property has unusual rules governing its use."),

            new Tuple<string, string>(Thrown,
                "If a weapon has the thrown property, you can throw the weapon to make a ranged attack. If the weapon is a melee " +
                "weapon, you use the same ability modifier for the attack roll and damage roll that you would use for a melee " +
                "attack with the weapon. For example, if you throw a handaxe, you use your Strength but if you throw a dagger, " +
                "you can use either your Strength or Dexterity, since the dagger has the finesse property."),

            new Tuple<string, string>(Two_Handed,
                "This weapon requires two hands when you attack with it."),

            new Tuple<string, string>(Versatile,
                "This weapon can be used with one or two hands. A damage value in parentheses appears with the property - the " +
                "damage when the weapon is used with two hands to make a melee attack."),

            new Tuple<string, string>(Improvised, ""),

            new Tuple<string, string>(Silvered,
                "Some monsters that have immunity or resistance to nonmagical weapons are susceptible to silver weapons, " +
                "so cautious adventurers invest extra coin to plate their weapons with silver. You can silver a single weapon " +
                "or ten pieces of ammunition for 100 gp. This cost represents not only the price of the silver, but the time " +
                "and expertise needed to add silver to the weapon without making it less effective."),

            new Tuple<string, string>("Special Weapon", ""),

        };

        public static readonly string Ammunition = "Ammunition (range {0}/{1})";
        public static readonly string Finesse = "Finesse";
        public static readonly string Heavy = "Heavy";
        public static readonly string Light = "Light";
        public static readonly string Loading = "Loading";
        public static readonly string Range = "Range";
        public static readonly string Reach = "Reach";
        public static readonly string Special = "Special";
        public static readonly string Thrown = "Thrown (range {0}/{1})";
        public static readonly string Two_Handed = "Two-Handed";
        public static readonly string Versatile = "Versatile {0}";
        public static readonly string Improvised = "Improvised Weapon";
        public static readonly string Silvered = "Silvered";

        public static readonly string Bludgeoning = "{0} bludgeoning";
        public static readonly string Piercing = "{0} piercing";
        public static readonly string Slashing = "{0} slashing";

        public const string MeleeSimple = "Simple Melee Weapon";
        public const string MeleeMartial = "Martial Melee Weapon";
        public const string RangedSimple = "Simple Ranged Weapon";
        public const string RangedMartial = "Martial Ranged Weapon";
        public const string LightArmor = "Light Armor";
        public const string MediumArmor = "Medium Armor";
        public const string HeavyArmor = "Heavy Armor";
        public const string Shield = "Shield";
        #endregion

        #region Config File Constants
        public static readonly string FileFilter = "DnD Character Files (*.DnD)|*.DnD";

        // Top Level
        public static readonly string Class1 = "Class1";
        public static readonly string Class2 = "Class2";
        public static readonly string SubClass1 = "SubClass1";
        public static readonly string SubClass2 = "SubClass2";
        public static readonly string Level1 = "Level1";
        public static readonly string Level2 = "Level2";
        public static readonly string Background = "Background";
        public static readonly string PlayerName = "PlayerName";
        public static readonly string Race = "Race";
        public static readonly string Subrace = "Subrace";
        public static readonly string Alignment = "Alignment";
        public static readonly string ExperiencePoints = "ExperiencePoints";
        public static readonly string Inspiration = "Inspiration";
        public static readonly string ArmorClass = "ArmorClass";
        public static readonly string Initiative = "Initiative";
        public static readonly string Speed = "Speed";
        public static readonly string HP_Max = "HP_Max";
        public static readonly string HP_Current = "HP_Current";
        public static readonly string HP_Temp = "HP_Temp";
        public static readonly string HitDice1 = "HitDice1";
        public static readonly string HitDice2 = "HitDice2";
        public static readonly string HitDiceTotal1 = "HitDiceTotal1";
        public static readonly string HitDiceTotal2 = "HitDiceTotal2";

        // Attributes
        public const string Strength = "Strength";
        public const string Dexterity = "Dexterity";
        public const string Constitution = "Constitution";
        public const string Intelligence = "Intelligence";
        public const string Wisdom = "Wisdom";
        public const string Charisma = "Charisma";

        // Skills
        public const string Acrobatics = "Acrobatics";
        public const string AnimalHandling = "AnimalHandling";
        public const string AnimalHandling_Spaced = "Animal Handling";
        public const string Arcana = "Arcana";
        public const string Athletics = "Athletics";
        public const string Deception = "Deception";
        public const string History = "History";
        public const string Insight = "Insight";
        public const string Intimidation = "Intimidation";
        public const string Investigation = "Investigation";
        public const string Medicine = "Medicine";
        public const string Nature = "Nature";
        public const string Perception = "Perception";
        public const string Performance = "Performance";
        public const string Persuassion = "Persuassion";
        public const string Religion = "Religion";
        public const string SlightOfHand = "SlightOfHand";
        public const string SlightOfHand_Spaced = "Slight of Hand";
        public const string Stealth = "Stealth";
        public const string Survival = "Survival";

        // Saving Throws
        public static readonly string StrengthSave = "StrengthSave";
        public static readonly string DexteritySave = "DexteritySave";
        public static readonly string ConstitutionSave = "ConstitutionSave";
        public static readonly string IntelligenceSave = "IntelligenceSave";
        public static readonly string WisdomSave = "WisdomSave";
        public static readonly string CharismaSave = "CharismaSave";

        // Money
        public const string Copper = "Copper";
        public const string Silver = "Silver";
        public const string Electrum = "Electrum";
        public const string Gold = "Gold";
        public const string Platinum = "Platinum";

        // Backstory
        public static readonly string Age = "Age";
        public static readonly string Height = "Height";
        public static readonly string Weight = "Weight";
        public static readonly string EyeColor = "EyeColor";
        public static readonly string SkinColor = "SkinColor";
        public static readonly string HairColor = "HairColor";
        public static readonly string PersonalityTraits = "PersonalityTraits";
        public static readonly string Ideals = "Ideals";
        public static readonly string Bonds = "Bonds";
        public static readonly string Flaws = "Flaws";
        public static readonly string Backstory = "Backstory";

        // Weapons and Items
        public static readonly string CharacterSheet = "CharacterSheet";
        public static readonly string Data = "Data";
        public static readonly string Key = "Key";
        public static readonly string Value = "Value";
        public static readonly string Proficient = "Proficient";
        public static readonly string Items = "Items";
        public static readonly string Item = "Item";
        public static readonly string Name = "Name";
        public static readonly string Cost = "Cost";
        public static readonly string Description = "Description";
        public static readonly string Weapon = "Weapon";
        public static readonly string Properties = "Properties";
        public static readonly string Property = "Property";
        public static readonly string Damage = "Damage";
        public static readonly string Style = "Style";
        public static readonly string Equipped = "Equipped";
        public static readonly string Armor = "Armor";
        public static readonly string StrengthReq = "StrengthReq";
        public static readonly string Disadvantage = "Disadvantage";
        public static readonly string Book = "Book";
        public static readonly string BackgroundInfo = "BackgroundInfo";
        public static readonly string Quantity = "Quantity";
        public static readonly string AdventuringGear = "Adventuring Gear";
        public static readonly string ArcaneFocus = "Arcane Focus";
        public static readonly string Ammo = "Ammunition";
        public static readonly string DruidicFocus = "Druidic Focus";
        public static readonly string HolySymbol = "Holy Symbol";
        public static readonly string EquipmentPack = "Equipment Pack";
        public static readonly string Tool = "Tool";

        // Books
        public static readonly string Using_PlayerHB = "PlayerHandbook";
        public static readonly string Using_Xanathar = "XanatharsGuide";

        #endregion

        #region UI Elements

        // Format Strings
        public static readonly string ArmorProperties = "Strength Required: {0}" + Environment.NewLine + "Stealth Disadvantage: {1}";

        // Check Lists
        public static readonly string Skills_CheckList = "Skills_CheckList";
        public static readonly string Saves_CheckList = "Saves_CheckList";

        // Buttons
        public const string Load_Button = "Load_Button";
        public const string Save_Button = "Save_Button";
        public const string button1 = "button1";
        public const string EquipBuy_Button = "EquipBuy_Button";
        public const string EquipSell_Button = "EquipSell_Button";
        public const string CurrencyExchange_Button = "CurrencyExchange_Button";
        public const string ItemBuy_Button = "ItemBuy_Button";
        public const string ItemSell_Button = "ItemSell_Button";

        // Numeric Spins
        public const string XP_Spin = "XP_Spin";
        public const string HitDiceRemain_Spin = "HitDiceRemain_Spin";
        public const string Initiative_Spin = "Initiative_Spin";
        public const string HPCurrent_Spin = "HPCurrent_Spin";
        public const string HPTemp_Spin = "HPTemp_Spin";
        public const string CP_Spin = "CP_Spin";
        public const string SP_Spin = "SP_Spin";
        public const string EP_Spin = "EP_Spin";
        public const string GP_Spin = "GP_Spin";
        public const string PP_Spin = "PP_Spin";
        public const string Str_Spin = "Str_Spin";
        public const string Dex_Spin = "Dex_Spin";
        public const string Con_Spin = "Con_Spin";
        public const string Int_Spin = "Int_Spin";
        public const string Wis_Spin = "Wis_Spin";
        public const string Cha_Spin = "Cha_Spin";

        // Grids
        public const string Equipment_Grid = "Equipment_Grid";
        public const string Item_Grid = "Item_Grid";

        // Buy/Sell Grid Column Names
        public static readonly string ItemName_Grid = "ItemName";
        public static readonly string Quantity_Grid = "Quantity";
        public static readonly string Type_Grid = "Type";
        public static readonly string Cost_Grid = "Cost";
        public static readonly string Armorclass_Grid = "Armorclass";
        public static readonly string Damage_Grid = "Damage";
        public static readonly string Weight_Grid = "Weight";
        public static readonly string Properties_Grid = "Properties";

        #endregion
    }
}
