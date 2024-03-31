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
    public partial class CreateChoreForm : Form
    {
        public Form ListForm { get; set; }
        public CreateChoreForm(Form mainForm = null)
        {
            InitializeComponent();
            ListForm = mainForm;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListForm.Show();
        }
    }
}
