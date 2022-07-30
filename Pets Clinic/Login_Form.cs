using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pets_Clinic
{
    public partial class Login_Form : Form
    {
        
        public Login_Form()
        {
            InitializeComponent();
        }
        



        private void Power_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (IDtxt.PasswordChar == '•')
                IDtxt.PasswordChar = '\0';
            else
                IDtxt.PasswordChar = '•';
        }
        
        private void Login_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BH4EKKE\SQLEXPRESS;Initial Catalog=Pets_Clinic;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT i FROM STF", con);
            //SqlDataReader sr = cmd.ExecuteReader();
            //while (sr.Read())
            //{
            //    var id = sr.GetDecimal(9);
            //    var b = sr.GetString(5);
            //    if (id == Convert.ToDecimal(IDtxt.Text))
            //    {
            //        if (b == "Doctor")
            //        {
            //            Main_Form.a = true;
            //        }
            //        Main_Form x = new Main_Form();
            //        x.Show();
            //        this.Hide();
            //        con.Close();
            //        return;
            //    }
            //}
            Main_Form.a = true;
            Main_Form x = new Main_Form();
                    x.Show();
                    this.Hide();
            IDlabel.Visible = true;
                    
        }
    }
}
