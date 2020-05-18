namespace Journal1
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.facultiesComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.buttonOpenTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInstr1 = new System.Windows.Forms.Label();
            this.labelInstr2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // facultiesComboBox
            // 
            this.facultiesComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultiesComboBox.FormattingEnabled = true;
            this.facultiesComboBox.Location = new System.Drawing.Point(270, 33);
            this.facultiesComboBox.Name = "facultiesComboBox";
            this.facultiesComboBox.Size = new System.Drawing.Size(206, 31);
            this.facultiesComboBox.TabIndex = 0;
            this.facultiesComboBox.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox_SelectedIndexChanged);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(270, 87);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(206, 31);
            this.comboBoxGroups.TabIndex = 1;
            // 
            // buttonOpenTable
            // 
            this.buttonOpenTable.AutoSize = true;
            this.buttonOpenTable.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonOpenTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenTable.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTable.ForeColor = System.Drawing.Color.White;
            this.buttonOpenTable.Location = new System.Drawing.Point(12, 245);
            this.buttonOpenTable.Name = "buttonOpenTable";
            this.buttonOpenTable.Size = new System.Drawing.Size(196, 33);
            this.buttonOpenTable.TabIndex = 3;
            this.buttonOpenTable.Text = "Показать таблицу";
            this.buttonOpenTable.UseVisualStyleBackColor = false;
            this.buttonOpenTable.Click += new System.EventHandler(this.buttonOpenTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(314, 179);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 31);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Consolas", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 23);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "label1";
            // 
            // labelInstr1
            // 
            this.labelInstr1.AutoSize = true;
            this.labelInstr1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr1.Location = new System.Drawing.Point(8, 36);
            this.labelInstr1.Name = "labelInstr1";
            this.labelInstr1.Size = new System.Drawing.Size(208, 23);
            this.labelInstr1.TabIndex = 8;
            this.labelInstr1.Text = "Выберите факультет";
            // 
            // labelInstr2
            // 
            this.labelInstr2.AutoSize = true;
            this.labelInstr2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr2.Location = new System.Drawing.Point(8, 90);
            this.labelInstr2.Name = "labelInstr2";
            this.labelInstr2.Size = new System.Drawing.Size(175, 23);
            this.labelInstr2.TabIndex = 9;
            this.labelInstr2.Text = "Выберите группу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Период:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstr2);
            this.Controls.Add(this.labelInstr1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonOpenTable);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.facultiesComboBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Table";
            this.Text = "Таблица посещаемости за период";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox facultiesComboBox;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Button buttonOpenTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInstr1;
        private System.Windows.Forms.Label labelInstr2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}