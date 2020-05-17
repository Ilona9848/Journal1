namespace Journal1
{
    partial class AddSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSchedule));
            this.buttonNext = new System.Windows.Forms.Button();
            this.journalDataDataSet = new Journal1.JournalDataDataSet();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekTableAdapter = new Journal1.JournalDataDataSetTableAdapters.WeekTableAdapter();
            this.tableAdapterManager = new Journal1.JournalDataDataSetTableAdapters.TableAdapterManager();
            this.facultiesTableAdapter = new Journal1.JournalDataDataSetTableAdapters.FacultiesTableAdapter();
            this.subjectsTableAdapter = new Journal1.JournalDataDataSetTableAdapters.SubjectsTableAdapter();
            this.typeOfClassTableAdapter = new Journal1.JournalDataDataSetTableAdapters.TypeOfClassTableAdapter();
            this.weekdayTableAdapter = new Journal1.JournalDataDataSetTableAdapters.WeekdayTableAdapter();
            this.weekComboBox = new System.Windows.Forms.ComboBox();
            this.weekdayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekdayComboBox = new System.Windows.Forms.ComboBox();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelWeek = new System.Windows.Forms.Label();
            this.labelWeekDay = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.labelFourth = new System.Windows.Forms.Label();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsComboBox1 = new System.Windows.Forms.ComboBox();
            this.typeOfClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassComboBox1 = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsComboBox2 = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsComboBox3 = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsComboBox4 = new System.Windows.Forms.ComboBox();
            this.typeOfClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassComboBox2 = new System.Windows.Forms.ComboBox();
            this.typeOfClassBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassComboBox3 = new System.Windows.Forms.ComboBox();
            this.typeOfClassBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfClassComboBox4 = new System.Windows.Forms.ComboBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonAddFaculty = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNext.Location = new System.Drawing.Point(749, 25);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 40);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // journalDataDataSet
            // 
            this.journalDataDataSet.DataSetName = "JournalDataDataSet";
            this.journalDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weekBindingSource
            // 
            this.weekBindingSource.DataMember = "Week";
            this.weekBindingSource.DataSource = this.journalDataDataSet;
            // 
            // weekTableAdapter
            // 
            this.weekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.FacultiesTableAdapter = this.facultiesTableAdapter;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.TypeOfClassTableAdapter = this.typeOfClassTableAdapter;
            this.tableAdapterManager.UpdateOrder = Journal1.JournalDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekdayTableAdapter = this.weekdayTableAdapter;
            this.tableAdapterManager.WeekTableAdapter = this.weekTableAdapter;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // typeOfClassTableAdapter
            // 
            this.typeOfClassTableAdapter.ClearBeforeFill = true;
            // 
            // weekdayTableAdapter
            // 
            this.weekdayTableAdapter.ClearBeforeFill = true;
            // 
            // weekComboBox
            // 
            this.weekComboBox.DataSource = this.weekBindingSource;
            this.weekComboBox.DisplayMember = "Неделя";
            this.weekComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekComboBox.FormattingEnabled = true;
            this.weekComboBox.Location = new System.Drawing.Point(230, 218);
            this.weekComboBox.Name = "weekComboBox";
            this.weekComboBox.Size = new System.Drawing.Size(300, 31);
            this.weekComboBox.TabIndex = 9;
            this.weekComboBox.ValueMember = "Неделя";
            // 
            // weekdayBindingSource
            // 
            this.weekdayBindingSource.DataMember = "Weekday";
            this.weekdayBindingSource.DataSource = this.journalDataDataSet;
            // 
            // weekdayComboBox
            // 
            this.weekdayComboBox.DataSource = this.weekdayBindingSource;
            this.weekdayComboBox.DisplayMember = "День недели";
            this.weekdayComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekdayComboBox.FormattingEnabled = true;
            this.weekdayComboBox.Location = new System.Drawing.Point(230, 283);
            this.weekdayComboBox.Name = "weekdayComboBox";
            this.weekdayComboBox.Size = new System.Drawing.Size(300, 31);
            this.weekdayComboBox.TabIndex = 9;
            this.weekdayComboBox.ValueMember = "Id";
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.journalDataDataSet;
            // 
            // facultiesComboBox
            // 
            this.facultiesComboBox.DataSource = this.facultiesBindingSource;
            this.facultiesComboBox.DisplayMember = "Факультет";
            this.facultiesComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultiesComboBox.FormattingEnabled = true;
            this.facultiesComboBox.Location = new System.Drawing.Point(230, 94);
            this.facultiesComboBox.Name = "facultiesComboBox";
            this.facultiesComboBox.Size = new System.Drawing.Size(300, 31);
            this.facultiesComboBox.TabIndex = 9;
            this.facultiesComboBox.ValueMember = "Id";
            this.facultiesComboBox.SelectedIndexChanged += new System.EventHandler(this.facultiesComboBox_SelectedIndexChanged);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(230, 157);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(300, 31);
            this.comboBoxGroups.TabIndex = 10;
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFaculty.Location = new System.Drawing.Point(24, 97);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(109, 23);
            this.labelFaculty.TabIndex = 11;
            this.labelFaculty.Text = "Факультет";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(24, 160);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(76, 23);
            this.labelGroup.TabIndex = 12;
            this.labelGroup.Text = "Группа";
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeek.Location = new System.Drawing.Point(24, 221);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(76, 23);
            this.labelWeek.TabIndex = 13;
            this.labelWeek.Text = "Неделя";
            // 
            // labelWeekDay
            // 
            this.labelWeekDay.AutoSize = true;
            this.labelWeekDay.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeekDay.Location = new System.Drawing.Point(24, 286);
            this.labelWeekDay.Name = "labelWeekDay";
            this.labelWeekDay.Size = new System.Drawing.Size(131, 23);
            this.labelWeekDay.TabIndex = 14;
            this.labelWeekDay.Text = "День недели";
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Location = new System.Drawing.Point(749, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 43);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirst.Location = new System.Drawing.Point(28, 97);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(76, 23);
            this.labelFirst.TabIndex = 16;
            this.labelFirst.Text = "1 пара";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecond.Location = new System.Drawing.Point(28, 160);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(76, 23);
            this.labelSecond.TabIndex = 17;
            this.labelSecond.Text = "2 пара";
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThird.Location = new System.Drawing.Point(28, 221);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(76, 23);
            this.labelThird.TabIndex = 18;
            this.labelThird.Text = "3 пара";
            // 
            // labelFourth
            // 
            this.labelFourth.AutoSize = true;
            this.labelFourth.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFourth.Location = new System.Drawing.Point(28, 286);
            this.labelFourth.Name = "labelFourth";
            this.labelFourth.Size = new System.Drawing.Size(76, 23);
            this.labelFourth.TabIndex = 19;
            this.labelFourth.Text = "4 пара";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.journalDataDataSet;
            // 
            // subjectsComboBox1
            // 
            this.subjectsComboBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectsComboBox1.FormattingEnabled = true;
            this.subjectsComboBox1.Location = new System.Drawing.Point(230, 94);
            this.subjectsComboBox1.Name = "subjectsComboBox1";
            this.subjectsComboBox1.Size = new System.Drawing.Size(188, 31);
            this.subjectsComboBox1.TabIndex = 19;
            // 
            // typeOfClassBindingSource
            // 
            this.typeOfClassBindingSource.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassComboBox1
            // 
            this.typeOfClassComboBox1.DataSource = this.typeOfClassBindingSource;
            this.typeOfClassComboBox1.DisplayMember = "Тип занятия";
            this.typeOfClassComboBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfClassComboBox1.FormattingEnabled = true;
            this.typeOfClassComboBox1.Location = new System.Drawing.Point(464, 94);
            this.typeOfClassComboBox1.Name = "typeOfClassComboBox1";
            this.typeOfClassComboBox1.Size = new System.Drawing.Size(300, 31);
            this.typeOfClassComboBox1.TabIndex = 22;
            this.typeOfClassComboBox1.ValueMember = "Id";
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataMember = "Subjects";
            this.subjectsBindingSource1.DataSource = this.journalDataDataSet;
            // 
            // subjectsComboBox2
            // 
            this.subjectsComboBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectsComboBox2.FormattingEnabled = true;
            this.subjectsComboBox2.Location = new System.Drawing.Point(230, 157);
            this.subjectsComboBox2.Name = "subjectsComboBox2";
            this.subjectsComboBox2.Size = new System.Drawing.Size(188, 31);
            this.subjectsComboBox2.TabIndex = 25;
            // 
            // subjectsBindingSource2
            // 
            this.subjectsBindingSource2.DataMember = "Subjects";
            this.subjectsBindingSource2.DataSource = this.journalDataDataSet;
            // 
            // subjectsComboBox3
            // 
            this.subjectsComboBox3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectsComboBox3.FormattingEnabled = true;
            this.subjectsComboBox3.Location = new System.Drawing.Point(230, 218);
            this.subjectsComboBox3.Name = "subjectsComboBox3";
            this.subjectsComboBox3.Size = new System.Drawing.Size(188, 31);
            this.subjectsComboBox3.TabIndex = 25;
            // 
            // subjectsBindingSource3
            // 
            this.subjectsBindingSource3.DataMember = "Subjects";
            this.subjectsBindingSource3.DataSource = this.journalDataDataSet;
            // 
            // subjectsComboBox4
            // 
            this.subjectsComboBox4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectsComboBox4.FormattingEnabled = true;
            this.subjectsComboBox4.Location = new System.Drawing.Point(230, 283);
            this.subjectsComboBox4.Name = "subjectsComboBox4";
            this.subjectsComboBox4.Size = new System.Drawing.Size(188, 31);
            this.subjectsComboBox4.TabIndex = 25;
            // 
            // typeOfClassBindingSource1
            // 
            this.typeOfClassBindingSource1.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource1.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassComboBox2
            // 
            this.typeOfClassComboBox2.DataSource = this.typeOfClassBindingSource1;
            this.typeOfClassComboBox2.DisplayMember = "Тип занятия";
            this.typeOfClassComboBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfClassComboBox2.FormattingEnabled = true;
            this.typeOfClassComboBox2.Location = new System.Drawing.Point(464, 157);
            this.typeOfClassComboBox2.Name = "typeOfClassComboBox2";
            this.typeOfClassComboBox2.Size = new System.Drawing.Size(300, 31);
            this.typeOfClassComboBox2.TabIndex = 25;
            this.typeOfClassComboBox2.ValueMember = "Id";
            // 
            // typeOfClassBindingSource2
            // 
            this.typeOfClassBindingSource2.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource2.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassComboBox3
            // 
            this.typeOfClassComboBox3.DataSource = this.typeOfClassBindingSource2;
            this.typeOfClassComboBox3.DisplayMember = "Тип занятия";
            this.typeOfClassComboBox3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfClassComboBox3.FormattingEnabled = true;
            this.typeOfClassComboBox3.Location = new System.Drawing.Point(464, 218);
            this.typeOfClassComboBox3.Name = "typeOfClassComboBox3";
            this.typeOfClassComboBox3.Size = new System.Drawing.Size(300, 31);
            this.typeOfClassComboBox3.TabIndex = 25;
            this.typeOfClassComboBox3.ValueMember = "Id";
            // 
            // typeOfClassBindingSource3
            // 
            this.typeOfClassBindingSource3.DataMember = "TypeOfClass";
            this.typeOfClassBindingSource3.DataSource = this.journalDataDataSet;
            // 
            // typeOfClassComboBox4
            // 
            this.typeOfClassComboBox4.DataSource = this.typeOfClassBindingSource3;
            this.typeOfClassComboBox4.DisplayMember = "Тип занятия";
            this.typeOfClassComboBox4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfClassComboBox4.FormattingEnabled = true;
            this.typeOfClassComboBox4.Location = new System.Drawing.Point(464, 283);
            this.typeOfClassComboBox4.Name = "typeOfClassComboBox4";
            this.typeOfClassComboBox4.Size = new System.Drawing.Size(300, 31);
            this.typeOfClassComboBox4.TabIndex = 25;
            this.typeOfClassComboBox4.ValueMember = "Id";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.AutoSize = true;
            this.buttonAddGroup.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGroup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroup.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddGroup.Location = new System.Drawing.Point(28, 403);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(284, 33);
            this.buttonAddGroup.TabIndex = 27;
            this.buttonAddGroup.Text = "Добавить новую группу";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonAddFaculty
            // 
            this.buttonAddFaculty.AutoSize = true;
            this.buttonAddFaculty.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAddFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddFaculty.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFaculty.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddFaculty.Location = new System.Drawing.Point(28, 364);
            this.buttonAddFaculty.Name = "buttonAddFaculty";
            this.buttonAddFaculty.Size = new System.Drawing.Size(284, 33);
            this.buttonAddFaculty.TabIndex = 26;
            this.buttonAddFaculty.Text = "Добавить новый факультет";
            this.buttonAddFaculty.UseVisualStyleBackColor = false;
            this.buttonAddFaculty.Click += new System.EventHandler(this.buttonAddFaculty_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.AutoSize = true;
            this.buttonAddSubject.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddSubject.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSubject.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddSubject.Location = new System.Drawing.Point(28, 364);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(284, 33);
            this.buttonAddSubject.TabIndex = 28;
            this.buttonAddSubject.Text = "Добавить новый предмет";
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(13, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 23);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "label1";
            // 
            // AddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(894, 524);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.buttonAddFaculty);
            this.Controls.Add(this.typeOfClassComboBox4);
            this.Controls.Add(this.typeOfClassComboBox3);
            this.Controls.Add(this.typeOfClassComboBox2);
            this.Controls.Add(this.subjectsComboBox4);
            this.Controls.Add(this.subjectsComboBox3);
            this.Controls.Add(this.subjectsComboBox2);
            this.Controls.Add(this.typeOfClassComboBox1);
            this.Controls.Add(this.subjectsComboBox1);
            this.Controls.Add(this.labelFourth);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelWeekDay);
            this.Controls.Add(this.labelWeek);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.facultiesComboBox);
            this.Controls.Add(this.weekdayComboBox);
            this.Controls.Add(this.weekComboBox);
            this.Controls.Add(this.buttonNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSchedule";
            this.Text = "Добавить расписание";
            this.Load += new System.EventHandler(this.AddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfClassBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private JournalDataDataSet journalDataDataSet;
        private System.Windows.Forms.BindingSource weekBindingSource;
        private JournalDataDataSetTableAdapters.WeekTableAdapter weekTableAdapter;
        private JournalDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private JournalDataDataSetTableAdapters.WeekdayTableAdapter weekdayTableAdapter;
        private System.Windows.Forms.ComboBox weekComboBox;
        private System.Windows.Forms.BindingSource weekdayBindingSource;
        private JournalDataDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private System.Windows.Forms.ComboBox weekdayComboBox;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private System.Windows.Forms.ComboBox facultiesComboBox;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Label labelWeekDay;
        private JournalDataDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelThird;
        private System.Windows.Forms.Label labelFourth;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private JournalDataDataSetTableAdapters.TypeOfClassTableAdapter typeOfClassTableAdapter;
        private System.Windows.Forms.ComboBox subjectsComboBox1;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource;
        private System.Windows.Forms.ComboBox typeOfClassComboBox1;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private System.Windows.Forms.ComboBox subjectsComboBox2;
        private System.Windows.Forms.BindingSource subjectsBindingSource2;
        private System.Windows.Forms.ComboBox subjectsComboBox3;
        private System.Windows.Forms.BindingSource subjectsBindingSource3;
        private System.Windows.Forms.ComboBox subjectsComboBox4;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource1;
        private System.Windows.Forms.ComboBox typeOfClassComboBox2;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource2;
        private System.Windows.Forms.ComboBox typeOfClassComboBox3;
        private System.Windows.Forms.BindingSource typeOfClassBindingSource3;
        private System.Windows.Forms.ComboBox typeOfClassComboBox4;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonAddFaculty;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Label labelName;
    }
}