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
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    /// <summary>
    /// This class contains all helper methods for the UI Events
    /// </summary>
    public partial class CharacterInfo
    {
        #region Private Helper Methods

        /// <summary>
        /// This method creates the master library of Races, Armor and Weapons
        /// based on which books the user has selected
        /// </summary>
        private void CreateMasterLibrary()
        {
            if (LIB.m_BookUtilization[LC.Using_PlayerHB])
            {
                PHB_DO.AddData();
            }
            if (LIB.m_BookUtilization[LC.Using_Xanathar])
            {

            }
        }

        /// <summary>
        /// This method populates every UI Element with the loaded character information
        /// </summary>
        private void PopulateCharacterUI()
        {
            CharName_TextBox.Text = LIB.m_MainCharacterInfo.CharacterName;
            if (LIB.m_MainCharacterInfo.Multiclass)
            {
                Class_TextBox.Text = LIB.m_MainCharacterInfo.Class1 + " / " + LIB.m_MainCharacterInfo.Class2;
                Level_TextBox.Text = LIB.m_MainCharacterInfo.Level1 + " / " + LIB.m_MainCharacterInfo.Level2;
                SubClass_TextBox.Text = LIB.m_MainCharacterInfo.SubClass1 + " / " + LIB.m_MainCharacterInfo.SubClass2;
                if (LIB.m_MainCharacterInfo.HitDice1 == LIB.m_MainCharacterInfo.HitDice2)
                {
                    DiceType_TextBox.Text = LIB.m_MainCharacterInfo.HitDice1;
                }
                else
                {
                    DiceType_TextBox.Text = LIB.m_MainCharacterInfo.HitDice1 + " / " + LIB.m_MainCharacterInfo.HitDice2;
                }
            }
            else
            {
                Class_TextBox.Text = LIB.m_MainCharacterInfo.Class1;
                Level_TextBox.Text = LIB.m_MainCharacterInfo.TotalLevel.ToString();
                SubClass_TextBox.Text = LIB.m_MainCharacterInfo.SubClass1;
                DiceType_TextBox.Text = LIB.m_MainCharacterInfo.HitDice1;
            }
            Race_TextBox.Text = LIB.m_MainCharacterInfo.Race;
            Subrace_TextBox.Text = LIB.m_MainCharacterInfo.Subrace;
            Background_TextBox.Text = LIB.m_MainCharacterInfo.Background;
            Alignment_TextBox.Text = LIB.m_MainCharacterInfo.Alignment;
            PlayerName_TextBox.Text = LIB.m_MainCharacterInfo.PlayerName;
            XP_Spin.Value = LIB.m_MainCharacterInfo.ExperiencePoints;

            Str_Spin.Value = LIB.m_MainCharacterInfo.Attributes.Strength;
            StrMod_Label.Text = LIB.m_MainCharacterInfo.Attributes.StrengthModifier.ToString();
            StrSign_Label.Text = LIB.m_MainCharacterInfo.Attributes.StrengthSign;

            Dex_Spin.Value = LIB.m_MainCharacterInfo.Attributes.Dexterity;
            DexMod_Label.Text = LIB.m_MainCharacterInfo.Attributes.DexterityModifier.ToString();
            DexSign_Label.Text = LIB.m_MainCharacterInfo.Attributes.DexteritySign;

            Con_Spin.Value = LIB.m_MainCharacterInfo.Attributes.Constitution;
            ConMod_Label.Text = LIB.m_MainCharacterInfo.Attributes.ConstitutionModifier.ToString();
            ConSign_Label.Text = LIB.m_MainCharacterInfo.Attributes.ConstitutionSign;

            Int_Spin.Value = LIB.m_MainCharacterInfo.Attributes.Intelligence;
            IntMod_Label.Text = LIB.m_MainCharacterInfo.Attributes.IntelligenceModifier.ToString();
            IntSign_Label.Text = LIB.m_MainCharacterInfo.Attributes.IntelligenceSign;

            Wis_Spin.Value = LIB.m_MainCharacterInfo.Attributes.Wisdom;
            WisMod_Label.Text = LIB.m_MainCharacterInfo.Attributes.WisdomModifier.ToString();
            WisSign_Label.Text = LIB.m_MainCharacterInfo.Attributes.WisdomSign;

            Cha_Spin.Value = LIB.m_MainCharacterInfo.Attributes.Charisma;
            ChaMod_Label.Text = LIB.m_MainCharacterInfo.Attributes.CharismaModifier.ToString();
            ChaSign_Label.Text = LIB.m_MainCharacterInfo.Attributes.CharismaSign;

            ProfBonus_Label.Text = LIB.m_MainCharacterInfo.ProficiencyBonus.ToString();
            Inspiration_CheckBox.Checked = LIB.m_MainCharacterInfo.Inspiration;
            Perception_Label.Text = LIB.m_MainCharacterInfo.Perception.ToString();

            Age_TextBox.Text = LIB.m_MainCharacterInfo.Age.ToString();
            Height_TextBox.Text = LIB.m_MainCharacterInfo.Height;
            Weight_TextBox.Text = LIB.m_MainCharacterInfo.Weight.ToString();
            Eye_TextBox.Text = LIB.m_MainCharacterInfo.EyeColor;
            Skin_TextBox.Text = LIB.m_MainCharacterInfo.SkinColor;
            Hair_TextBox.Text = LIB.m_MainCharacterInfo.HairColor;

            AC_TextBox.Text = LIB.m_MainCharacterInfo.ArmorClass.ToString();
            Initiative_Spin.Value = LIB.m_MainCharacterInfo.Initiative;
            Speed_TextBox.Text = LIB.m_MainCharacterInfo.Speed.ToString();
            HPMax_TextBox.Text = LIB.m_MainCharacterInfo.HP_Max.ToString();
            HPCurrent_Spin.Maximum = LIB.m_MainCharacterInfo.HP_Max;
            HPCurrent_Spin.Value = LIB.m_MainCharacterInfo.HP_Current;
            HPTemp_Spin.Value = LIB.m_MainCharacterInfo.HP_Temp;
            HitDiceRemain_Spin.Maximum = LIB.m_MainCharacterInfo.TotalLevel;
            HitDiceRemain_Spin.Value = LIB.m_MainCharacterInfo.HitDiceTotal1 + LIB.m_MainCharacterInfo.HitDiceTotal2;

            Info_TextBox.Text =
                "Personality Traits = " + LIB.m_MainCharacterInfo.PersonalityTraits + Environment.NewLine + Environment.NewLine +
                "Ideals = " + LIB.m_MainCharacterInfo.Ideals + Environment.NewLine + Environment.NewLine +
                "Bonds = " + LIB.m_MainCharacterInfo.Bonds + Environment.NewLine + Environment.NewLine +
                "Flaws = " + LIB.m_MainCharacterInfo.Flaws + Environment.NewLine + Environment.NewLine;

            Backstory_TextBox.Text = LIB.m_MainCharacterInfo.Backstory;

            UpdateMoney();
            UpdateLists();
            UpdateGrids();
            Carry_TextBox.Text = LIB.m_MainCharacterInfo.CarryingWeight + " / " + LIB.m_MainCharacterInfo.CarryingCapacity + " lb.";
        }

        /// <summary>
        /// This method updates the Money Numeric spin controls
        /// </summary>
        private void UpdateMoney()
        {

            CP_Spin.Value = LIB.m_MainCharacterInfo.Money.Copper;
            SP_Spin.Value = LIB.m_MainCharacterInfo.Money.Silver;
            EP_Spin.Value = LIB.m_MainCharacterInfo.Money.Electrum;
            GP_Spin.Value = LIB.m_MainCharacterInfo.Money.Gold;
            PP_Spin.Value = LIB.m_MainCharacterInfo.Money.Platinum;
        }

        /// <summary>
        /// This method updates the Skills/Saves checkbox lists
        /// </summary>
        private void UpdateLists()
        {
            Skills_CheckList.Items.Clear();
            List<Tuple<string, bool>> skills = LIB.m_MainCharacterInfo.GetSkills();
            foreach (Tuple<string, bool> skill in skills)
            {
                Skills_CheckList.Items.Add(skill.Item1, skill.Item2);
            }

            Saves_CheckList.Items.Clear();
            List<Tuple<string, bool>> saves = LIB.m_MainCharacterInfo.GetSaves();

            foreach (Tuple<string, bool> save in saves)
            {
                Saves_CheckList.Items.Add(save.Item1, save.Item2);
            }
        }

        /// <summary>
        /// This Method updates the Equipment and Items Grids
        /// </summary>
        private void UpdateGrids()
        {
            Item_Grid.Rows.Clear();
            Equipment_Grid.Rows.Clear();
            foreach (var key in LIB.m_MainCharacterInfo.Item_List)
            {
                CLIB.Item_Class item = LIB.m_MainCharacterInfo.Items[key];
                object[] param = { key, item.Cost, item.Weight + " lb.", item.Description };
                LIB.m_MainCharacterInfo.CarryingWeight += item.Weight;
                Item_Grid.Rows.Add(param);
            }

            foreach (var key in LIB.m_MainCharacterInfo.Weapon_List)
            {
                CLIB.Weapon_Class weapon = LIB.m_MainCharacterInfo.Weapons[key];

                string properties = string.Join(", ", weapon.Properties.ToArray());

                object[] param = { weapon.Equipped, "Weapon", key, weapon.Cost, weapon.Damage, string.Empty, weapon.Weight + " lb.", properties };
                LIB.m_MainCharacterInfo.CarryingWeight += weapon.Weight;
                Equipment_Grid.Rows.Add(param);
            }

            foreach (var key in LIB.m_MainCharacterInfo.Armor_List)
            {
                CLIB.Armor_Class armor = LIB.m_MainCharacterInfo.Armor[key];
                string properties = "Strength Required: " + armor.StrengthReq + Environment.NewLine + "Stealth Disadvantage: " + armor.Disadvantage;
                object[] param = { armor.Equipped, "Armor", key, armor.Cost, string.Empty, armor.ArmorClass, armor.Weight + " lb.", properties };
                LIB.m_MainCharacterInfo.CarryingWeight += armor.Weight;
                Equipment_Grid.Rows.Add(param);
            }
        }

        #endregion

        #region UI Events

        /// <summary>
        /// This method sets the level based on the xp the user inputs into the spin control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XP_ValueChanged(NumericUpDown xpSpin)
        {
            if (LIB.m_CharacterLoaded)
            {
                int oldXP = LIB.m_MainCharacterInfo.ExperiencePoints;
                int oldLevel1 = LIB.m_MainCharacterInfo.Level1;
                int oldLevel2 = LIB.m_MainCharacterInfo.Level2;
                int oldTotalLevel = LIB.m_MainCharacterInfo.TotalLevel;
                int oldHitDice1 = LIB.m_MainCharacterInfo.HitDiceTotal1;
                int oldHitDice2 = LIB.m_MainCharacterInfo.HitDiceTotal2;

                LIB.m_MainCharacterInfo.ExperiencePoints = (int)xpSpin.Value;
                int newTotalLevel = CALC.CalcLevel();
                if (oldTotalLevel > newTotalLevel)
                {
                    XP_Spin.Value = oldXP;
                    LIB.m_MainCharacterInfo.ExperiencePoints = oldXP;
                    return;
                }
                if (oldTotalLevel != newTotalLevel)
                {
                    for (; oldTotalLevel < newTotalLevel; oldTotalLevel++)
                    {
                        if (LIB.m_MainCharacterInfo.Multiclass)
                        {
                            MulticlassLevelUpForm multiclassLevelUpForm = new MulticlassLevelUpForm(
                            LIB.m_MainCharacterInfo.Class1,
                            LIB.m_MainCharacterInfo.Class2,
                            LIB.m_MainCharacterInfo.Level1,
                            LIB.m_MainCharacterInfo.Level2);

                            var result = multiclassLevelUpForm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                string value = multiclassLevelUpForm.ClassSelection;
                                if (value == "Class1")
                                {
                                    LIB.m_MainCharacterInfo.Level1 += 1;
                                    LIB.m_MainCharacterInfo.HitDiceTotal1 = LIB.m_MainCharacterInfo.Level1;
                                    MessageBox.Show("Will soon add a new form for level up.", "Future Implimentation", MessageBoxButtons.OK);
                                    // Need to show level up for Class 1
                                }
                                else
                                {
                                    LIB.m_MainCharacterInfo.Level2 += 1;
                                    LIB.m_MainCharacterInfo.HitDiceTotal2 = LIB.m_MainCharacterInfo.Level2;
                                    MessageBox.Show("Will soon add a new form for level up.", "Future Implimentation", MessageBoxButtons.OK);
                                    // Need to show level up for Class 2
                                }
                            }
                            else
                            {
                                // User has canceled the level up, therefore need to reset to previous levels
                                LIB.m_MainCharacterInfo.ExperiencePoints = oldXP;
                                LIB.m_MainCharacterInfo.Level1 = oldLevel1;
                                LIB.m_MainCharacterInfo.Level2 = oldLevel2;
                                LIB.m_MainCharacterInfo.HitDiceTotal1 = oldHitDice1;
                                LIB.m_MainCharacterInfo.HitDiceTotal2 = oldHitDice2;
                                break;
                            }
                        }
                        else
                        {
                            // Need to show level up for Class 1
                            var result = MessageBox.Show("Congrats on level: " + (oldTotalLevel + 1), "Level UP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.Cancel)
                            {
                                LIB.m_MainCharacterInfo.ExperiencePoints = oldXP;
                                LIB.m_MainCharacterInfo.Level1 = oldLevel1;
                                LIB.m_MainCharacterInfo.HitDiceTotal1 = oldHitDice1;
                                break;
                            }
                            MessageBox.Show("Will soon add a new form for level up instead of the previous message box.", "Future Implimentation", MessageBoxButtons.OK);
                            LIB.m_MainCharacterInfo.HitDiceTotal1 += 1;
                            LIB.m_MainCharacterInfo.Level1 += 1;
                        }
                    }
                    LIB.m_MainCharacterInfo.Calculate();
                    PopulateCharacterUI();
                }
            }
        }

        /// <summary>
        /// This method shows a window for increasing health based on the number of hit dice spent
        /// </summary>
        /// <param name="hitDiceSpin"></param>
        private void HitDice_ValueChanged(NumericUpDown hitDiceSpin)
        {
            int oldTotal = LIB.m_MainCharacterInfo.HitDiceTotal1;
            int newTotal = Convert.ToInt32(hitDiceSpin.Value);
            if (oldTotal != newTotal)
            {
                if (oldTotal > newTotal)
                {
                    int maxHP = LIB.m_MainCharacterInfo.HP_Max;
                    for (; newTotal < oldTotal; newTotal++)
                    {
                        var result = MessageBox.Show("Please roll a " + LIB.m_MainCharacterInfo.HitDice1 + " and record the value below.", "Roll Hit Dice", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            LIB.m_MainCharacterInfo.HitDiceTotal1 -= 1;
                        }
                        else
                        {
                            HitDiceRemain_Spin.Value = oldTotal;
                            LIB.m_MainCharacterInfo.HitDiceTotal1 = oldTotal;
                            break;
                        }
                    }
                }
                else
                {
                    LIB.m_MainCharacterInfo.HitDiceTotal1 = newTotal;
                }
            }
        }

        #endregion
    }
}
