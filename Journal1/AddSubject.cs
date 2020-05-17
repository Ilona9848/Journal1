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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
                string subject = textBoxSubject.Text;
                Guid id = new Guid(facultiesComboBox.SelectedValue.ToString());
                if (subject == "")
                {
                    MessageBox.Show("Введите название предмета и выберите факультет");
                }
                else
                {
                    string sqlExpression = String.Format("INSERT INTO Subjects (Предмет, Факультет) VALUES ('{0}','{1}')", subject,id);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int number = command.ExecuteNonQuery();
                    }
                    this.Close();
                }
            }
            catch { }
        }

        private void facultiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDataDataSet);

        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        private void buttonAddFaculty_Click(object sender, EventArgs e)
        {
            AddFaculty addFaculty = new AddFaculty();
            addFaculty.ShowDialog();
            addFaculty.Close();
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }
    }
}
