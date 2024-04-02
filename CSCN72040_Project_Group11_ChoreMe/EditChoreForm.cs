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
    public partial class EditChoreForm : Form
    {
        public ChoreListForm ListForm { get; set; }
        public Chore myChore { get; set; }
        public Memento myMemento { get; set; }
        public CareTaker myCareTaker = new CareTaker();




        public EditChoreForm(ChoreListForm prevForm, Chore ch)
        {
            InitializeComponent();
            ListForm = prevForm;
            myChore = ch;
            nameBox.Text = myChore.Name;
            descriptionBox.Text = myChore.Description;
            priorityBox.Text = myChore.Priority.ToString();
            categoryBox.Text = myChore.Category;
            dueDatePicker.Value = myChore.DueDate;
            myMemento = new Memento(ch);
            myCareTaker.AddMemento(myMemento);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListForm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            myChore.Name = nameBox.Text;
            myChore.Description = descriptionBox.Text;
            myChore.Priority = Int32.Parse(priorityBox.Text);
            myChore.Category = categoryBox.Text;
            myChore.DueDate = dueDatePicker.Value;
            Memento temp = new Memento(myChore);
            myCareTaker.AddMemento(temp);
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            Memento temp = myCareTaker.GetMemento(0);

            myChore.Name = temp.Name;
            myChore.Description = temp.Description;
            myChore.Priority = temp.Priority;
            myChore.Category = temp.Category;
            myChore.DueDate = temp.DueDate;

            nameBox.Text = temp.Name;
            descriptionBox.Text = temp.Description;
            priorityBox.Text = temp.Priority.ToString();
            categoryBox.Text = temp.Category;
            dueDatePicker.Value = temp.DueDate;
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            myCareTaker.GetMemento(1);
            Memento temp = myCareTaker.GetMemento(1);

            myChore.Name = temp.Name;
            myChore.Description = temp.Description;
            myChore.Priority = temp.Priority;
            myChore.Category = temp.Category;
            myChore.DueDate = temp.DueDate;

            nameBox.Text = temp.Name;
            descriptionBox.Text = temp.Description;
            priorityBox.Text = temp.Priority.ToString();
            categoryBox.Text = temp.Category;
            dueDatePicker.Value = temp.DueDate;
        }
    }
}
