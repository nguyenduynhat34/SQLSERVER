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
    public partial class FormBookManage : Form
    {
        public FormBookManage()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }   

        private void FormBookManage_Load(object sender, EventArgs e)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = Program.connstr;
                String selectCommand = "Select * from ISBN";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBookID.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            textBoxBookName.Text = dataGridView1.CurrentRow.Cells["TENSACH"].Value.ToString();
            textBoxBookSize.Text = dataGridView1.CurrentRow.Cells["KHOSACH"].Value.ToString();
            textBoxBookContent.Text = dataGridView1.CurrentRow.Cells["NOIDUNG"].Value.ToString();
            textBoxPublishTime.Text = dataGridView1.CurrentRow.Cells["LANXUATBAN"].Value.ToString();
            textBoxBookPages.Text = dataGridView1.CurrentRow.Cells["SOTRANG"].Value.ToString();
            textBoxBookCost.Text = dataGridView1.CurrentRow.Cells["GIA"].Value.ToString();
            textBoxPublishHouse.Text = dataGridView1.CurrentRow.Cells["NHAXB"].Value.ToString();
            textBoxLangID.Text = dataGridView1.CurrentRow.Cells["MANGONNGU"].Value.ToString();
            textBoxBookTypeID.Text = dataGridView1.CurrentRow.Cells["MATL"].Value.ToString();
        }

        private void pictureBoxBookCover_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "image files (*.png; *.jpeg; *.jpg)|*.png; *.jpeg; *.jpg|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a image file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                //richTextBox1.Text = System.IO.File.ReadAllText(fname);
                //MessageBox.Show(fname);
                //Image image = Image.FromFile(fname);
               
                pictureBoxBookCover.Image = Image.FromFile(fname);
            }
        }
    }
}
