namespace Journal1
{
    partial class DeleteSubject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteSubject));
            this.facultiesComboBox = new System.Windows.Forms.ComboBox();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalDataDataSet = new Journal1.JournalDataDataSet();
            this.labelInstr = new System.Windows.Forms.Label();
            this.labelInstr2 = new System.Windows.Forms.Label();
            this.facultiesTableAdapter = new Journal1.JournalDataDataSetTableAdapters.FacultiesTableAdapter();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // facultiesComboBox
            // 
            this.facultiesComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultiesComboBox.FormattingEnabled = true;
            this.facultiesComboBox.Location = new System.Drawing.Point(16, 65);
            this.facultiesComboBox.Name = "facultiesComboBox";
            this.facultiesComboBox.Size = new System.Drawing.Size(752, 31);
            this.facultiesComboBox.TabIndex = 14;
            this.facultiesComboBox.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox_SelectedIndexChanged);
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.journalDataDataSet;
            // 
            // journalDataDataSet
            // 
            this.journalDataDataSet.DataSetName = "JournalDataDataSet";
            this.journalDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelInstr
            // 
            this.labelInstr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInstr.AutoSize = true;
            this.labelInstr.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr.Location = new System.Drawing.Point(12, 23);
            this.labelInstr.Name = "labelInstr";
            this.labelInstr.Size = new System.Drawing.Size(208, 23);
            this.labelInstr.TabIndex = 13;
            this.labelInstr.Text = "Выберите факультет";
            // 
            // labelInstr2
            // 
            this.labelInstr2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInstr2.AutoSize = true;
            this.labelInstr2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr2.Location = new System.Drawing.Point(12, 123);
            this.labelInstr2.Name = "labelInstr2";
            this.labelInstr2.Size = new System.Drawing.Size(208, 23);
            this.labelInstr2.TabIndex = 15;
            this.labelInstr2.Text = "Выберите факультет";
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 23;
            this.listBoxSubjects.Location = new System.Drawing.Point(16, 181);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(752, 234);
            this.listBoxSubjects.TabIndex = 40;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(660, 14);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 40);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Удалить предмет";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DeleteSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxSubjects);
            this.Controls.Add(this.labelInstr2);
            this.Controls.Add(this.facultiesComboBox);
            this.Controls.Add(this.labelInstr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteSubject";
            this.Text = "Удалить предмет";
            this.Load += new System.EventHandler(this.DeleteSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox facultiesComboBox;
        private System.Windows.Forms.Label labelInstr;
        private System.Windows.Forms.Label labelInstr2;
        private JournalDataDataSet journalDataDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private JournalDataDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.Button buttonDelete;
    }
}