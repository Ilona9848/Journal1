namespace Journal1
{
    partial class AddGroupWithoutStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupWithoutStudents));
            this.labelInstruction = new System.Windows.Forms.Label();
            this.journalDataDataSet = new Journal1.JournalDataDataSet();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new Journal1.JournalDataDataSetTableAdapters.FacultiesTableAdapter();
            this.tableAdapterManager = new Journal1.JournalDataDataSetTableAdapters.TableAdapterManager();
            this.facultiesComboBox = new System.Windows.Forms.ComboBox();
            this.labelInstruction2 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(219, 76);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(263, 33);
            this.labelInstruction.TabIndex = 2;
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
            this.facultiesComboBox.DataSource = this.facultiesBindingSource;
            this.facultiesComboBox.DisplayMember = "Факультет";
            this.facultiesComboBox.FormattingEnabled = true;
            this.facultiesComboBox.Location = new System.Drawing.Point(199, 121);
            this.facultiesComboBox.Name = "facultiesComboBox";
            this.facultiesComboBox.Size = new System.Drawing.Size(300, 28);
            this.facultiesComboBox.TabIndex = 3;
            this.facultiesComboBox.ValueMember = "Id";
            this.facultiesComboBox.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox_SelectedIndexChanged);
            // 
            // labelInstruction2
            // 
            this.labelInstruction2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInstruction2.AutoSize = true;
            this.labelInstruction2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction2.Location = new System.Drawing.Point(219, 195);
            this.labelInstruction2.Name = "labelInstruction2";
            this.labelInstruction2.Size = new System.Drawing.Size(269, 33);
            this.labelInstruction2.TabIndex = 4;
            this.labelInstruction2.Text = "Введите номер группы";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(290, 263);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 26);
            this.textBoxGroup.TabIndex = 5;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNext.Location = new System.Drawing.Point(668, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 40);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // AddGroupWithoutStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelInstruction2);
            this.Controls.Add(this.facultiesComboBox);
            this.Controls.Add(this.labelInstruction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGroupWithoutStudents";
            this.Text = "Добавить группу";
            this.Load += new System.EventHandler(this.AddGroupWithoutStudents_Load);
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
        private System.Windows.Forms.Label labelInstruction2;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button buttonNext;
    }
}