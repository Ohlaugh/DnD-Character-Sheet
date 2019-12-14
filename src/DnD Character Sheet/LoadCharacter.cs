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

namespace DnD_Character_Sheet
{
    class LoadCharacter : Library
    {
        public bool Load()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "DnD Character Files (*.DnD)|*.DnD";
            var result = fileDialog.ShowDialog();

            XmlDocument xDoc = new XmlDocument();
            string filePath = fileDialog.FileName;
            if (result == DialogResult.OK)
            {
                FileStream stream = new FileStream(filePath, FileMode.Open);
                xDoc.Load(stream);
                ClearLibrary();
                m_CharacterName = xDoc.GetElementsByTagName("CharacterSheet")[0].Attributes[0].Value;

                PopulateCharData(xDoc);
                PopulateProfData(xDoc);
                PopulateBookData(xDoc);
                stream.Close();
                PopulateCharacterInformation();
                m_CharacterLoaded = true;
                return true;
            }
            return false;
        }

        private void PopulateCharData(XmlDocument xDoc)
        {
            m_CharData.Add(m_CharacterName, new Dictionary<string, string>());

            XmlNodeList dataNodeList = xDoc.GetElementsByTagName("Data");
            foreach (XmlNode dataNode in dataNodeList)
            {
                string key = dataNode.SelectSingleNode("Key").InnerText;
                string value = dataNode.SelectSingleNode("Value").InnerText;
                m_CharData[m_CharacterName].Add(key, value);
            }
        }

        private void PopulateProfData(XmlDocument xDoc)
        {
            m_ProficientData.Add(m_CharacterName, new Dictionary<string, bool>());
            XmlNodeList proficientNodeList = xDoc.GetElementsByTagName("Proficient");
            foreach (XmlNode profNode in proficientNodeList)
            {
                string key = profNode.SelectSingleNode("Key").InnerText;
                bool value = Convert.ToBoolean(profNode.SelectSingleNode("Value").InnerText);
                m_ProficientData[m_CharacterName].Add(key, value);
            }
        }

        private void PopulateBookData(XmlDocument xDoc)
        {
            XmlNodeList bookNodeList = xDoc.GetElementsByTagName("Book");
            foreach (XmlNode bookNode in bookNodeList)
            {
                string key = bookNode.SelectSingleNode("Key").InnerText;
                bool value = Convert.ToBoolean(bookNode.SelectSingleNode("Value").InnerText);
                m_BookUtilization.Add(key, value);
            }
        }

        private void PopulateCharacterInformation()
        {
            Dictionary<string, string> characterInfo = m_CharData[m_CharacterName];
            Dictionary<string, bool> proficiencyInfo = m_ProficientData[m_CharacterName];

            m_MainCharacterInfo = new MainCharacterInfo
            {
                // Top Level Info
                CharacterName = m_CharacterName,
                Class = characterInfo[LC.Class],
                Background = characterInfo[LC.Background],
                PlayerName = characterInfo[LC.PlayerName],
                Race = characterInfo[LC.Race],
                Subrace = characterInfo[LC.Subrace],
                Alignment = characterInfo[LC.Alignment],
                ExperiencePoints = Convert.ToInt32(characterInfo[LC.ExperiencePoints]),
                Age = Convert.ToInt32(characterInfo[LC.Age]),
                Height = characterInfo[LC.Height],
                Weight = Convert.ToInt32(characterInfo[LC.Weight]),
                EyeColor = characterInfo[LC.EyeColor],
                SkinColor = characterInfo[LC.SkinColor],
                HairColor = characterInfo[LC.HairColor],

                // Left Column Info
                Attributes = new Attributes
                {
                    Strength = Convert.ToInt32(characterInfo[LC.Strength]),
                    Dexterity = Convert.ToInt32(characterInfo[LC.Dexterity]),
                    Constitution = Convert.ToInt32(characterInfo[LC.Constitution]),
                    Intelligence = Convert.ToInt32(characterInfo[LC.Intelligence]),
                    Wisdom = Convert.ToInt32(characterInfo[LC.Wisdom]),
                    Charisma = Convert.ToInt32(characterInfo[LC.Charisma])
                },
                Skills = new Skills()
                {
                    _Acrobatics = proficiencyInfo[LC.Acrobatics],
                    _AnimalHandling = proficiencyInfo[LC.AnimalHandling],
                    _Arcana = proficiencyInfo[LC.Arcana],
                    _Athletics = proficiencyInfo[LC.Athletics],
                    _Deception = proficiencyInfo[LC.Deception],
                    _History = proficiencyInfo[LC.History],
                    _Insight = proficiencyInfo[LC.Insight],
                    _Intimidation = proficiencyInfo[LC.Intimidation],
                    _Investigation = proficiencyInfo[LC.Investigation],
                    _Medicine = proficiencyInfo[LC.Medicine],
                    _Nature = proficiencyInfo[LC.Nature],
                    _Perception = proficiencyInfo[LC.Perception],
                    _Performance = proficiencyInfo[LC.Performance],
                    _Persuassion = proficiencyInfo[LC.Persuassion],
                    _Religion = proficiencyInfo[LC.Religion],
                    _SlightOfHand = proficiencyInfo[LC.SlightOfHand],
                    _Stealth = proficiencyInfo[LC.Stealth],
                    _Survival = proficiencyInfo[LC.Survival]
                },
                Inspiration = Convert.ToBoolean(characterInfo[LC.Inspiration]),
                // ProficiencyBonus is Calculated
                SavingThrows = new SavingThrows()
                {
                    _Strength = proficiencyInfo[LC.StrengthSave],
                    _Dexterity = proficiencyInfo[LC.DexteritySave],
                    _Constitution = proficiencyInfo[LC.ConstitutionSave],
                    _Intelligence = proficiencyInfo[LC.IntelligenceSave],
                    _Wisdom = proficiencyInfo[LC.WisdomSave],
                    _Charisma = proficiencyInfo[LC.CharismaSave]
                },
                // Perception is Calculated
                // Proficiencies
                // Languages

                // Middle Column Info
                ArmorClass = Convert.ToInt32(characterInfo[LC.ArmorClass]),
                Initiative = Convert.ToInt32(characterInfo[LC.Initiative]),
                Speed = Convert.ToInt32(characterInfo[LC.Speed]),
                HP_Max = Convert.ToInt32(characterInfo[LC.HP_Max]),
                HP_Current = Convert.ToInt32(characterInfo[LC.HP_Current]),
                HP_Temp = Convert.ToInt32(characterInfo[LC.HP_Temp]),
                HitDice = characterInfo[LC.HitDice],
                HitDiceTotal = Convert.ToInt32(characterInfo[LC.HitDiceTotal]),
                Money = new Money()
                {
                    Copper = Convert.ToInt32(characterInfo[LC.Copper]),
                    Silver = Convert.ToInt32(characterInfo[LC.Silver]),
                    Electrum = Convert.ToInt32(characterInfo[LC.Electrum]),
                    Gold = Convert.ToInt32(characterInfo[LC.Gold]),
                    Platinum = Convert.ToInt32(characterInfo[LC.Platinum]),
                },
                // Death Saves
                // Attacks and spellcasting
                // Equipment

                // Right Column Info
                PersonalityTraits = characterInfo[LC.PersonalityTraits],
                Ideals = characterInfo[LC.Ideals],
                Bonds = characterInfo[LC.Bonds],
                Flaws = characterInfo[LC.Flaws],
                // Features
                // Traits

            };

            m_MainCharacterInfo.Calculate();
        }

    }
}
