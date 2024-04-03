namespace ChoreMe
{
    partial class EditChoreForm
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
            categoryBox = new TextBox();
            redoButton = new Button();
            undoButton = new Button();
            categoryLabel = new Label();
            dueDateLabel = new Label();
            dueDatePicker = new DateTimePicker();
            priorityLabel = new Label();
            descriptionLabel = new Label();
            nameLabel = new Label();
            descriptionBox = new TextBox();
            createButton = new Button();
            backButton = new Button();
            nameBox = new TextBox();
            priorityComboBox = new ComboBox();
            SuspendLayout();
            // 
            // categoryBox
            // 
            categoryBox.Anchor = AnchorStyles.None;
            categoryBox.Location = new Point(144, 213);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(455, 27);
            categoryBox.TabIndex = 31;
            // 
            // redoButton
            // 
            redoButton.Anchor = AnchorStyles.None;
            redoButton.Location = new Point(349, 370);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(69, 29);
            redoButton.TabIndex = 30;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = true;
            redoButton.Click += redoButton_Click;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.None;
            undoButton.Location = new Point(274, 370);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(69, 29);
            undoButton.TabIndex = 29;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = AnchorStyles.None;
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(69, 210);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(69, 20);
            categoryLabel.TabIndex = 27;
            categoryLabel.Text = "Category";
            // 
            // dueDateLabel
            // 
            dueDateLabel.Anchor = AnchorStyles.None;
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(66, 252);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(72, 20);
            dueDateLabel.TabIndex = 26;
            dueDateLabel.Text = "Due Date";
            // 
            // dueDatePicker
            // 
            dueDatePicker.Anchor = AnchorStyles.None;
            dueDatePicker.Location = new Point(144, 246);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(250, 27);
            dueDatePicker.TabIndex = 25;
            // 
            // priorityLabel
            // 
            priorityLabel.Anchor = AnchorStyles.None;
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(82, 173);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(56, 20);
            priorityLabel.TabIndex = 24;
            priorityLabel.Text = "Priority";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(53, 137);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 23;
            descriptionLabel.Text = "Description";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(89, 104);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 22;
            nameLabel.Text = "Name";
            // 
            // descriptionBox
            // 
            descriptionBox.Anchor = AnchorStyles.None;
            descriptionBox.Location = new Point(144, 137);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(455, 27);
            descriptionBox.TabIndex = 21;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.None;
            createButton.Location = new Point(653, 370);
            createButton.Name = "createButton";
            createButton.Size = new Size(94, 29);
            createButton.TabIndex = 20;
            createButton.Text = "Save";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.None;
            backButton.Location = new Point(653, 52);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 19;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.None;
            nameBox.Location = new Point(144, 104);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(455, 27);
            nameBox.TabIndex = 18;
            // 
            // priorityComboBox
            // 
            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            priorityComboBox.Location = new Point(144, 177);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(125, 28);
            priorityComboBox.TabIndex = 32;
            // 
            // EditChoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(priorityComboBox);
            Controls.Add(categoryBox);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(categoryLabel);
            Controls.Add(dueDateLabel);
            Controls.Add(dueDatePicker);
            Controls.Add(priorityLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(descriptionBox);
            Controls.Add(createButton);
            Controls.Add(backButton);
            Controls.Add(nameBox);
            Name = "EditChoreForm";
            Text = "EditChoreForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox categoryBox;
        private Button redoButton;
        private Button undoButton;
        private Label categoryLabel;
        private Label dueDateLabel;
        private DateTimePicker dueDatePicker;
        private Label priorityLabel;
        private Label descriptionLabel;
        private Label nameLabel;
        private TextBox descriptionBox;
        private Button createButton;
        private Button backButton;
        private TextBox nameBox;
        private ComboBox priorityComboBox;
    }
}