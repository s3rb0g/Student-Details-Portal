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

namespace GOBRES_04272024_TP.Forms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            ArrayList allUsers = Class1.GetAllUsers();
            foreach (Class1 user in allUsers)
            {

                showuname.Text = user.username;
                showfname.Text = user.fullname;
                showgender.Text = user.gender;
                showsection.Text = user.section;
                showcourse.Text = user.course;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
