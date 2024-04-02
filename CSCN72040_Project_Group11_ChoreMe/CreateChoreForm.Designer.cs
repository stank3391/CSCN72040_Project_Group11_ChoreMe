namespace ChoreMe
{
    partial class CreateChoreForm
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
            nameBox = new TextBox();
            backButton = new Button();
            createButton = new Button();
            descriptionBox = new TextBox();
            nameLabel = new Label();
            descriptionLabel = new Label();
            priorityLabel = new Label();
            dueDatePicker = new DateTimePicker();
            dueDateLabel = new Label();
            priorityBox = new TextBox();
            categoryLabel = new Label();
            categoryBox = new TextBox();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.None;
            nameBox.Location = new Point(152, 103);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.None;
            backButton.Location = new Point(661, 51);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.None;
            createButton.Location = new Point(661, 369);
            createButton.Name = "createButton";
            createButton.Size = new Size(94, 29);
            createButton.TabIndex = 2;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.Anchor = AnchorStyles.None;
            descriptionBox.Location = new Point(152, 136);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(125, 27);
            descriptionBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(97, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(61, 136);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description";
            // 
            // priorityLabel
            // 
            priorityLabel.Anchor = AnchorStyles.None;
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(90, 172);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(56, 20);
            priorityLabel.TabIndex = 8;
            priorityLabel.Text = "Priority";
            // 
            // dueDatePicker
            // 
            dueDatePicker.Anchor = AnchorStyles.None;
            dueDatePicker.Location = new Point(152, 245);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(250, 27);
            dueDatePicker.TabIndex = 9;
            // 
            // dueDateLabel
            // 
            dueDateLabel.Anchor = AnchorStyles.None;
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(74, 251);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(72, 20);
            dueDateLabel.TabIndex = 10;
            dueDateLabel.Text = "Due Date";
            // 
            // priorityBox
            // 
            priorityBox.Anchor = AnchorStyles.None;
            priorityBox.Location = new Point(152, 173);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(125, 27);
            priorityBox.TabIndex = 14;
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = AnchorStyles.None;
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(77, 209);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(69, 20);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "Category";
            // 
            // categoryBox
            // 
            categoryBox.Anchor = AnchorStyles.None;
            categoryBox.Location = new Point(152, 212);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(125, 27);
            categoryBox.TabIndex = 17;
            // 
            // CreateChoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(categoryBox);
            Controls.Add(priorityBox);
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
            Name = "CreateChoreForm";
            Text = "CreateChoreForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Button backButton;
        private Button createButton;
        private TextBox descriptionBox;
        private Label nameLabel;
        private Label descriptionLabel;
        private Label priorityLabel;
        private DateTimePicker dueDatePicker;
        private Label dueDateLabel;
        private TextBox priorityBox;
        private Label categoryLabel;
        private TextBox categoryBox;
    }
}