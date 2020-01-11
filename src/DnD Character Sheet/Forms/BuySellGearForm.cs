using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;
using LIB = DnD_Character_Sheet.Library;
using LC = DnD_Character_Sheet.Constants;

namespace DnD_Character_Sheet.Forms
{
    public partial class BuySellGearForm : Form
    {
        private readonly List<string> selectedItems = new List<string>();
        private readonly List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

        public BuySellGearForm(bool Buying)
        {
            InitializeComponent();
            if (Buying)
            {
                Sell_Button.Visible = false;
                PopulateGrid(LIB.m_ArmorLibrary, LIB.m_WeaponLibrary);
            }
            else
            {
                Text = "Sell Gear";
                BuyEquipment_Grid.Columns[0].HeaderText = "Sell";
                Purchase_Button.Visible = false;
                PopulateGrid(LIB.m_MainCharacterInfo.Armor, LIB.m_MainCharacterInfo.Weapons);
            }
        }

        private void PopulateGrid(Dictionary<string, CLIB.Armor> ArmorDictionary, Dictionary<string, CLIB.Weapon> WeaponDictionary)
        {
            BuyEquipment_Grid.Rows.Clear();
            if (ArmorDictionary.Keys.Count > 0)
            {
                foreach (var key in ArmorDictionary.Keys)
                {
                    CLIB.Armor armor = ArmorDictionary[key];
                    string properties = string.Format(LC.ArmorProperties, armor.StrengthReq, armor.Disadvantage);
                    object[] param = { false, armor.Style, key, armor.Quantity, armor.Cost, string.Empty, armor.ArmorClass, armor.Weight + " lb.", properties };
                    BuyEquipment_Grid.Rows.Add(param);
                }
            }
            if (WeaponDictionary.Keys.Count > 0)
            {
                foreach (var key in WeaponDictionary.Keys)
                {
                    CLIB.Weapon weapon = WeaponDictionary[key];
                    string properties = string.Join(", ", weapon.Properties.ToArray());
                    object[] param = { false, weapon.Style, key, weapon.Quantity, weapon.Cost, weapon.Damage, string.Empty, weapon.Weight + " lb.", properties };
                    BuyEquipment_Grid.Rows.Add(param);
                }
            }
        }

        private void BuyEquipment_Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridView grid = (DataGridView)sender;
                DataGridViewRow row = grid.Rows[e.RowIndex];
                string selectedItem = row.Cells[LC.ItemName_Grid].Value.ToString();
                if (selectedItems.Contains(selectedItem))
                {
                    selectedItems.Remove(selectedItem);
                    selectedRows.Remove(row);
                }
                else
                {
                    selectedItems.Add(selectedItem);
                    selectedRows.Add(row);
                }
            }
        }

        private void Purchase_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedRows)
            {
                string key = row.Cells[LC.ItemName_Grid].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells[LC.Quantity_Grid].Value.ToString());

                if (LIB.m_MainCharacterInfo.Armor.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Armor[key].Quantity += quantity;
                    continue;
                }
                if (LIB.m_MainCharacterInfo.Weapons.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Weapons[key].Quantity += quantity;
                    continue;
                }

                if (LIB.m_ArmorLibrary.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Armor.Add(key, LIB.m_ArmorLibrary[key]);
                    LIB.m_MainCharacterInfo.Armor[key].Quantity = quantity;
                }
                else if (LIB.m_WeaponLibrary.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Weapons.Add(key, LIB.m_WeaponLibrary[key]);
                    LIB.m_MainCharacterInfo.Weapons[key].Quantity = quantity;
                }
            }
            Close();
        }

        private void Sell_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedRows)
            {
                string key = row.Cells[LC.ItemName_Grid].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells[LC.Quantity_Grid].Value.ToString());
                if (LIB.m_MainCharacterInfo.Armor.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Armor[key].Quantity -= quantity;
                    if (LIB.m_MainCharacterInfo.Armor[key].Quantity <= 0)
                    {
                        LIB.m_MainCharacterInfo.Armor.Remove(key);
                    }
                    continue;
                }
                if (LIB.m_MainCharacterInfo.Weapons.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Weapons[key].Quantity -= quantity;
                    if (LIB.m_MainCharacterInfo.Weapons[key].Quantity <= 0)
                    {
                        LIB.m_MainCharacterInfo.Weapons.Remove(key);
                    }
                    continue;
                }
            }
            Close();
        }
    }
}
