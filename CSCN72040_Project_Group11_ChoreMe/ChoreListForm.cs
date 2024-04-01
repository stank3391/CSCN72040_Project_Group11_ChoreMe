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
using CSCN72030_group6;

namespace CSCN72040_Project_Group11_ChoreMe
{
    public partial class ChoreListForm : Form
    {
        public LoginForm LogForm { get; set; }
        public CreateChoreForm CCForm = new CreateChoreForm();
        //CreateChoreForm CCForm = new CreateChoreForm();
        private User myUser;


        public ChoreListForm(LoginForm logForm = null)
        {
            InitializeComponent();
            LogForm = logForm;
            CCForm.ListForm = this;
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = this.ClientSize.Width / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            Iterator<Chore> myIterator = null;
                
            User myUser = new User();                                                                       //DELETE THIS LINE WHEN FIXED!!!!!!                            
            myUser.addChore(new Chore("TEST100", "TEST DESC", 2, "TEST CAT2", DateTime.Now));                   
            myUser.addChore(new Chore("TEST2", "TEST DESC", 1, "TEST CAT1", DateTime.Now));                   
            myUser.addChore(new Chore("TEST3", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST4", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST5", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST6", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST7", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST8", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST9", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST10", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST11", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST12", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST13", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST14", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST15", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST16", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST17", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST18", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST19", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST20", "TEST DESC", 3, "TEST CAT2", DateTime.Now));
            myUser.addChore(new Chore("TEST21", "TEST DESC", 3, "TEST CAT2", DateTime.Now));


            switch (priorityBox.Text)
            {
                case "Priority":
                    myIterator = new ChoresPriorityIterator(myUser.chores);
                    Console.Out.WriteLine("Priority");
                    break;
                case "Category":
                    myIterator = new ChoresCategoryIterator(myUser.chores);
                    Console.Out.WriteLine("Category");
                    break;
                case "Due Date":
                    myIterator = new ChoresDueDateIterator(myUser.chores);
                    Console.Out.WriteLine("Due Date");
                    break;
                case "Creation Date":
                    myIterator = new ChoresCreationDateIterator(myUser.chores);
                    Console.Out.WriteLine("Creation Date");
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
                itemPanel.Size = new System.Drawing.Size(400, 30);

                // Create a label for plain text
                Label itemLabel = new Label();
                itemLabel.AutoSize = true;
                itemLabel.Text = "Chore: " + chore.Name; // Example text
                itemPanel.Controls.Add(itemLabel);

                // Create a button
                Button itemButton = new Button();
                itemButton.Text = "View";
                itemButton.Tag = chore;
                itemButton.Click += ItemButton_Click; // Add event handler for button click
                itemButton.Dock = DockStyle.Right; // Align button to the right
                itemPanel.Controls.Add(itemButton);

                // Create a button to remove chore
                Button removeButton = new Button();
                removeButton.Text = "Remove";
                removeButton.Tag = chore;
                removeButton.Click += RemoveButton_Click; // Add event handler for remove button click
                removeButton.Dock = DockStyle.Right; // Align button to the right
                itemPanel.Controls.Add(removeButton);

                // Add the panel to the flow layout panel
                flowLayoutPanel1.Controls.Add(itemPanel);
            }

        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            // Handle button click here
            Button clickedButton = (Button)sender;
            Chore chore = (Chore)clickedButton.Tag;
            if (chore == null)
            {
                MessageBox.Show("Err this is null");
            }
            else
            {
                MessageBox.Show("Chore Name: " + chore.Name + "\nChore Description: " + chore.Description + "\nChore Category: " + chore.Category + "\nChore Priority: " + chore.Priority + "\nChore Due Date: " + chore.DueDate + "\nChore Creation Date:" + chore.CreationDate);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Handle remove button click here
            Button clickedButton = (Button)sender;
            Chore chore = (Chore)clickedButton.Tag;
            if (chore != null)
            {
                myUser.removeChore(chore);
                MessageBox.Show("Chore removed: " + chore.Name);
                // Optionally, you can refresh the list after removing the chore
                button4_Click(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CCForm.Show();
        }
    }
}
