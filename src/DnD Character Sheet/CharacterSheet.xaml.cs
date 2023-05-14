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
          if (Library.AddCharacter(mainCharacterInfo))
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
      Library.MainCharacterInfo.ProficiencyBonus = 7;
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
        description = feature.Description;
        featureFound = true;
        break;
      }

      if (featureFound)
      {
        UpdateHelpMenu(featureName, description);
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
