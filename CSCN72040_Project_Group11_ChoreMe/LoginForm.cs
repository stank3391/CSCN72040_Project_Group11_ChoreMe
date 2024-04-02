using ChoreMe;
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

namespace ChoreMe
{

    public partial class LoginForm : Form
    {
        private ChoreListForm ChoreListForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // read from json file
            string json = File.ReadAllText("../../../loginInfo.json");
            List<LoginInfo> jsonList = new List<LoginInfo>();
            jsonList = JsonConvert.DeserializeObject<List<LoginInfo>>(json);

            //checking for match password
            bool found = false;
            foreach (LoginInfo loginInfo in jsonList)
            {
                if (usernameBox.Text == loginInfo.username && passwordBox.Text == loginInfo.password)
                {
                    Console.WriteLine("User found");

                    User CurUser = new User(usernameBox.Text, loginInfo.chores);

                    // create new chore list form
                    ChoreListForm = new ChoreListForm(this, CurUser);

                    this.Hide();

                    ChoreListForm.Show();

                    found = true;

                    break;
                }
            }

            if(!found)
            {
                MessageBox.Show("Username or Password is incorrect", "Error");

            }

            // clear textboxes
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
        public string username { get; set; }
        public string password { get; set; }

        public List<Chore> chores { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public LoginInfo()
        {
            this.username = string.Empty;
            this.password = string.Empty;
            this.chores = new List<Chore>();
        }

        /// <summary>
        /// used for creating a new user (because new user doesnt have any chores)
        /// </summary>
        public LoginInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.chores = new List<Chore>();
        }

        /// <summary>
        /// used for saving and loading users
        /// </summary>
        public LoginInfo(string username, string password, List<Chore> chores)
        {
            this.username = username;
            this.password = password;
            this.chores = chores;
        }
        
    }
}