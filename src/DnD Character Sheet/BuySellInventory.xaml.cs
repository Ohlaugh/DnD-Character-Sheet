using DnD_Character_Sheet.Classes;
using Interfaces.HelperClasses;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DnD_Character_Sheet
{
  /// <summary>
  /// Interaction logic for BuySellInventory.xaml
  /// </summary>
  public partial class BuySellInventory : Window
  {
    private readonly bool m_Buy;
    private readonly string m_Type;
    private readonly DataGrid m_CurrentGrid;

    public BuySellInventory(string type, bool buy)
    {
      InitializeComponent();
      m_Buy = buy;
      m_Type = type;

      string actionHeader = m_Buy ? "Purchase" : "Sell";
      Button_Action.Content = actionHeader;

      if (m_Type == nameof(Weapon))
      {
        List<Weapon> itemSource = m_Buy ?
          Library.WeaponLibrary.ConvertAll(weapon => (Weapon)weapon.Clone()) :
          Library.MainCharacterInfo.Weapons.ToList().ConvertAll(weapon => (Weapon)weapon.Clone());

        m_CurrentGrid = DataGrid_Weapons;
        DataGrid_Weapons.ItemsSource = itemSource;
        DataGrid_Weapons.Columns[0].Header = actionHeader;

        DataGrid_Weapons.Visibility = Visibility.Visible;
      }
      else if (m_Type == nameof(Armor))
      {
        List<Armor> itemSource = m_Buy ?
          Library.ArmorLibrary.ConvertAll(armor => (Armor)armor.Clone()) :
          Library.MainCharacterInfo.Armors.ToList().ConvertAll(armor => (Armor)armor.Clone());

        m_CurrentGrid = DataGrid_Armor;
        DataGrid_Armor.ItemsSource = itemSource;
        DataGrid_Armor.Columns[0].Header = actionHeader;

        DataGrid_Armor.Visibility = Visibility.Visible;
      }
      else
      {
        List<Item> itemSource = m_Buy ?
          Library.ItemLibrary.ConvertAll(item => (Item)item.Clone()) :
          Library.MainCharacterInfo.Items.ToList().ConvertAll(item => (Item)item.Clone());

        m_CurrentGrid = DataGrid_Armor;
        DataGrid_Equipment.ItemsSource = itemSource;
        DataGrid_Equipment.Columns[0].Header = actionHeader;

        DataGrid_Equipment.Visibility = Visibility.Visible;
      }
    }

    private void Button_Action_Click(object sender, RoutedEventArgs e)
    {
      if (m_Buy)
      {
        Purchase();
      }
      else
      {
        Sell();
      }
      Close();
    }

    private void Purchase()
    {
      Money money = new Money();
      List<Item> purchasedItems = new List<Item>();
      foreach (Item item in m_CurrentGrid.Items)
      {
        if (item.BuySell == true)
        {
          money.AddFunds(item.Cost, item.Quantity);
          item.BuySell = false;
          purchasedItems.Add(item);
        }
      }

      if (m_Type == nameof(Weapon))
      {
        foreach (Weapon weapon in purchasedItems)
        {
          Library.MainCharacterInfo.AddWeapon(weapon);
        }
      }
      else if (m_Type == nameof(Armor))
      {
        foreach (Armor armor in purchasedItems)
        {
          Library.MainCharacterInfo.AddArmor(armor);
        }
      }
      else if (m_Type == nameof(Item))
      {
        foreach (Item item in purchasedItems)
        {
          Library.MainCharacterInfo.AddItem(item);
        }
      }
    }

    private void Sell()
    {
      Money money = new Money();
      List<Item> soldItems = new List<Item>();
      foreach (Item item in m_CurrentGrid.Items)
      {
        if (item.BuySell == true)
        {
          money.AddFunds(item.Cost, item.Quantity);
          soldItems.Add(item);
        }
      }

      if (m_Type == nameof(Weapon))
      {
        foreach (Weapon weapon in soldItems)
        {
          Library.MainCharacterInfo.SellWeapon(weapon);
        }
      }
      else if (m_Type == nameof(Armor))
      {
        foreach (Armor armor in soldItems)
        {
          Library.MainCharacterInfo.SellArmor(armor);
        }
      }
      else if (m_Type == nameof(Item))
      {
        foreach (Item item in soldItems)
        {
          Library.MainCharacterInfo.SellItem(item);
        }
      }
    }


  }
}
