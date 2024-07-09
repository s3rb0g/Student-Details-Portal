using GOBRES_04272024_TP.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOBRES_04272024_TP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ArrayList allUsers = Class1.GetAllUsers();
            foreach (Class1 user in allUsers) {
                showName.Text = ("User: " + user.fullname);
            }
            
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
                MessageBox.Show("Logout Successfully!");
            }
        }
    }
}
