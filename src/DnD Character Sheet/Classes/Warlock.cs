using DnD_Character_Sheet.HelperClasses;
using Interfaces;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DnD_Character_Sheet.Classes
{
  public class Warlock : ICharacterClass, INotifyPropertyChanged
  {
    #region Private Members

    private string m_ProfBonus = string.Empty;
    private string m_Features = string.Empty;
    private int m_CantripsKnown = 2;
    private int m_SpellsKnown = 2;
    private int m_SpellSlots = 2;
    private string m_SpellSlotLevel = "1st";
    private int m_InvocationsKnown = 0;
    private ObservableCollection<Feature> m_Evocations = new ObservableCollection<Feature> { new Feature { Name = "TEST", Description = "TEST2" } };

    #endregion Private Members

    #region Public Members

    public string ProfBonus
    {
      get { return m_ProfBonus; }

      set
      {
        if (value != m_ProfBonus)
        {
          m_ProfBonus = value;
          NotifyPropertyChanged();
        }
      }
    }

    public string Features2
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

    public int CantripsKnown
    {
      get { return m_CantripsKnown; }

      set
      {
        if (value != m_CantripsKnown)
        {
          m_CantripsKnown = value;
          NotifyPropertyChanged();
        }
      }
    }

    public int SpellsKnown
    {
      get { return m_SpellsKnown; }

      set
      {
        if (value != m_SpellsKnown)
        {
          m_SpellsKnown = value;
          NotifyPropertyChanged();
        }
      }
    }

    public int SpellSlots
    {
      get { return m_SpellSlots; }

      set
      {
        if (value != m_SpellSlots)
        {
          m_SpellSlots = value;
          NotifyPropertyChanged();
        }
      }
    }

    public string SpellSlotLevel
    {
      get { return m_SpellSlotLevel; }

      set
      {
        if (value != m_SpellSlotLevel)
        {
          m_SpellSlotLevel = value;
          NotifyPropertyChanged();
        }
      }
    }

    public int InvocationsKnown
    {
      get { return m_InvocationsKnown; }

      set
      {
        if (m_InvocationsKnown != value)
        {
          m_InvocationsKnown = value;
          NotifyPropertyChanged();
        }
      }
    }

    #endregion Public Members

    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    protected void NotifyPropertyChanged([CallerMemberName] String propertyFeatures = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyFeatures));
    }

    #endregion IPropertyChanged

    #region ICharacterClass

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

    public void LevelUp(int newLevel)
    {
      int cantripsAdded, SpellsAdded, InvocationsAdded;
      cantripsAdded = SpellsAdded = InvocationsAdded = 0;


      switch (newLevel)
      {
        case 1:
          // NEW CHARACTER
          break;
        case 2:
          m_ProfBonus = "+2";
          m_Features = "Eldritch Invocations";
          m_CantripsKnown = 2;
          m_SpellsKnown = 2;
          m_SpellSlots = 2;
          m_SpellSlotLevel = "1st";
          m_InvocationsKnown = 2;
          SpellsAdded = 1;
          InvocationsAdded = 2;


          // Eldritch Invocations
          // Invocations known = 2
          // Spells Known = 3
          // Spell Slots = 2
          break;
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 16:
        case 17:
        case 18:
        case 19:
        case 20:
          break;
      }
      Warlock_LevelUp levelUpScreen = new Warlock_LevelUp(this);
      levelUpScreen.SetOptions(cantripsAdded, SpellsAdded, InvocationsAdded);
    }

    public void Decorate()
    {
      //Library.CharacterSheet.StackPanel_Features.Children.Add();
      Library.CharacterSheet.ItemsControl_EldritchInvocations.Visibility = System.Windows.Visibility.Visible;
    }

    #endregion ICharacterClass
  }
}