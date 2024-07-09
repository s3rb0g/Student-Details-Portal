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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = regUsername.Text;
            string password = regPassword.Text;
            string fullname = regFullname.Text;
            string section = regSection.Text;

            string gender = regMale.Checked ? "Male" : "Female";

            string course = regCourse.SelectedItem.ToString();

            Class1 classer = new Class1();

            classer.addUser(username, password, fullname, section, gender, course);

            MessageBox.Show("Registration successful!");
            regUsername.Clear();
            regPassword.Clear();
            regFullname.Clear();
            regSection.Clear();
            regMale.Checked = false;
            regFemale.Checked = false;
            regCourse.SelectedIndex = -1;

        }

        private void Register_Load(object sender, EventArgs e)
        {
            ArrayList program = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information System",
                "Bachelor of Science in Computer Engineering"

            };

            foreach (string prog in program) {
                regCourse.Items.Add(prog.ToString());
            
            }
        }
    }
}
