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
        private List<string> selectedItems = new List<string>();
        private List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

        public BuySellGearForm()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            BuyEquipment_Grid.Rows.Clear();
            foreach (var key in LIB.m_ArmorLibrary.Keys)
            {
                CLIB.Armor_Class armor = LIB.m_ArmorLibrary[key];
                string properties = "Strength Required: " + armor.StrengthReq + Environment.NewLine + "Stealth Disadvantage: " + armor.Disadvantage;
                object[] param = { armor.Equipped, armor.Style, key, armor.Quantity, armor.Cost, string.Empty, armor.ArmorClass, armor.Weight + " lb.", properties };
                BuyEquipment_Grid.Rows.Add(param);
            }
            foreach (var key in LIB.m_WeaponLibrary.Keys)
            {
                CLIB.Weapon_Class weapon = LIB.m_WeaponLibrary[key];
                string properties = string.Join(", ", weapon.Properties.ToArray());
                object[] param = { weapon.Equipped, weapon.Style, key, weapon.Quantity, weapon.Cost, weapon.Damage, string.Empty, weapon.Weight + " lb.", properties };
                BuyEquipment_Grid.Rows.Add(param);
            }

        }

        private void BuyEquipment_Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridView grid = (DataGridView)sender;
                DataGridViewRow row = grid.Rows[e.RowIndex];
                string selectedItem = row.Cells["Name_Buy"].Value.ToString();
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
                string key = row.Cells["Name_Buy"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity_Buy"].Value.ToString());
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
                string style = row.Cells["Type_Buy"].Value.ToString();
                string cost = row.Cells["Cost_Buy"].Value.ToString();
                string armorClass = row.Cells["Armorclass_Buy"].Value.ToString();
                string damage = row.Cells["Damage_Buy"].Value.ToString();
                int weight = Convert.ToInt32(row.Cells["Weight_Buy"].Value.ToString().Split()[0]);

                switch (style)
                {
                    case (LC.LightArmor):
                    case (LC.MediumArmor):
                    case (LC.HeavyArmor):
                    case (LC.Shield):
                        {
                            string[] properties = row.Cells["Properties_Buy"].Value.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            int strengthReq = Convert.ToInt32(properties[0].Split(':')[1]);
                            bool disadvantage = Convert.ToBoolean(properties[1].Split(':')[1]);

                            LIB.m_MainCharacterInfo.Armor.Add(key,
                                new CLIB.Armor_Class
                                {
                                    Style = style,
                                    Cost = cost,
                                    ArmorClass = armorClass,
                                    StrengthReq = strengthReq,
                                    Disadvantage = disadvantage,
                                    Weight = weight,
                                    Quantity = quantity
                                });
                            break;
                        }
                    case (LC.MeleeSimple):
                    case (LC.MeleeMartial):
                    case (LC.RangedSimple):
                    case (LC.RangedMartial):
                        {
                            string[] properties = row.Cells["Properties_Buy"].Value.ToString().Split(',');
                            foreach (string property in properties)
                            {
                                property.Trim();
                            }

                            LIB.m_MainCharacterInfo.Weapons.Add(key,
                                new CLIB.Weapon_Class
                                {
                                    Style = style,
                                    Cost = cost,
                                    Damage = damage,
                                    Weight = weight,
                                    Properties = properties.ToList(),
                                    Quantity = quantity
                                });
                            break;
                        }
                    default:
                        break;
                }
            }
            Close();
        }
    }
}
