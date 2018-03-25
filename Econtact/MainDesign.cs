using Econtact.econtactClasses;
using Econtact.TerminetClasses;
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
    public partial class MainDesign : Form
    {
        public MainDesign()
        {
            InitializeComponent();
        }

        TerminetClass c = new TerminetClass();
        contactClass cn = new contactClass();

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kontakticlick(object sender, EventArgs e)
        {
            Econtact m = new Econtact();
            m.Show();
        }

        private void terminet_click(object sender, EventArgs e)
        {
            Terminet m = new Terminet();
            m.Show();
        }

        private void MainDesign_Load(object sender, EventArgs e)
        {

 
            
            DataTable dt = c.Select();
            dgvterminetList.DataSource = dt;

            DataTable dtt = cn.Select();
            dgvContactList.DataSource = dtt;
        }
        static String myconnstr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            // get the value from texbox
            string keyword = txtboxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_terminet WHERE Emri_tr LIKE '%" + keyword + "%' OR Mbiemri_tr LIKE '%" + keyword + "%' OR Numri_tr LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvterminetList.DataSource = dt;
        }
        
      

        private void txtboxSearch1_TextChanged_1(object sender, EventArgs e)
        {
            // get the value from texbox

            string keyword = txtboxSearch1.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private class Write
        {
        }

        private void chatClick(object sender, EventArgs e)
        {
            Chat_Client_App m = new Chat_Client_App();
            m.Show();
        }
    }
}
