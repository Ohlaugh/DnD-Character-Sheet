using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DnD_Character_Sheet;
using LC = DnD_Character_Sheet.Constants;
using PHB_DO = DnD_Character_Sheet.Books.Player_Handbook.PHB_DataObject;
using CALC = DnD_Character_Sheet.Calculations;
using LIB = DnD_Character_Sheet.Library;

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
                case (LC.LoadButton):
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


            if (box.Name == LC.SkillsCheckList)
            {
                Skills_CheckList.Items[box.SelectedIndex] = skillBonus + " " + skillName;
            }
            else if (box.Name == LC.SavesCheckList)
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
            if (box.Name == LC.SkillsCheckList)
            {
                Skills_CheckList.ClearSelected();
            }
            else if (box.Name == LC.SavesCheckList)
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
                        LIB.m_MainCharacterInfo.Initiative = Convert.ToInt32(spinCtrl.Value);
                        break;
                    }
                case (LC.HPCurrent_Spin):
                    {
                        LIB.m_MainCharacterInfo.HP_Current = Convert.ToInt32(spinCtrl.Value);
                        break;
                    }
                case (LC.HPTemp_Spin):
                    {
                        LIB.m_MainCharacterInfo.HP_Temp = Convert.ToInt32(spinCtrl.Value);
                        break;
                    }
                default:
                    break;
            }

        }
    }
}
