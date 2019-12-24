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
                new CLIB.Armor_Class
                {
                    Style = LC.LightArmor,
                    Cost = "5 gp",
                    ArmorClass = "11 + Dex",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 8
                });

            LIB.m_ArmorLibrary.Add("Leather",
                new CLIB.Armor_Class
                {
                    Style = LC.LightArmor,
                    Cost = "10 gp",
                    ArmorClass = "11 + Dex",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 10
                });

            LIB.m_ArmorLibrary.Add("Studded Leather",
                new CLIB.Armor_Class
                {
                    Style = LC.LightArmor,
                    Cost = "45 gp",
                    ArmorClass = "12 + Dex",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 13
                });
            #endregion

            #region Medium Armor
            LIB.m_ArmorLibrary.Add("Hide",
                new CLIB.Armor_Class
                {
                    Style = LC.MediumArmor,
                    Cost = "10 gp",
                    ArmorClass = "12 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 12
                });

            LIB.m_ArmorLibrary.Add("Chain Shirt",
                new CLIB.Armor_Class
                {
                    Style = LC.MediumArmor,
                    Cost = "50 gp",
                    ArmorClass = "13 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 20
                });

            LIB.m_ArmorLibrary.Add("Scale Mail",
                new CLIB.Armor_Class
                {
                    Style = LC.MediumArmor,
                    Cost = "50 gp",
                    ArmorClass = "14 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 45
                });

            LIB.m_ArmorLibrary.Add("Breastplate",
                new CLIB.Armor_Class
                {
                    Style = LC.MediumArmor,
                    Cost = "400 gp",
                    ArmorClass = "14 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 20
                });

            LIB.m_ArmorLibrary.Add("Half Plate",
                new CLIB.Armor_Class
                {
                    Style = LC.MediumArmor,
                    Cost = "750 gp",
                    ArmorClass = "15 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 40
                });
            #endregion

            #region Heavy Armor
            LIB.m_ArmorLibrary.Add("Ring Mail",
                new CLIB.Armor_Class
                {
                    Style = LC.HeavyArmor,
                    Cost = "30 gp",
                    ArmorClass = "14",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 40
                });

            LIB.m_ArmorLibrary.Add("Chain Mail",
                new CLIB.Armor_Class
                {
                    Style = LC.HeavyArmor,
                    Cost = "75 gp",
                    ArmorClass = "16",
                    StrengthReq = 13,
                    Disadvantage = true,
                    Weight = 55
                });

            LIB.m_ArmorLibrary.Add("Splint",
                new CLIB.Armor_Class
                {
                    Style = LC.HeavyArmor,
                    Cost = "200 gp",
                    ArmorClass = "17",
                    StrengthReq = 15,
                    Disadvantage = true,
                    Weight = 60
                });

            LIB.m_ArmorLibrary.Add("Plate",
                new CLIB.Armor_Class
                {
                    Style = LC.HeavyArmor,
                    Cost = "1500 gp",
                    ArmorClass = "18",
                    StrengthReq = 15,
                    Disadvantage = true,
                    Weight = 65
                });

            LIB.m_ArmorLibrary.Add("Shield",
                new CLIB.Armor_Class
                {
                    Style = LC.Shield,
                    Cost = "10 gp",
                    ArmorClass = "+2",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 6
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
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "1 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light
                    }
                });

            LIB.m_WeaponLibrary.Add("Dagger",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Greatclub",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d8"),
                    Weight = 10,
                    Properties = new List<string>
                    {
                        LC.Two_Handed
                    }
                });

            LIB.m_WeaponLibrary.Add("Handaxe",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Slashing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light,
                        string.Format(LC.Thrown,20,60)
                    }
                });

            LIB.m_WeaponLibrary.Add("LC.Light hammer",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light,
                        string.Format(LC.Thrown,20,60)
                    }
                });

            LIB.m_WeaponLibrary.Add("Mace",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d6"),
                    Weight = 4,
                    Properties = new List<string>()
                });

            LIB.m_WeaponLibrary.Add("Quarterstaff",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "2 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d6"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d8")
                    }
                });

            LIB.m_WeaponLibrary.Add("Sickle",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "1 gp",
                    Damage = string.Format(LC.Slashing, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Light
                    }
                });

            LIB.m_WeaponLibrary.Add("Spear",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeSimple,
                    Cost = "1 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(LC.Thrown,20,60),
                        string.Format(LC.Versatile, "1d8")
                    }
                });

            LIB.m_WeaponLibrary.Add("Battleaxe",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Slashing, "1d8"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d10")
                    }
                });

            LIB.m_WeaponLibrary.Add("Flail",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d8"),
                    Weight = 2,
                    Properties = new List<string>()
                });

            LIB.m_WeaponLibrary.Add("Glaive",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Greataxe",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "30 gp",
                    Damage = string.Format(LC.Slashing, "1d12"),
                    Weight = 7,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Two_Handed
                    }
                });

            LIB.m_WeaponLibrary.Add("Greatsword",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "50 gp",
                    Damage = string.Format(LC.Slashing, "2d6"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Two_Handed
                    }
                });

            LIB.m_WeaponLibrary.Add("Halberd",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Lance",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Piercing, "1d12"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        LC.Reach,
                        LC.Special
                    }
                });

            LIB.m_WeaponLibrary.Add("Longsword",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(LC.Slashing, "1d8"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d10")
                    }
                });

            LIB.m_WeaponLibrary.Add("Maul",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Bludgeoning, "2d6"),
                    Weight = 10,
                    Properties = new List<string>
                    {
                        LC.Heavy,
                        LC.Two_Handed
                    }
                });

            LIB.m_WeaponLibrary.Add("Morningstar",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 4,
                    Properties = new List<string>()
                });

            LIB.m_WeaponLibrary.Add("Pike",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Rapier",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "25 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Finesse
                    }
                });

            LIB.m_WeaponLibrary.Add("Scimitar",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "25 gp",
                    Damage = string.Format(LC.Slashing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Light
                    }
                });

            LIB.m_WeaponLibrary.Add("Shortsword",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Light
                    }
                });

            LIB.m_WeaponLibrary.Add("Trident",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(LC.Thrown,20,60),
                        string.Format(LC.Versatile, "1d18")
                    }
                });

            LIB.m_WeaponLibrary.Add("War Pick",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(LC.Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>()
                });

            LIB.m_WeaponLibrary.Add("Warhammer",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(LC.Bludgeoning, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(LC.Versatile, "1d10")
                    }
                });

            LIB.m_WeaponLibrary.Add("Whip",
                new CLIB.Weapon_Class
                {
                    Style = LC.MeleeMartial,
                    Cost = "2 gp",
                    Damage = string.Format(LC.Slashing, "1d4"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        LC.Reach
                    }
                });
            #endregion

            #region Ranged Weapons
            LIB.m_WeaponLibrary.Add("Crossbow, LC.Light",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Dart",
                new CLIB.Weapon_Class
                {
                    Style = LC.RangedSimple,
                    Cost = "5 cp",
                    Damage = string.Format(LC.Piercing, "1d4"),
                    Weight = .25,
                    Properties = new List<string>
                    {
                        LC.Finesse,
                        string.Format(LC.Thrown,20,60)
                    }
                });

            LIB.m_WeaponLibrary.Add("Shortbow",
                new CLIB.Weapon_Class
                {
                    Style = LC.RangedSimple,
                    Cost = "25 gp",
                    Damage = string.Format(LC.Piercing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,80,320),
                        LC.Two_Handed
                    }
                });

            LIB.m_WeaponLibrary.Add("Sling",
                new CLIB.Weapon_Class
                {
                    Style = LC.RangedSimple,
                    Cost = "1 sp",
                    Damage = string.Format(LC.Bludgeoning, "1d4"),
                    Weight = 0,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,30,120)
                    }
                });

            LIB.m_WeaponLibrary.Add("Blowgun",
                new CLIB.Weapon_Class
                {
                    Style = LC.RangedMartial,
                    Cost = "10 gp",
                    Damage = string.Format(LC.Piercing, "1"),
                    Weight = 1,
                    Properties = new List<string>
                    {
                        string.Format(LC.Ammunition,25,100),
                        LC.Loading
                    }
                });

            LIB.m_WeaponLibrary.Add("Crossbow, hand",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Crossbow, LC.Heavy",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Longbow",
                new CLIB.Weapon_Class
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
                    }
                });

            LIB.m_WeaponLibrary.Add("Net",
                new CLIB.Weapon_Class
                {
                    Style = LC.RangedMartial,
                    Cost = "1 gp",
                    Damage = "0",
                    Weight = 3,
                    Properties = new List<string>
                    {
                        LC.Special,
                        string.Format(LC.Thrown,5,15)
                    }
                });
            #endregion
        }
    }
}
