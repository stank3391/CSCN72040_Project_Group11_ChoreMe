using CSCN72040_Project_Group11_ChoreMe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChoreMe
{
    public partial class EditChoreForm : Form
    {
        public ChoreListForm ListForm { get; set; }
        public Chore myChore { get; set; }
        public Memento myMemento { get; set; }
        public CareTaker myCareTaker = new CareTaker();
        public int currentIndex { get; set; }
        public EditChoreForm(ChoreListForm prevForm, Chore ch)
        {
            InitializeComponent();
            ListForm = prevForm;
            myChore = ch;
            nameBox.Text = myChore.Name;
            descriptionBox.Text = myChore.Description;
            priorityComboBox.Text = myChore.Priority.ToString();
            categoryBox.Text = myChore.Category;
            dueDatePicker.Value = myChore.DueDate;
            myMemento = new Memento(ch);
            myCareTaker.AddMemento(myMemento);
            currentIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ListForm.ShowSortedChores();
            this.Hide();
            ListForm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            int prior = Int32.Parse(priorityComboBox.Text); //this can break code


            //if okay
            if (nameBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty!");
            }
            else if (categoryBox.Text == "")
            {
                MessageBox.Show("Category cannot be empty!");
            }
            else if (1 > prior && prior < 4)
            {
                MessageBox.Show("Priority has to be within 1-4!");
            }
            else
            {
                myChore.Name = nameBox.Text;
                myChore.Description = descriptionBox.Text;
                myChore.Priority = Int32.Parse(priorityComboBox.Text);
                myChore.Category = categoryBox.Text;
                myChore.DueDate = dueDatePicker.Value;
                Memento temp = new Memento(myChore);
                myCareTaker.AddMemento(temp);
                currentIndex = myCareTaker.SavedChores.Count - 1;
                myChore.NotifyObservers(myChore.Name + ", Edited");
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (currentIndex - 1 >= 0)
            {
                currentIndex--;
            }
            UpdateChoreDisplay();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (currentIndex + 1 <= myCareTaker.SavedChores.Count-1)
            {
                currentIndex++;
            }
            UpdateChoreDisplay();
        }
        private void UpdateChoreDisplay()
        {
            Memento temp = myCareTaker.GetMemento(currentIndex);

            myChore.Name = temp.Name;
            myChore.Description = temp.Description;
            myChore.Priority = temp.Priority;
            myChore.Category = temp.Category;
            myChore.DueDate = temp.DueDate;

            nameBox.Text = temp.Name;
            descriptionBox.Text = temp.Description;
            priorityComboBox.Text = temp.Priority.ToString();
            categoryBox.Text = temp.Category;
            dueDatePicker.Value = temp.DueDate;
        }
    }
}
