using Econtact.econtactClasses;
using Econtact.TerminetClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
