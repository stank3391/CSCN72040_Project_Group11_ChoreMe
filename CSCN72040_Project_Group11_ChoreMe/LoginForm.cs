using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCN72030_group6
{
    public partial class LoginForm : Form
    {
        //public Credential CredTest { get; set; }
        public Form MainForm { get; set; }
        //public List<List<String>> Creds { get; set; }

        //Put your object in here too
        public LoginForm(Form form = null /*Credential credtest = null,*//* List<List<string>> creds = null*/)
        {
            MainForm = form;
            //CredTest = credtest;
            InitializeComponent();
            //Creds = creds;
        }

        private void login_Click(object sender, EventArgs e)
        {
            //temp code
            List<String> list = new List<String>();
            list.Add("justin");
            list.Add("password");
            List<List<String>> Creds = new List<List<String>>();
            Creds.Add(list);


            //checking for match password
            bool found = false;
            foreach (List<string> line in Creds)
            {
                if (usernameBox.Text == line.ElementAt(0) && passwordBox.Text == line.ElementAt(1))
                {
                    //create new credential
                    //Credential user;
                    MainForm.Show();
                    this.Hide();
                    found = true;

                }

            }
            if (!found)
            {
                //if incorrect
                MessageBox.Show("Username or Password is incorrect", "Error");
            }
            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            passwordBox.ForeColor = Color.Black;
            passwordBox.UseSystemPasswordChar = true;
        }
    }
}