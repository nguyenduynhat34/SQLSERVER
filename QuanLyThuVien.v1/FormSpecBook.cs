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

namespace QuanLyThuVien.v1
{
    public partial class FormSpecBook : Form
    {
        public FormSpecBook()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void FormSpecBook_Load(object sender, EventArgs e)
        {
            // Specify a connection string. Replace the given value with a 
            // valid connection string for a Northwind SQL Server sample
            // database accessible to your system.
            String connectionString = Program.connstr;
            String selectCommand = "Select * from SACH";

            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            textBoxBookID.Text = dataGridView1.CurrentRow.Cells["MASACH"].Value.ToString();
            textBoxBookcaseId.Text = dataGridView1.CurrentRow.Cells["MANGANTU"].Value.ToString();
            String condition = dataGridView1.CurrentRow.Cells["TINHTRANG"].Value.ToString();

            if (condition == "True")
            {
                radioButtonNew.Checked = true;
            }
            else
            {
                radioButtonOld.Checked = true;
            }

            String rent = dataGridView1.CurrentRow.Cells["CHOMUON"].Value.ToString();
            if (rent == "True")
            {
                radioButtonRentted.Checked = true;
            }
            else
            {
                radioButtonNotRent.Checked = true;
            }
        }
    }
}
