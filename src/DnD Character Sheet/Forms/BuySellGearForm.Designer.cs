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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sell_Button = new System.Windows.Forms.Button();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.BuyEquipment_Grid = new System.Windows.Forms.DataGridView();
            this.Buy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArmorClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BuyEquipment_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Sell_Button
            // 
            this.Sell_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_Button.Location = new System.Drawing.Point(12, 1205);
            this.Sell_Button.Name = "Sell_Button";
            this.Sell_Button.Size = new System.Drawing.Size(158, 70);
            this.Sell_Button.TabIndex = 222;
            this.Sell_Button.Text = "Sell Equipment";
            this.Sell_Button.UseVisualStyleBackColor = true;
            this.Sell_Button.Click += new System.EventHandler(this.Sell_Button_Click);
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_Button.Location = new System.Drawing.Point(12, 1205);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(158, 70);
            this.Purchase_Button.TabIndex = 221;
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
            this.Type,
            this.ItemName,
            this.Quantity,
            this.Cost,
            this.Damage,
            this.ArmorClass,
            this.Weight,
            this.Properties});
            this.BuyEquipment_Grid.Location = new System.Drawing.Point(12, 12);
            this.BuyEquipment_Grid.Name = "BuyEquipment_Grid";
            this.BuyEquipment_Grid.RowHeadersVisible = false;
            this.BuyEquipment_Grid.RowHeadersWidth = 62;
            this.BuyEquipment_Grid.RowTemplate.Height = 28;
            this.BuyEquipment_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BuyEquipment_Grid.Size = new System.Drawing.Size(2034, 1187);
            this.BuyEquipment_Grid.TabIndex = 220;
            this.BuyEquipment_Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BuyEquipment_Grid_CellValueChanged);
            // 
            // Buy
            // 
            this.Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.Buy.DefaultCellStyle = dataGridViewCellStyle10;
            this.Buy.HeaderText = "Buy";
            this.Buy.MinimumWidth = 8;
            this.Buy.Name = "Buy";
            this.Buy.Width = 42;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.DefaultCellStyle = dataGridViewCellStyle11;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 150;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle12;
            this.ItemName.HeaderText = "Name";
            this.ItemName.MinimumWidth = 150;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle13;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 104;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cost.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 8;
            this.Cost.Name = "Cost";
            this.Cost.Width = 78;
            // 
            // Damage
            // 
            this.Damage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Damage.DefaultCellStyle = dataGridViewCellStyle15;
            this.Damage.HeaderText = "Damage";
            this.Damage.MinimumWidth = 8;
            this.Damage.Name = "Damage";
            this.Damage.ReadOnly = true;
            this.Damage.Width = 106;
            // 
            // ArmorClass
            // 
            this.ArmorClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArmorClass.DefaultCellStyle = dataGridViewCellStyle16;
            this.ArmorClass.HeaderText = "Armor Class";
            this.ArmorClass.MinimumWidth = 8;
            this.ArmorClass.Name = "ArmorClass";
            this.ArmorClass.ReadOnly = true;
            this.ArmorClass.Width = 131;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Weight.DefaultCellStyle = dataGridViewCellStyle17;
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 8;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 95;
            // 
            // Properties
            // 
            this.Properties.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Properties.DefaultCellStyle = dataGridViewCellStyle18;
            this.Properties.HeaderText = "Properties";
            this.Properties.MinimumWidth = 150;
            this.Properties.Name = "Properties";
            this.Properties.ReadOnly = true;
            // 
            // BuySellGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2058, 1287);
            this.Controls.Add(this.Sell_Button);
            this.Controls.Add(this.Purchase_Button);
            this.Controls.Add(this.BuyEquipment_Grid);
            this.MaximumSize = new System.Drawing.Size(2080, 1343);
            this.Name = "BuySellGearForm";
            this.Text = "Buy Gear";
            ((System.ComponentModel.ISupportInitialize)(this.BuyEquipment_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sell_Button;
        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.DataGridView BuyEquipment_Grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Damage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmorClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties;
    }
}