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
    public partial class FormBookReturn : Form
    {
        String readerID;
        public FormBookReturn()
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

        private void FormBookReturn_Load(object sender, EventArgs e)
        {
            String connectionString = Program.connstr;
            String selectCommand = "Select * from PHIEUMUON";

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

        private void buttonFind_Click(object sender, EventArgs e)
        {
            readerID = textBoxSsearchReaderID.Text;
            String connectionString = Program.connstr;
            String selectCommand = "Select * from PHIEUMUON WHERE MADG = '" + readerID + "'";

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
    }
}
