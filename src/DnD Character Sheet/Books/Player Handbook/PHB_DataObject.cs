using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Character_Sheet;
using LC = DnD_Character_Sheet.Constants;
using PHBC = DnD_Character_Sheet.Books.Player_Handbook.PHB_Constants;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;
using LIB = DnD_Character_Sheet.Library;

namespace DnD_Character_Sheet.Books.Player_Handbook
{
    class PHB_DataObject
    {
        /// <summary>
        /// This method adds all Player Handbook information to the master Libraries
        /// </summary>
        public static void AddData()
        {
            AddRaces();
            AddClasses();
            AddArmor();
            AddWeapons();
            AddItems();
        }

        /// <summary>
        /// Adds all Player Handbook Races to the Master Race Library
        /// </summary>
        private static void AddRaces()
        {
            foreach (string race in PHBC.Races)
            {
                LIB.m_RaceLibrary.Add(race, new List<string>());
                List<string> subraces = new List<string>();
                foreach (string subrace in PHBC.Subraces)
                {
                    if (subrace.Split(':')[0] == race)
                    {
                        subraces.Add(subrace.Split(':')[1]);
                    }
                }
                LIB.m_RaceLibrary[race] = subraces;
            }
        }

        private static void AddClasses()
        {

        }

        /// <summary>
        /// Adds all Player Handbook Pieces of Armor to the Master Armor Library
        /// </summary>
        private static void AddArmor()
        {
            #region Light Armor
            LIB.m_ArmorLibrary.Add("Padded",
                new CLIB.Armor
                {
                    Style = LC.LightArmor,
                    Cost = "5 gp",
                    ArmorClass = "11 + Dex",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 8,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Leather",
                new CLIB.Armor
                {
                    Style = LC.LightArmor,
                    Cost = "10 gp",
                    ArmorClass = "11 + Dex",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 10,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Studded Leather",
                new CLIB.Armor
                {
                    Style = LC.LightArmor,
                    Cost = "45 gp",
                    ArmorClass = "12 + Dex",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 13,
                    Quantity = 1
                });
            #endregion

            #region Medium Armor
            LIB.m_ArmorLibrary.Add("Hide",
                new CLIB.Armor
                {
                    Style = LC.MediumArmor,
                    Cost = "10 gp",
                    ArmorClass = "12 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 12,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Chain Shirt",
                new CLIB.Armor
                {
                    Style = LC.MediumArmor,
                    Cost = "50 gp",
                    ArmorClass = "13 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 20,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Scale Mail",
                new CLIB.Armor
                {
                    Style = LC.MediumArmor,
                    Cost = "50 gp",
                    ArmorClass = "14 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 45,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Breastplate",
                new CLIB.Armor
                {
                    Style = LC.MediumArmor,
                    Cost = "400 gp",
                    ArmorClass = "14 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 20,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Half Plate",
                new CLIB.Armor
                {
                    Style = LC.MediumArmor,
                    Cost = "750 gp",
                    ArmorClass = "15 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 40,
                    Quantity = 1
                });
            #endregion

            #region Heavy Armor
            LIB.m_ArmorLibrary.Add("Ring Mail",
                new CLIB.Armor
                {
                    Style = LC.HeavyArmor,
                    Cost = "30 gp",
                    ArmorClass = "14",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 40,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Chain Mail",
                new CLIB.Armor
                {
                    Style = LC.HeavyArmor,
                    Cost = "75 gp",
                    ArmorClass = "16",
                    StrengthReq = 13,
                    Disadvantage = true,
                    Weight = 55,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Splint",
                new CLIB.Armor
                {
                    Style = LC.HeavyArmor,
                    Cost = "200 gp",
                    ArmorClass = "17",
                    StrengthReq = 15,
                    Disadvantage = true,
                    Weight = 60,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Plate",
                new CLIB.Armor
                {
                    Style = LC.HeavyArmor,
                    Cost = "1500 gp",
                    ArmorClass = "18",
                    StrengthReq = 15,
                    Disadvantage = true,
                    Weight = 65,
                    Quantity = 1
                });

            LIB.m_ArmorLibrary.Add("Shield",
                new CLIB.Armor
                {
                    Style = LC.Shield,
                    Cost = "10 gp",
                    ArmorClass = "+2",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 6,
                    Quantity = 1
                });
            #endregion
        }

        /// <summary>
        /// Adds all Player Handbook Weapons to the Master Weapon Library
        /// </summary>
        private static void AddWeapons()
        {
            #region Melee Weapons
            LIB.m_WeaponLibrary.Add("Club",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "1 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Dagger",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 gp",
                    Damage = string.Format(LC.Piercing, "1d4"),
                    Weight = 1,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Light,
                        string.Format(LC.Thrown,20,60)
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Greatclub",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d8"),
                    Weight = 10,
                    Properties = new List<string>
                    {
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Handaxe",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Slashing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light,
                        string.Format(LC.Thrown,20,60)
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Light hammer",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light,
                        string.Format(LC.Thrown,20,60)
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Mace",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d6"),
                    Weight = 4,
                    Properties = new List<string>(),
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Quarterstaff",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d6"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d8")
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Sickle",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "1 gp",
                    Damage = string.Format(LC.Slashing, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Spear",
                new CLIB.Weapon
                {
                    Style = LC.MeleeSimple,
                    Cost = "1 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(LC.Thrown,20,60),
                        string.Format(LC.Versatile, "1d8")
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Battleaxe",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Slashing, "1d8"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d10")
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Flail",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d8"),
                    Weight = 2,
                    Properties = new List<string>(),
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Glaive",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "20 gp",
                    Damage = string.Format(LC.Slashing, "1d10"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Reach,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Greataxe",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "30 gp",
                    Damage = string.Format(LC.Slashing, "1d12"),
                    Weight = 7,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Greatsword",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "50 gp",
                    Damage = string.Format(LC.Slashing, "2d6"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Halberd",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "20 gp",
                    Damage = string.Format(LC.Slashing, "1d10"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Reach,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Lance",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Piercing, "1d12"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        LC.Reach,
                        LC.Special
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Longsword",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(LC.Slashing, "1d8"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d10")
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Maul",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Bludgeoning, "2d6"),
                    Weight = 10,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Morningstar",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 4,
                    Properties = new List<string>(),
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Pike",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Piercing, "1d10"),
                    Weight = 18,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Reach,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Rapier",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "25 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Finesse
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Scimitar",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "25 gp",
                    Damage = string.Format(LC.Slashing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Light
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Shortsword",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Light
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Trident",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(LC.Thrown,20,60),
                        string.Format(LC.Versatile, "1d18")
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("War Pick",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>(),
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Warhammer",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d10")
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Whip",
                new CLIB.Weapon
                {
                    Style = LC.MeleeMartial,
                    Cost = "2 gp",
                    Damage = string.Format(LC.Slashing, "1d4"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Reach
                    },
                    Quantity = 1
                });
            #endregion

            #region Ranged Weapons
            LIB.m_WeaponLibrary.Add("Crossbow, Light",
                new CLIB.Weapon
                {
                    Style = LC.RangedSimple,
                    Cost = "25 sp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 5,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,80,320),
                        LC.Loading,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Dart",
                new CLIB.Weapon
                {
                    Style = LC.RangedSimple,
                    Cost = "5 cp",
                    Damage = string.Format(LC.Piercing, "1d4"),
                    Weight = .25,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        string.Format(LC.Thrown,20,60)
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Shortbow",
                new CLIB.Weapon
                {
                    Style = LC.RangedSimple,
                    Cost = "25 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,80,320),
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Sling",
                new CLIB.Weapon
                {
                    Style = LC.RangedSimple,
                    Cost = "1 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d4"),
                    Weight = 0,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,30,120)
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Blowgun",
                new CLIB.Weapon
                {
                    Style = LC.RangedMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Piercing, "1"),
                    Weight = 1,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,25,100),
                        LC.Loading
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Crossbow, hand",
                new CLIB.Weapon
                {
                    Style = LC.RangedMartial,
                    Cost = "75 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,30,120),
                        LC.Light,
                        LC.Loading
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Crossbow, Heavy",
                new CLIB.Weapon
                {
                    Style = LC.RangedMartial,
                    Cost = "50 gp",
                    Damage = string.Format(LC.Piercing, "1d10"),
                    Weight = 18,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,100,400),
                        LC.Heavy,
                        LC.Loading,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Longbow",
                new CLIB.Weapon
                {
                    Style = LC.RangedMartial,
                    Cost = "50 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,100,400),
                        LC.Heavy,
                        LC.Two_Handed
                    },
                    Quantity = 1
                });

            LIB.m_WeaponLibrary.Add("Net",
                new CLIB.Weapon
                {
                    Style = LC.RangedMartial,
                    Cost = "1 gp",
                    Damage = "0",
                    Weight = 3,
                    Properties = new List<string>
                    {
                        LC.Special,
                        string.Format(LC.Thrown,5,15)
                    },
                    Quantity = 1
                });
            #endregion
        }

        /// <summary>
        /// Adds all Player Handbook Normal Items to the Master Item Library
        /// </summary>
        private static void AddItems()
        {
            #region A Items

            LIB.m_ItemLibrary.Add("Acid (vial)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "25 gp",
                    Weight = 1,
                    Description = "As an action, you can splash the contents of this vial onto a creature within " +
                    "5 feet of you or throw the vial up to 20 feet, shattering it on impact. In either case, make " +
                    "a ranged attack against a creature or object, treating the acid as an improvised weapon. On a " +
                    "hit, the target rakes 2d6 acid damage.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Alchemist's Fire (flask)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "50 gp",
                    Weight = 1,
                    Description = "This sticky, adhesive fluid ignites when exposed to air. As an action, you can " +
                    "throw this flask up to 20 feet, shattering it on impact. Make a ranged attack against a creature " +
                    "or object, treating the alchemist's fire as an improvised weapon. On a hit, the target takes 1d4 " +
                    "fire damage at the start of each of its turns. A creature can end this damage by using its action " +
                    "to make a DC 10 Dexterity check to extinguish the flames.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Alms Box",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A small box for alms, typically found in a priest's pack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Amulet",
                new CLIB.Item
                {
                    Style = LC.HolySymbol,
                    Cost = "5 gp",
                    Weight = 1,
                    Description = "A holy symbol is a representation of a god or pantheon. A cleric or paladin can " +
                    "use a holy symbol as a spellcasting focus, as described in the Spellcasting section. To use the " +
                    "symbol in this way, the caster must hold it in hand, wear it visibly, or bear it on a shield.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Antitoxin",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "50 gp",
                    Weight = 0,
                    Description = "A creature that drinks this vial of liquid gains advantage on saving throws against " +
                    "poison for 1 hour. It confers no benefit to undead or constructs.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Arrows",
                new CLIB.Item
                {
                    Style = LC.Ammo,
                    Cost = "1 gp",
                    Weight = 1,
                    Description = "Arrows are used with a weapon that has the ammunition property to make a ranged attack. " +
                    "Each time you attack with the weapon, you expend one piece of ammunition. Drawing the ammunition from " +
                    "a quiver, case, or other container is part of the attack (you need a free hand to load a one-handed " +
                    "weapon). At the end of the battle, you can recover half your expended ammunition by taking a minute " +
                    "to search the battlefield.",
                    Quantity = 20
                });

            #endregion

            #region B Items

            LIB.m_ItemLibrary.Add("Backpack",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 5,
                    Description = "A backpack is a leather pack carried on the back, typically with straps to secure it. " +
                    "A backpack can hold 1 cubic foot/ 30 pounds of gear. You can also strap items, such as a bedroll or " +
                    "a coil of rope, to the outside of a backpack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Ball Bearings (bag of 1,000)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 2,
                    Description = "As an action, you can spill these tiny metal balls from their pouch to cover a level, " +
                    "square area that is 10 feet on a side. A creature moving across the covered area must succeed on a " +
                    "DC 10 Dexterity saving throw or fall prone. A creature moving through the area at half speed doesn't " +
                    "need to make the save.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Barrel",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 70,
                    Description = "A barrel can hold 40 gallons of liquid, or 4 cubic feet of solid material.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Basket",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "4 sp",
                    Weight = 2,
                    Description = "A basket can hold 2 cubic feet/40 pounds of gear.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Bedroll",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 7,
                    Description = "You never know where you’re going to sleep, and a bedroll helps you get better sleep in " +
                    "a hayloft or on the cold ground. A bedroll consists of bedding and a blanket thin enough to be rolled " +
                    "up and tied. In an emergency, it can double as a stretcher.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Bell",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 0,
                    Description = "A standard bell that rings, typically used for signaling.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Blanket",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 3,
                    Description = "A thick, quilted, blanket made to keep you warm in cold weather.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Block and Tackle",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 5,
                    Description = "A set of pulleys with a cable threaded through them and a hook to attach to objects, " +
                    "a block and tackle allows you to hoist up to four times the weight you can normally lift.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Blowgun needles",
                new CLIB.Item
                {
                    Style = LC.Ammo,
                    Cost = "1 gp",
                    Weight = 1,
                    Description = "Blowgun needles are used with a weapon that has the ammunition property to make a ranged " +
                    "attack. Each time you attack with the weapon, you expend one piece of ammunition. Drawing the ammunition " +
                    "from a quiver, case, or other container is part of the attack (you need a free hand to load a one-handed " +
                    "weapon). At the end of the battle, you can recover half your expended ammunition by taking a minute to " +
                    "search the battlefield.",
                    Quantity = 50
                });

            LIB.m_ItemLibrary.Add("Book",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "25 gp",
                    Weight = 5,
                    Description = "A book might contain poetry, historical accounts, information pertaining to a particular " +
                    "field of lore, diagrams and notes on gnomish contraptions, or just about anything else that can be " +
                    "represented using text or pictures. A book of spells is a spellbook.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Book of Lore",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A book of lore, typically found in a scholar's pack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Bottle, Glass",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 2,
                    Description = "A bottle can hold 1 1/2 pints of liquid.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Bucket",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 cp",
                    Weight = 2,
                    Description = "A bucket can hold 3 gallons of liquid, or 1/2 cubic foot of solid material.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Burglar's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "16 gp",
                    Weight = 47.5,
                    Description = "Includes a backpack, a bag of 1,000 ball bearings, 10 feet of string, a bell, 5 candles, " +
                    "a crowbar, a hammer, 10 pitons, a hooded lantern, 2 flasks of oil, 5 days rations, a tinderbox, and a " +
                    "waterskin. The pack also has 50 feet of hempen rope strapped to the side of it.",
                    Quantity = 1
                });

            #endregion

            #region C Items

            LIB.m_ItemLibrary.Add("Caltrops (bag of 20)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 2,
                    Description = "As an action, you can spread a bag of caltrops to cover a square area that is 5 feet on a side. " +
                    "Any creature that enters the area must succeed on a DC 15 Dexterity saving throw or stop moving this turn and " +
                    "take 1 piercing damage. Taking this damage reduces the creature's walking speed by 10 feet until the creature " +
                    "regains at least 1 hit point. A creature moving through the area at half speed doesn't need to make the save.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Candle",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 cp",
                    Weight = 0,
                    Description = "For 1 hour, a candle sheds bright light in a 5-foot radius and dim light for an additional 5 feet.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Case, Crossbow Bolt",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 1,
                    Description = "This wooden case can hold up to twenty crossbow bolts.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Case, Map or Scroll",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 1,
                    Description = "This cylindrical leather case can hold up to ten rolled-up sheets of paper or " +
                    "five rolled-up sheets of parchment.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Censer)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A censer, typically found in a priest's pack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Chain (10 feet)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 10,
                    Description = "A chain has 10 hit points. It can be burst with a successful DC 20 Strength check.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Chalk (1 piece)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 cp",
                    Weight = 0,
                    Description = "A piece of chalk used for writing and marking on various surfaces.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Chest",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 25,
                    Description = "A chest can hold 12 cubic feet/ 300 pounds of gear.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Climber's Kit",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "25 gp",
                    Weight = 12,
                    Description = "A climber's kit includes special pitons, boot tips, gloves, and a harness. You can use " +
                    "the climber's kit as an action to anchor yourself; when you do, you can't fall more than 25 feet from " +
                    "the point where you anchored yourself, and you can't climb more than 25 feet away from that point " +
                    "without undoing the anchor.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Clothes, Common",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 3,
                    Description = "This set of clothes could consist of a loose shirt and baggy breeches, or a loose shirt " +
                    "and skirt or overdress. Cloth wrappings are used for shoes.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Clothes, Costume",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 4,
                    Description = "This set of clothes is fashioned after a particular costume, typically meant for entertaining.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Clothes, Fine",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "15 gp",
                    Weight = 6,
                    Description = "This set of clothes is designed specifically to be expensive and to show it, including fancy, " +
                    "tailored clothes in whatever fashion happens to be the current style in the courts of the nobles. Precious " +
                    "metals and gems could be worked into the clothing.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Clothes, Traveler's",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 4,
                    Description = "This set of clothes could consist of boots, a wool skirt or breeches, a sturdy belt, a shirt " +
                    "(perhaps with a vest or jacket), and an ample cloak with a hood.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Component Pouch",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "25 gp",
                    Weight = 2,
                    Description = "A component pouch is a small, watertight leather belt pouch that has compartments to hold " +
                    "all the material components and other special items you need to cast your spells, except for those " +
                    "components that have a specific cost (as indicated in a spell's description).",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Crossbow bolts",
                new CLIB.Item
                {
                    Style = LC.Ammo,
                    Cost = "1 gp",
                    Weight = 1.5,
                    Description = "Crossbow bolts are used with a weapon that has the ammunition property to make a ranged " +
                    "attack. Each time you attack with the weapon, you expend one piece of ammunition. Drawing the ammunition " +
                    "from a quiver, case, or other container is part of the attack (you need a free hand to load a one-handed " +
                    "weapon). At the end of the battle, you can recover half your expended ammunition by taking a minute to " +
                    "search the battlefield.",
                    Quantity = 20
                });

            LIB.m_ItemLibrary.Add("Crowbar",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 5,
                    Description = "Using a crowbar grants advantage to Strength checks where the crowbar's leverage can be applied.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Crystal",
                new CLIB.Item
                {
                    Style = LC.ArcaneFocus,
                    Cost = "10 gp",
                    Weight = 1,
                    Description = "An arcane focus is a special item designed to channel the power of arcane spells. A sorcerer, " +
                    "warlock, or wizard can use such an item as a spellcasting focus.",
                    Quantity = 1
                });

            #endregion

            #region D Items

            LIB.m_ItemLibrary.Add("Disguise Kit",
                new CLIB.Item
                {
                    Style = LC.Tool,
                    Cost = "25 gp",
                    Weight = 3,
                    Description = "This pouch of cosmetics, hair dye, and small props lets you create disguises that change " +
                    "your physical appearance. Proficiency with this kit lets you add your proficiency bonus to any ability " +
                    "checks you make to create a visual disguise.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Diplomat's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "39 gp",
                    Weight = 36,
                    Description = "Includes a chest, 2 cases for maps and scrolls, a set of fine clothes, a bottle of ink, " +
                    "an ink pen, a lamp, 2 flasks of oil, 5 sheets of paper, a vial of perfume, sealing wax, and soap.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Dungeoneer's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "12 gp",
                    Weight = 61.5,
                    Description = "Includes a backpack, a crowbar, a hammer, 10 pitons, 10 torches, a tinderbox, 10 days " +
                    "of rations, and a waterskin. The pack also has 50 feet of hempen rope strapped to the side of it.",
                    Quantity = 1
                });

            #endregion

            #region E Items

            LIB.m_ItemLibrary.Add("Emblem",
                new CLIB.Item
                {
                    Style = LC.HolySymbol,
                    Cost = "5 gp",
                    Weight = 0,
                    Description = "A holy symbol is a representation of a god or pantheon. A cleric or paladin can use a holy " +
                    "symbol as a spellcasting focus, as described in the Spellcasting section. To use the symbol in this way, " +
                    "the caster must hold it in hand, wear it visibly, or bear it on a shield.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Entertainer's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "40 gp",
                    Weight = 38,
                    Description = "Includes a backpack, a bedroll, 2 costumes, 5 candles, 5 days of rations, a waterskin, " +
                    "and a disguise kit.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Explorer's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "10 gp",
                    Weight = 59,
                    Description = "Includes a backpack, a bedroll, a mess kit, a tinderbox, 10 torches, 10 days of rations, " +
                    "and a waterskin. The pack also has 50 feet of hempen rope strapped to the side of it.",
                    Quantity = 1
                });

            #endregion

            #region F Items

            LIB.m_ItemLibrary.Add("Fishing Tackle",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 4,
                    Description = "This kit includes a wooden rod, silken line, corkwood bobbers, steel hooks, lead " +
                    "sinkers, velvet lures, and narrow netting.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Flask or Tankard",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 cp",
                    Weight = 1,
                    Description = "A flask or tankard can hold 1 pint of liquid.",
                    Quantity = 1
                });

            #endregion

            #region G Items

            LIB.m_ItemLibrary.Add("Grappling Hook",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 4,
                    Description = "When tied to the end of a rope, a grappling hook can secure the rope to a battlement, " +
                    "window ledge, tree limb, or other protrusion.",
                    Quantity = 1
                });

            #endregion

            #region H Items

            LIB.m_ItemLibrary.Add("Hammer",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 3,
                    Description = "This one-handed hammer with an iron head is useful for pounding pitons into a wall.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Hammer, Sledge",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 10,
                    Description = "This two-handed, iron-headed hammer is good for smashing open treasure chests.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Healer's Kit",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 3,
                    Description = "This kit is a leather pouch containing bandages, salves, and splints. The kit has ten uses. " +
                    "As an action, you can expend one use of the kit to stabilize a creature that has 0 hit points, without " +
                    "needing to make a Wisdom (Medicine) check.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Holy Water (Flask)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "25 gp",
                    Weight = 1,
                    Description = "As an action, you can splash the contents of this flask onto a creature within 5 feet of " +
                    "you or throw it up to 20 feet, shattering it on impact. In either case, make a ranged attack against a " +
                    "target creature, treating the holy water as an improvised weapon. If the target is a fiend or undead, " +
                    "it takes 2d6 radiant damage. A cleric or paladin may create holy water by performing a special ritual. " +
                    "The ritual takes 1 hour to perform, uses 25 gp worth of powdered silver, and requires the caster to " +
                    "expend a 1st - level spell slot.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Hourglass",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "25 gp",
                    Weight = 1,
                    Description = "A standard hourglass used to measure the passage of time.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Hunting Trap",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 25,
                    Description = "When you use your action to set it, this trap forms a saw-toothed steel ring that " +
                    "snaps shut when a creature steps on a pressure plate in the center. The trap is affixed by a " +
                    "heavy chain to an immobile object, such as a tree or a spike driven into the ground. A creature " +
                    "that steps on the plate must succeed on a DC 13 Dexterity saving throw or take 1d4 piercing damage " +
                    "and stop moving. Thereafter, until the creature breaks free of the trap, its movement is limited by " +
                    "the length of the chain (typically 3 feet long). A creature can use its action to make a DC 13 " +
                    "Strength check, freeing itself or another creature within its reach on a success. Each failed check " +
                    "deals 1 piercing damage to the trapped creature.",
                    Quantity = 1
                });

            #endregion

            #region I Items

            LIB.m_ItemLibrary.Add("Ink (1 ounce bottle)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "10 gp",
                    Weight = 0,
                    Description = "Ink is typically used with an ink pen to write.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Ink Pen",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 cp",
                    Weight = 0,
                    Description = "An ink pen is a wooden stick with a special tip on the end. The tip draws ink in when " +
                    "dipped in a vial and leaves an ink trail when drawn across a surface.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Block of Incense",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A block of incense, typically found in a priest's pack.",
                    Quantity = 1
                });

            #endregion

            #region J Items

            LIB.m_ItemLibrary.Add("Jug or Pitcher",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 cp",
                    Weight = 4,
                    Description = "A jug or pitcher can hold 1 gallon of liquid.",
                    Quantity = 1
                });

            #endregion

            #region L Items

            LIB.m_ItemLibrary.Add("Ladder (10 foot)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 sp",
                    Weight = 25,
                    Description = "This item is a straight, simple wooden ladder.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Lamp",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 1,
                    Description = "A lamp casts bright light in a 15-foot radius and dim light for an additional 30 feet. " +
                    "Once lit, it burns for 6 hours on a flask (1 pint) of oil.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Lantern, Bullseye",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "10 gp",
                    Weight = 2,
                    Description = "A bullseye lantern casts bright light in a 60-foot cone and dim light for an additional " +
                    "60 feet. Once lit, it burns for 6 hours on a flask (1 pint) of oil.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Lantern, Hooded",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 2,
                    Description = "A hooded lantern casts bright light in a 30-foot radius and dim light for an additional " +
                    "30 feet. Once lit, it burns for 6 hours on a flask (1 pint) of oil. As an action, you can lower the " +
                    "hood, reducing the light to dim light in a 5-foot radius.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Little Bag of Sand",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A small bag of sand, typically found in a scholar's pack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Lock",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "10 gp",
                    Weight = 1,
                    Description = "A key is provided with the lock. Without the key, a creature proficient with thieves' " +
                    "tools can pick this lock with a successful DC 15 Dexterity check. Your DM may decide that better " +
                    "locks are available for higher prices.",
                    Quantity = 1
                });

            #endregion

            #region M Items

            LIB.m_ItemLibrary.Add("Magnifying Glass",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "100 gp",
                    Weight = 0,
                    Description = "This lens allows a closer look at small objects. It is also useful as a substitute for " +
                    "flint and steel when starting fires. Lighting a fire with a magnifying glass requires light as bright " +
                    "as sunlight to focus, tinder to ignite, and about 5 minutes for the fire to ignite. A magnifying glass " +
                    "grants advantage on any ability check made to appraise or inspect an item that is small or highly detailed.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Manacles",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 6,
                    Description = "These metal restraints can bind a Small or Medium creature. Escaping the manacles requires " +
                    "a successful DC 20 Dexterity check. Breaking them requires a successful DC 20 Strength check. Each set of " +
                    "manacles comes with one key. Without the key, a creature proficient with thieves' tools can pick the " +
                    "manacles' lock with a successful DC 15 Dexterity check. Manacles have 15 hit points.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Mess Kit",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 sp",
                    Weight = 1,
                    Description = "This tin box contains a cup and simple cutlery. The box clamps together, and one side " +
                    "can be used as a cooking pan and the other as a plate or shallow bowl.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Mirror, Steel",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 0.5,
                    Description = "A steel mirror is handy when you want to look around corners, signal friends with " +
                    "reflected sunlight, keep an eye on a medusa, make sure that you look good enough to present yourself " +
                    "to the queen, or examine wounds that you’ve received on hard-to-see parts of your body.",
                    Quantity = 1
                });

            #endregion

            #region O Items

            LIB.m_ItemLibrary.Add("Oil (flask)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 sp",
                    Weight = 1,
                    Description = "Oil usually comes in a clay flask that holds 1 pint. As an action, you can splash the oil " +
                    "in this flask onto a creature within 5 feet of you or throw it up to 20 feet, shattering it on impact. " +
                    "Make a ranged attack against a target creature or object, treating the oil as an improvised weapon. On " +
                    "a hit, the target is covered in oil. If the target takes any fire damage before the oil dries (after 1 " +
                    "minute), the target takes an additional 5 fire damage from the burning oil. You can also pour a flask " +
                    "of oil on the ground to cover a 5-foot-square area, provided that the surface is level. If lit, the oil " +
                    "burns for 2 rounds and deals 5 fire damage to any creature that enters the area or ends its turn in the " +
                    "area. A creature can take this damage only once per turn.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Orb",
                new CLIB.Item
                {
                    Style = LC.ArcaneFocus,
                    Cost = "20 gp",
                    Weight = 3,
                    Description = "An arcane focus is a special item designed to channel the power of arcane spells. A sorcerer, " +
                    "warlock, or wizard can use such an item as a spellcasting focus.",
                    Quantity = 1
                });

            #endregion

            #region P Items

            LIB.m_ItemLibrary.Add("Paper (one sheet)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 sp",
                    Weight = 0,
                    Description = "A sheet of standard paper is made from cloth fibers.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Parchment (one sheet)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 sp",
                    Weight = 0,
                    Description = "A sheet of parchment is a piece of goat hide or sheepskin that has been prepared for writing on.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Perfume (vial)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 0,
                    Description = "A fragrant commodity typically used by the wealthy.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Pick, miner's",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 10,
                    Description = "A miner's pick is designed to concentrate the force of its blow on a small area.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Piton",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 cp",
                    Weight = 0.25,
                    Description = "When a wall doesn’t offer handholds and footholds, you can make your own. A piton is a " +
                    "steel spike with an eye through which you can loop a rope.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Poison, basic (vial)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "100 gp",
                    Weight = 0,
                    Description = "You can use the poison in this vial to coat one slashing or piercing weapon or up to " +
                    "three pieces of ammunition. Applying the poison takes an action. A creature hit by the poisoned " +
                    "weapon or ammunition must make a DC 10 Constitution saving throw or take 1d4 poison damage. Once " +
                    "applied, the poison retains potency for 1 minute before drying.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Pole (10-foot)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 cp",
                    Weight = 7,
                    Description = "When you suspect a trap, you can put the end of your 10-foot pole through that hole in " +
                    "the wall instead of reaching in with your hand.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Pot, Iron",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 10,
                    Description = "An iron pot can hold 1 gallon of liquid.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Potion of Healing",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "50 gp",
                    Weight = 0.5,
                    Description = "A character who drinks the magical red fluid in this vial regains 2d4 + 2 hit points. " +
                    "Drinking or administering a potion takes an action.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Pouch",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 1,
                    Description = "A cloth or leather pouch can hold 1/5 cubic foot/ 6 pounds of gear - or up to 20 sling " +
                    "bullets or 50 blowgun needles, among other things. A compartmentalized pouch for holding spell " +
                    "components is called a component pouch.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Priest's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "19 gp",
                    Weight = 24,
                    Description = "Includes a backpack, a blanket, 10 candles, a tinderbox, an alms box, 2 blocks of incense, " +
                    "a censer, vestments, 2 days of rations, and a waterskin.",
                    Quantity = 1
                });

            #endregion

            #region Q Items

            LIB.m_ItemLibrary.Add("Quiver",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 1,
                    Description = "A quiver can hold up to 20 arrows.",
                    Quantity = 1
                });

            #endregion

            #region R Items

            LIB.m_ItemLibrary.Add("Ram, Portable",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "4 gp",
                    Weight = 35,
                    Description = "You can use a portable ram to break down doors. When doing so, you gain a +4 bonus on the " +
                    "Strength check. One other character can help you use the ram, giving you advantage on this check.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Rations (1 day)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 2,
                    Description = "Rations consist of dry foods suitable for extended travel, including jerky, dried " +
                    "fruit, hardtack, and nuts.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Reliquary",
                new CLIB.Item
                {
                    Style = LC.HolySymbol,
                    Cost = "5 gp",
                    Weight = 2,
                    Description = "A holy symbol is a representation of a god or pantheon. A cleric or paladin can use a holy " +
                    "symbol as a spellcasting focus, as described in the Spellcasting section. To use the symbol in this way, " +
                    "the caster must hold it in hand, wear it visibly, or bear it on a shield.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Robes",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 4,
                    Description = "A standard set of robes.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Rod",
                new CLIB.Item
                {
                    Style = LC.ArcaneFocus,
                    Cost = "10 gp",
                    Weight = 2,
                    Description = "An arcane focus is a special item designed to channel the power of arcane spells. A sorcerer, " +
                    "warlock, or wizard can use such an item as a spellcasting focus.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Rope, Hempen (50 feet)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 10,
                    Description = "Rope, has 2 hit points and can be burst with a DC 17 Strength check.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Rope, Silk (50 feet)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "10 gp",
                    Weight = 5,
                    Description = "Rope, has 2 hit points and can be burst with a DC 17 Strength check.",
                    Quantity = 1
                });

            #endregion

            #region S Items

            LIB.m_ItemLibrary.Add("Sack",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 cp",
                    Weight = 0.5,
                    Description = "A sack can hold 1 cubic foot/ 30 pounds of gear.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Scale, Merchant's",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 3,
                    Description = "A scale includes a small balance, pans, and a suitable assortment of weights up to 2 pounds. " +
                    "With it, you can measure the exact weight of small objects, such as raw precious metals or trade goods, to " +
                    "help determine their worth.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Scholar's Pack",
                new CLIB.Item
                {
                    Style = LC.EquipmentPack,
                    Cost = "40 gp",
                    Weight = 10,
                    Description = "Includes a backpack, a book of lore, a bottle of ink, an ink pen, 10 sheets of parchment, " +
                    "a little bag of sand, and a small knife.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Sealing Wax",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 0,
                    Description = "When you press a signet ring into warm sealing wax, you leave an identifying mark.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Shovel",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 5,
                    Description = "A standard shovel used for digging.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Signal Whistle",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 cp",
                    Weight = 0,
                    Description = "A small whistle used for signaling.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Signet Ring",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 gp",
                    Weight = 0,
                    Description = "Each signet ring has a distinctive design carved into it. When you press this ring " +
                    "into warm sealing wax, you leave an identifying mark.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Sling Bullets",
                new CLIB.Item
                {
                    Style = LC.Ammo,
                    Cost = "4 cp",
                    Weight = 1.5,
                    Description = "Sling bullets are used with a weapon that has the ammunition property to make a ranged " +
                    "attack. Each time you attack with the weapon, you expend one piece of ammunition. Drawing the " +
                    "ammunition from a quiver, case, or other container is part of the attack (you need a free hand to load " +
                    "a one-handed weapon). At the end of the battle, you can recover half your expended ammunition by taking " +
                    "a minute to search the battlefield.",
                    Quantity = 20
                });

            LIB.m_ItemLibrary.Add("Small Knife",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A small knife, typically found in a scholar's pack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Soap",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 cp",
                    Weight = 0,
                    Description = "A commodity used for bathing.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Spellbook",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "50 gp",
                    Weight = 3,
                    Description = "Essential for wizards, a spellbook is a leather-bound tome with 100 blank " +
                    "vellum pages suitable for recording spells.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Spikes, Iron (10)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 5,
                    Description = "Standard iron spikes typically used with a hammer.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Sprig of Mistletoe",
                new CLIB.Item
                {
                    Style = LC.DruidicFocus,
                    Cost = "1 gp",
                    Weight = 0,
                    Description = "A druid can use a Sprig of Mistletoe (or holly) as a spellcasting focus, as described " +
                    "in the Spellcasting section.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Spyglass",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1000 gp",
                    Weight = 1,
                    Description = "Objects viewed through a spyglass are magnified to twice their size.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Staff",
                new CLIB.Item
                {
                    Style = LC.ArcaneFocus,
                    Cost = "5 gp",
                    Weight = 4,
                    Description = "An arcane focus is a special item designed to channel the power of arcane spells. A sorcerer, " +
                    "warlock, or wizard can use such an item as a spellcasting focus.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("String (10 feet)",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "A 10-foot length of string, typically found in a burglar's pack.",
                    Quantity = 1
                });

            #endregion

            #region T Items

            LIB.m_ItemLibrary.Add("Tent, two-person",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 gp",
                    Weight = 20,
                    Description = "A simple and portable canvas shelter, a tent sleeps two.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Tinderbox",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "5 sp",
                    Weight = 1,
                    Description = "This small container holds flint, fire steel, and tinder (usually dry cloth soaked in light " +
                    "oil) used to kindle a fire. Using it to light a torch -- or anything else with abundant, exposed fuel -- " +
                    "takes an action. Lighting any other fire takes 1 minute.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Torch",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 cp",
                    Weight = 1,
                    Description = "A torch burns for 1 hour, providing bright light in a 20-foot radius and dim light for an " +
                    "additional 20 feet. If you make a melee attack with a burning torch and hit, it deals 1 fire damage.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Totem",
                new CLIB.Item
                {
                    Style = LC.DruidicFocus,
                    Cost = "1 gp",
                    Weight = 0,
                    Description = "A druid can use a Totem as a spellcasting focus, as described in the Spellcasting section.",
                    Quantity = 1
                });

            #endregion

            #region V Items

            LIB.m_ItemLibrary.Add("Vestments",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "",
                    Weight = 0,
                    Description = "Religious clothing, typically found in a priest's pack.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Vial",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 gp",
                    Weight = 0,
                    Description = "A vial can hold 4 ounces of liquid.",
                    Quantity = 1
                });

            #endregion

            #region W Items

            LIB.m_ItemLibrary.Add("Wand",
                new CLIB.Item
                {
                    Style = LC.ArcaneFocus,
                    Cost = "10 gp",
                    Weight = 1,
                    Description = "An arcane focus is a special item designed to channel the power of arcane spells. A sorcerer, " +
                    "warlock, or wizard can use such an item as a spellcasting focus.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Waterskin",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "2 sp",
                    Weight = 5,
                    Description = "A waterskin can hold 4 pints of liquid.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Whetstone",
                new CLIB.Item
                {
                    Style = LC.AdventuringGear,
                    Cost = "1 cp",
                    Weight = 1,
                    Description = "A standard whetstone used to sharpen blades.",
                    Quantity = 1
                });

            LIB.m_ItemLibrary.Add("Wooden Staff",
                new CLIB.Item
                {
                    Style = LC.DruidicFocus,
                    Cost = "5 gp",
                    Weight = 4,
                    Description = "A druid can use a Wooden Staff as a spellcasting focus, as described in the Spellcasting section.",
                    Quantity = 1
                });

            #endregion

            #region Y Items

            LIB.m_ItemLibrary.Add("Yew Wand",
                new CLIB.Item
                {
                    Style = LC.DruidicFocus,
                    Cost = "10 gp",
                    Weight = 1,
                    Description = "A druid can use a Yew Wand as a spellcasting focus, as described in the Spellcasting section.",
                    Quantity = 1
                });

            #endregion
        }
    }
}
