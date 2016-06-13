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
    public partial class FormReader : Form
    {
        public FormReader()
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

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormReader_Load(object sender, EventArgs e)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = Program.connstr;
                String selectCommand = "Select * from DOCGIA";

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
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBoxReaderID.Text = dataGridView1.CurrentRow.Cells["MADG"].Value.ToString();
            textBoxReaderFirstname.Text = dataGridView1.CurrentRow.Cells["HODG"].Value.ToString();
            textBoxReaderLastname.Text = dataGridView1.CurrentRow.Cells["TENDG"].Value.ToString();
            textBoxReaderEmail.Text = dataGridView1.CurrentRow.Cells["EMAILDG"].Value.ToString();
            textBoxReaderNumberID.Text = dataGridView1.CurrentRow.Cells["SOCMND"].Value.ToString();
            textBoxReaderAddress.Text = dataGridView1.CurrentRow.Cells["DIACHI"].Value.ToString();
            textBoxReaderPhone.Text = dataGridView1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            dateTimePickerReaderBirth.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString());
            dateTimePickerBeginDay.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYLAMTHE"].Value.ToString());
            dateTimePickerEndDay.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYHETHAN"].Value.ToString());

            String gender = dataGridView1.CurrentRow.Cells["GIOITINH"].Value.ToString();
            if(gender == "True")
            {
                radioButtonMale.Checked = true;
            } else
            {
                radioButtonFemale.Checked = true;
            }
            String isActive = dataGridView1.CurrentRow.Cells["HOATDONG"].Value.ToString();
            if (isActive == "True")
            {
                radioButtonActive.Checked = true;
            } else
            {
                radioButtonUnActive.Checked = true;
            }
        }
    }
}
