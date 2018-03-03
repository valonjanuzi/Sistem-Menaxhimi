using Econtact.terminetClasses;
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

        private void Terminet_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            terminetDataGrid.DataSource = dt;
        }

        private void add_terminet(object sender, EventArgs e)
        {
            // get the value from input fields
           
            c.Emri_trr = emritext.Text;
            c.Mbiemri_trr = mbiemritext.Text;
            c.Data_trr = datatext.Text;
            c.Koha_trr = kohatext.Text;

            //inserting data into database

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Termin Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add New Termin. Try Again");
            }
            // Load data in gridView
            DataTable dt = c.Select();
            terminetDataGrid.DataSource = dt;

        }


        private void Clear()
        {
            terminetidtext.Text = "";
            emritext.Text = "";
            mbiemritext.Text = "";
            datatext.Text = "";
            kohatext.Text = "";
        }

       
    }
}
