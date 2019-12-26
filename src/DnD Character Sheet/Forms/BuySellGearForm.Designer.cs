namespace DnD_Character_Sheet.Forms
{
    partial class BuySellGearForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BuyGear_Panel = new System.Windows.Forms.Panel();
            this.Cost_Label = new System.Windows.Forms.Label();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.BuyEquipment_Grid = new System.Windows.Forms.DataGridView();
            this.Buy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Damage_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArmorClass_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyGear_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyEquipment_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyGear_Panel
            // 
            this.BuyGear_Panel.Controls.Add(this.Cost_Label);
            this.BuyGear_Panel.Controls.Add(this.Purchase_Button);
            this.BuyGear_Panel.Controls.Add(this.BuyEquipment_Grid);
            this.BuyGear_Panel.Location = new System.Drawing.Point(12, 12);
            this.BuyGear_Panel.Name = "BuyGear_Panel";
            this.BuyGear_Panel.Size = new System.Drawing.Size(2034, 1263);
            this.BuyGear_Panel.TabIndex = 0;
            // 
            // Cost_Label
            // 
            this.Cost_Label.AutoSize = true;
            this.Cost_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_Label.Location = new System.Drawing.Point(33, 1067);
            this.Cost_Label.Name = "Cost_Label";
            this.Cost_Label.Size = new System.Drawing.Size(0, 25);
            this.Cost_Label.TabIndex = 218;
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_Button.Location = new System.Drawing.Point(19, 1152);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(158, 70);
            this.Purchase_Button.TabIndex = 217;
            this.Purchase_Button.Text = "Purchase Equipment";
            this.Purchase_Button.UseVisualStyleBackColor = true;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // BuyEquipment_Grid
            // 
            this.BuyEquipment_Grid.AllowUserToAddRows = false;
            this.BuyEquipment_Grid.AllowUserToDeleteRows = false;
            this.BuyEquipment_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BuyEquipment_Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BuyEquipment_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyEquipment_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buy,
            this.Type_Buy,
            this.Name_Buy,
            this.Quantity_Buy,
            this.Cost_Buy,
            this.Damage_Buy,
            this.ArmorClass_Buy,
            this.Weight_Buy,
            this.Properties_Buy});
            this.BuyEquipment_Grid.Location = new System.Drawing.Point(19, 12);
            this.BuyEquipment_Grid.Name = "BuyEquipment_Grid";
            this.BuyEquipment_Grid.RowHeadersVisible = false;
            this.BuyEquipment_Grid.RowHeadersWidth = 62;
            this.BuyEquipment_Grid.RowTemplate.Height = 28;
            this.BuyEquipment_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BuyEquipment_Grid.Size = new System.Drawing.Size(1996, 1004);
            this.BuyEquipment_Grid.TabIndex = 216;
            this.BuyEquipment_Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BuyEquipment_Grid_CellValueChanged);
            // 
            // Buy
            // 
            this.Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Buy.DefaultCellStyle = dataGridViewCellStyle1;
            this.Buy.HeaderText = "Buy";
            this.Buy.MinimumWidth = 8;
            this.Buy.Name = "Buy";
            this.Buy.Width = 42;
            // 
            // Type_Buy
            // 
            this.Type_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Type_Buy.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type_Buy.HeaderText = "Type";
            this.Type_Buy.MinimumWidth = 150;
            this.Type_Buy.Name = "Type_Buy";
            this.Type_Buy.ReadOnly = true;
            this.Type_Buy.Width = 150;
            // 
            // Name_Buy
            // 
            this.Name_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Name_Buy.DefaultCellStyle = dataGridViewCellStyle3;
            this.Name_Buy.HeaderText = "Name";
            this.Name_Buy.MinimumWidth = 150;
            this.Name_Buy.Name = "Name_Buy";
            this.Name_Buy.ReadOnly = true;
            this.Name_Buy.Width = 150;
            // 
            // Quantity_Buy
            // 
            this.Quantity_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity_Buy.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity_Buy.HeaderText = "Quantity";
            this.Quantity_Buy.MinimumWidth = 8;
            this.Quantity_Buy.Name = "Quantity_Buy";
            this.Quantity_Buy.Width = 104;
            // 
            // Cost_Buy
            // 
            this.Cost_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cost_Buy.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cost_Buy.HeaderText = "Cost";
            this.Cost_Buy.MinimumWidth = 8;
            this.Cost_Buy.Name = "Cost_Buy";
            this.Cost_Buy.Width = 78;
            // 
            // Damage_Buy
            // 
            this.Damage_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Damage_Buy.DefaultCellStyle = dataGridViewCellStyle6;
            this.Damage_Buy.HeaderText = "Damage";
            this.Damage_Buy.MinimumWidth = 8;
            this.Damage_Buy.Name = "Damage_Buy";
            this.Damage_Buy.ReadOnly = true;
            this.Damage_Buy.Width = 106;
            // 
            // ArmorClass_Buy
            // 
            this.ArmorClass_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArmorClass_Buy.DefaultCellStyle = dataGridViewCellStyle7;
            this.ArmorClass_Buy.HeaderText = "Armor Class";
            this.ArmorClass_Buy.MinimumWidth = 8;
            this.ArmorClass_Buy.Name = "ArmorClass_Buy";
            this.ArmorClass_Buy.ReadOnly = true;
            this.ArmorClass_Buy.Width = 131;
            // 
            // Weight_Buy
            // 
            this.Weight_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Weight_Buy.DefaultCellStyle = dataGridViewCellStyle8;
            this.Weight_Buy.HeaderText = "Weight";
            this.Weight_Buy.MinimumWidth = 8;
            this.Weight_Buy.Name = "Weight_Buy";
            this.Weight_Buy.ReadOnly = true;
            this.Weight_Buy.Width = 95;
            // 
            // Properties_Buy
            // 
            this.Properties_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Properties_Buy.DefaultCellStyle = dataGridViewCellStyle9;
            this.Properties_Buy.HeaderText = "Properties";
            this.Properties_Buy.MinimumWidth = 150;
            this.Properties_Buy.Name = "Properties_Buy";
            this.Properties_Buy.ReadOnly = true;
            // 
            // BuySellGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2058, 1287);
            this.Controls.Add(this.BuyGear_Panel);
            this.MaximumSize = new System.Drawing.Size(2080, 1343);
            this.Name = "BuySellGearForm";
            this.Text = "Buy Gear";
            this.BuyGear_Panel.ResumeLayout(false);
            this.BuyGear_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyEquipment_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BuyGear_Panel;
        private System.Windows.Forms.DataGridView BuyEquipment_Grid;
        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.Label Cost_Label;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Damage_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmorClass_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties_Buy;
    }
}