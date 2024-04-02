using Newtonsoft.Json;

namespace ChoreMe
{
    public partial class ChoreListForm : Form
    {
        private LoginForm LoginForm; // assigned in constructor
        public CreateChoreForm CCForm; // instantiated in constructor
        public EditChoreForm ECForm; // instantiated in EditButton_Click()

        public User myUser { get; set; }

        private List<Chore> SelectedChoreList; // List of chores to sort and display (ALL, COMPLETED, INCOMPLETED)

        public ChoreListForm(LoginForm loginForm, User user)
        {
            InitializeComponent();
            this.LoginForm = loginForm;
            this.CCForm = new CreateChoreForm(this);

            myUser = user;

            this.SelectedChoreList = user.chores; // Default to all chores

            ShowSortedChores();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = this.ClientSize.Width / 2;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // find user in json and update
            string json = File.ReadAllText("../../../loginInfo.json");
            List<LoginInfo> jsonList = new List<LoginInfo>();
            jsonList = JsonConvert.DeserializeObject<List<LoginInfo>>(json);

            bool found = false;
            foreach (LoginInfo LoginInfo in jsonList)
            {
                if (LoginInfo.username == myUser.name)
                {
                    LoginInfo.chores = myUser.chores;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("ERROR: User not found when trying to save, issue with create user logic in login form");
                Application.Exit();
            }
            // save to json
            string jsontemp = JsonConvert.SerializeObject(jsonList);
            File.WriteAllText("../../../loginInfo.json", jsontemp);
            Console.WriteLine("User saved to JSON");

            this.Close();
            LoginForm.Show();
        }

        /// <summary>
        /// Called when the user selects a different sorting option in the combo box
        /// (priority, category, due date, creation date)
        /// just call ShowSortedChores() to update the list
        /// </summary>
        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSortedChores();
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
                MessageBox.Show("Chore Name: " + chore.Name + "\nChore Description: " + chore.Description + "\nChore Category: " + chore.Category + "\nChore Priority: " + chore.Priority + "\nChore Due Date: " + chore.DueDate + "\nChore Creation Date:" + chore.CreationDate + "\nIsComplete: " + chore.IsComplete);
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Handle remove button click here
            Button clickedButton = (Button)sender;
            Chore chore = (Chore)clickedButton.Tag;
            if (chore != null)
            {
                ECForm = new EditChoreForm(this, chore);
                this.Hide();
                ECForm.Show();
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
            }

            ShowSortedChores();
        }

        /// <summary>
        /// hides the current form and shows the create chore form
        /// </summary>
        private void createChoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CCForm.Show();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            // complete the chore
            Button clickedButton = (Button)sender;
            Chore chore = (Chore)clickedButton.Tag;

            if (chore != null)
            {
                chore.Complete();
                MessageBox.Show("Chore completed: " + chore.Name);
            }
            ShowSortedChores();
        }

        /// <summary>
        /// Called when the user selects a different chore status in the combo box
        /// (All, completed, incompleted)
        /// updates the SelectedChoreList with the list of chores to sort and display
        /// and calls ShowSortedChores() to update the list
        /// </summary>
        private void choresStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Chore status selected: " + choresStatusComboBox.Text);
            // show only chores with selected status
            flowLayoutPanel1.Controls.Clear();

            Iterator<Chore> myIterator = null;

            switch (choresStatusComboBox.Text)
            {
                case "All":
                    // set selected chore list to a copy of ALL chores in user
                    this.SelectedChoreList = new List<Chore>(myUser.chores);
                    break;
                case "Completed":
                    // set selected chore list to COMPLETED chores in user
                    this.SelectedChoreList = myUser.getCompletedChores();
                    break;
                case "Incompleted":
                    // set selected chore list to INCOMPLETED chores in user
                    this.SelectedChoreList = myUser.getIncompletedChores();
                    break;
                default:
                    Console.WriteLine("Invalid chore status selected");
                    break;
            }
            ShowSortedChores();
        }

        /// <summary>
        /// Show sorted chores in the flow layout panel
        /// Takes in account of the selected sorting option in the Sort By combo box
        /// </summary>
        public void ShowSortedChores()
        {
            flowLayoutPanel1.Controls.Clear();

            Iterator<Chore> myIterator = null;

            switch (sortByComboBox.Text)
            {
                case "Priority":
                    myIterator = new ChoresPriorityIterator(this.SelectedChoreList);
                    Console.Out.WriteLine("Sort By: Priority");
                    break;
                case "Category":
                    myIterator = new ChoresCategoryIterator(this.SelectedChoreList);
                    Console.Out.WriteLine("Sort By: Category");
                    break;
                case "Due Date":
                    myIterator = new ChoresDueDateIterator(this.SelectedChoreList);
                    Console.Out.WriteLine("Sort By: Due Date");
                    break;
                case "Creation Date":
                    myIterator = new ChoresCreationDateIterator(this.SelectedChoreList);
                    Console.Out.WriteLine("Sort By: Creation Date");
                    break;
                default:
                    Console.WriteLine("Iterator not initialized.");
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

                // Create a button
                Button editButton = new Button();
                editButton.Text = "Edit";
                editButton.Tag = chore;
                editButton.Click += EditButton_Click; // Add event handler for button click
                editButton.Dock = DockStyle.Right; // Align button to the right
                itemPanel.Controls.Add(editButton);

                // create button to complete chore
                Button completeButton = new Button();
                completeButton.Text = "Complete";
                completeButton.Tag = chore;
                completeButton.Click += CompleteButton_Click;
                completeButton.Dock = DockStyle.Right;
                itemPanel.Controls.Add(completeButton);
                // if the chore is already completed, disable the complete button
                if (chore.IsComplete)
                {
                    completeButton.Enabled = false;
                }


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
        
    }
}
