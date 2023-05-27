using Interfaces.HelperClasses;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;

namespace DnD_Character_Sheet
{
  /// <summary>
  /// Interaction logic for CharacterSheet.xaml
  /// </summary>
  public partial class CharacterSheet : Window
  {
    public CharacterSheet()
    {
      InitializeComponent();
    }

    #region Menu Buttons

    private void Load_Button_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog fileDialog = new OpenFileDialog();
      fileDialog.Filter = Constants.FileFilter;
      fileDialog.RestoreDirectory = false;
      bool? result = fileDialog.ShowDialog();

      if (result == true)
      {
        Library.ClearLibrary();

        XmlSerializer serializer = new(typeof(MainCharacterInfo));
        using XmlReader reader = XmlReader.Create(fileDialog.FileName);
        if (serializer.Deserialize(reader) is MainCharacterInfo mainCharacterInfo)
        {
          if (Library.LoadCharacter(mainCharacterInfo, this))
          {
            Library.MainCharacterInfo.Initialize();
            PopulateCharacterSheet();
            Library.MainCharacterInfo.SubscribeEvents();
          }
        }
      }
    }

    private void PopulateCharacterSheet()
    {
      DataContext = Library.MainCharacterInfo;
      Title = $"{Library.MainCharacterInfo.Race} {Library.MainCharacterInfo.Class} - {Library.MainCharacterInfo.CharacterName}";

      string profAndLangText = string.Format(Constants.ProfAndLangFormat,
        string.Join(", ", Library.MainCharacterInfo.Proficient_Languages),
        string.Join(", ", Library.MainCharacterInfo.Proficient_Armor),
        string.Join(", ", Library.MainCharacterInfo.Proficient_Weapon),
        string.Join(", ", Library.MainCharacterInfo.Proficient_Tools));
      TextBlock_ProfAndLang.Text = profAndLangText;

      StackPanel_CharacterSheet.Visibility = Visibility.Visible;
    }

    private void Save_Button_Click(object sender, RoutedEventArgs e)
    {
      SaveFileDialog fileDialog = new SaveFileDialog();
      fileDialog.FileName = fileDialog.InitialDirectory + Library.MainCharacterInfo.Race + " " + Library.MainCharacterInfo.Class;
      fileDialog.FileName += " - " + Library.MainCharacterInfo.CharacterName;

      fileDialog.Filter = Constants.FileFilter;
      fileDialog.FilterIndex = 1;
      bool? result = fileDialog.ShowDialog();
      if (result == true)
      {
        var serializer = new XmlSerializer(typeof(MainCharacterInfo));
        using (var writer = new StreamWriter(fileDialog.FileName))
        {
          serializer.Serialize(writer, Library.MainCharacterInfo);
        }
      }
    }

    private void Test_Button_Click(object sender, RoutedEventArgs e)
    {
      //Library.MainCharacterInfo.Spells.Add(Library.SpellLibrary[0]);
      //Library.MainCharacterInfo.ProficiencyBonus = 7;
      //Library.MainCharacterInfo.Features.Add(new HelperClasses.Feature { Name = "Pact of The Blade", Description = "You can use your action to create a pact weapon in your empty hand. You can choose the form that this melee weapon takes each time you create it. You are proficient with it while you wield it. This weapon counts as magical for the purpose of overcoming resistance and immunity to nonmagical attacks and damage.\r\n\r\nYour pact weapon disappears if it is more than 5 feet away from you for 1 minute or more. It also disappears if you use this feature again, if you dismiss the weapon (no action required), or if you die.\r\n\r\nYou can transform one Magic Weapon into your pact weapon by performing a special ritual while you hold the weapon. You perform the ritual over the course of 1 hour, which can be done during a short rest. You can then dismiss the weapon, shunting it into an extradimensional space, and it appears whenever you create your pact weapon thereafter. You can’t affect an artifact or a sentient weapon in this way. The weapon ceases being your pact weapon if you die, if you perform the 1-hour ritual on a different weapon, or if you use a 1-hour ritual to break your bond to it. The weapon appears at your feet if it is in the extradimensional space when the bond breaks." });

      Library.MainCharacterInfo.Evocations = new System.Collections.ObjectModel.ObservableCollection<HelperClasses.Feature>
      {
        new HelperClasses.Feature
        {
          Name = "Improved Pact Weapon",
          Description= "You can use any weapon you summon with your Pact of the Blade feature as a spellcasting focus for your warlock spells.\r\n\r\nIn addition, the weapon gains a +1 bonus to its attack and damage rolls, unless it is a magic weapon that already has a bonus to those rolls.\r\n\r\nFinally, the weapon you conjure can be a shortbow, longbow, light crossbow, or heavy crossbow.",
          Prerequisite = "Pact of the Blade feature"
        },

        new HelperClasses.Feature
        {
          Name = "Devil's Sight",
          Description= "You can see normally in darkness, both magical and nonmagical, to a distance of 120 feet.",
          Prerequisite = "None"
        }
      };



      //OpenFileDialog fileDialog = new OpenFileDialog();
      //fileDialog.Filter = Constants.FileFilter;
      //fileDialog.RestoreDirectory = false;
      //bool? result = fileDialog.ShowDialog();
      //string mainClass = string.Empty;
      //string subClass = string.Empty;
      //string fileName = string.Empty;

      //if (result == true)
      //{
      //  XmlDocument xDoc = new XmlDocument();
      //  FileStream stream = new FileStream(fileDialog.FileName, FileMode.Open);
      //  xDoc.Load(stream);

      //  mainClass = xDoc.GetElementsByTagName("Class")[0].InnerText;
      //  subClass = xDoc.GetElementsByTagName("SubClass")[0].InnerText;
      //  stream.Close();


      //  Type? type = Type.GetType("DnD_Character_Sheet.Classes." + mainClass);
      //  if (type != null)
      //  {

      //    XmlSerializer serializer = new(type);
      //    using XmlReader reader = XmlReader.Create(fileDialog.FileName);

      //    object charObject = serializer.Deserialize(reader);
      //    if (charObject != null)
      //    {
      //      if (Library.LoadCharacter(charObject))
      //      {
      //        Library.MainCharacterInfo.Initialize();
      //        PopulateCharacterSheet();
      //        Library.MainCharacterInfo.SubscribeEvents();
      //      }
      //    }
      //    reader.Close();

      //    Library.MainCharacterInfo.ProficiencyBonus = 7;

      //    //object? instance = Activator.CreateInstance(type);
      //    //if (instance != null)
      //    //{
      //    //  //m_CharacterClass = ((ICharacterClass)instance);
      //    //}
      //    SaveFileDialog fileDialog2 = new SaveFileDialog();
      //    fileDialog2.FileName = fileDialog2.InitialDirectory + Library.MainCharacterInfo.Race + " " + Library.MainCharacterInfo.Class;
      //    fileDialog2.FileName += " - " + Library.MainCharacterInfo.CharacterName;

      //    fileDialog2.Filter = Constants.FileFilter;
      //    fileDialog2.FilterIndex = 1;
      //    result = fileDialog2.ShowDialog();
      //    if (result == true)
      //    {
      //      var serializer2 = new XmlSerializer(type);
      //      using (var writer = new StreamWriter(fileDialog2.FileName))
      //      {
      //        serializer2.Serialize(writer, Library.MainCharacterObject);
      //      }
      //    }
      //  }
      //}

    }

    #endregion Menu Buttons

    #region Buy / Sell

    private void BuySell(string type, bool buy)
    {
      BuySellInventory buySellInventory = new BuySellInventory(type, buy);
      buySellInventory.ShowDialog();
    }

    private void Buy_Weapons_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Weapon), true);
    }
    private void Sell_Weapons_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Weapon), false);
    }
    private void Buy_Armors_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Armor), true);
    }
    private void Sell_Armors_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Armor), false);
    }
    private void Buy_Items_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Item), true);
    }
    private void Sell_Items_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Item), false);
    }
    private void Add_Spells_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Spell), true);
    }
    private void Remove_Spells_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell(nameof(Spell), false);
    }

    #endregion Buy / Sell

    #region Help Menu

    private void UpdateHelpMenu(string headerName, string blockText)
    {
      if (headerName == GroupBox_HelpMenu.Header)
      {
        HideHelp();
      }
      else
      {
        TextBlock_HelpMenu.Text = blockText;
        GroupBox_HelpMenu.Header = headerName;
        StackPanel_HelpMenu.Visibility = Visibility.Visible;
        StackPanel_Help_Separator.Visibility = Visibility.Visible;
      }
    }

    private void Button_HelpMenu_Click(object sender, RoutedEventArgs e)
    {
      HideHelp();
    }

    private void HideHelp()
    {
      TextBlock_HelpMenu.Text = string.Empty;
      GroupBox_HelpMenu.Header = string.Empty;
      StackPanel_HelpMenu.Visibility = Visibility.Collapsed;
      StackPanel_Help_Separator.Visibility = Visibility.Collapsed;
    }

    private void Action_Label_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
      string actionName = (string)((Label)sender).Content;
      string description = string.Empty;
      bool actionFound = false;
      foreach (var action in Library.MainCharacterInfo.CombatActions.Where(action => action.Name == actionName))
      {
        description = action.Description;

        string[] splitSource = action.Source.Split('|');

        if (splitSource.Length == 2)
        {
          // Use the Feature name for header info
          if (splitSource[0] == "Feature")
          {
            actionName = splitSource[1];
          }
        }
        actionFound = true;
        break;
      }

      if (actionFound)
      {
        UpdateHelpMenu(actionName, description);
      }
    }

    private void Feature_Label_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
      string featureName = (string)((Label)sender).Content;
      string description = string.Empty;
      bool featureFound = false;
      foreach (var feature in Library.MainCharacterInfo.Features.Where(feature => feature.Name == featureName))
      {
        description = $"Prerequisite: " + feature.Prerequisite + Environment.NewLine + Environment.NewLine;
        description += feature.Description;
        featureFound = true;
        break;
      }

      if (featureFound)
      {
        UpdateHelpMenu(featureName, description);
      }
    }
    private void Evocations_Label_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
      string evocationName = (string)((Label)sender).Content;
      string description = string.Empty;
      bool evocationFound = false;
      foreach (var evocation in Library.MainCharacterInfo.Evocations.Where(evocation => evocation.Name == evocationName))
      {
        description = $"Prerequisite: " + evocation.Prerequisite + Environment.NewLine + Environment.NewLine;
        description += evocation.Description;
        evocationFound = true;
        break;
      }

      if (evocationFound)
      {
        UpdateHelpMenu(evocationName, description);
      }
    }

    private void DataGrid_Spells_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      int index = DataGrid_Spells_0.SelectedIndex;
      Spell spell = ((Spell)DataGrid_Spells_0.Items[index]);
      string description = $"{spell.Components}{Environment.NewLine}{spell.Description}";

      UpdateHelpMenu(spell.Name, description);
    }

    private void DataGrid_Equipment_CurrentCellChanged(object sender, EventArgs e)
    {
      if (DataGrid_Equipment.CurrentCell.Column != null)
      {
        if (DataGrid_Equipment.CurrentCell.Column.Header.ToString() != "Equiped" &&
          DataGrid_Equipment.CurrentCell.Column.Header.ToString() != "Quantity")
        {
          Item item = (Item)((DataGrid)sender).CurrentCell.Item;

          UpdateHelpMenu(item.Name, item.Description);
        }
      }
      else
      {
        HideHelp();
      }
    }

    private void DataGrid_Weapons_CurrentCellChanged(object sender, EventArgs e)
    {
      if (DataGrid_Weapons.CurrentCell.Column != null)
      {
        if (DataGrid_Weapons.CurrentCell.Column.Header.ToString() != "Equiped" &&
          DataGrid_Weapons.CurrentCell.Column.Header.ToString() != "Quantity")
        {
          Weapon weapon = (Weapon)((DataGrid)sender).CurrentCell.Item;
          string description = string.Empty;
          foreach (string property in weapon.Properties)
          {
            foreach (string key in Interfaces.Constants.WeaponProperties.Keys)
            {
              if (property.Split()[0] == key.Split()[0])
              {
                if (!string.IsNullOrEmpty(description))
                {
                  description += Environment.NewLine + Environment.NewLine;
                }
                description += property + ": " + Environment.NewLine +
                  Interfaces.Constants.WeaponProperties[key];
                break;
              }
            }
          }

          UpdateHelpMenu(weapon.Name, description);
        }
      }
      else
      {
        HideHelp();
      }
    }

    #endregion Help Menu
  }
}
