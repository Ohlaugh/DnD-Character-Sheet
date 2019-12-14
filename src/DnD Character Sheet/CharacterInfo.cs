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
using PHBDO = DnD_Character_Sheet.Player_Handbook.PHB_DataObject;

namespace DnD_Character_Sheet
{
    public partial class CharacterInfo : Form
    {

        public List<string> m_Classes = new List<string>();

        public CharacterInfo()
        {
            InitializeComponent();
        }

        private void CreateMasterList()
        {
            bool result = Library.m_BookUtilization[LC.Using_PHB];
            if (result)
            {
                PHBDO.AddRaces();
                PHBDO.AddArmor();
                PHBDO.AddWeapons();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadCharacter characterLoader = new LoadCharacter();
            if (characterLoader.Load())
            {
                CreateMasterList();
                Reload();
            }
        }

        private void Reload()
        {
            PopulateCharacterUI();
            UpdateSkillsList();
            UpdateSavesList();
        }

        private void PopulateCharacterUI()
        {
            CharName_TextBox.Text = Library.m_MainCharacterInfo.CharacterName;
            Class_TextBox.Text = Library.m_MainCharacterInfo.Class;
            Level_TextBox.Text = Library.m_MainCharacterInfo.Level.ToString();
            Race_TextBox.Text = Library.m_MainCharacterInfo.Race;
            Subrace_TextBox.Text = Library.m_MainCharacterInfo.Subrace;
            Background_TextBox.Text = Library.m_MainCharacterInfo.Background;
            Alignment_TextBox.Text = Library.m_MainCharacterInfo.Alignment;
            PlayerName_TextBox.Text = Library.m_MainCharacterInfo.PlayerName;
            XP_Spin.Value = Library.m_MainCharacterInfo.ExperiencePoints;

            Str_TextBox.Text = Library.m_MainCharacterInfo.Attributes.Strength.ToString();
            StrMod_Label.Text = Library.m_MainCharacterInfo.Attributes.StrengthModifier.ToString();
            StrSign_Label.Text = Library.m_MainCharacterInfo.Attributes.StrengthSign;

            Dex_TextBox.Text = Library.m_MainCharacterInfo.Attributes.Dexterity.ToString();
            DexMod_Label.Text = Library.m_MainCharacterInfo.Attributes.DexterityModifier.ToString();
            DexSign_Label.Text = Library.m_MainCharacterInfo.Attributes.DexteritySign;

            Con_TextBox.Text = Library.m_MainCharacterInfo.Attributes.Constitution.ToString();
            ConMod_Label.Text = Library.m_MainCharacterInfo.Attributes.ConstitutionModifier.ToString();
            ConSign_Label.Text = Library.m_MainCharacterInfo.Attributes.ConstitutionSign;

            Int_TextBox.Text = Library.m_MainCharacterInfo.Attributes.Intelligence.ToString();
            IntMod_Label.Text = Library.m_MainCharacterInfo.Attributes.IntelligenceModifier.ToString();
            IntSign_Label.Text = Library.m_MainCharacterInfo.Attributes.IntelligenceSign;

            Wis_TextBox.Text = Library.m_MainCharacterInfo.Attributes.Wisdom.ToString();
            WisMod_Label.Text = Library.m_MainCharacterInfo.Attributes.WisdomModifier.ToString();
            WisSign_Label.Text = Library.m_MainCharacterInfo.Attributes.WisdomSign;

            Cha_TextBox.Text = Library.m_MainCharacterInfo.Attributes.Charisma.ToString();
            ChaMod_Label.Text = Library.m_MainCharacterInfo.Attributes.CharismaModifier.ToString();
            ChaSign_Label.Text = Library.m_MainCharacterInfo.Attributes.CharismaSign;

            ProfBonus_TextBox.Text = Library.m_MainCharacterInfo.ProficiencyBonus.ToString();

            textBox5.Text +=
                "Age = " + Library.m_MainCharacterInfo.Age + Environment.NewLine +
                "Height = " + Library.m_MainCharacterInfo.Height + Environment.NewLine +
                "Weight = " + Library.m_MainCharacterInfo.Weight + Environment.NewLine +
                "Eye Color = " + Library.m_MainCharacterInfo.EyeColor + Environment.NewLine +
                "Skin Color = " + Library.m_MainCharacterInfo.SkinColor + Environment.NewLine +
                "Hair Color = " + Library.m_MainCharacterInfo.HairColor + Environment.NewLine +

                "Inspiration = " + Library.m_MainCharacterInfo.Inspiration + Environment.NewLine +

                "Perception = " + Library.m_MainCharacterInfo.Perception + Environment.NewLine +
                "ArmorClass = " + Library.m_MainCharacterInfo.ArmorClass + Environment.NewLine +
                "Initiative = " + Library.m_MainCharacterInfo.Initiative + Environment.NewLine +
                "Speed = " + Library.m_MainCharacterInfo.Speed + Environment.NewLine +
                "HP_Max = " + Library.m_MainCharacterInfo.HP_Max + Environment.NewLine +
                "HP_Current = " + Library.m_MainCharacterInfo.HP_Current + Environment.NewLine +
                "HP_Temp = " + Library.m_MainCharacterInfo.HP_Temp + Environment.NewLine +
                "HitDice = " + Library.m_MainCharacterInfo.Age + Environment.NewLine +
                "HitDiceTotal = " + Library.m_MainCharacterInfo.HitDiceTotal + Environment.NewLine +

                "Copper = " + Library.m_MainCharacterInfo.Money.Copper + Environment.NewLine +
                "Silver = " + Library.m_MainCharacterInfo.Money.Silver + Environment.NewLine +
                "Electrum = " + Library.m_MainCharacterInfo.Money.Electrum + Environment.NewLine +
                "Gold = " + Library.m_MainCharacterInfo.Money.Gold + Environment.NewLine +
                "Platinum = " + Library.m_MainCharacterInfo.Money.Platinum + Environment.NewLine +

                "PersonalityTraits = " + Library.m_MainCharacterInfo.PersonalityTraits + Environment.NewLine + Environment.NewLine +
                "Ideals = " + Library.m_MainCharacterInfo.Ideals + Environment.NewLine + Environment.NewLine +
                "Bonds = " + Library.m_MainCharacterInfo.Bonds + Environment.NewLine + Environment.NewLine +
                "Flaws = " + Library.m_MainCharacterInfo.Flaws + Environment.NewLine + Environment.NewLine;
        }

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

        private void UpdateSkillsList()
        {
            Skills_CheckList.Items.Clear();
            List<Tuple<string, bool>> skills = Library.m_MainCharacterInfo.GetSkills();
            foreach (Tuple<string, bool> skill in skills)
            {
                Skills_CheckList.Items.Add(skill.Item1, skill.Item2);
            }
        }

        private void UpdateSavesList()
        {
            Saves_CheckList.Items.Clear();
            List<Tuple<string, bool>> saves = Library.m_MainCharacterInfo.GetSaves();

            foreach (Tuple<string, bool> save in saves)
            {
                Saves_CheckList.Items.Add(save.Item1, save.Item2);
            }
        }

        private void Skills_CheckList_ItemCheck(object sender, EventArgs e)
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

            Skills_CheckList.Items[box.SelectedIndex] = skillBonus + " " + skillName;
            Library.UpdateLibrary(skillName, skillBonus, check);
        }

        private void Skills_CheckList_LostFocus(object sender, EventArgs e)
        {
            Skills_CheckList.ClearSelected();
        }

        private void XP_Spin_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown xpBox = (NumericUpDown)sender;
            if (Library.m_CharacterLoaded)
            {
                Library.m_MainCharacterInfo.ExperiencePoints = (int)xpBox.Value;
                int previousLevel = Library.m_MainCharacterInfo.Level;
                Library.m_MainCharacterInfo.Calculate();
                int newLevel = Library.m_MainCharacterInfo.Level;
                if (previousLevel != newLevel)
                {
                    Reload();
                }
            }
        }
    }
}
