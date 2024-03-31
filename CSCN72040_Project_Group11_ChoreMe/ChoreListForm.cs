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
using ChoreMe;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSCN72040_Project_Group11_ChoreMe
{
    public partial class ChoreListForm : Form
    {
        public Form MainForm { get; set; }
        CreateChoreForm CCForm = new CreateChoreForm();
        private User myUser;


        public ChoreListForm(Form mainForm = null, CreateChoreForm createForm = null)
        {
            InitializeComponent();
            MainForm = mainForm;
            //flowLayoutPanel1.Width = this.ClientSize.Width / 2;

            // Attach an event handler to resize the FlowLayoutPanel when the form is resized
            //this.Resize += MainForm_Resize;
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Adjust the width of the FlowLayoutPanel to occupy half of the form's width
            flowLayoutPanel1.Width = this.ClientSize.Width / 2;
            CCForm.MainForm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            Iterator<Chore> myIterator = null;
            Users user = new Users();

            switch (comboBox1.SelectedIndex.ToString())
            {
                case "Priority":
                    myIterator = new ChoresPriorityIterator(user.chores);
                    break;
                case "Category":
                    myIterator = new ChoresCategoryIterator(user.chores);
                    break;
                case "Due Date":
                    myIterator = new ChoresDueDateIterator(user.chores);
                    break;
                case "Creation Date":
                    myIterator = new ChoresCreationDateIterator(user.chores);
                    break;
            }

            if (myIterator == null)
            {
                throw new InvalidOperationException("Iterator not initialized.");
            }

            while (myIterator.hasNext())
            {
                Chore chore = myIterator.Next();
                Panel itemPanel = new Panel();
                itemPanel.AutoSize = false;
                itemPanel.Size = new System.Drawing.Size(200, 30);

                // Create a label for plain text
                Label itemLabel = new Label();
                itemLabel.Text = "Chore: " + chore.Name; // Example text
                itemPanel.Controls.Add(itemLabel);

                // Create a button
                Button itemButton = new Button();
                itemButton.Text = "Button";
                itemButton.Click += ItemButton_Click; // Add event handler for button click
                itemButton.Dock = DockStyle.Right; // Align button to the right
                itemPanel.Controls.Add(itemButton);

                // Add the panel to the flow layout panel
                flowLayoutPanel1.Controls.Add(itemPanel);
            }

        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            // Handle button click here
            MessageBox.Show("Button clicked!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CCForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }
    }
}
