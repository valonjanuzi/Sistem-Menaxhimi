using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void quitclick(object sender, EventArgs e)
        {
            this.Close();
        }
        static String myconnstr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private void loginclick(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Role from Login Where Username ='" + username.Text + "' and Password= '" + password.Text + "' ", myconnstr);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                this.Hide();
                MainDesign m = new MainDesign();
                m.Show();
            }
            else
            {
                MessageBox.Show("Username ose Password eshte gabim , provoni perseri");

            }

        }
    }
}
