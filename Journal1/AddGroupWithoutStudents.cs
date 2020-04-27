using System;
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
    public partial class AddGroupWithoutStudents : Form
    {
        string facultySelected;
        public AddGroupWithoutStudents()
        {
            InitializeComponent();
        }

        private void facultiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDataDataSet);

        }

        private void AddGroupWithoutStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            labelInstruction2.Hide();
            textBoxGroup.Hide();
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            facultySelected = facultiesComboBox.SelectedValue.ToString();
            labelInstruction2.Show();
            textBoxGroup.Show();
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
                int group = Convert.ToInt32(textBoxGroup.Text);
                string sqlExpression = "INSERT INTO Groups (Факультет, Группа) VALUES (@faculty, @group)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlParameter facultyParam = new SqlParameter("@faculty", new Guid(facultySelected));
                    command.Parameters.Add(facultyParam);
                    SqlParameter groupParam = new SqlParameter("@group", group);
                    command.Parameters.Add(groupParam);
                    int number = command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Выберите факультет и введите номер группы");
            }
        }

        private void facultiesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
                    }
    }
}
