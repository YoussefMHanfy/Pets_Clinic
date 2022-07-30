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
    public partial class Staff : UserControl
    {
        public Staff()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            sn.Text = "";
            sa.Clear();
            stn.Clear();
            sadd.Clear();
            sg.Text = "";
            spf.Text = "";
            sp.Text = "";
            scs.Text = "";
            sc.Clear();
            si.Clear();
            sm.Text = "";
            ss.Clear();
        }
        public void ReadOnly(bool x)
        {
            sa.ReadOnly = x;
            stn.ReadOnly = x;
            sadd.ReadOnly = x;
            sc.ReadOnly = x;
            si.ReadOnly = x;
            ss.ReadOnly = x;
        }
        public void Visi_ble(bool x, bool y, bool z)
        {
            sn.Visible = x;
            sa.Visible = z;
            stn.Visible = z;
            sadd.Visible = z;
            sg.Visible = z;
            spf.Visible = z;
            sp.Visible = z;
            scs.Visible = z;
            sc.Visible = z;
            sln.Visible = x;
            sla.Visible = z;
            sltn.Visible = z;
            sladd.Visible = z;
            slg.Visible = z;
            slpf.Visible = z;
            slp.Visible = z;
            slcs.Visible = z;
            slc.Visible = z;
            slm.Visible = z;
            sm.Visible = z;
            sli.Visible = z;
            si.Visible = z;

            if (Main_Form.a == true || z == false)
            {
                sls.Visible = z;
                ss.Visible = z;
            }            
            dataGridView1.Visible = y;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sls_Click(object sender, EventArgs e)
        {

        }

        private void ss_TextChanged(object sender, EventArgs e)
        {

        }

        private void sinsert_Click(object sender, EventArgs e)
        {
            if (Main_Form.a == false)
            {
                MessageBox.Show("This is Out Your Permission","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Clear();
            tableLayoutPanel1.Visible = true;
            sbtn.Text = "Save";
            Visi_ble(true, false, true);
        }

        private void supdate_Click(object sender, EventArgs e)
        {
            Clear();
            ReadOnly(false);
            tableLayoutPanel1.Visible = true;
            sbtn.Text = "Search";
            Visi_ble(true, true, false);
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            if (sbtn.Text == "Save")
            {
                MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else if (sbtn.Text == "Search")
            {
                Visi_ble(true, true, true);
                if (Main_Form.a == true)
                {
                    sbtn.Text = "Edit";
                    ReadOnly(true);
                }
                else if (Main_Form.a == false)
                {
                    sbtn.Text = "Reset";
                }
            }
            else if (sbtn.Text == "Edit")
            {
                ReadOnly(false);
                sbtn.Text = "Update";
            }
            else if (sbtn.Text == "Update")
            {
                MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                ReadOnly(false);
                tableLayoutPanel1.Visible = true;
                sbtn.Text = "Search";
                Visi_ble(true, true, false);
            }
            else if (sbtn.Text == "Reset")
            {
                Clear();
                ReadOnly(false);
                tableLayoutPanel1.Visible = true;
                sbtn.Text = "Search";
                Visi_ble(true, true, false);
            }
        }
    }
}
