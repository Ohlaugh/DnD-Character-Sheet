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
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    /// <summary>
    /// This class contains all helper methods for the UIEventHandler
    /// </summary>
    public partial class CharacterInfo : Form
    {
        public CharacterInfo()
        {
            InitializeComponent();
            Character_Panel.Hide();
        }

        /// <summary>
        /// This method creates the master library of Races, Armor and Weapons
        /// based on which books the user has selected
        /// </summary>
        private void CreateMasterLibrary()
        {
            if (Library.m_BookUtilization[LC.Using_PlayerHB])
            {
                PHB_DO.AddData();
            }
            if (Library.m_BookUtilization[LC.Using_Xanathar])
            {

            }
        }

        /// <summary>
        /// This method populates every UI Element with the loaded character information
        /// </summary>
        private void PopulateCharacterUI()
        {
            CharName_TextBox.Text = Library.m_MainCharacterInfo.CharacterName;
            if (Library.m_MainCharacterInfo.Multiclass)
            {
                Class_TextBox.Text = Library.m_MainCharacterInfo.Class1 + " / " + Library.m_MainCharacterInfo.Class2;
                Level_TextBox.Text = Library.m_MainCharacterInfo.Level1 + " / " + Library.m_MainCharacterInfo.Level2;
            }
            else
            {
                Class_TextBox.Text = Library.m_MainCharacterInfo.Class1;
                Level_TextBox.Text = Library.m_MainCharacterInfo.TotalLevel.ToString();
            }
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

            ProfBonus_Label.Text = Library.m_MainCharacterInfo.ProficiencyBonus.ToString();
            Inspiration_CheckBox.Checked = Library.m_MainCharacterInfo.Inspiration;
            Perception_Label.Text = Library.m_MainCharacterInfo.Perception.ToString();

            Age_TextBox.Text = Library.m_MainCharacterInfo.Age.ToString();
            Height_TextBox.Text = Library.m_MainCharacterInfo.Height;
            Weight_TextBox.Text = Library.m_MainCharacterInfo.Weight.ToString();
            Eye_TextBox.Text = Library.m_MainCharacterInfo.EyeColor;
            Skin_TextBox.Text = Library.m_MainCharacterInfo.SkinColor;
            Hair_TextBox.Text = Library.m_MainCharacterInfo.HairColor;

            AC_TextBox.Text = Library.m_MainCharacterInfo.ArmorClass.ToString();
            Initiative_Spin.Value = Library.m_MainCharacterInfo.Initiative;
            Speed_TextBox.Text = Library.m_MainCharacterInfo.Speed.ToString();
            HPMax_TextBox.Text = Library.m_MainCharacterInfo.HP_Max.ToString();
            HPCurrent_Spin.Value = Library.m_MainCharacterInfo.HP_Current;
            HPCurrent_Spin.Maximum = Library.m_MainCharacterInfo.HP_Max;
            HPTemp_Spin.Value = Library.m_MainCharacterInfo.HP_Temp;
            HitDiceRemain_Spin.Value = Library.m_MainCharacterInfo.HitDiceTotal;
            DiceType_TextBox.Text = Library.m_MainCharacterInfo.HitDice;

            Info_TextBox.Text =
                "Personality Traits = " + Library.m_MainCharacterInfo.PersonalityTraits + Environment.NewLine + Environment.NewLine +
                "Ideals = " + Library.m_MainCharacterInfo.Ideals + Environment.NewLine + Environment.NewLine +
                "Bonds = " + Library.m_MainCharacterInfo.Bonds + Environment.NewLine + Environment.NewLine +
                "Flaws = " + Library.m_MainCharacterInfo.Flaws + Environment.NewLine + Environment.NewLine;

            Backstory_TextBox.Text = Library.m_MainCharacterInfo.Backstory;

            CP_Spin.Value = Library.m_MainCharacterInfo.Money.Copper;
            SP_Spin.Value = Library.m_MainCharacterInfo.Money.Silver;
            EP_Spin.Value = Library.m_MainCharacterInfo.Money.Electrum;
            GP_Spin.Value = Library.m_MainCharacterInfo.Money.Gold;
            PP_Spin.Value = Library.m_MainCharacterInfo.Money.Platinum;

            UpdateLists();
            UpdateGrids();
        }

        /// <summary>
        /// This Method updates the Equipment and Items Grids
        /// </summary>
        private void UpdateGrids()
        {
            Item_Grid.Rows.Clear();
            Equipment_Grid.Rows.Clear();
            foreach (var key in Library.m_MainCharacterInfo.Item_List)
            {
                CLIB.Item_Class item = Library.m_MainCharacterInfo.Items[key];
                object[] param = { key, item.Cost, item.Weight, item.Description };
                Item_Grid.Rows.Add(param);
            }

            foreach (var key in Library.m_MainCharacterInfo.Weapon_List)
            {
                CLIB.Weapon_Class weapon = Library.m_MainCharacterInfo.Weapons[key];

                string properties = string.Join(", ", weapon.Properties.ToArray());

                object[] param = { weapon.Equipped, "Weapon", key, weapon.Cost, weapon.Damage, string.Empty, weapon.Weight + " lb.", properties };
                Equipment_Grid.Rows.Add(param);
            }

            foreach (var key in Library.m_MainCharacterInfo.Armor_List)
            {
                CLIB.Armor_Class armor = Library.m_MainCharacterInfo.Armor[key];
                string properties = "Strength Required: " + armor.StrengthReq + Environment.NewLine + "Stealth Disadvantage: " + armor.Disadvantage;
                object[] param = { armor.Equipped, "Armor", key, armor.Cost, string.Empty, armor.ArmorClass, armor.Weight + " lb.", properties };
                Equipment_Grid.Rows.Add(param);
            }
        }

        /// <summary>
        /// This method updates the Skills/Saves checkbox lists
        /// </summary>
        private void UpdateLists()
        {
            Skills_CheckList.Items.Clear();
            List<Tuple<string, bool>> skills = Library.m_MainCharacterInfo.GetSkills();
            foreach (Tuple<string, bool> skill in skills)
            {
                Skills_CheckList.Items.Add(skill.Item1, skill.Item2);
            }

            Saves_CheckList.Items.Clear();
            List<Tuple<string, bool>> saves = Library.m_MainCharacterInfo.GetSaves();

            foreach (Tuple<string, bool> save in saves)
            {
                Saves_CheckList.Items.Add(save.Item1, save.Item2);
            }
        }
    }
}
