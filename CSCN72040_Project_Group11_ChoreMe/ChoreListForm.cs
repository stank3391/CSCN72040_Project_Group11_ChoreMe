using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCN72040_Project_Group11_ChoreMe
{
    public partial class ChoreListForm : Form
    {
        public Form MainForm { get; set; }
        public ChoreListForm(Form mainForm = null)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }
    }
}
