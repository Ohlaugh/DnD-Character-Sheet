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
using LC = DnD_Character_Sheet.Constants;
using CLIB = DnD_Character_Sheet.Classes.ClassLibrary;

namespace DnD_Character_Sheet
{
    class SaveCharacter : Library
    {
        private List<object> dataNodes = new List<object>();
        private List<object> itemNodes = new List<object>();

        public bool Save()
        {
            dataNodes.Clear();
            itemNodes.Clear();

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = fileDialog.InitialDirectory + m_MainCharacterInfo.Class1;
            if (m_MainCharacterInfo.Class2 != string.Empty)
            {
                fileDialog.FileName += "_" + m_MainCharacterInfo.Class2;
            }
            fileDialog.FileName += " " + m_MainCharacterInfo.Race + " - " + m_MainCharacterInfo.CharacterName;

            fileDialog.Filter = LC.FileFilter;
            fileDialog.FilterIndex = 1;
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;


                PropertyInfo[] properties = typeof(MainCharacterInfo).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.PropertyType == typeof(CLIB.Attributes))
                    {
                        AddNode(typeof(CLIB.Attributes), m_MainCharacterInfo.Attributes, LC.Data, typeof(Int32));
                    }
                    else if (property.PropertyType == typeof(CLIB.Skills))
                    {
                        AddNode(typeof(CLIB.Skills), m_MainCharacterInfo.Skills, LC.Proficient, typeof(bool));
                    }
                    else if (property.PropertyType == typeof(CLIB.SavingThrows))
                    {
                        AddNode(typeof(CLIB.SavingThrows), m_MainCharacterInfo.SavingThrows, LC.Proficient, typeof(bool));
                    }
                    else if (property.PropertyType == typeof(CLIB.Money))
                    {
                        AddNode(typeof(CLIB.Money), m_MainCharacterInfo.Money, LC.Data);
                    }
                    // Only Proficiencies, Languages, Features and Traits are stored as List<string> 
                    else if (property.PropertyType == typeof(List<string>))
                    {
                        // Currently Unused
                    }
                    else if (property.PropertyType == typeof(Dictionary<string, CLIB.Item>))
                    {
                        foreach (var key in m_MainCharacterInfo.Items.Keys)
                        {
                            AddItemNode(key, m_MainCharacterInfo.Items[key]);
                        }
                    }
                    else if (property.PropertyType == typeof(Dictionary<string, CLIB.Weapon>))
                    {
                        foreach (var key in m_MainCharacterInfo.Weapons.Keys)
                        {
                            AddWeaponNode(key, m_MainCharacterInfo.Weapons[key]);
                        }
                    }
                    else if (property.PropertyType == typeof(Dictionary<string, CLIB.Armor>))
                    {
                        foreach (var key in m_MainCharacterInfo.Armor.Keys)
                        {
                            AddArmorNode(key, m_MainCharacterInfo.Armor[key]);
                        }
                    }
                    else
                    {
                        var dataNode =
                            new XElement(LC.Data,
                                new XElement(LC.Key, property.Name),
                                new XElement(LC.Value, property.GetValue(m_MainCharacterInfo)));
                        dataNodes.Add(dataNode);
                    }
                }

                foreach (var key in m_BookUtilization.Keys)
                {
                    var bookNode =
                        new XElement(LC.Book,
                            new XElement(LC.Key, key),
                            new XElement(LC.Value, m_BookUtilization[key]));
                    dataNodes.Add(bookNode);
                }

                var xmlNode =
                    new XElement(LC.CharacterSheet,
                    new XAttribute("CharacterName", m_CharacterName),
                        dataNodes,
                        new XElement(LC.Items,
                            itemNodes
                        ));
                xmlNode.Save(filePath);
            }
            return true;
        }


        /// <summary>
        /// This method adds a new node onto the main node collection
        /// </summary>
        /// <param name="type">type of property to add</param>
        /// <param name="valueContainer">the container of same type that holds the value</param>
        /// <param name="label">label of the node</param>
        private void AddNode(Type type, object valueContainer, string label, Type typeLimit = null)
        {
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (typeLimit != null && property.PropertyType != typeLimit)
                {
                    continue;
                }
                var dataNode =
                    new XElement(label,
                        new XElement(LC.Key, property.Name),
                        new XElement(LC.Value, property.GetValue(valueContainer)));
                dataNodes.Add(dataNode);
            }
        }

        private void AddItemNode(string itemName, CLIB.Item item)
        {
            var itemNode =
                new XElement(LC.Item,
                    new XElement(LC.Name, itemName),
                    new XElement(LC.Cost, item.Cost),
                    new XElement(LC.Weight, item.Weight),
                    new XElement(LC.Style, item.Style),
                    new XElement(LC.Description, item.Description),
                    new XElement(LC.Quantity, item.Quantity));
            itemNodes.Add(itemNode);
        }

        private void AddWeaponNode(string itemName, CLIB.Weapon item)
        {
            List<object> properties = new List<object>();
            foreach (var property in item.Properties)
            {
                properties.Add(new XElement(LC.Property, property));
            }

            var itemNode =
                new XElement(LC.Weapon,
                    new XElement(LC.Name, itemName),
                    new XElement(LC.Cost, item.Cost),
                    new XElement(LC.Weight, item.Weight),
                    new XElement(LC.Style, item.Style),
                    new XElement(LC.Description, item.Description),
                    new XElement(LC.Quantity, item.Quantity),
                    new XElement(LC.Damage, item.Damage),
                    new XElement(LC.Equipped, item.Equipped),
                    new XElement(LC.Properties,
                        properties));
            itemNodes.Add(itemNode);
        }

        private void AddArmorNode(string itemName, CLIB.Armor item)
        {
            var itemNode =
                new XElement(LC.Armor,
                    new XElement(LC.Name, itemName),
                    new XElement(LC.Cost, item.Cost),
                    new XElement(LC.Weight, item.Weight),
                    new XElement(LC.Style, item.Style),
                    new XElement(LC.Description, item.Description),
                    new XElement(LC.Quantity, item.Quantity),
                    new XElement(LC.ArmorClass, item.ArmorClass),
                    new XElement(LC.StrengthReq, item.StrengthReq),
                    new XElement(LC.Disadvantage, item.Disadvantage),
                    new XElement(LC.Equipped, item.Equipped));
            itemNodes.Add(itemNode);
        }
    }
}
