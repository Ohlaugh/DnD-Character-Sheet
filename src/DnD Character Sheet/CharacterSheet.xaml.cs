using DnD_Character_Sheet.Classes;
using Interfaces.HelperClasses;
using Microsoft.Win32;
using System.IO;
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

    private void PopulateCharacterSheet()
    {
      DataContext = Library.MainCharacterInfo;

      foreach (Feature feature in Library.MainCharacterInfo.Features)
      {
        Label label = new Label();
        label.Content = feature.Name;
        label.ToolTip = feature.Description;
        label.Margin = new Thickness(0, -5, 0, -5);
        label.FontSize = 16;

        StackPanel_Features_Traits.Children.Add(label);
      }

      string profAndLangText = string.Format(Constants.ProfAndLangFormat,
        string.Join(", ", Library.MainCharacterInfo.Proficient_Languages),
        string.Join(", ", Library.MainCharacterInfo.Proficient_Armor),
        string.Join(", ", Library.MainCharacterInfo.Proficient_Weapon),
        string.Join(", ", Library.MainCharacterInfo.Proficient_Tools));


      foreach (Weapon weapon in Library.MainCharacterInfo.Weapons)
      {

      }

      TabControl_CharacterSheet.Visibility = Visibility.Visible;
    }

    private void Load_Button_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog fileDialog = new OpenFileDialog();
      fileDialog.Filter = Constants.FileFilter;
      fileDialog.RestoreDirectory = false;
      bool? result = fileDialog.ShowDialog();

      if (result == true)
      {
        XmlSerializer serializer = new(typeof(MainCharacterInfo));
        using XmlReader reader = XmlReader.Create(fileDialog.FileName);
        if (serializer.Deserialize(reader) is MainCharacterInfo mainCharacterInfo)
        {
          if (Library.AddCharacter(mainCharacterInfo))
          {
            PopulateCharacterSheet();
          }
        }
      }
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
      DEV_HELP.Parsers test = new DEV_HELP.Parsers();
      test.SpellParser();
    }
  }
}
