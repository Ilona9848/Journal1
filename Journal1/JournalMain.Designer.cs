namespace Journal1
{
    partial class JournalMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSubjectsList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFacultiesList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.journalDataDataSet = new Journal1.JournalDataDataSet();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new Journal1.JournalDataDataSetTableAdapters.FacultiesTableAdapter();
            this.tableAdapterManager = new Journal1.JournalDataDataSetTableAdapters.TableAdapterManager();
            this.groupsTableAdapter = new Journal1.JournalDataDataSetTableAdapters.GroupsTableAdapter();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new Journal1.JournalDataDataSetTableAdapters.SubjectsTableAdapter();
            this.subjectsListBox = new System.Windows.Forms.ListBox();
            this.facultiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesListBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassTableAdapter = new Journal1.JournalDataDataSetTableAdapters.TypeOfClassTableAdapter();
            this.typeOfClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdd,
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1245, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // ToolStripMenuItemAdd
            // 
            this.ToolStripMenuItemAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ToolStripMenuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddFaculty,
            this.ToolStripMenuItemAddGroup,
            this.ToolStripMenuItemAddStudent,
            this.ToolStripMenuItemAddSubject,
            this.ToolStripMenuItemAddSchedule});
            this.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            this.ToolStripMenuItemAdd.Size = new System.Drawing.Size(137, 37);
            this.ToolStripMenuItemAdd.Text = "Добавить";
            // 
            // ToolStripMenuItemAddFaculty
            // 
            this.ToolStripMenuItemAddFaculty.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemAddFaculty.Name = "ToolStripMenuItemAddFaculty";
            this.ToolStripMenuItemAddFaculty.Size = new System.Drawing.Size(270, 42);
            this.ToolStripMenuItemAddFaculty.Text = "факультет";
            this.ToolStripMenuItemAddFaculty.Click += new System.EventHandler(this.ToolStripMenuItemAddFaculty_Click);
            // 
            // ToolStripMenuItemAddGroup
            // 
            this.ToolStripMenuItemAddGroup.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemAddGroup.Name = "ToolStripMenuItemAddGroup";
            this.ToolStripMenuItemAddGroup.Size = new System.Drawing.Size(270, 42);
            this.ToolStripMenuItemAddGroup.Text = "группу";
            this.ToolStripMenuItemAddGroup.Click += new System.EventHandler(this.ToolStripMenuItemAddGroup_Click);
            // 
            // ToolStripMenuItemAddStudent
            // 
            this.ToolStripMenuItemAddStudent.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemAddStudent.Name = "ToolStripMenuItemAddStudent";
            this.ToolStripMenuItemAddStudent.Size = new System.Drawing.Size(270, 42);
            this.ToolStripMenuItemAddStudent.Text = "студента";
            this.ToolStripMenuItemAddStudent.Click += new System.EventHandler(this.ToolStripMenuItemAddStudent_Click);
            // 
            // ToolStripMenuItemAddSubject
            // 
            this.ToolStripMenuItemAddSubject.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemAddSubject.Name = "ToolStripMenuItemAddSubject";
            this.ToolStripMenuItemAddSubject.Size = new System.Drawing.Size(270, 42);
            this.ToolStripMenuItemAddSubject.Text = "предмет";
            this.ToolStripMenuItemAddSubject.Click += new System.EventHandler(this.ToolStripMenuItemAddSubject_Click);
            // 
            // ToolStripMenuItemAddSchedule
            // 
            this.ToolStripMenuItemAddSchedule.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemAddSchedule.Name = "ToolStripMenuItemAddSchedule";
            this.ToolStripMenuItemAddSchedule.Size = new System.Drawing.Size(270, 42);
            this.ToolStripMenuItemAddSchedule.Text = "расписание";
            this.ToolStripMenuItemAddSchedule.Click += new System.EventHandler(this.ToolStripMenuItemAddSchedule_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSubjectsList,
            this.ToolStripMenuItemFacultiesList});
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(140, 37);
            this.ToolStripMenuItemOpen.Text = "Открыть";
            // 
            // ToolStripMenuItemSubjectsList
            // 
            this.ToolStripMenuItemSubjectsList.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemSubjectsList.Name = "ToolStripMenuItemSubjectsList";
            this.ToolStripMenuItemSubjectsList.Size = new System.Drawing.Size(355, 42);
            this.ToolStripMenuItemSubjectsList.Text = "список предметов";
            this.ToolStripMenuItemSubjectsList.Click += new System.EventHandler(this.ToolStripMenuItemSubjectsList_Click);
            // 
            // ToolStripMenuItemFacultiesList
            // 
            this.ToolStripMenuItemFacultiesList.BackColor = System.Drawing.Color.Thistle;
            this.ToolStripMenuItemFacultiesList.Name = "ToolStripMenuItemFacultiesList";
            this.ToolStripMenuItemFacultiesList.Size = new System.Drawing.Size(355, 42);
            this.ToolStripMenuItemFacultiesList.Text = "список факультетов";
            this.ToolStripMenuItemFacultiesList.Click += new System.EventHandler(this.ToolStripMenuItemFacultiesList_Click);
            // 
            // ToolStripMenuItemBack
            // 
            this.ToolStripMenuItemBack.Name = "ToolStripMenuItemBack";
            this.ToolStripMenuItemBack.Size = new System.Drawing.Size(362, 37);
            this.ToolStripMenuItemBack.Text = "Вернуться на главный экран";
            this.ToolStripMenuItemBack.Click += new System.EventHandler(this.ToolStripMenuItemBack_Click);
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
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TypeOfClassTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Journal1.JournalDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekdayTableAdapter = null;
            this.tableAdapterManager.WeekTableAdapter = null;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.journalDataDataSet;
            // 
            // facultiesBindingSource1
            // 
            this.facultiesBindingSource1.DataMember = "Faculties";
            this.facultiesBindingSource1.DataSource = this.journalDataDataSet;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 33;
            this.listBoxGroups.Location = new System.Drawing.Point(12, 116);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(300, 367);
            this.listBoxGroups.TabIndex = 2;
            this.listBoxGroups.Click += new System.EventHandler(this.listBoxGroups_Click);
            this.listBoxGroups.DoubleClick += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.journalDataDataSet;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.DataSource = this.subjectsBindingSource;
            this.subjectsListBox.DisplayMember = "Предмет";
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.ItemHeight = 33;
            this.subjectsListBox.Location = new System.Drawing.Point(12, 116);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(300, 367);
            this.subjectsListBox.TabIndex = 3;
            this.subjectsListBox.ValueMember = "Id";
            // 
            // facultiesBindingSource2
            // 
            this.facultiesBindingSource2.DataMember = "Faculties";
            this.facultiesBindingSource2.DataSource = this.journalDataDataSet;
            // 
            // facultiesBindingSource3
            // 
            this.facultiesBindingSource3.DataMember = "Faculties";
            this.facultiesBindingSource3.DataSource = this.journalDataDataSet;
            // 
            // facultiesListBox
            // 
            this.facultiesListBox.DataSource = this.facultiesBindingSource3;
            this.facultiesListBox.DisplayMember = "Факультет";
            this.facultiesListBox.FormattingEnabled = true;
            this.facultiesListBox.ItemHeight = 33;
            this.facultiesListBox.Location = new System.Drawing.Point(12, 116);
            this.facultiesListBox.Name = "facultiesListBox";
            this.facultiesListBox.Size = new System.Drawing.Size(300, 367);
            this.facultiesListBox.TabIndex = 3;
            this.facultiesListBox.ValueMember = "Id";
            this.facultiesListBox.SelectedIndexChanged += new System.EventHandler(this.facultiesListBox_SelectedIndexChanged_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(354, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(296, 40);
            this.dateTimePicker.TabIndex = 4;
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataMember = "Subjects";
            this.subjectsBindingSource1.DataSource = this.journalDataDataSet;
            // 
            // subjectsBindingSource2
            // 
            this.subjectsBindingSource2.DataMember = "Subjects";
            this.subjectsBindingSource2.DataSource = this.journalDataDataSet;
            // 
            // subjectsBindingSource3
            // 
            this.subjectsBindingSource3.DataMember = "Subjects";
            this.subjectsBindingSource3.DataSource = this.journalDataDataSet;
            // 
            // subjectsBindingSource4
            // 
            this.subjectsBindingSource4.DataMember = "Subjects";
            this.subjectsBindingSource4.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassBindingSource
            // 
            this.typeOfClassBindingSource.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassTableAdapter
            // 
            this.typeOfClassTableAdapter.ClearBeforeFill = true;
            // 
            // typeOfClassBindingSource1
            // 
            this.typeOfClassBindingSource1.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource1.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassBindingSource2
            // 
            this.typeOfClassBindingSource2.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource2.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassBindingSource3
            // 
            this.typeOfClassBindingSource3.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource3.DataSource = this.journalDataDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // buttonNext
            // 
            this.buttonNext.AutoSize = true;
            this.buttonNext.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonNext.Location = new System.Drawing.Point(703, 70);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(181, 43);
            this.buttonNext.TabIndex = 25;
            this.buttonNext.Text = "Выбрать пару";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "1 пара";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(12, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 43);
            this.button2.TabIndex = 27;
            this.button2.Text = "2 пара";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Location = new System.Drawing.Point(12, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 43);
            this.button3.TabIndex = 28;
            this.button3.Text = "3 пара";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(12, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 43);
            this.button4.TabIndex = 29;
            this.button4.Text = "4 пара";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 33);
            this.label4.TabIndex = 31;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "label2";
            // 
            // JournalMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1245, 742);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.facultiesListBox);
            this.Controls.Add(this.subjectsListBox);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JournalMain";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddFaculty;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddGroup;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddStudent;
        private JournalDataDataSet journalDataDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private JournalDataDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private JournalDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private JournalDataDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.BindingSource facultiesBindingSource1;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddSubject;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSubjectsList;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private JournalDataDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.ListBox subjectsListBox;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddSchedule;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFacultiesList;
        private System.Windows.Forms.BindingSource facultiesBindingSource2;
        private System.Windows.Forms.BindingSource facultiesBindingSource3;
        private System.Windows.Forms.ListBox facultiesListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private System.Windows.Forms.BindingSource subjectsBindingSource2;
        private System.Windows.Forms.BindingSource subjectsBindingSource3;
        private System.Windows.Forms.BindingSource subjectsBindingSource4;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource;
        private JournalDataDataSetTableAdapters.TypeOfClassTableAdapter typeOfClassTableAdapter;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource1;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource2;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

