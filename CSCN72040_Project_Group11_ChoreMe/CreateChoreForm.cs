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

        private void backButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            descriptionBox.Text = "";
            priorityBox.Text = "";
            categoryBox.Text = "";
            dueDatePicker.Value = DateTime.Now;
            this.Hide();
            ListForm.Show();
        }

        //create chore button
        private void createButton_Click(object sender, EventArgs e) {
            //add checks to make sure data is okay
            String name = nameBox.Text;
            String desc = descriptionBox.Text;
            int prior = Int32.Parse(priorityBox.Text);
            String cat = categoryBox.Text;
            DateTime dueDate = dueDatePicker.Value.Date;




            //if data is okay
            Chore tempChore = new Chore(name, desc, prior, cat, dueDate);
            ListForm.myUser.addChore(tempChore);

            //clear data
            nameBox.Text = "";
            descriptionBox.Text = "";
            priorityBox.Text = "";
            categoryBox.Text = "";
            dueDatePicker.Value = DateTime.Now;
            MessageBox.Show("Successfully added chore!", "Success");
        }
    }
}
