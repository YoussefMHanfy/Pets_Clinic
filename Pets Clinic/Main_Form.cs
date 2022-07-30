using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pets_Clinic
{
    public partial class Main_Form : Form
    {
        
        public Main_Form()
        {
            InitializeComponent();
        }
        public static bool a = false;
        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void cab1_Click(object sender, EventArgs e)
        {
            data_Of_Patient1.Visible = true;
            staff1.Visible = false;
            medicines1.Visible = false;
        }

        private void data_Of_Patient1_Load(object sender, EventArgs e)
        {
            
        }

        private void cab2_Click(object sender, EventArgs e)
        {
            data_Of_Patient1.Visible = false;
            staff1.Visible = true;
            medicines1.Visible = false;
        }

        private void cab3_Click(object sender, EventArgs e)
        {
            data_Of_Patient1.Visible = false;
            staff1.Visible = false;
            medicines1.Visible = true;
        }
    }
}
