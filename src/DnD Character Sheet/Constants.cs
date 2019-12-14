using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Sheet
{
    class Constants
    {
        #region Weapon/Armor Properties
        /// <summary>
        /// List of all weapon properties
        /// (Property, Description)
        /// </summary>
        List<Tuple<string, string>> WeaponProperties = new List<Tuple<string, string>>
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

        public static readonly string MeleeSimple = "Simple Melee Weapon";
        public static readonly string MeleeMartial = "Martial Melee Weapon";
        public static readonly string RangedSimple = "Simple Ranged Weapon";
        public static readonly string RangedMartial = "Martial Ranged Weapon";
        public static readonly string LightArmor = "Light Armor";
        public static readonly string MediumArmor = "Medium Armor";
        public static readonly string HeavyArmor = "Heavy Armor";
        public static readonly string Shield = "Shield";
        #endregion

        #region Config File Constants
        // Top Level
        public static readonly string Class = "Class";
        public static readonly string Background = "Background";
        public static readonly string PlayerName = "PlayerName";
        public static readonly string Race = "Race";
        public static readonly string Subrace = "Subrace";
        public static readonly string Alignment = "Alignment";
        public static readonly string ExperiencePoints = "ExperiencePoints";
        public static readonly string Age = "Age";
        public static readonly string Height = "Height";
        public static readonly string Weight = "Weight";
        public static readonly string EyeColor = "EyeColor";
        public static readonly string SkinColor = "SkinColor";
        public static readonly string HairColor = "HairColor";

        // Left Column
        public static readonly string Inspiration = "Inspiration";

        // Attributes
        public static readonly string Strength = "Strength";
        public static readonly string Dexterity = "Dexterity";
        public static readonly string Constitution = "Constitution";
        public static readonly string Intelligence = "Intelligence";
        public static readonly string Wisdom = "Wisdom";
        public static readonly string Charisma = "Charisma";

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


        // Middle Column
        public static readonly string ArmorClass = "ArmorClass";
        public static readonly string Initiative = "Initiative";
        public static readonly string Speed = "Speed";
        public static readonly string HP_Max = "HP_Max";
        public static readonly string HP_Current = "HP_Current";
        public static readonly string HP_Temp = "HP_Temp";
        public static readonly string HitDice = "HitDice";
        public static readonly string HitDiceTotal = "HitDiceTotal";
        public static readonly string Copper = "Copper";
        public static readonly string Silver = "Silver";
        public static readonly string Electrum = "Electrum";
        public static readonly string Gold = "Gold";
        public static readonly string Platinum = "Platinum";


        // Right Column
        public static readonly string PersonalityTraits = "PersonalityTraits";
        public static readonly string Ideals = "Ideals";
        public static readonly string Bonds = "Bonds";
        public static readonly string Flaws = "Flaws";
        /*
        public static readonly string PLACEHOLDER = "";
        public static readonly string PLACEHOLDER = "";
        */
        public static readonly string Using_PHB = "UsingPlayerHandbook";
        #endregion

        public class Item
        {
            public string Name;
            public string Weight;
            public Money Cost;
            public string Type; // Weapon / armor
        }

        public class Weapon
        {
            public string Style;
            public string Cost;
            public string Damage;
            public double Weight;
            public List<string> Properties;
        }

        public class Armor
        {
            public string Style;
            public string Cost;
            public string ArmorClass;
            public int StrengthReq;
            public bool Disadvantage;
            public int Weight;
        }
    }
}
