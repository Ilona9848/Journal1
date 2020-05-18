﻿using System;
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
    public partial class Table : Form
    {
        public class Faculties
        {
            public string Id { get; set; }
            public string Faculty { get; set; }
            public Faculties(object id, object faculty)
            {
                this.Id = id.ToString();
                this.Faculty = faculty.ToString();
            }
        }

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

        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";

        string facultySelected, groupSelected;
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            facultiesComboBox.SelectedIndex = -1;
            labelName.Hide();
            dataGridView1.Hide();
        }

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                facultySelected = facultiesComboBox.SelectedValue.ToString();
                LoadGroups();
            }
            catch
            {

            }
        }

        public void LoadFaculties()
        {
            string sqlExpression = "SELECT * FROM Faculties ORDER BY Факультет";
            List<Faculties> listFaculties = new List<Faculties>();
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
                        listFaculties.Add(new Faculties(id, faculty));
                    }
                }
                facultiesComboBox.DataSource = listFaculties;
                facultiesComboBox.DisplayMember = "faculty";
                facultiesComboBox.ValueMember = "id";
                reader.Close();
            }
        }

        

        public void LoadGroups()
        {
            try
            {
                ArrayList groups = new ArrayList();
                string sqlExpression = "SELECT * FROM Groups ORDER BY Группа";
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

        private void buttonOpenTable_Click(object sender, EventArgs e)
        {
            labelInstr1.Hide();
            labelInstr2.Hide();
            label1.Hide();
            label2.Hide();
            string n = "";
            groupSelected = comboBoxGroups.SelectedValue.ToString();
            string sqlexpression1 = "SELECT * FROM Faculties";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlexpression1, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object faculty = reader.GetValue(1);
                        if (id.ToString() == facultySelected)
                        {
                            n = faculty.ToString() + " ";
                        }
                    }
                }
                reader.Close();
            }
            string sqlexpression4 = "SELECT * FROM Groups";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlexpression4, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object group = reader.GetValue(2);
                        if (id.ToString() == groupSelected)
                        {
                            n = n + " " + group.ToString() + " группа ";
                        }
                    }
                }
                reader.Close();
            }
            labelName.Text = n;
            labelName.Show();
            comboBoxGroups.Hide();
            facultiesComboBox.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            buttonOpenTable.Hide();
            groupSelected = comboBoxGroups.SelectedValue.ToString();
            DateTime begin = dateTimePicker1.Value;
            begin = new DateTime(begin.Year, begin.Month, begin.Day, 0, 0, 0);
            DateTime end = dateTimePicker2.Value;
            end = new DateTime(end.Year, end.Month, end.Day, 0, 0, 0);
            this.Text = begin.ToShortDateString() + "-" + end.ToShortDateString();
            dataGridView1.Show();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns.Add("Name", "Имя студента");
            for(DateTime h=begin;h<=end;h=h.AddDays(1))
            {
                dataGridView1.Columns.Add(h.ToShortDateString(),h.ToShortDateString());
            }
            string sqlExpression = "SELECT * FROM Students";
            string sqlExpression1 = "SELECT * FROM Attendance ORDER BY Студент";
            int row = 0;
            dataGridView1.Columns.Add("Sum", "Всего");
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
                        string surname = reader.GetString(3);
                        string name = reader.GetString(4);
                        if (group.ToString() == groupSelected)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[row].Cells[0].Value = id.ToString();
                            dataGridView1.Rows[row].Cells[1].Value = surname+" "+name;
                            row++;
                        }
                    }
                }
                reader.Close();
                row = 0;
                command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader1 = command.ExecuteReader();
                if(reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        object student = reader1.GetValue(1);
                        object date = reader1.GetValue(3);
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == student.ToString() && Convert.ToDateTime(date) >= begin && Convert.ToDateTime(date) <= end)
                            {
                                object d = dataGridView1.Rows[i].Cells[Convert.ToDateTime(date).ToShortDateString()].Value;
                                if (d == null)
                                    dataGridView1.Rows[i].Cells[Convert.ToDateTime(date).ToShortDateString()].Value = 1;
                                else
                                    dataGridView1.Rows[i].Cells[Convert.ToDateTime(date).ToShortDateString()].Value = Convert.ToInt32(d) + 1;
                                break;
                            }
                        }
                    }
                    
                }
                reader1.Close();
            }
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                int count = 0;
                for(int k=2;k<dataGridView1.Columns.Count;k++)
                {
                    object d = dataGridView1.Rows[i].Cells[k].Value;
                    if (d != null)
                        count += Convert.ToInt32(d);
                }
                dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value = count;
            }
            
        }
    }
}
