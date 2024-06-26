﻿using ChoreMe;
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
            categoryBox.Text = "";
            dueDatePicker.Value = DateTime.Now;
            this.Hide();
            ListForm.ShowSortedChores(); // refresh the list
            ListForm.choresStatusComboBox_SelectedIndexChanged(sender, e);
            ListForm.Show();
        }

        //create chore button
        private void createButton_Click(object sender, EventArgs e) {
            //add checks to make sure data is okay
            String name = nameBox.Text;
            String desc = descriptionBox.Text;
            int prior = Int32.Parse(priorityComboBox.Text); //this can break code
            String cat = categoryBox.Text;
            DateTime dueDate = dueDatePicker.Value.Date;

            //if data is okay
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
                Chore tempChore = new Chore(name, desc, prior, cat, dueDate);
                ListForm.myUser.addChore(tempChore);
                AlertBoxObserver observer = new AlertBoxObserver();
                FileWriteObserver fileWriteObserver = new FileWriteObserver();

                tempChore.RegisterObserver(observer);
                tempChore.RegisterObserver(fileWriteObserver);
                tempChore.NotifyObservers("New chore created: " + name);


                //clear data
                nameBox.Text = "";
                descriptionBox.Text = "";
                priorityComboBox.Text = "1";
                categoryBox.Text = "";
                dueDatePicker.Value = DateTime.Now;
            }            
        }
    }
}
