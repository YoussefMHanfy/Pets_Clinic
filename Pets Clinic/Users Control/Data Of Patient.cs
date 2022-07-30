using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pets_Clinic.Users_Control
{
    public partial class Data_Of_Patient : UserControl
    {
        public Data_Of_Patient()
        {
            InitializeComponent();
        }
        public void NotNull()
        {
            if (dpnp.Text == "")
            {
                MessageBox.Show("You Must Write Name Of Pet", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dpno.Text =="")
            {
                MessageBox.Show("You Must Write Name Of Pet's Owner", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dpa.Text == "")
            {
                MessageBox.Show("You Must Write Name Of Pet's Owner", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dpg.Text == "")
            {
                MessageBox.Show("You Must Write Name Of Pet's Owner", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dptn.Text == "")
            {
                MessageBox.Show("You Must Write Name Of Pet's Owner", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dpadd.Text == "")
            {
                MessageBox.Show("You Must Write Name Of Pet's Owner", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dpno.Text == "")
            {

            }
            else if (dpno.Text == "")
            {

            }
            else if (dpno.Text == "")
            {

            }
            else if (dpno.Text == "")
            {

            }
        }
        public void Clear()
        {
            dpnp.Text = "";
            dpa.Clear();
            dpg.Text = "";
            dptn.Clear();
            dpadd.Clear();
            dpf.Clear();
            dpno.Text = "";
            dpd.Clear();
            dpn.Clear();
            dpm.Clear();
            dpt.Clear();
            dptp.Clear();
        }
        public void ReadOnly(bool x)
        {
            dpa.ReadOnly = x;
            dptn.ReadOnly = x;
            dpa.ReadOnly = x;
            dpadd.ReadOnly = x;
            dpf.ReadOnly = x;
            dpd.ReadOnly = x;
            dpn.ReadOnly = x;
            dpm.ReadOnly = x;
            dpt.ReadOnly = x;
            dptp.ReadOnly = x;
        }
        public void Visi_ble(bool x, bool y, bool z)
        {
            dpnp.Visible = x;
            dplnp.Visible = x;
            dpno.Visible = x;
            dplno.Visible = x;
            dataGridView1.Visible = y;
            dpa.Visible = z;
            dpla.Visible = z;
            dpg.Visible = z;
            dplg.Visible = z;
            dptn.Visible = z;
            dpltn.Visible = z;
            dpadd.Visible = z;
            dpladd.Visible = z;
            dpf.Visible = z;
            dplf.Visible = z;
            dpd.Visible = z;
            dpld.Visible = z;
            dpn.Visible = z;
            dpln.Visible = z;
            dpm.Visible = z;
            dplm.Visible = z;
            dpt.Visible = z;
            dplt.Visible = z;
            dptp.Visible = z;
            dpltp.Visible = z;
        }
        private void Data_Of_Patient_Load(object sender, EventArgs e)
        {

        }

        private void dpupdate_Click(object sender, EventArgs e)
        {
            Clear();
            ReadOnly(false);
            tableLayoutPanel1.Visible = true;
            dpbtn.Text = "Search";
            Visi_ble(true, true, false);
        }

        private void dpsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BH4EKKE\SQLEXPRESS;Initial Catalog=Pets_Clinic;Integrated Security=True");
            con.Open();

            if (dpbtn.Text == "Save")
            {
                
                        MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
            }
            else if (dpbtn.Text == "Search")
            {
                Visi_ble(true, true, true);
                dpbtn.Text = "Edit";
                ReadOnly(true);
            }
            else if (dpbtn.Text == "Edit")
            {
                ReadOnly(false);
                dpbtn.Text = "Update";
            }
            else if (dpbtn.Text == "Update")
            {

                MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                ReadOnly(false);
                tableLayoutPanel1.Visible = true;
                dpbtn.Text = "Search";
                Visi_ble(true, true, false);
            }
        }

        private void dpinsert_Click(object sender, EventArgs e)
        {
            Clear();
            tableLayoutPanel1.Visible = true;
            dpbtn.Text = "Save";
            Visi_ble(true, false, true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dpld_Click(object sender, EventArgs e)
        {

        }

        private void dpnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dplt_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
