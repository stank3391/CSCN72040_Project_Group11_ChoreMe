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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Button newButton = new Button();
            //newButton.Text = "test";
            //flowLayoutPanel1.Controls.Add(newButton);
            // Create a new panel to hold each item
            flowLayoutPanel1.Controls.Clear();

            Panel itemPanel = new Panel();
            itemPanel.AutoSize = false;
            itemPanel.Size = new System.Drawing.Size(200, 30);

            // Create a label for plain text
            Label itemLabel = new Label();
            itemLabel.Text = "Item " + (flowLayoutPanel1.Controls.Count + 1); // Example text
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

        private void ItemButton_Click(object sender, EventArgs e)
        {
            // Handle button click here
            MessageBox.Show("Button clicked!");
        }
    }
}
