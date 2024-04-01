using ChoreMe;
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
    public partial class CreateChoreForm : Form
    {
        public ChoreListForm ListForm { get; set; }
        public CreateChoreForm(ChoreListForm prevForm = null)
        {
            InitializeComponent();
            ListForm = prevForm;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListForm.Show();
        }

        //create chore button
        private void button2_Click(object sender, EventArgs e) {
            //add checks to make sure data is okay
            String name = textBox1.Text;
            String desc = textBox2.Text;
            int prior = Int32.Parse(textBox3.Text);
            String cat = textBox4.Text;
            DateTime dueDate = dateTimePicker1.Value.Date;




            //if data is okay
            Chore tempChore = new Chore(name, desc, prior, cat, dueDate);
            ListForm.myUser.addChore(tempChore);
            
            //clear data
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            MessageBox.Show("Successfully added chore!", "Success");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
