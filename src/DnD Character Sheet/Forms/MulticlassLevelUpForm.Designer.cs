namespace DnD_Character_Sheet
{
    partial class MulticlassLevelUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public string ClassSelection { get; set; }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Class1 = new System.Windows.Forms.Button();
            this.Class2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.Class1_Level = new System.Windows.Forms.Label();
            this.Class2_Level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.Class1.Location = new System.Drawing.Point(12, 157);
            this.Class1.Name = "Class1";
            this.Class1.Size = new System.Drawing.Size(145, 52);
            this.Class1.TabIndex = 0;
            this.Class1.Text = "Class1";
            this.Class1.UseVisualStyleBackColor = true;
            this.Class1.Click += new System.EventHandler(this.Class1_Click);
            // 
            // Class2
            // 
            this.Class2.Location = new System.Drawing.Point(183, 157);
            this.Class2.Name = "Class2";
            this.Class2.Size = new System.Drawing.Size(145, 52);
            this.Class2.TabIndex = 1;
            this.Class2.Text = "Class2";
            this.Class2.UseVisualStyleBackColor = true;
            this.Class2.Click += new System.EventHandler(this.Class1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(354, 157);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(144, 52);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Class1_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainTextBox.Location = new System.Drawing.Point(12, 12);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(486, 89);
            this.MainTextBox.TabIndex = 3;
            this.MainTextBox.Text = "Which class would you like to apply your level up to?";
            // 
            // Class1_Level
            // 
            this.Class1_Level.AutoSize = true;
            this.Class1_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Class1_Level.Location = new System.Drawing.Point(63, 118);
            this.Class1_Level.Name = "Class1_Level";
            this.Class1_Level.Size = new System.Drawing.Size(32, 36);
            this.Class1_Level.TabIndex = 4;
            this.Class1_Level.Text = "0";
            this.Class1_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Class2_Level
            // 
            this.Class2_Level.AutoSize = true;
            this.Class2_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Class2_Level.Location = new System.Drawing.Point(231, 118);
            this.Class2_Level.Name = "Class2_Level";
            this.Class2_Level.Size = new System.Drawing.Size(32, 36);
            this.Class2_Level.TabIndex = 5;
            this.Class2_Level.Text = "0";
            this.Class2_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MulticlassLevelUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(510, 239);
            this.Controls.Add(this.Class2_Level);
            this.Controls.Add(this.Class1_Level);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Class2);
            this.Controls.Add(this.Class1);
            this.MaximumSize = new System.Drawing.Size(532, 295);
            this.Name = "MulticlassLevelUpForm";
            this.Text = "Multiclass Level Up";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Class1;
        private System.Windows.Forms.Button Class2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Label Class1_Level;
        private System.Windows.Forms.Label Class2_Level;
    }
}