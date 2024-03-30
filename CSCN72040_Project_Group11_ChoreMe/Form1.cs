using ChoreMe;
using CSCN72030_group6;

namespace CSCN72040_Project_Group11_ChoreMe
{
    public partial class Form1 : Form
    {
        //references for other forms here
        ChoreListForm CLForm = new ChoreListForm();
        LoginForm LoginForm = new LoginForm();
        GroupForm GForm = new GroupForm();
        User users = new User();

        public Form1()
        {
            InitializeComponent();
            LoginForm.MainForm = this;
            CLForm.MainForm = this;
            //CCForm.MainForm = this;
            GForm.MainForm = this;
        }

        private void LoginFormBtn(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Show();
        }

        private void ScrollViewBtn(object sender, EventArgs e)
        {
            this.Hide();
            CLForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GForm.Show();
        }
    }
}
