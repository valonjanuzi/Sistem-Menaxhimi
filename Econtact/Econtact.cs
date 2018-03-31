using Econtact.econtactClasses;
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
using System.Runtime.InteropServices;

namespace Econtact
{
    public partial class Econtact : Form,KlientiClass
    {
        public Econtact()
        {
            InitializeComponent();
        }
       
       

       

        private void Econtact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get the value from input fields
            FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtbocContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            //inserting data into database

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add New Contact. Try Again");
            }
            // Load data in gridView
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

       

        private void Clear()
        {
            txtboxFirstName.Text = "";
             txtboxLastName.Text = "";
            txtbocContactNumber.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";
            txtbocContactID.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get data from data Grid

            int rowIndex = e.RowIndex;
            txtbocContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtbocContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtbocContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtbocContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            bool success = c.Update(c);
            if(success == true)
            {
                MessageBox.Show("Contact Successfully Update");
                //refresh
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Clear daata
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update , Try again");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            c.ContactID = Convert.ToInt32(txtbocContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact Successfully Deleted");
                //refresh
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Clear daata
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete , Try again");
            }
        }
        static String myconnstr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            // get the value from texbox
            string keyword = txtboxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%"+keyword+ "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'" ,conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        internal class Write
        {
        }

        internal class RegisterClientScriptBlock
        {
        }

        internal class TerminetClasses
        {
        }
    }
}
