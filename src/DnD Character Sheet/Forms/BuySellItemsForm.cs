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
    public partial class BuySellItemsForm : Form
    {
        private readonly List<string> selectedItems = new List<string>();
        private readonly List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

        public BuySellItemsForm(bool Buying)
        {
            InitializeComponent();
            if (Buying)
            {
                Sell_Button.Visible = false;
                PopulateGrid(LIB.m_ItemLibrary);
            }
            else
            {
                Text = "Sell Items";
                BuyItems_Grid.Columns[0].HeaderText = "Sell";
                Purchase_Button.Visible = false;
                PopulateGrid(LIB.m_MainCharacterInfo.Items);
            }
        }

        private void PopulateGrid(Dictionary<string, CLIB.Item> ItemDictionary)
        {
            BuyItems_Grid.Rows.Clear();
            foreach (var key in ItemDictionary.Keys)
            {
                CLIB.Item item = ItemDictionary[key];
                if (item.Cost != string.Empty)
                {
                    object[] param = { false, item.Style, key, item.Quantity, item.Cost, item.Weight + " lb.", item.Description };
                    BuyItems_Grid.Rows.Add(param);
                }
            }
        }

        private void BuyItems_Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                string style = row.Cells[LC.Type_Grid].Value.ToString();
                if (style == LC.EquipmentPack)
                {
                    PurchaseItemPack(key, quantity);
                    continue;
                }
                PurchaseItem(key, quantity);
            }
            Close();
        }

        /// <summary>
        /// This method will handle whenever a user buys an Equipment Pack
        /// </summary>
        /// <param name="key"></param>
        /// <param name="quantity"></param>
        private void PurchaseItemPack(string key, int quantity)
        {
            switch (key)
            {
                case ("Burglar's Pack"):
                    {
                        PurchaseItem("Backpack", 1 * quantity);
                        PurchaseItem("Ball Bearings (bag of 1,000)", 1 * quantity);
                        PurchaseItem("String (10 feet)", 1 * quantity);
                        PurchaseItem("Bell", 1 * quantity);
                        PurchaseItem("Candle", 5 * quantity);
                        PurchaseItem("Crowbar", 1 * quantity);
                        PurchaseItem("Hammer", 1 * quantity);
                        PurchaseItem("Piton", 10 * quantity);
                        PurchaseItem("Lantern, Hooded", 1 * quantity);
                        PurchaseItem("Oil (flask)", 2 * quantity);
                        PurchaseItem("Rations (1 day)", 5 * quantity);
                        PurchaseItem("Tinderbox", 1 * quantity);
                        PurchaseItem("Waterskin", 1 * quantity);
                        PurchaseItem("Rope, Hempen (50 feet)", 1 * quantity);
                        break;
                    }
                case ("Diplomat's Pack"):
                    {
                        PurchaseItem("Chest", 1 * quantity);
                        PurchaseItem("Case, Map or Scroll", 2 * quantity);
                        PurchaseItem("Clothes, Fine", 1 * quantity);
                        PurchaseItem("Ink (1 ounce bottle)", 1 * quantity);
                        PurchaseItem("Ink Pen", 1 * quantity);
                        PurchaseItem("Lamp", 1 * quantity);
                        PurchaseItem("Oil (flask)", 2 * quantity);
                        PurchaseItem("Paper (one sheet)", 5 * quantity);
                        PurchaseItem("Perfume (vial)", 1 * quantity);
                        PurchaseItem("Sealing Wax", 1 * quantity);
                        PurchaseItem("Soap", 1 * quantity);
                        break;
                    }
                case ("Dungeoneer's Pack"):
                    {
                        PurchaseItem("Backpack", 1 * quantity);
                        PurchaseItem("Crowbar", 1 * quantity);
                        PurchaseItem("Hammer", 1 * quantity);
                        PurchaseItem("Piton", 10 * quantity);
                        PurchaseItem("Torch", 10 * quantity);
                        PurchaseItem("Tinderbox", 1 * quantity);
                        PurchaseItem("Rations (1 day)", 10 * quantity);
                        PurchaseItem("Waterskin", 1 * quantity);
                        PurchaseItem("Rope, Hempen (50 feet)", 1 * quantity);
                        break;
                    }
                case ("Entertainer's Pack"):
                    {
                        PurchaseItem("Backpack", 1 * quantity);
                        PurchaseItem("Bedroll", 1 * quantity);
                        PurchaseItem("Clothes, Costume", 2 * quantity);
                        PurchaseItem("Candle", 5 * quantity);
                        PurchaseItem("Rations (1 day)", 5 * quantity);
                        PurchaseItem("Waterskin", 1 * quantity);
                        PurchaseItem("Disguise Kit", 1 * quantity);
                        break;
                    }
                case ("Explorer's Pack"):
                    {
                        PurchaseItem("Backpack", 1 * quantity);
                        PurchaseItem("Bedroll", 1 * quantity);
                        PurchaseItem("Mess Kit", 1 * quantity);
                        PurchaseItem("Tinderbox", 1 * quantity);
                        PurchaseItem("Torch", 10 * quantity);
                        PurchaseItem("Rations (1 day)", 10 * quantity);
                        PurchaseItem("Waterskin", 1 * quantity);
                        PurchaseItem("Rope, Hempen (50 feet)", 1 * quantity);
                        break;
                    }
                case ("Priest's Pack"):
                    {
                        PurchaseItem("Backpack", 1 * quantity);
                        PurchaseItem("Blanket", 1 * quantity);
                        PurchaseItem("Candle", 10 * quantity);
                        PurchaseItem("Tinderbox", 1 * quantity);
                        PurchaseItem("Alms Box", 1 * quantity);
                        PurchaseItem("Block of Incense", 2 * quantity);
                        PurchaseItem("Censer", 1 * quantity);
                        PurchaseItem("Vestments", 1 * quantity);
                        PurchaseItem("Rations (1 day)", 2 * quantity);
                        PurchaseItem("Waterskin", 1 * quantity);
                        break;
                    }
                case ("Scholar's Pack"):
                    {
                        PurchaseItem("Backpack", 1 * quantity);
                        PurchaseItem("Book of Lore", 1 * quantity);
                        PurchaseItem("Ink (1 ounce bottle)", 1 * quantity);
                        PurchaseItem("Ink Pen", 1 * quantity);
                        PurchaseItem("Parchment (one sheet)", 10 * quantity);
                        PurchaseItem("Little Bag of Sand", 1 * quantity);
                        PurchaseItem("Small Knife", 1 * quantity);
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// This method will handle adding an item to the users inventory
        /// or if the item already exsists will increase the quantity
        /// </summary>
        /// <param name="key"></param>
        /// <param name="quantity"></param>
        private void PurchaseItem(string key, int quantity)
        {
            if (LIB.m_MainCharacterInfo.Items.ContainsKey(key))
            {
                LIB.m_MainCharacterInfo.Items[key].Quantity += quantity;
            }
            else if (LIB.m_ItemLibrary.ContainsKey(key))
            {
                LIB.m_MainCharacterInfo.Items.Add(key, LIB.m_ItemLibrary[key]);
                LIB.m_MainCharacterInfo.Items[key].Quantity = quantity;
            }
        }

        private void Sell_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedRows)
            {
                string key = row.Cells[LC.ItemName_Grid].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells[LC.Quantity_Grid].Value.ToString());

                if (LIB.m_MainCharacterInfo.Items.ContainsKey(key))
                {
                    LIB.m_MainCharacterInfo.Items[key].Quantity -= quantity;
                    if (LIB.m_MainCharacterInfo.Items[key].Quantity <= 0)
                    {
                        LIB.m_MainCharacterInfo.Items.Remove(key);
                    }
                }
            }
            Close();
        }
    }
}
