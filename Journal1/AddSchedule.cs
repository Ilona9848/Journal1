using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal1
{
    public partial class AddSchedule : Form
    {
        string facultySelected;
        string groupSelected;
        int weekSelected;
        int weekDaySelected;
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        bool exist = true;
        public class Groups
        {
            public string Id { get; set; }
            public int Group { get; set; }
            public Groups(object id, object group)
            {
                this.Id = id.ToString();
                this.Group = Convert.ToInt32(group);
            }
        }
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void weekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.weekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDataDataSet);

        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.TypeOfClass". При необходимости она может быть перемещена или удалена.
            this.typeOfClassTableAdapter.Fill(this.journalDataDataSet.TypeOfClass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.journalDataDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Weekday". При необходимости она может быть перемещена или удалена.
            this.weekdayTableAdapter.Fill(this.journalDataDataSet.Weekday);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Week". При необходимости она может быть перемещена или удалена.
            this.weekTableAdapter.Fill(this.journalDataDataSet.Week);
            buttonAdd.Hide();
            labelFirst.Hide();
            labelSecond.Hide();
            labelThird.Hide();
            labelFourth.Hide();
            subjectsComboBox1.Hide();
            subjectsComboBox2.Hide();
            subjectsComboBox3.Hide();
            subjectsComboBox4.Hide();
            typeOfClassComboBox1.Hide();
            typeOfClassComboBox2.Hide();
            typeOfClassComboBox3.Hide();
            typeOfClassComboBox4.Hide();
            try
            {
                weekComboBox.SelectedIndex = -1;
                weekdayComboBox.SelectedIndex=-1;
            }
            catch { }
        }

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                facultySelected = facultiesComboBox.SelectedValue.ToString();
                Group();
            }
            catch { }
        }
        public void Group()
        {
            try
            {
                ArrayList groups = new ArrayList();
                string sqlExpression = "SELECT * FROM Groups";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object id = reader.GetValue(0);
                            object faculty = reader.GetValue(1);
                            object group = reader.GetValue(2);
                            if (faculty.ToString() == facultySelected)
                            {
                                groups.Add(new Groups(id, group));
                            }
                        }
                    }
                    comboBoxGroups.DataSource = groups;
                    comboBoxGroups.DisplayMember = "group";
                    comboBoxGroups.ValueMember = "id";
                    reader.Close();
                }
                comboBoxGroups.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            weekSelected = Convert.ToInt32(weekComboBox.SelectedValue);
            weekDaySelected = Convert.ToInt32(weekdayComboBox.SelectedValue);
            groupSelected = comboBoxGroups.SelectedValue.ToString();
            string sqlExpression = "SELECT * FROM Schedule";
            string sqlExpression1 = String.Format("DELETE FROM Schedule WHERE Неделя={0} WHERE День_недели={1} WHERE Группа={2}", weekSelected, weekDaySelected, new Guid(groupSelected));
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object week = reader.GetValue(1);
                        object weekday = reader.GetValue(2);
                        object group = reader.GetValue(4);
                        if (Convert.ToInt32(week)==weekSelected&&Convert.ToInt32(weekday)==weekDaySelected&&group.ToString()==groupSelected)
                        {
                            MessageBox.Show("Расписание на этот день уже есть");
                            exist = false;
                            break;
                        }
                    }
                }
                reader.Close();
            }
            if (exist) Change();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            labelFaculty.Show();
            labelGroup.Show();
            labelWeek.Show();
            labelWeekDay.Show();
            facultiesComboBox.Show();
            comboBoxGroups.Show();
            weekComboBox.Show();
            weekdayComboBox.Show();
            buttonNext.Show();
            buttonAdd.Hide();
            labelFirst.Hide();
            labelSecond.Hide();
            labelThird.Hide();
            labelFourth.Hide();
            subjectsComboBox1.Hide();
            subjectsComboBox2.Hide();
            subjectsComboBox3.Hide();
            subjectsComboBox4.Hide();
            typeOfClassComboBox1.Hide();
            typeOfClassComboBox2.Hide();
            typeOfClassComboBox3.Hide();
            typeOfClassComboBox4.Hide();
            try
            {
                weekComboBox.SelectedIndex = -1;
                weekdayComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        public void Change()
        {
            try
            {
                labelFaculty.Hide();
                labelGroup.Hide();
                labelWeek.Hide();
                labelWeekDay.Hide();
                facultiesComboBox.Hide();
                comboBoxGroups.Hide();
                weekComboBox.Hide();
                weekdayComboBox.Hide();
                buttonNext.Hide();
                labelFirst.Show();
                labelSecond.Show();
                labelThird.Show();
                labelFourth.Show();
                subjectsComboBox1.Show();
                subjectsComboBox1.SelectedIndex = -1;
                subjectsComboBox2.Show();
                subjectsComboBox2.SelectedIndex = -1;
                subjectsComboBox3.Show();
                subjectsComboBox3.SelectedIndex = -1;
                subjectsComboBox4.Show();
                subjectsComboBox4.SelectedIndex = -1;
                typeOfClassComboBox1.Show();
                typeOfClassComboBox1.SelectedIndex = -1;
                typeOfClassComboBox2.Show();
                typeOfClassComboBox2.SelectedIndex = -1;
                typeOfClassComboBox3.Show();
                typeOfClassComboBox3.SelectedIndex = -1;
                typeOfClassComboBox4.Show();
                typeOfClassComboBox4.SelectedIndex = -1;
                buttonAdd.Show();
            }
            catch { }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (subjectsComboBox1.SelectedIndex!=-1&&typeOfClassComboBox1.SelectedIndex!=-1)
                {
                    Insert(1, subjectsComboBox1.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox1.SelectedValue));
                }
                if(subjectsComboBox2.SelectedIndex != -1 && typeOfClassComboBox2.SelectedIndex != -1)
                {
                    Insert(2, subjectsComboBox2.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox2.SelectedValue));
                }
                if (subjectsComboBox3.SelectedIndex != -1 && typeOfClassComboBox3.SelectedIndex != -1)
                {
                    Insert(3, subjectsComboBox3.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox3.SelectedValue));
                }
                if (subjectsComboBox4.SelectedIndex != -1 && typeOfClassComboBox4.SelectedIndex != -1)
                {
                    Insert(4, subjectsComboBox4.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox4.SelectedValue));
                }
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Заполните предмет и тип занятия");
            }
        }
        public void Insert(int cl, string sub, int type)
        {
            string sqlExpression = String.Format("INSERT INTO Schedule (Неделя, День_недели, Пара, Группа, Предмет, Тип_занятия) VALUES (@week, @weekday ,@class,@group,@subject,@type)");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter weekParam = new SqlParameter("@week", weekSelected);
                command.Parameters.Add(weekParam);
                SqlParameter dayParam = new SqlParameter("@weekday", weekDaySelected);
                command.Parameters.Add(dayParam);
                SqlParameter clParam = new SqlParameter("@class", cl);
                command.Parameters.Add(clParam);
                SqlParameter grParam = new SqlParameter("@group", new Guid(groupSelected));
                command.Parameters.Add(grParam);
                SqlParameter subParam = new SqlParameter("@subject", new Guid(sub));
                command.Parameters.Add(subParam);
                SqlParameter typeParam = new SqlParameter("@type", type);
                command.Parameters.Add(typeParam);
                int number = command.ExecuteNonQuery();
            }

        }
    }
}
