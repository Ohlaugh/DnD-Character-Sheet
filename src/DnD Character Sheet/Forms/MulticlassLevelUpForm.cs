using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Character_Sheet
{
    public partial class MulticlassLevelUpForm : Form
    {
        public MulticlassLevelUpForm(string class1, string class2, int level1, int level2)
        {
            InitializeComponent();
            Class1.Text = class1;
            Class1_Level.Text = level1.ToString();
            Class2.Text = class2;
            Class2_Level.Text = level2.ToString();
        }
        private void Class1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DialogResult = DialogResult.OK;
            ClassSelection = button.Name;
            if (ClassSelection == "Cancel")
            {
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }
    }
}
