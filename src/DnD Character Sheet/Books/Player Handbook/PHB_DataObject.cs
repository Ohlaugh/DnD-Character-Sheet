using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Character_Sheet;
using static DnD_Character_Sheet.Constants;
using LC = DnD_Character_Sheet.Books.Player_Handbook.PHB_Constants;

namespace DnD_Character_Sheet.Books.Player_Handbook
{
    class PHB_DataObject : Library
    {
        /// <summary>
        /// Adds all Player Handbook Races to the Master Race Library
        /// </summary>
        public static void AddRaces()
        {
            foreach (string race in LC.Races)
            {
                m_RaceLibrary.Add(race, new List<string>());
                List<string> subraces = new List<string>();
                foreach (string subrace in LC.Subraces)
                {
                    if (subrace.Split(':')[0] == race)
                    {
                        subraces.Add(subrace.Split(':')[1]);
                    }
                }
                m_RaceLibrary[race] = subraces;
            }
        }

        public static void AddClasses()
        {
            
        }

        /// <summary>
        /// Adds all Player Handbook Pieces of Armor to the Master Armor Library
        /// </summary>
        public static void AddArmor()
        {
            #region Light Armor
            m_ArmorLibrary.Add("Padded",
                new Armor_Class
                {
                    Style = LightArmor,
                    Cost = "5 gp",
                    ArmorClass = "11 + Dex",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 8
                });

            m_ArmorLibrary.Add("Leather",
                new Armor_Class
                {
                    Style = LightArmor,
                    Cost = "10 gp",
                    ArmorClass = "11 + Dex",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 10
                });

            m_ArmorLibrary.Add("Studded Leather",
                new Armor_Class
                {
                    Style = LightArmor,
                    Cost = "45 gp",
                    ArmorClass = "12 + Dex",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 13
                });
            #endregion

            #region Medium Armor
            m_ArmorLibrary.Add("Hide",
                new Armor_Class
                {
                    Style = MediumArmor,
                    Cost = "10 gp",
                    ArmorClass = "12 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 12
                });

            m_ArmorLibrary.Add("Chain Shirt",
                new Armor_Class
                {
                    Style = MediumArmor,
                    Cost = "50 gp",
                    ArmorClass = "13 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 20
                });

            m_ArmorLibrary.Add("Scale Mail",
                new Armor_Class
                {
                    Style = MediumArmor,
                    Cost = "50 gp",
                    ArmorClass = "14 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 45
                });

            m_ArmorLibrary.Add("Breastplate",
                new Armor_Class
                {
                    Style = MediumArmor,
                    Cost = "400 gp",
                    ArmorClass = "14 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = false,
                    Weight = 20
                });

            m_ArmorLibrary.Add("Half Plate",
                new Armor_Class
                {
                    Style = MediumArmor,
                    Cost = "750 gp",
                    ArmorClass = "15 + Dex(Max 2)",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 40
                });
            #endregion

            #region Heavy Armor
            m_ArmorLibrary.Add("Ring Mail",
                new Armor_Class
                {
                    Style = HeavyArmor,
                    Cost = "30 gp",
                    ArmorClass = "14",
                    StrengthReq = 0,
                    Disadvantage = true,
                    Weight = 40
                });

            m_ArmorLibrary.Add("Chain Mail",
                new Armor_Class
                {
                    Style = HeavyArmor,
                    Cost = "75 gp",
                    ArmorClass = "16",
                    StrengthReq = 13,
                    Disadvantage = true,
                    Weight = 55
                });

            m_ArmorLibrary.Add("Splint",
                new Armor_Class
                {
                    Style = HeavyArmor,
                    Cost = "200 gp",
                    ArmorClass = "17",
                    StrengthReq = 15,
                    Disadvantage = true,
                    Weight = 60
                });

            m_ArmorLibrary.Add("Plate",
                new Armor_Class
                {
                    Style = HeavyArmor,
                    Cost = "1500 gp",
                    ArmorClass = "18",
                    StrengthReq = 15,
                    Disadvantage = true,
                    Weight = 65
                });

            m_ArmorLibrary.Add("Shield",
                new Armor_Class
                {
                    Style = Shield,
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
        public static void AddWeapons()
        {
            #region Melee Weapons
            m_WeaponLibrary.Add("Club",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "1 sp",
                    Damage = string.Format(Bludgeoning, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        Light
                    }
                });

            m_WeaponLibrary.Add("Dagger",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "2 gp",
                    Damage = string.Format(Piercing, "1d4"),
                    Weight = 1,
                    Properties = new List<string>
                    {
                        Finesse,
                        Light,
                        string.Format(Thrown,20,60)
                    }
                });

            m_WeaponLibrary.Add("Greatclub",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "2 sp",
                    Damage = string.Format(Bludgeoning, "1d8"),
                    Weight = 10,
                    Properties = new List<string>
                    {
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Handaxe",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "5 gp",
                    Damage = string.Format(Slashing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        Light,
                        string.Format(Thrown,20,60)
                    }
                });

            m_WeaponLibrary.Add("Light hammer",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "2 gp",
                    Damage = string.Format(Bludgeoning, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        Light,
                        string.Format(Thrown,20,60)
                    }
                });

            m_WeaponLibrary.Add("Mace",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "5 gp",
                    Damage = string.Format(Bludgeoning, "1d6"),
                    Weight = 4,
                    Properties = new List<string>()
                });

            m_WeaponLibrary.Add("Quarterstaff",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "2 sp",
                    Damage = string.Format(Bludgeoning, "1d6"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(Versatile, "1d8")
                    }
                });

            m_WeaponLibrary.Add("Sickle",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "1 gp",
                    Damage = string.Format(Slashing, "1d4"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        Light
                    }
                });

            m_WeaponLibrary.Add("Spear",
                new Weapon_Class
                {
                    Style = MeleeSimple,
                    Cost = "1 gp",
                    Damage = string.Format(Piercing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(Thrown,20,60),
                        string.Format(Versatile, "1d8")
                    }
                });

            m_WeaponLibrary.Add("Battleaxe",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(Slashing, "1d8"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(Versatile, "1d10")
                    }
                });

            m_WeaponLibrary.Add("Flail",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(Bludgeoning, "1d8"),
                    Weight = 2,
                    Properties = new List<string>()
                });

            m_WeaponLibrary.Add("Glaive",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "20 gp",
                    Damage = string.Format(Slashing, "1d10"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        Heavy,
                        Reach,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Greataxe",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "30 gp",
                    Damage = string.Format(Slashing, "1d12"),
                    Weight = 7,
                    Properties = new List<string>
                    {
                        Heavy,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Greatsword",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "50 gp",
                    Damage = string.Format(Slashing, "2d6"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        Heavy,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Halberd",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "20 gp",
                    Damage = string.Format(Slashing, "1d10"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        Heavy,
                        Reach,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Lance",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(Piercing, "1d12"),
                    Weight = 6,
                    Properties = new List<string>
                    {
                        Reach,
                        Special
                    }
                });

            m_WeaponLibrary.Add("Longsword",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(Slashing, "1d8"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(Versatile, "1d10")
                    }
                });

            m_WeaponLibrary.Add("Maul",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(Bludgeoning, "2d6"),
                    Weight = 10,
                    Properties = new List<string>
                    {
                        Heavy,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Morningstar",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(Piercing, "1d8"),
                    Weight = 4,
                    Properties = new List<string>()
                });

            m_WeaponLibrary.Add("Pike",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(Piercing, "1d10"),
                    Weight = 18,
                    Properties = new List<string>
                    {
                        Heavy,
                        Reach,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Rapier",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "25 gp",
                    Damage = string.Format(Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        Finesse
                    }
                });

            m_WeaponLibrary.Add("Scimitar",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "25 gp",
                    Damage = string.Format(Slashing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        Finesse,
                        Light
                    }
                });

            m_WeaponLibrary.Add("Shortsword",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "10 gp",
                    Damage = string.Format(Piercing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        Finesse,
                        Light
                    }
                });

            m_WeaponLibrary.Add("Trident",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(Piercing, "1d6"),
                    Weight = 4,
                    Properties = new List<string>
                    {
                        string.Format(Thrown,20,60),
                        string.Format(Versatile, "1d18")
                    }
                });

            m_WeaponLibrary.Add("War Pick",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "5 gp",
                    Damage = string.Format(Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>()
                });

            m_WeaponLibrary.Add("Warhammer",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "15 gp",
                    Damage = string.Format(Bludgeoning, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(Versatile, "1d10")
                    }
                });

            m_WeaponLibrary.Add("Whip",
                new Weapon_Class
                {
                    Style = MeleeMartial,
                    Cost = "2 gp",
                    Damage = string.Format(Slashing, "1d4"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        Finesse,
                        Reach
                    }
                });
            #endregion

            #region Ranged Weapons
            m_WeaponLibrary.Add("Crossbow, light",
                new Weapon_Class
                {
                    Style = RangedSimple,
                    Cost = "25 sp",
                    Damage = string.Format(Piercing, "1d8"),
                    Weight = 5,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,80,320),
                        Loading,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Dart",
                new Weapon_Class
                {
                    Style = RangedSimple,
                    Cost = "5 cp",
                    Damage = string.Format(Piercing, "1d4"),
                    Weight = .25,
                    Properties = new List<string>
                    {
                        Finesse,
                        string.Format(Thrown,20,60)
                    }
                });

            m_WeaponLibrary.Add("Shortbow",
                new Weapon_Class
                {
                    Style = RangedSimple,
                    Cost = "25 gp",
                    Damage = string.Format(Piercing, "1d6"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,80,320),
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Sling",
                new Weapon_Class
                {
                    Style = RangedSimple,
                    Cost = "1 sp",
                    Damage = string.Format(Bludgeoning, "1d4"),
                    Weight = 0,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,30,120)
                    }
                });

            m_WeaponLibrary.Add("Blowgun",
                new Weapon_Class
                {
                    Style = RangedMartial,
                    Cost = "10 gp",
                    Damage = string.Format(Piercing, "1"),
                    Weight = 1,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,25,100),
                        Loading
                    }
                });

            m_WeaponLibrary.Add("Crossbow, hand",
                new Weapon_Class
                {
                    Style = RangedMartial,
                    Cost = "75 gp",
                    Damage = string.Format(Piercing, "1d6"),
                    Weight = 3,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,30,120),
                        Light,
                        Loading
                    }
                });

            m_WeaponLibrary.Add("Crossbow, heavy",
                new Weapon_Class
                {
                    Style = RangedMartial,
                    Cost = "50 gp",
                    Damage = string.Format(Piercing, "1d10"),
                    Weight = 18,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,100,400),
                        Heavy,
                        Loading,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Longbow",
                new Weapon_Class
                {
                    Style = RangedMartial,
                    Cost = "50 gp",
                    Damage = string.Format(Piercing, "1d8"),
                    Weight = 2,
                    Properties = new List<string>
                    {
                        string.Format(Ammunition,100,400),
                        Heavy,
                        Two_Handed
                    }
                });

            m_WeaponLibrary.Add("Net",
                new Weapon_Class
                {
                    Style = RangedMartial,
                    Cost = "1 gp",
                    Damage = "0",
                    Weight = 3,
                    Properties = new List<string>
                    {
                        Special,
                        string.Format(Thrown,5,15)
                    }
                });
            #endregion
        }
    }
}
