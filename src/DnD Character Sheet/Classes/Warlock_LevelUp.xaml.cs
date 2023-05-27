using Interfaces.HelperClasses;
using System.Windows;

namespace DnD_Character_Sheet.Classes
{
  /// <summary>
  /// Interaction logic for Warlock_LevelUp.xaml
  /// </summary>
  public partial class Warlock_LevelUp : Window
  {
    public Warlock_LevelUp(Warlock warlock)
    {
      InitializeComponent();
      DataContext = warlock;
    }

    public void SetOptions(int CantripsAdded, int SpellsAdded, int InvocationsAdded)
    {
      if (CantripsAdded > 0)
      {
        GroupBox_Cantrips.Header = $"Add {CantripsAdded} Cantrip";
        GroupBox_Cantrips.Visibility = Visibility.Visible;
      }
      if (SpellsAdded > 0)
      {
        GroupBox_Spells.Header = $"Add {SpellsAdded} Spell";
        GroupBox_Spells.Visibility = Visibility.Visible;
      }
      if (InvocationsAdded > 0)
      {
        GroupBox_Invocations.Header = $"Add {InvocationsAdded} Invocation";
        GroupBox_Invocations.Visibility = Visibility.Visible;
      }
    }

    private void Add_Cantrips_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell<Spell>(true);
    }
    private void Clear_Cantrips_Button_Click(object sender, RoutedEventArgs e)
    {

    }
    private void Add_Spells_Button_Click(object sender, RoutedEventArgs e)
    {
      BuySell<Spell>(true);
    }
    private void Clear_Spells_Button_Click(object sender, RoutedEventArgs e)
    {

    }
    private void Add_Invocations_Button_Click(object sender, RoutedEventArgs e)
    {
      //BuySell<Spell>(true);
    }
    private void Clear_Invocations_Button_Click(object sender, RoutedEventArgs e)
    {

    }
    private void BuySell<T>(bool buy)
    {
      BuySellInventory buySellInventory = new BuySellInventory(nameof(T), buy);
      buySellInventory.ShowDialog();
    }
  }
}
