using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Reflection;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DnD_Character_Sheet;
using DnD_Character_Sheet.Forms;
using LC = DnD_Character_Sheet.Constants;
using PHB_DO = DnD_Character_Sheet.Books.Player_Handbook.PHB_DataObject;
using CALC = DnD_Character_Sheet.Calculations;
using LIB = DnD_Character_Sheet.Library;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    /// <summary>
    /// This class contains all possible events
    /// </summary>
    public partial class CharacterInfo : Form
    {
        public CharacterInfo()
        {
            InitializeComponent();
            Character_Panel.Hide();
        }

        /// <summary>
        /// This method handles all button click events from the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case (LC.Load_Button):
                    {
                        LoadCharacter characterLoader = new LoadCharacter();
                        if (characterLoader.Load())
                        {
                            CreateMasterLibrary();
                            PopulateCharacterUI();
                            Character_Panel.Show();
                        }
                        break;
                    }
                case (LC.Save_Button):
                    {
                        if (LIB.m_CharacterLoaded)
                        {
                            SaveCharacter saveCharacter = new SaveCharacter();
                            saveCharacter.Save();
                        }
                        else
                        {
                            MessageBox.Show("No Character information loaded.");
                        }
                        break;
                    }
                case (LC.button1):
                    {
                        if (Character_Panel.Visible)
                        {
                            Character_Panel.Hide();
                        }
                        else
                        {
                            Character_Panel.Show();
                        }
                        break;
                    }
                case (LC.EquipBuy_Button):
                    {
                        BuySellGearForm form = new BuySellGearForm(true);
                        form.ShowDialog();
                        UpdateGrids();
                        break;
                    }
                case (LC.EquipSell_Button):
                    {
                        BuySellGearForm form = new BuySellGearForm(false);
                        form.ShowDialog();
                        UpdateGrids();
                        break;
                    }
                case (LC.ItemBuy_Button):
                    {
                        BuySellItemsForm form = new BuySellItemsForm(true);
                        form.ShowDialog();
                        UpdateGrids();
                        break;
                    }
                case (LC.ItemSell_Button):
                    {
                        BuySellItemsForm form = new BuySellItemsForm(false);
                        form.ShowDialog();
                        UpdateGrids();
                        break;
                    }
                case (LC.CurrencyExchange_Button):
                    {
                        MessageBox.Show("Will soon add a new form for the user to decide what they want to convert. " +
                            "For now all this does is convert gold to silver or silver to gold.", "Future Implimentation", MessageBoxButtons.OK);
                        if (LIB.m_MainCharacterInfo.Money.Gold != 0)
                        {
                            CLIB.Money.Convert(LC.Gold, LC.Silver, LIB.m_MainCharacterInfo.Money.Gold);
                        }
                        else if (LIB.m_MainCharacterInfo.Money.Silver != 0)
                        {
                            CLIB.Money.Convert(LC.Silver, LC.Gold, LIB.m_MainCharacterInfo.Money.Silver);
                        }
                        UpdateMoney();
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// This method handles whenever the user checks/unchecks an item from the checkbox list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckList_ItemCheck(object sender, EventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            ItemCheckEventArgs eventArgs = (ItemCheckEventArgs)e;
            if (box.SelectedIndex == -1)
            {
                return;
            }
            int bonus = int.Parse(box.SelectedItem.ToString().Split()[1]);
            string sign = box.SelectedItem.ToString().Split()[0] + " ";
            bool check = false;
            if (eventArgs.NewValue == CheckState.Checked)
            {
                bonus += LIB.m_MainCharacterInfo.ProficiencyBonus;
                check = true;
            }
            else if (eventArgs.NewValue == CheckState.Unchecked)
            {
                bonus -= LIB.m_MainCharacterInfo.ProficiencyBonus;
                check = false;
            }
            if (bonus < 0 && sign != "- ")
            {
                bonus *= -1;
                sign = "- ";
            }
            string skillBonus = sign + bonus;
            string[] numbers = new string[] { "10", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string skillName = box.SelectedItem.ToString().Split(numbers, StringSplitOptions.None)[1].Trim();


            if (box.Name == LC.Skills_CheckList)
            {
                Skills_CheckList.Items[box.SelectedIndex] = skillBonus + " " + skillName;
            }
            else if (box.Name == LC.Saves_CheckList)
            {
                Saves_CheckList.Items[box.SelectedIndex] = skillBonus + " " + skillName;
            }
            LIB.UpdateLibrary(skillName, skillBonus, check);
        }

        /// <summary>
        /// This method removes the blue highlight from the checkbox list
        /// when focus is lost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckList_LostFocus(object sender, EventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            if (box.Name == LC.Skills_CheckList)
            {
                Skills_CheckList.ClearSelected();
            }
            else if (box.Name == LC.Saves_CheckList)
            {
                Saves_CheckList.ClearSelected();
            }
        }

        /// <summary>
        /// This method handles all Spin Control Changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spin_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown spinCtrl = (NumericUpDown)sender;
            int spinValue = Convert.ToInt32(spinCtrl.Value);
            switch (spinCtrl.Name)
            {
                case (LC.XP_Spin):
                    {
                        XP_ValueChanged(spinCtrl);
                        break;
                    }
                case (LC.HitDiceRemain_Spin):
                    {
                        HitDice_ValueChanged(spinCtrl);
                        break;
                    }
                case (LC.Initiative_Spin):
                    {
                        LIB.m_MainCharacterInfo.Initiative = spinValue;
                        break;
                    }
                case (LC.HPCurrent_Spin):
                    {
                        LIB.m_MainCharacterInfo.HP_Current = spinValue;
                        break;
                    }
                case (LC.HPTemp_Spin):
                    {
                        LIB.m_MainCharacterInfo.HP_Temp = spinValue;
                        break;
                    }
                case (LC.CP_Spin):
                    {
                        LIB.m_MainCharacterInfo.Money.Copper = spinValue;
                        break;
                    }
                case (LC.SP_Spin):
                    {
                        LIB.m_MainCharacterInfo.Money.Silver = spinValue;
                        break;
                    }
                case (LC.EP_Spin):
                    {
                        LIB.m_MainCharacterInfo.Money.Electrum = spinValue;
                        break;
                    }
                case (LC.GP_Spin):
                    {
                        LIB.m_MainCharacterInfo.Money.Gold = spinValue;
                        break;
                    }
                case (LC.PP_Spin):
                    {
                        LIB.m_MainCharacterInfo.Money.Platinum = spinValue;
                        break;
                    }
                case (LC.Str_Spin):
                    {
                        LIB.m_MainCharacterInfo.Attributes.Strength = spinValue;
                        LIB.m_MainCharacterInfo.Calculate();
                        PopulateAttributes();
                        break;
                    }
                case (LC.Dex_Spin):
                    {
                        LIB.m_MainCharacterInfo.Attributes.Dexterity = spinValue;
                        LIB.m_MainCharacterInfo.Calculate();
                        PopulateAttributes();
                        break;
                    }
                case (LC.Con_Spin):
                    {
                        LIB.m_MainCharacterInfo.Attributes.Constitution = spinValue;
                        LIB.m_MainCharacterInfo.Calculate();
                        PopulateAttributes();
                        break;
                    }
                case (LC.Int_Spin):
                    {
                        LIB.m_MainCharacterInfo.Attributes.Intelligence = spinValue;
                        LIB.m_MainCharacterInfo.Calculate();
                        PopulateAttributes();
                        break;
                    }
                case (LC.Wis_Spin):
                    {
                        LIB.m_MainCharacterInfo.Attributes.Wisdom = spinValue;
                        LIB.m_MainCharacterInfo.Calculate();
                        PopulateAttributes();
                        break;
                    }
                case (LC.Cha_Spin):
                    {
                        LIB.m_MainCharacterInfo.Attributes.Charisma = spinValue;
                        LIB.m_MainCharacterInfo.Calculate();
                        PopulateAttributes();
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// This method handles all grid value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            switch (grid.Name)
            {
                case (LC.Equipment_Grid):
                    {
                        if (grid.CurrentCell != null &&
                            grid.Columns[grid.CurrentCell.ColumnIndex].HeaderText == LC.Quantity)
                        {
                            EqupimentGrid_ValueChanged(grid, 2);
                        }
                        break;
                    }
                case (LC.Item_Grid):
                    {
                        if (grid.CurrentCell != null &&
                            grid.Columns[grid.CurrentCell.ColumnIndex].HeaderText == LC.Quantity)
                        {
                            EqupimentGrid_ValueChanged(grid, 1);
                        }
                        break;
                    }
                default:
                    break;
            }

        }
    }
}
