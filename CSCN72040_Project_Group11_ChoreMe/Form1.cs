using CSCN72030_group6;

namespace CSCN72040_Project_Group11_ChoreMe
{
    public partial class Form1 : Form
    {
        //references for other forms here
        CalendarMonthForm CalMonthForm = new CalendarMonthForm();
        CalendarWeekForm CalWeekForm = new CalendarWeekForm();
        ChoreListForm CLForm = new ChoreListForm();
        LoginForm LoginForm = new LoginForm();

        public Form1()
        {
            InitializeComponent();
            LoginForm.MainForm = this;
            CalMonthForm.MainForm = this;
            CalWeekForm.MainForm = this;
            CLForm.MainForm = this;

        }

        private void LoginFormBtn(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Show();
        }

        private void CalMonthBtn(object sender, EventArgs e)
        {
            this.Hide();
            CalMonthForm.Show();
        }

        private void CalWeekBtn(object sender, EventArgs e)
        {
            this.Hide();
            CalWeekForm.Show();
        }

        private void ScrollViewBtn(object sender, EventArgs e)
        {
            this.Hide();
            CLForm.Show();
        }
    }
}
