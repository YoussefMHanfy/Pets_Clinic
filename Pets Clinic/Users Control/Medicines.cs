using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pets_Clinic.Users_Control
{
    public partial class Medicines : UserControl
    {
        public Medicines()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            mn.Text = "";
            mq.Clear();
            ms.Clear();
            mts.Clear();
            mp.Clear();
        }
        public void ReadOnly(bool x)
        {
            mq.ReadOnly = x;
            ms.ReadOnly = x;
            mts.ReadOnly = x;
            mp.ReadOnly = x;
        }
        public void Visi_ble(bool x,bool y,bool z)
        {
            mn.Visible = x;
            mln.Visible = x;
            dataGridView1.Visible = y;
            mq.Visible = z;
            mlq.Visible = z;
            ms.Visible = z;
            mls.Visible = z;
            mts.Visible = z;
            mlts.Visible = z;
            mp.Visible = z;
            mlp.Visible = z;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sinsert_Click(object sender, EventArgs e)
        {
            Clear();
            tableLayoutPanel1.Visible = true;
            mbtn.Text = "Save";
            Visi_ble(true, true, true);
        }

        private void mupdate_Click(object sender, EventArgs e)
        {
            Clear();
            ReadOnly(false);
            tableLayoutPanel1.Visible = true;
            mbtn.Text = "Search";
            Visi_ble(true, true, false);
        }

        private void mbtn_Click(object sender, EventArgs e)
        {
            if (mbtn.Text == "Save")
            {
                MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else if (mbtn.Text == "Search")
            {
                Visi_ble(true, true, true);
                mbtn.Text = "Edit";
                ReadOnly(true);
            }
            else if (mbtn.Text == "Edit")
            {
                ReadOnly(false);
                mbtn.Text = "Update";
            }
            else if (mbtn.Text == "Update")
            {
                MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                ReadOnly(false);
                tableLayoutPanel1.Visible = true;
                mbtn.Text = "Search";
                Visi_ble(true, true, false);
            }
        }
    }
}
