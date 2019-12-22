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

namespace DnD_Character_Sheet
{
    /// <summary>
    /// This class contains all possible events
    /// </summary>
    public partial class CharacterInfo
    {
        /// <summary>
        /// This method handles whenever the user clicks the Load button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadCharacter characterLoader = new LoadCharacter();
            if (characterLoader.Load())
            {
                CreateMasterLibrary();
                PopulateCharacterUI();
                Character_Panel.Show();
            }
        }

        /// <summary>
        /// This is a test button for hide/show panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Character_Panel.Visible)
            {
                Character_Panel.Hide();
            }
            else
            {
                Character_Panel.Show();
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
                bonus += Library.m_MainCharacterInfo.ProficiencyBonus;
                check = true;
            }
            else if (eventArgs.NewValue == CheckState.Unchecked)
            {
                bonus -= Library.m_MainCharacterInfo.ProficiencyBonus;
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
            Library.UpdateLibrary(skillName, skillBonus, check);
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
        /// This method sets the level based on the xp the user inputs into the spin control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XP_Spin_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown xpBox = (NumericUpDown)sender;
            if (Library.m_CharacterLoaded)
            {
                Library.m_MainCharacterInfo.ExperiencePoints = (int)xpBox.Value;
                int previousLevel = Library.m_MainCharacterInfo.TotalLevel;
                int newLevel = CALC.CalcLevel();

                if (previousLevel != newLevel)
                {
                    if (Library.m_MainCharacterInfo.Multiclass)
                    {
                        // set levels correctly
                    }
                    else
                    {
                        Library.m_MainCharacterInfo.Level1 = newLevel;
                    }
                    Library.m_MainCharacterInfo.Calculate();
                    PopulateCharacterUI();
                }
            }
        }
    }
}
