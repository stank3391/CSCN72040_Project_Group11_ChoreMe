namespace CSCN72040_Project_Group11_ChoreMe
{
    partial class ChoreListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoutButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            myChoresButton = new Button();
            sortByButton = new Button();
            createChoreButton = new Button();
            completedButton = new Button();
            priorityBox = new ComboBox();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(622, 9);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(82, 22);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(715, 300);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // myChoresButton
            // 
            myChoresButton.Location = new Point(27, 9);
            myChoresButton.Margin = new Padding(3, 2, 3, 2);
            myChoresButton.Name = "myChoresButton";
            myChoresButton.Size = new Size(82, 22);
            myChoresButton.TabIndex = 2;
            myChoresButton.Text = "MyChores";
            myChoresButton.UseVisualStyleBackColor = true;
            // 
            // sortByButton
            // 
            sortByButton.Location = new Point(349, 9);
            sortByButton.Margin = new Padding(3, 2, 3, 2);
            sortByButton.Name = "sortByButton";
            sortByButton.Size = new Size(82, 22);
            sortByButton.TabIndex = 4;
            sortByButton.Text = "Sort By:";
            sortByButton.UseVisualStyleBackColor = true;
            sortByButton.Click += button4_Click;
            // 
            // createChoreButton
            // 
            createChoreButton.Location = new Point(535, 1);
            createChoreButton.Margin = new Padding(3, 2, 3, 2);
            createChoreButton.Name = "createChoreButton";
            createChoreButton.Size = new Size(82, 38);
            createChoreButton.TabIndex = 5;
            createChoreButton.Text = "Create Chore";
            createChoreButton.UseVisualStyleBackColor = true;
            createChoreButton.Click += button5_Click;
            // 
            // completedButton
            // 
            completedButton.Location = new Point(238, 9);
            completedButton.Margin = new Padding(3, 2, 3, 2);
            completedButton.Name = "completedButton";
            completedButton.Size = new Size(106, 22);
            completedButton.TabIndex = 6;
            completedButton.Text = "Completed";
            completedButton.UseVisualStyleBackColor = true;
            // 
            // priorityBox
            // 
            priorityBox.FormattingEnabled = true;
            priorityBox.Items.AddRange(new object[] { "Priority", "Category", "Due Date", "Creation Date" });
            priorityBox.Location = new Point(437, 9);
            priorityBox.Margin = new Padding(3, 2, 3, 2);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(93, 23);
            priorityBox.TabIndex = 7;
            priorityBox.Text = "Priority";
            // 
            // ChoreListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 353);
            Controls.Add(priorityBox);
            Controls.Add(completedButton);
            Controls.Add(createChoreButton);
            Controls.Add(sortByButton);
            Controls.Add(myChoresButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(logoutButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChoreListForm";
            Text = "ChoreListForm";
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button myChoresButton;
        private Button sortByButton;
        private Button createChoreButton;
        private Button completedButton;
        private ComboBox priorityBox;
    }
}