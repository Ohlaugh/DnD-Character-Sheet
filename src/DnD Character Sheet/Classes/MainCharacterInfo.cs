using DnD_Character_Sheet.Classes;
using DnD_Character_Sheet.HelperClasses;
using Interfaces.HelperClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DnD_Character_Sheet
{
  public class MainCharacterInfo : NotifyProperty
  {
    #region Private Members

    private string m_CharacterName = string.Empty;
    private string m_Class = string.Empty;
    private string m_SubClass = string.Empty;
    private int m_Level = 0;
    private string m_Background = string.Empty;
    private string m_PlayerName = string.Empty;
    private string m_Race = string.Empty;
    private string m_Subrace = string.Empty;
    private string m_Alignment = string.Empty;
    private int m_ExperiencePoints = 0;
    private int m_Age = 0;
    private string m_Height = string.Empty;
    private double m_Weight = 0;
    private string m_EyeColor = string.Empty;
    private string m_SkinColor = string.Empty;
    private string m_HairColor = string.Empty;
    private bool m_Inspiration = false;
    private int m_ArmorClass = 0;
    private int m_Initiative = 0;
    private int m_Speed = 0;
    private int m_HP_Max = 0;
    private int m_HP_Current = 0;
    private int m_HP_Temp = 0;
    private string m_HitDice = string.Empty;
    private int m_HitDiceRem = 0;
    private int m_HitDiceTotal = 0;
    private string m_PersonalityTraits = string.Empty;
    private string m_Ideals = string.Empty;
    private string m_Bonds = string.Empty;
    private string m_Flaws = string.Empty;
    private double m_CarryingWeight = 0;
    private string m_Backstory = string.Empty;
    private string m_Organizations = string.Empty;
    private string m_Allies = string.Empty;
    private string m_Enemies = string.Empty;
    private string m_Notes = string.Empty;
    private bool m_Multiclass = false;
    private int m_ProficiencyBonus = 0;
    private int m_Perception = 0;
    private double m_CarryingCapacity = 0;

    private Money m_Money = new();
    private Attributes m_Attributes = new();
    private Skills m_Skills = new();
    private SavingThrows m_SavingThrows = new();

    private ObservableCollection<string> m_Proficient_Languages = new();
    private ObservableCollection<string> m_Proficient_Armor = new();
    private ObservableCollection<string> m_Proficient_Weapon = new();
    private ObservableCollection<string> m_Proficient_Tools = new();
    private ObservableCollection<string> m_Books = new();

    private ObservableCollection<Feature> m_Features = new();
    private ObservableCollection<Item> m_Items = new();
    private ObservableCollection<Weapon> m_Weapons = new();
    private ObservableCollection<Armor> m_Armors = new();
    private ObservableCollection<CombatAction> m_Actions = new();



    #endregion Private Members

    #region Public Members

    public string CharacterName
    {
      get { return m_CharacterName; }

      set
      {
        if (value != m_CharacterName)
        {
          m_CharacterName = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Class
    {
      get { return m_Class; }

      set
      {
        if (value != m_Class)
        {
          m_Class = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string SubClass
    {
      get { return m_SubClass; }

      set
      {
        if (value != m_SubClass)
        {
          m_SubClass = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Level
    {
      get { return m_Level; }

      set
      {
        if (value != m_Level)
        {
          m_Level = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Background
    {
      get { return m_Background; }

      set
      {
        if (value != m_Background)
        {
          m_Background = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string PlayerName
    {
      get { return m_PlayerName; }

      set
      {
        if (value != m_PlayerName)
        {
          m_PlayerName = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Race
    {
      get { return m_Race; }

      set
      {
        if (value != m_Race)
        {
          m_Race = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Subrace
    {
      get { return m_Subrace; }

      set
      {
        if (value != m_Subrace)
        {
          m_Subrace = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Alignment
    {
      get { return m_Alignment; }

      set
      {
        if (value != m_Alignment)
        {
          m_Alignment = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int ExperiencePoints
    {
      get { return m_ExperiencePoints; }

      set
      {
        if (value != m_ExperiencePoints)
        {
          m_ExperiencePoints = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Age
    {
      get { return m_Age; }

      set
      {
        if (value != m_Age)
        {
          m_Age = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Height
    {
      get { return m_Height; }

      set
      {
        if (value != m_Height)
        {
          m_Height = value;
          NotifyPropertyChanged();
        }
      }
    }
    public double Weight
    {
      get { return m_Weight; }

      set
      {
        if (value != m_Weight)
        {
          m_Weight = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string EyeColor
    {
      get { return m_EyeColor; }

      set
      {
        if (value != m_EyeColor)
        {
          m_EyeColor = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string SkinColor
    {
      get { return m_SkinColor; }

      set
      {
        if (value != m_SkinColor)
        {
          m_SkinColor = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string HairColor
    {
      get { return m_HairColor; }

      set
      {
        if (value != m_HairColor)
        {
          m_HairColor = value;
          NotifyPropertyChanged();
        }
      }
    }
    public bool Inspiration
    {
      get { return m_Inspiration; }

      set
      {
        if (value != m_Inspiration)
        {
          m_Inspiration = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int ArmorClass
    {
      get { return m_ArmorClass; }

      set
      {
        if (value != m_ArmorClass)
        {
          m_ArmorClass = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Initiative
    {
      get { return m_Initiative; }

      set
      {
        if (value != m_Initiative)
        {
          m_Initiative = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Speed
    {
      get { return m_Speed; }

      set
      {
        if (value != m_Speed)
        {
          m_Speed = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int HP_Max
    {
      get { return m_HP_Max; }

      set
      {
        if (value != m_HP_Max)
        {
          m_HP_Max = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int HP_Current
    {
      get { return m_HP_Current; }

      set
      {
        if (value != m_HP_Current)
        {
          m_HP_Current = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int HP_Temp
    {
      get { return m_HP_Temp; }

      set
      {
        if (value != m_HP_Temp)
        {
          m_HP_Temp = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string HitDice
    {
      get { return m_HitDice; }

      set
      {
        if (value != m_HitDice)
        {
          m_HitDice = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int HitDiceRem
    {
      get { return m_HitDiceRem; }

      set
      {
        if (value != m_HitDiceRem)
        {
          m_HitDiceRem = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int HitDiceTotal
    {
      get { return m_HitDiceTotal; }

      set
      {
        if (value != m_HitDiceTotal)
        {
          m_HitDiceTotal = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string PersonalityTraits
    {
      get { return m_PersonalityTraits; }

      set
      {
        if (value != m_PersonalityTraits)
        {
          m_PersonalityTraits = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Ideals
    {
      get { return m_Ideals; }

      set
      {
        if (value != m_Ideals)
        {
          m_Ideals = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Bonds
    {
      get { return m_Bonds; }

      set
      {
        if (value != m_Bonds)
        {
          m_Bonds = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Flaws
    {
      get { return m_Flaws; }

      set
      {
        if (value != m_Flaws)
        {
          m_Flaws = value;
          NotifyPropertyChanged();
        }
      }
    }
    public double CarryingWeight
    {
      get { return m_CarryingWeight; }

      set
      {
        if (value != m_CarryingWeight)
        {
          m_CarryingWeight = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Backstory
    {
      get { return m_Backstory; }

      set
      {
        if (value != m_Backstory)
        {
          m_Backstory = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Organizations
    {
      get { return m_Organizations; }

      set
      {
        if (value != m_Organizations)
        {
          m_Organizations = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Allies
    {
      get { return m_Allies; }

      set
      {
        if (value != m_Allies)
        {
          m_Allies = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Enemies
    {
      get { return m_Enemies; }

      set
      {
        if (value != m_Enemies)
        {
          m_Enemies = value;
          NotifyPropertyChanged();
        }
      }
    }
    public string Notes
    {
      get { return m_Notes; }

      set
      {
        if (value != m_Notes)
        {
          m_Notes = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int ProficiencyBonus
    {
      get { return m_ProficiencyBonus; }

      set
      {
        if (value != m_ProficiencyBonus)
        {
          m_ProficiencyBonus = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Perception
    {
      get
      {
        return 0;
        // TODO
        //return Skills.Perception ?
        //    10 + Attributes.WisdomModifier + ProficiencyBonus :
        //    10 + Attributes.WisdomModifier;
      }
    }
    public double CarryingCapacity { get => Attributes.Strength * 15; }

    public Money Money
    {
      get { return m_Money; }

      set
      {
        if (value != m_Money)
        {
          m_Money = value;
          NotifyPropertyChanged();
        }
      }
    }
    public Attributes Attributes
    {
      get { return m_Attributes; }

      set
      {
        if (value != m_Attributes)
        {
          m_Attributes = value;
          NotifyPropertyChanged();
        }
      }
    }
    public Skills Skills
    {
      get { return m_Skills; }

      set
      {
        if (value != m_Skills)
        {
          m_Skills = value;
          NotifyPropertyChanged();
        }
      }
    }
    public SavingThrows SavingThrows
    {
      get { return m_SavingThrows; }

      set
      {
        if (value != m_SavingThrows)
        {
          m_SavingThrows = value;
          NotifyPropertyChanged();
        }
      }
    }

    public ObservableCollection<string> Proficient_Languages
    {
      get { return m_Proficient_Languages; }

      set
      {
        if (value != m_Proficient_Languages)
        {
          m_Proficient_Languages = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<string> Proficient_Armor
    {
      get { return m_Proficient_Armor; }

      set
      {
        if (value != m_Proficient_Armor)
        {
          m_Proficient_Armor = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<string> Proficient_Weapon
    {
      get { return m_Proficient_Weapon; }

      set
      {
        if (value != m_Proficient_Weapon)
        {
          m_Proficient_Weapon = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<string> Proficient_Tools
    {
      get { return m_Proficient_Tools; }

      set
      {
        if (value != m_Proficient_Tools)
        {
          m_Proficient_Tools = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<string> Books
    {
      get { return m_Books; }

      set
      {
        if (value != m_Books)
        {
          m_Books = value;
          NotifyPropertyChanged();
        }
      }
    }


    public ObservableCollection<Feature> Features
    {
      get { return m_Features; }

      set
      {
        if (value != m_Features)
        {
          m_Features = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<Item> Items
    {
      get { return m_Items; }

      set
      {
        if (value != m_Items)
        {
          m_Items = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<Weapon> Weapons
    {
      get { return m_Weapons; }

      set
      {
        if (value != m_Weapons)
        {
          m_Weapons = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<Armor> Armors
    {
      get { return m_Armors; }

      set
      {
        if (value != m_Armors)
        {
          m_Armors = value;
          NotifyPropertyChanged();
        }
      }
    }
    public ObservableCollection<CombatAction> Actions
    {
      get { return m_Actions; }

      set
      {
        if (value != m_Actions)
        {
          m_Actions = value;
          NotifyPropertyChanged();
        }
      }
    }

    #endregion Public Members


    public void AddWeapon(Weapon weapon)
    {
      bool exists = false;
      foreach (Weapon curWep in m_Weapons.Where(current => current.Name == weapon.Name))
      {
        curWep.Quantity += weapon.Quantity;
        exists = true;
        break;
      }

      if (!exists)
      {
        m_Weapons.Add(weapon);
      }
    }

    public void AddArmor(Armor armor)
    {
      bool exists = false;
      foreach (Armor curArmor in m_Armors.Where(current => current.Name == armor.Name))
      {
        curArmor.Quantity += armor.Quantity;
        exists = true;
        break;
      }

      if (!exists)
      {
        m_Armors.Add(armor);
      }
    }

    public void AddItem(Item item)
    {
      bool exists = false;
      foreach (Item curItem in m_Items.Where(current => current.Name == item.Name))
      {
        curItem.Quantity += item.Quantity;
        exists = true;
        break;
      }

      if (!exists)
      {
        m_Items.Add(item);
      }
    }

    public void SellWeapon(Weapon weapon)
    {
      bool quantityOut = false;
      int weaponIndex = -1;
      foreach (Weapon curWep in m_Weapons.Where(current => current.Name == weapon.Name))
      {
        weaponIndex = m_Weapons.IndexOf(curWep);
        curWep.Quantity -= weapon.Quantity;
        if (curWep.Quantity <= 0)
        {
          quantityOut = true;
        }
        break;
      }

      if (quantityOut)
      {
        m_Weapons.RemoveAt(weaponIndex);
      }
    }

    public void SellArmor(Armor armor)
    {
      bool quantityOut = false;
      int armorIndex = -1;
      foreach (Armor curArmor in m_Armors.Where(current => current.Name == armor.Name))
      {
        armorIndex = m_Armors.IndexOf(curArmor);
        curArmor.Quantity -= armor.Quantity;
        if (curArmor.Quantity <= 0)
        {
          quantityOut = true;
        }
        break;
      }

      if (quantityOut)
      {
        m_Armors.RemoveAt(armorIndex);
      }
    }

    public void SellItem(Item item)
    {
      bool quantityOut = false;
      int itemIndex = -1;
      foreach (Item curItem in m_Items.Where(current => current.Name == item.Name))
      {
        itemIndex = m_Items.IndexOf(curItem);
        curItem.Quantity -= item.Quantity;
        if (curItem.Quantity <= 0)
        {
          quantityOut = true;
        }
        break;
      }

      if (quantityOut)
      {
        m_Items.RemoveAt(itemIndex);
      }
    }






    public void Calculate()
    {
      SetProfBonus();
    }

    private void SetProfBonus()
    {
      int bonus = 0;
      switch (Level)
      {
        case 1:
        case 2:
        case 3:
        case 4:
          bonus = 2;
          break;
        case 5:
        case 6:
        case 7:
        case 8:
          bonus = 3;
          break;
        case 9:
        case 10:
        case 11:
        case 12:
          bonus = 4;
          break;
        case 13:
        case 14:
        case 15:
        case 16:
          bonus = 5;
          break;
        case 17:
        case 18:
        case 19:
        case 20:
          bonus = 6;
          break;
        default:
          break;
      }
      //_ProficiencyBonus = bonus;
    }

    public List<Tuple<string, bool>> GetSkills()
    {
      return new List<Tuple<string, bool>>
            {
                new Tuple<string, bool>(Skills.Acrobatics_Modifier+" Acrobatics", Skills.Acrobatics_Proficient),
                new Tuple<string, bool>(Skills.AnimalHandling_Modifier+" Animal Handling", Skills.AnimalHandling_Proficient),
                new Tuple<string, bool>(Skills.Arcana_Modifier+" Arcana", Skills.Arcana_Proficient),
                new Tuple<string, bool>(Skills.Athletics_Modifier+" Athletics", Skills.Athletics_Proficient),
                new Tuple<string, bool>(Skills.Deception_Modifier+" Deception", Skills.Deception_Proficient),
                new Tuple<string, bool>(Skills.History_Modifier+" History", Skills.History_Proficient),
                new Tuple<string, bool>(Skills.Insight_Modifier+" Insight", Skills.Insight_Proficient),
                new Tuple<string, bool>(Skills.Intimidation_Modifier+" Intimidation", Skills.Intimidation_Proficient),
                new Tuple<string, bool>(Skills.Investigation_Modifier+" Investigation", Skills.Investigation_Proficient),
                new Tuple<string, bool>(Skills.Medicine_Modifier+" Medicine", Skills.Medicine_Proficient),
                new Tuple<string, bool>(Skills.Nature_Modifier+" Nature", Skills.Nature_Proficient),
                new Tuple<string, bool>(Skills.Perception_Modifier+" Perception", Skills.Perception_Proficient),
                new Tuple<string, bool>(Skills.Performance_Modifier+" Performance", Skills.Performance_Proficient),
                new Tuple<string, bool>(Skills.Persuassion_Modifier+" Persuassion", Skills.Persuassion_Proficient),
                new Tuple<string, bool>(Skills.Religion_Modifier+" Religion", Skills.Religion_Proficient),
                new Tuple<string, bool>(Skills.SlightOfHand_Modifier+" Slight of Hand", Skills.SlightOfHand_Proficient),
                new Tuple<string, bool>(Skills.Stealth_Modifier+" Stealth", Skills.Stealth_Proficient),
                new Tuple<string, bool>(Skills.Survival_Modifier+" Survival", Skills.Survival_Proficient)
            };
    }

    public List<Tuple<string, bool>> GetSaves()
    {
      return new List<Tuple<string, bool>>
            {
                new Tuple<string, bool>(SavingThrows.StrengthSave_Modifier+" Strength", SavingThrows.StrengthSave_Proficient),
                new Tuple<string, bool>(SavingThrows.DexteritySave_Modifier+" Dexterity",SavingThrows.DexteritySave_Proficient),
                new Tuple<string, bool>(SavingThrows.ConstitutionSave_Modifier+" Constitution",SavingThrows.ConstitutionSave_Proficient),
                new Tuple<string, bool>(SavingThrows.IntelligenceSave_Modifier+" Intelligence",SavingThrows.IntelligenceSave_Proficient),
                new Tuple<string, bool>(SavingThrows.WisdomSave_Modifier+" Wisdom",SavingThrows.WisdomSave_Proficient),
                new Tuple<string, bool>(SavingThrows.CharismaSave_Modifier+" Charisma",SavingThrows.CharismaSave_Proficient)
            };
    }
  }

}
