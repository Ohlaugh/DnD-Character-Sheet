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
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

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
                m_CharacterName = xDoc.GetElementsByTagName(LC.CharacterSheet)[0].Attributes[0].Value;

                GatherCharData(xDoc);
                GatherProfData(xDoc);
                GatherItemData(xDoc);
                GatherWeaponData(xDoc);
                GatherArmorData(xDoc);
                GatherBookData(xDoc);
                GatherBackgroundData(xDoc);
                stream.Close();
                PopulateCharacterInformation();
                m_CharacterLoaded = true;
                return true;
            }
            return false;
        }

        private void GatherCharData(XmlDocument xDoc)
        {
            XmlNodeList nodeList = xDoc.GetElementsByTagName(LC.Data);
            foreach (XmlNode node in nodeList)
            {
                string key = node.SelectSingleNode(LC.Key).InnerText;
                string value = node.SelectSingleNode(LC.Value).InnerText;
                m_CharData.Add(key, value);
            }
        }

        private void GatherProfData(XmlDocument xDoc)
        {
            XmlNodeList nodeList = xDoc.GetElementsByTagName(LC.Proficient);
            foreach (XmlNode node in nodeList)
            {
                string key = node.SelectSingleNode(LC.Key).InnerText;
                bool value = Convert.ToBoolean(node.SelectSingleNode(LC.Value).InnerText);
                m_ProficientData.Add(key, value);
            }
        }

        private void GatherItemData(XmlDocument xDoc)
        {
            XmlNode itemsNode = xDoc.GetElementsByTagName(LC.Items)[0];
            XmlNodeList items = itemsNode.SelectNodes(LC.Item);

            foreach (XmlNode itemNode in items)
            {
                string name = itemNode.SelectSingleNode(LC.Name).InnerText;
                CLIB.Item_Class item = new CLIB.Item_Class
                {
                    Cost = itemNode.SelectSingleNode(LC.Cost).InnerText,
                    Weight = Convert.ToDouble(itemNode.SelectSingleNode(LC.Weight).InnerText),
                    Description = itemNode.SelectSingleNode(LC.Description).InnerText,
                    Quantity = Convert.ToInt32(itemNode.SelectSingleNode(LC.Quantity).InnerText)
                };
                m_ItemData.Add(name, item);
            }
        }

        private void GatherWeaponData(XmlDocument xDoc)
        {
            XmlNode itemsNode = xDoc.GetElementsByTagName(LC.Items)[0];
            XmlNodeList weapons = itemsNode.SelectNodes(LC.Weapon);

            foreach (XmlNode weaponNode in weapons)
            {
                string name = weaponNode.SelectSingleNode(LC.Name).InnerText;
                XmlNode propertiesNode = weaponNode.SelectNodes(LC.Properties)[0];
                XmlNodeList propertyNodes = propertiesNode.SelectNodes(LC.Property);

                List<string> properties = new List<string>();
                foreach (XmlNode property in propertyNodes)
                {
                    properties.Add(property.InnerText);
                }

                CLIB.Weapon_Class weapon = new CLIB.Weapon_Class
                {
                    Cost = weaponNode.SelectSingleNode(LC.Cost).InnerText,
                    Damage = weaponNode.SelectSingleNode(LC.Damage).InnerText,
                    Weight = Convert.ToDouble(weaponNode.SelectSingleNode(LC.Weight).InnerText),
                    Style = weaponNode.SelectSingleNode(LC.Style).InnerText,
                    Properties = properties,
                    Equipped = Convert.ToBoolean(weaponNode.SelectSingleNode(LC.Equipped).InnerText),
                    Quantity = Convert.ToInt32(weaponNode.SelectSingleNode(LC.Quantity).InnerText)
                };                

                m_WeaponData.Add(name, weapon);
            }
        }

        private void GatherArmorData(XmlDocument xDoc)
        {
            XmlNode itemsNode = xDoc.GetElementsByTagName(LC.Items)[0];
            XmlNodeList armor = itemsNode.SelectNodes(LC.Armor);

            foreach (XmlNode armorNode in armor)
            {
                string name = armorNode.SelectSingleNode(LC.Name).InnerText;
                CLIB.Armor_Class item = new CLIB.Armor_Class
                {
                    Cost = armorNode.SelectSingleNode(LC.Cost).InnerText,
                    Weight = Convert.ToDouble(armorNode.SelectSingleNode(LC.Weight).InnerText),
                    Style = armorNode.SelectSingleNode(LC.Style).InnerText,
                    Equipped = Convert.ToBoolean(armorNode.SelectSingleNode(LC.Equipped).InnerText),
                    ArmorClass = armorNode.SelectSingleNode(LC.ArmorClass).InnerText,
                    StrengthReq = Convert.ToInt32(armorNode.SelectSingleNode(LC.StrengthReq).InnerText),
                    Disadvantage = Convert.ToBoolean(armorNode.SelectSingleNode(LC.Disadvantage).InnerText),
                    Quantity = Convert.ToInt32(armorNode.SelectSingleNode(LC.Quantity).InnerText)
                };
                m_ArmorData.Add(name, item);
            }
        }

        private void GatherBookData(XmlDocument xDoc)
        {
            XmlNodeList nodeList = xDoc.GetElementsByTagName(LC.Book);
            foreach (XmlNode node in nodeList)
            {
                string key = node.SelectSingleNode(LC.Key).InnerText;
                bool value = Convert.ToBoolean(node.SelectSingleNode(LC.Value).InnerText);
                m_BookUtilization.Add(key, value);
            }
        }

        private void GatherBackgroundData(XmlDocument xDoc)
        {
            XmlNodeList nodeList = xDoc.GetElementsByTagName(LC.BackgroundInfo);
            foreach (XmlNode node in nodeList)
            {
                string key = node.SelectSingleNode(LC.Key).InnerText;
                string value = node.SelectSingleNode(LC.Value).InnerText;
                m_CharData.Add(key, value);
            }
        }

        private void PopulateCharacterInformation()
        {
            m_MainCharacterInfo = new MainCharacterInfo
            {
                // Top Level Info
                CharacterName = m_CharacterName,
                Class1 = m_CharData[LC.Class1],
                Class2 = m_CharData[LC.Class2],
                SubClass1 = m_CharData[LC.SubClass1],
                SubClass2 = m_CharData[LC.SubClass2],
                Level1 = Convert.ToInt32(m_CharData[LC.Level1]),
                Level2 = Convert.ToInt32(m_CharData[LC.Level2]),
                Background = m_CharData[LC.Background],
                PlayerName = m_CharData[LC.PlayerName],
                Race = m_CharData[LC.Race],
                Subrace = m_CharData[LC.Subrace],
                Alignment = m_CharData[LC.Alignment],
                ExperiencePoints = Convert.ToInt32(m_CharData[LC.ExperiencePoints]),
                Age = Convert.ToInt32(m_CharData[LC.Age]),
                Height = m_CharData[LC.Height],
                Weight = Convert.ToInt32(m_CharData[LC.Weight]),
                EyeColor = m_CharData[LC.EyeColor],
                SkinColor = m_CharData[LC.SkinColor],
                HairColor = m_CharData[LC.HairColor],

                // Left Column Info
                Attributes = new CLIB.Attributes
                {
                    Strength = Convert.ToInt32(m_CharData[LC.Strength]),
                    Dexterity = Convert.ToInt32(m_CharData[LC.Dexterity]),
                    Constitution = Convert.ToInt32(m_CharData[LC.Constitution]),
                    Intelligence = Convert.ToInt32(m_CharData[LC.Intelligence]),
                    Wisdom = Convert.ToInt32(m_CharData[LC.Wisdom]),
                    Charisma = Convert.ToInt32(m_CharData[LC.Charisma])
                },
                Skills = new CLIB.Skills()
                {
                    _Acrobatics = m_ProficientData[LC.Acrobatics],
                    _AnimalHandling = m_ProficientData[LC.AnimalHandling],
                    _Arcana = m_ProficientData[LC.Arcana],
                    _Athletics = m_ProficientData[LC.Athletics],
                    _Deception = m_ProficientData[LC.Deception],
                    _History = m_ProficientData[LC.History],
                    _Insight = m_ProficientData[LC.Insight],
                    _Intimidation = m_ProficientData[LC.Intimidation],
                    _Investigation = m_ProficientData[LC.Investigation],
                    _Medicine = m_ProficientData[LC.Medicine],
                    _Nature = m_ProficientData[LC.Nature],
                    _Perception = m_ProficientData[LC.Perception],
                    _Performance = m_ProficientData[LC.Performance],
                    _Persuassion = m_ProficientData[LC.Persuassion],
                    _Religion = m_ProficientData[LC.Religion],
                    _SlightOfHand = m_ProficientData[LC.SlightOfHand],
                    _Stealth = m_ProficientData[LC.Stealth],
                    _Survival = m_ProficientData[LC.Survival]
                },
                Inspiration = Convert.ToBoolean(m_CharData[LC.Inspiration]),
                // ProficiencyBonus is Calculated
                SavingThrows = new CLIB.SavingThrows()
                {
                    _Strength = m_ProficientData[LC.StrengthSave],
                    _Dexterity = m_ProficientData[LC.DexteritySave],
                    _Constitution = m_ProficientData[LC.ConstitutionSave],
                    _Intelligence = m_ProficientData[LC.IntelligenceSave],
                    _Wisdom = m_ProficientData[LC.WisdomSave],
                    _Charisma = m_ProficientData[LC.CharismaSave]
                },
                // Perception is Calculated
                // Proficiencies
                // Languages

                // Middle Column Info
                ArmorClass = Convert.ToInt32(m_CharData[LC.ArmorClass]),
                Initiative = Convert.ToInt32(m_CharData[LC.Initiative]),
                Speed = Convert.ToInt32(m_CharData[LC.Speed]),
                HP_Max = Convert.ToInt32(m_CharData[LC.HP_Max]),
                HP_Current = Convert.ToInt32(m_CharData[LC.HP_Current]),
                HP_Temp = Convert.ToInt32(m_CharData[LC.HP_Temp]),
                HitDice1 = m_CharData[LC.HitDice1],
                HitDice2 = m_CharData[LC.HitDice2],
                HitDiceTotal1 = Convert.ToInt32(m_CharData[LC.HitDiceTotal1]),
                HitDiceTotal2 = Convert.ToInt32(m_CharData[LC.HitDiceTotal2]),
                Money = new CLIB.Money()
                {
                    Copper = Convert.ToInt32(m_CharData[LC.Copper]),
                    Silver = Convert.ToInt32(m_CharData[LC.Silver]),
                    Electrum = Convert.ToInt32(m_CharData[LC.Electrum]),
                    Gold = Convert.ToInt32(m_CharData[LC.Gold]),
                    Platinum = Convert.ToInt32(m_CharData[LC.Platinum]),
                },
                // Death Saves
                // Attacks and spellcasting

                // Right Column Info
                PersonalityTraits = m_CharData[LC.PersonalityTraits],
                Ideals = m_CharData[LC.Ideals],
                Bonds = m_CharData[LC.Bonds],
                Flaws = m_CharData[LC.Flaws],

                Backstory = m_CharData[LC.Backstory],

                Items = m_ItemData,
                Weapons = m_WeaponData,
                Armor = m_ArmorData

            };

            m_MainCharacterInfo.Calculate();
        }

    }
}
