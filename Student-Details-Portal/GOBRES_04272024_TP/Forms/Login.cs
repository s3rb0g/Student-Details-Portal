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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string username = logUsername.Text;
            string password = logPassword.Text;
            

            ArrayList allUsers = Class1.GetAllUsers();

            foreach(Class1 list in allUsers)
            {
                
                if (list.username == username && list.password == password) {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                    MessageBox.Show("Login Successfully");
                    break;
                }
                MessageBox.Show("Invalid username or password. Please try again.");
            }


        }
    }
}
