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
        //public User CurUser { get; set; }
        public ChoreListForm ChoreListForm = new ChoreListForm();

        //Put your object in here too
        public LoginForm(Form form = null /*User u = null*/)
        {
            ChoreListForm.LogForm = this;
            //CurUser = u;
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            /*Chore chore1 = new Chore("TEST100", "TEST DESC", 2, "TEST CAT2", DateTime.Now);
            Chore chore2 = new Chore("TEST2", "TEST DESC", 1, "TEST CAT1", DateTime.Now);

            List<Chore> chores = new List<Chore>
            {
                chore1,
                chore2
            };

            List<LoginInfo> loginInfos = new List<LoginInfo>
            {
                new LoginInfo("", "", chores),
                new LoginInfo("admin", "admin", chores)
            };
            string jsontemp = JsonConvert.SerializeObject(loginInfos);
            File.WriteAllText("../../../loginInfo.json", jsontemp);*/

            string json = File.ReadAllText("../../../loginInfo.json");
            List<LoginInfo> jsonList = new List<LoginInfo>();
            jsonList = JsonConvert.DeserializeObject<List<LoginInfo>>(json);

            //checking for match password
            bool found = false;
            foreach (LoginInfo loginInfo in jsonList)
            {
                if (usernameBox.Text == loginInfo.username && passwordBox.Text == loginInfo.password)
                {
                    Console.WriteLine("Login Successful");
                    //create new credential
                    //Credential user;
                    User CurUser = new User(usernameBox.Text, loginInfo.chores);
                    //LoginInfo actual = new LoginInfo(loginInfo.username, loginInfo.password);
                    //ChoreListForm.
                    ChoreListForm.myUser = CurUser;
                    ChoreListForm.Show();
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
        /// <param name="username"></param>
        /// <param name="password"></param>
        public LoginInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.chores = new List<Chore>();
        }

        /// <summary>
        /// used for saving and loading users
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="chores"></param>
        public LoginInfo(string username, string password, List<Chore> chores)
        {
            this.username = username;
            this.password = password;
            this.chores = chores;
        }
        
    }
}