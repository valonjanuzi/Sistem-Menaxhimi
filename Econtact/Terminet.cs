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
    public partial class Terminet : Form
    {
        public Terminet()
        {
            InitializeComponent();
        }
        TerminetClass c = new TerminetClass();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_termine(object sender, EventArgs e)
        {
           
                // get the value from input fields
                c.Emri_tr = Emri.Text;
                c.Mbiemri_tr = Mbiemri.Text;
                c.Numri_tr = Numri.Text;
                c.Data_tr = Data.Text;
                c.Koha_tr = Koha.Text;

                //inserting data into database

                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("New Appointment Successfully Inserted");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add New Appointment. Try Again");
                }
                // Load data in gridView
                DataTable dt = c.Select();
                dgvterminetList.DataSource = dt;

            
        }
        private void Clear()
        {
            Emri.Text = "";
            Mbiemri.Text = "";
            Numri.Text = "";
            Data.Text = "";
            Koha.Text = "";
            terminet_id.Text = "";
        }

    

        private void Terminet_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvterminetList.DataSource = dt;
        }
        private void dgvterminetList_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            terminet_id.Text = dgvterminetList.Rows[rowIndex].Cells[0].Value.ToString();
            Emri.Text = dgvterminetList.Rows[rowIndex].Cells[1].Value.ToString();
            Mbiemri.Text = dgvterminetList.Rows[rowIndex].Cells[2].Value.ToString();
            Numri.Text = dgvterminetList.Rows[rowIndex].Cells[3].Value.ToString();
            Data.Text = dgvterminetList.Rows[rowIndex].Cells[4].Value.ToString();
            Koha.Text = dgvterminetList.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void update_termin(object sender, EventArgs e)
        {
            c.Terminet_ID = int.Parse(terminet_id.Text);
            c.Emri_tr = Emri.Text;
            c.Mbiemri_tr = Mbiemri.Text;
            c.Numri_tr = Numri.Text;
            c.Data_tr = Data.Text;
            c.Koha_tr = Koha.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Appointment Successfully Update");
                //refresh
                DataTable dt = c.Select();
                dgvterminetList.DataSource = dt;
                //Clear daata
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update , Try again");
            }

        }

        private void delete_termin(object sender, EventArgs e)
        {
            c.Terminet_ID = Convert.ToInt32(terminet_id.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Appointment Successfully Deleted");
                //refresh
                DataTable dt = c.Select();
                dgvterminetList.DataSource = dt;
                //Clear daata
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete , Try again");
            }
        }

        private void clear_termin(object sender, EventArgs e)
        {
            Clear();
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

       
    }
}
