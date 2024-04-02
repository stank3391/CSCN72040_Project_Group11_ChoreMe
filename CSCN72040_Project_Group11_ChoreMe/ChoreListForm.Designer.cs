namespace ChoreMe
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
            createChoreButton = new Button();
            sortByComboBox = new ComboBox();
            choresStatusComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Top;
            logoutButton.Location = new Point(622, 9);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(82, 22);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(715, 300);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // createChoreButton
            // 
            createChoreButton.Anchor = AnchorStyles.Top;
            createChoreButton.Location = new Point(535, 1);
            createChoreButton.Margin = new Padding(3, 2, 3, 2);
            createChoreButton.Name = "createChoreButton";
            createChoreButton.Size = new Size(82, 38);
            createChoreButton.TabIndex = 5;
            createChoreButton.Text = "Create Chore";
            createChoreButton.UseVisualStyleBackColor = true;
            createChoreButton.Click += createChoreButton_Click;
            // 
            // sortByComboBox
            // 
            sortByComboBox.Anchor = AnchorStyles.Top;
            sortByComboBox.FormattingEnabled = true;
            sortByComboBox.Items.AddRange(new object[] { "Priority", "Category", "Due Date", "Creation Date" });
            sortByComboBox.Location = new Point(437, 9);
            sortByComboBox.Margin = new Padding(3, 2, 3, 2);
            sortByComboBox.Name = "sortByComboBox";
            sortByComboBox.Size = new Size(93, 23);
            sortByComboBox.TabIndex = 7;
            sortByComboBox.Text = "Priority";
            sortByComboBox.SelectedIndexChanged += sortByComboBox_SelectedIndexChanged;
            // 
            // choresStatusComboBox
            // 
            choresStatusComboBox.FormattingEnabled = true;
            choresStatusComboBox.Items.AddRange(new object[] { "All", "Incompleted", "Completed" });
            choresStatusComboBox.Location = new Point(131, 10);
            choresStatusComboBox.Name = "choresStatusComboBox";
            choresStatusComboBox.Size = new Size(121, 23);
            choresStatusComboBox.TabIndex = 8;
            choresStatusComboBox.Text = "All";
            choresStatusComboBox.SelectedIndexChanged += choresStatusComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 9;
            label1.Text = "My Chores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 13);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 10;
            label2.Text = "Sort By:";
            // 
            // ChoreListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 353);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(choresStatusComboBox);
            Controls.Add(sortByComboBox);
            Controls.Add(createChoreButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(logoutButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChoreListForm";
            Text = "ChoreListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button createChoreButton;
        private ComboBox sortByComboBox;
        private ComboBox choresStatusComboBox;
        private Label label1;
        private Label label2;
    }
}