namespace Journal1
{
    partial class ChangeFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeFaculty));
            this.labelFaculty = new System.Windows.Forms.Label();
            this.journalDataDataSet = new Journal1.JournalDataDataSet();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new Journal1.JournalDataDataSetTableAdapters.FacultiesTableAdapter();
            this.tableAdapterManager = new Journal1.JournalDataDataSetTableAdapters.TableAdapterManager();
            this.facultiesComboBox = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelInstr = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.facultiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesComboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxGroups1 = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFaculty.Location = new System.Drawing.Point(12, 71);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(208, 23);
            this.labelFaculty.TabIndex = 0;
            this.labelFaculty.Text = "Выберите факультет";
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
            this.facultiesComboBox.Location = new System.Drawing.Point(264, 68);
            this.facultiesComboBox.Name = "facultiesComboBox";
            this.facultiesComboBox.Size = new System.Drawing.Size(623, 31);
            this.facultiesComboBox.TabIndex = 2;
            this.facultiesComboBox.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox_SelectedIndexChanged);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(12, 127);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(175, 23);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "Выберите группу";
            // 
            // labelInstr
            // 
            this.labelInstr.AutoSize = true;
            this.labelInstr.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr.Location = new System.Drawing.Point(282, 22);
            this.labelInstr.Name = "labelInstr";
            this.labelInstr.Size = new System.Drawing.Size(164, 23);
            this.labelInstr.TabIndex = 4;
            this.labelInstr.Text = "Поиск студента";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(264, 124);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(623, 31);
            this.comboBoxGroups.TabIndex = 5;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 23;
            this.listBoxStudents.Location = new System.Drawing.Point(12, 163);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(875, 257);
            this.listBoxStudents.TabIndex = 6;
            this.listBoxStudents.DoubleClick += new System.EventHandler(this.listBoxStudents_DoubleClick);
            // 
            // facultiesBindingSource1
            // 
            this.facultiesBindingSource1.DataMember = "Faculties";
            this.facultiesBindingSource1.DataSource = this.journalDataDataSet;
            // 
            // facultiesComboBox1
            // 
            this.facultiesComboBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultiesComboBox1.FormattingEnabled = true;
            this.facultiesComboBox1.Location = new System.Drawing.Point(264, 68);
            this.facultiesComboBox1.Name = "facultiesComboBox1";
            this.facultiesComboBox1.Size = new System.Drawing.Size(623, 31);
            this.facultiesComboBox1.TabIndex = 6;
            this.facultiesComboBox1.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox1_SelectedIndexChanged);
            // 
            // comboBoxGroups1
            // 
            this.comboBoxGroups1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroups1.FormattingEnabled = true;
            this.comboBoxGroups1.Location = new System.Drawing.Point(264, 124);
            this.comboBoxGroups1.Name = "comboBoxGroups1";
            this.comboBoxGroups1.Size = new System.Drawing.Size(623, 31);
            this.comboBoxGroups1.TabIndex = 7;
            // 
            // buttonChange
            // 
            this.buttonChange.AutoSize = true;
            this.buttonChange.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.ForeColor = System.Drawing.Color.Transparent;
            this.buttonChange.Location = new System.Drawing.Point(0, 426);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(943, 35);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Перевести студента";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // ChangeFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(943, 461);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.comboBoxGroups1);
            this.Controls.Add(this.facultiesComboBox1);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.labelInstr);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.facultiesComboBox);
            this.Controls.Add(this.labelFaculty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeFaculty";
            this.Text = "Перевод студента";
            this.Load += new System.EventHandler(this.ChangeFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFaculty;
        private JournalDataDataSet journalDataDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private JournalDataDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private JournalDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox facultiesComboBox;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelInstr;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.BindingSource facultiesBindingSource1;
        private System.Windows.Forms.ComboBox facultiesComboBox1;
        private System.Windows.Forms.ComboBox comboBoxGroups1;
        private System.Windows.Forms.Button buttonChange;
    }
}