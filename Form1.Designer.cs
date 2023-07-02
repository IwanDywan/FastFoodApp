
namespace Restauracja_Fast_Food
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCloseApp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonDrinks = new System.Windows.Forms.RadioButton();
            this.radioButtonFood = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRepay = new System.Windows.Forms.TextBox();
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddItems = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTop.Controls.Add(this.labelCloseApp);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1333, 77);
            this.panelTop.TabIndex = 1;
            // 
            // labelCloseApp
            // 
            this.labelCloseApp.AutoSize = true;
            this.labelCloseApp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCloseApp.Location = new System.Drawing.Point(1288, 9);
            this.labelCloseApp.Name = "labelCloseApp";
            this.labelCloseApp.Size = new System.Drawing.Size(33, 32);
            this.labelCloseApp.TabIndex = 0;
            this.labelCloseApp.Text = "X";
            this.labelCloseApp.Click += new System.EventHandler(this.labelCloseApp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(666, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(577, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fast";
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.PeachPuff;
            this.panelCenter.Controls.Add(this.dateTimePicker1);
            this.panelCenter.Controls.Add(this.radioButtonDrinks);
            this.panelCenter.Controls.Add(this.radioButtonFood);
            this.panelCenter.Controls.Add(this.label11);
            this.panelCenter.Controls.Add(this.label10);
            this.panelCenter.Controls.Add(this.label9);
            this.panelCenter.Controls.Add(this.textBoxRepay);
            this.panelCenter.Controls.Add(this.textBoxPay);
            this.panelCenter.Controls.Add(this.textBoxTotal);
            this.panelCenter.Controls.Add(this.buttonLoad);
            this.panelCenter.Controls.Add(this.buttonClear);
            this.panelCenter.Controls.Add(this.buttonSave);
            this.panelCenter.Controls.Add(this.dataGridView1);
            this.panelCenter.Controls.Add(this.buttonDelete);
            this.panelCenter.Controls.Add(this.buttonAddItems);
            this.panelCenter.Controls.Add(this.textBoxAmount);
            this.panelCenter.Controls.Add(this.textBoxQuantity);
            this.panelCenter.Controls.Add(this.textBoxPrice);
            this.panelCenter.Controls.Add(this.comboBoxSelect);
            this.panelCenter.Controls.Add(this.label8);
            this.panelCenter.Controls.Add(this.label7);
            this.panelCenter.Controls.Add(this.label6);
            this.panelCenter.Controls.Add(this.label5);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 77);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1333, 650);
            this.panelCenter.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1022, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // radioButtonDrinks
            // 
            this.radioButtonDrinks.AutoSize = true;
            this.radioButtonDrinks.ForeColor = System.Drawing.Color.Black;
            this.radioButtonDrinks.Location = new System.Drawing.Point(349, 38);
            this.radioButtonDrinks.Name = "radioButtonDrinks";
            this.radioButtonDrinks.Size = new System.Drawing.Size(72, 25);
            this.radioButtonDrinks.TabIndex = 25;
            this.radioButtonDrinks.TabStop = true;
            this.radioButtonDrinks.Text = "Drinks";
            this.radioButtonDrinks.UseVisualStyleBackColor = true;
            this.radioButtonDrinks.CheckedChanged += new System.EventHandler(this.radioButtonDrinks_CheckedChanged);
            // 
            // radioButtonFood
            // 
            this.radioButtonFood.AutoSize = true;
            this.radioButtonFood.ForeColor = System.Drawing.Color.Black;
            this.radioButtonFood.Location = new System.Drawing.Point(174, 38);
            this.radioButtonFood.Name = "radioButtonFood";
            this.radioButtonFood.Size = new System.Drawing.Size(67, 25);
            this.radioButtonFood.TabIndex = 24;
            this.radioButtonFood.TabStop = true;
            this.radioButtonFood.Text = "Food";
            this.radioButtonFood.UseVisualStyleBackColor = true;
            this.radioButtonFood.CheckedChanged += new System.EventHandler(this.radioButtonFood_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(889, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Repay amont";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(889, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Pay Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(889, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total Amount";
            // 
            // textBoxRepay
            // 
            this.textBoxRepay.Location = new System.Drawing.Point(1022, 568);
            this.textBoxRepay.Name = "textBoxRepay";
            this.textBoxRepay.ReadOnly = true;
            this.textBoxRepay.Size = new System.Drawing.Size(121, 27);
            this.textBoxRepay.TabIndex = 20;
            // 
            // textBoxPay
            // 
            this.textBoxPay.Location = new System.Drawing.Point(1022, 524);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(121, 27);
            this.textBoxPay.TabIndex = 19;
            this.textBoxPay.TextChanged += new System.EventHandler(this.textBoxPay_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(1022, 481);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(121, 27);
            this.textBoxTotal.TabIndex = 18;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLoad
            // 
            this.buttonLoad.ForeColor = System.Drawing.Color.Black;
            this.buttonLoad.Location = new System.Drawing.Point(789, 430);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(102, 45);
            this.buttonLoad.TabIndex = 17;
            this.buttonLoad.Text = "Load Data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(681, 430);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 45);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(573, 430);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 45);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItems,
            this.ColumnPrices,
            this.ColumnQuantity,
            this.ColumnTotal,
            this.ColumnDate});
            this.dataGridView1.Location = new System.Drawing.Point(573, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(570, 276);
            this.dataGridView1.TabIndex = 14;
            // 
            // ColumnItems
            // 
            this.ColumnItems.HeaderText = "Items";
            this.ColumnItems.Name = "ColumnItems";
            this.ColumnItems.ReadOnly = true;
            // 
            // ColumnPrices
            // 
            this.ColumnPrices.HeaderText = "Price";
            this.ColumnPrices.Name = "ColumnPrices";
            this.ColumnPrices.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(368, 400);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(102, 45);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddItems
            // 
            this.buttonAddItems.ForeColor = System.Drawing.Color.Black;
            this.buttonAddItems.Location = new System.Drawing.Point(242, 400);
            this.buttonAddItems.Name = "buttonAddItems";
            this.buttonAddItems.Size = new System.Drawing.Size(106, 45);
            this.buttonAddItems.TabIndex = 12;
            this.buttonAddItems.Text = "Add Items";
            this.buttonAddItems.UseVisualStyleBackColor = true;
            this.buttonAddItems.Click += new System.EventHandler(this.buttonAddItems_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(349, 311);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(121, 27);
            this.textBoxAmount.TabIndex = 11;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(349, 235);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(121, 27);
            this.textBoxQuantity.TabIndex = 10;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(349, 156);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(121, 27);
            this.textBoxPrice.TabIndex = 9;
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(349, 93);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(121, 29);
            this.comboBoxSelect.TabIndex = 8;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(170, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(170, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(170, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(170, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCloseApp;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddItems;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRepay;
        private System.Windows.Forms.TextBox textBoxPay;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonDrinks;
        private System.Windows.Forms.RadioButton radioButtonFood;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}

