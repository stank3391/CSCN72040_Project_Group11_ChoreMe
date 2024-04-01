using CSCN72040_Project_Group11_ChoreMe;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
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
        public User CurUser { get; set; }
        public ChoreListForm ChoreList = new ChoreListForm();

        //Put your object in here too
        public LoginForm(Form form = null, User u = null)
        {
            ChoreList.LogForm = this;
            CurUser = u;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //List<LoginInfo> loginInfos = new List<LoginInfo>
            //{
            //    new LoginInfo("", ""),
            //    new LoginInfo("admin", "admin")
            //};
            //string jsontemp = JsonConvert.SerializeObject(loginInfos);
            //File.WriteAllText("../../../loginInfo.json", jsontemp);

            string json = File.ReadAllText("../../../loginInfo.json");
            List<LoginInfo> jsonList = new List<LoginInfo>();
            jsonList = JsonConvert.DeserializeObject<List<LoginInfo>>(json);
            //checking for match password
            bool found = false;
            foreach (LoginInfo loginInfo in jsonList)
            {
                if (usernameBox.Text == loginInfo.username && passwordBox.Text == loginInfo.password)
                {
                    //create new credential
                    //Credential user;
                    CurUser = new User();
                    ChoreList.Show();
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

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("../../../loginInfo.json");
            List<LoginInfo> jsonList = new List<LoginInfo>();
            jsonList = JsonConvert.DeserializeObject<List<LoginInfo>>(json);
            //checking for match password
            bool found = false;
            foreach (LoginInfo loginInfo in jsonList)
            {
                if (usernameBox.Text == loginInfo.username)
                {
                    MessageBox.Show("Account Already Exists", "Error");
                    found = true;
                }

            }

            if (!found)
            {
                //if not in DB
                MessageBox.Show("You have successfully created an account. Please press Log In \\o/!", "Success!!");
                jsonList.Add(new LoginInfo(usernameBox.Text, passwordBox.Text));
            }

            string jsontemp = JsonConvert.SerializeObject(jsonList);
            File.WriteAllText("../../../loginInfo.json", jsontemp);
        }
    }


    /// <summary>
    /// AUXILIARY CLASS USED FOR LOGINS. ONLY USED WITH OUR DATABASE
    /// </summary>
    public class LoginInfo
    {
        public LoginInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string username { get; set; }
        public string password { get; set; }
    }
}