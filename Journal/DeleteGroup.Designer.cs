namespace Journal1
{
    partial class DeleteGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGroup));
            this.labelInstruction = new System.Windows.Forms.Label();
            this.journalDataDataSet = new Journal1.JournalDataDataSet();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new Journal1.JournalDataDataSetTableAdapters.FacultiesTableAdapter();
            this.tableAdapterManager = new Journal1.JournalDataDataSetTableAdapters.TableAdapterManager();
            this.facultiesComboBox = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(12, 18);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(208, 23);
            this.labelInstruction.TabIndex = 3;
            this.labelInstruction.Text = "Выберите факультет";
            // 
            // journalDataDataSet
            // 
            this.journalDataDataSet.DataSetName = "JournalDataDataSet";
            this.journalDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.journalDataDataSet;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.FacultiesTableAdapter = this.facultiesTableAdapter;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TypeOfClassTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Journal1.JournalDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekdayTableAdapter = null;
            this.tableAdapterManager.WeekTableAdapter = null;
            // 
            // facultiesComboBox
            // 
            this.facultiesComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultiesComboBox.FormattingEnabled = true;
            this.facultiesComboBox.Location = new System.Drawing.Point(16, 64);
            this.facultiesComboBox.Name = "facultiesComboBox";
            this.facultiesComboBox.Size = new System.Drawing.Size(750, 31);
            this.facultiesComboBox.TabIndex = 4;
            this.facultiesComboBox.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox_SelectedIndexChanged);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(12, 115);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(76, 23);
            this.labelGroup.TabIndex = 5;
            this.labelGroup.Text = "Группа";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxGroups.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 23;
            this.listBoxGroups.Location = new System.Drawing.Point(16, 178);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(750, 234);
            this.listBoxGroups.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(590, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(176, 35);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить группу";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DeleteGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.facultiesComboBox);
            this.Controls.Add(this.labelInstruction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteGroup";
            this.Text = "Удалить группу";
            this.Load += new System.EventHandler(this.DeleteGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private JournalDataDataSet journalDataDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private JournalDataDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private JournalDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox facultiesComboBox;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonDelete;
    }
}