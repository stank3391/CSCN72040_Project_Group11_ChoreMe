namespace CSCN72040_Project_Group11_ChoreMe
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
            dueDateDateTimePicker = new DateTimePicker();
            dueDateLabel = new Label();
            assignBox = new ComboBox();
            assignLabel = new Label();
            priorityBox = new TextBox();
            undoButton = new Button();
            redoButton = new Button();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(133, 77);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(110, 23);
            nameBox.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Location = new Point(578, 38);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(82, 22);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(578, 277);
            createButton.Margin = new Padding(3, 2, 3, 2);
            createButton.Name = "createButton";
            createButton.Size = new Size(82, 22);
            createButton.TabIndex = 2;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(133, 102);
            descriptionBox.Margin = new Padding(3, 2, 3, 2);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(110, 23);
            descriptionBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(85, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(53, 102);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(79, 129);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(45, 15);
            priorityLabel.TabIndex = 8;
            priorityLabel.Text = "Priority";
            priorityLabel.Click += label3_Click;
            // 
            // dueDateDateTimePicker
            // 
            dueDateDateTimePicker.Location = new Point(133, 184);
            dueDateDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            dueDateDateTimePicker.Size = new Size(219, 23);
            dueDateDateTimePicker.TabIndex = 9;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(65, 188);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(55, 15);
            dueDateLabel.TabIndex = 10;
            dueDateLabel.Text = "Due Date";
            // 
            // assignBox
            // 
            assignBox.FormattingEnabled = true;
            assignBox.Location = new Point(133, 154);
            assignBox.Margin = new Padding(3, 2, 3, 2);
            assignBox.Name = "assignBox";
            assignBox.Size = new Size(133, 23);
            assignBox.TabIndex = 13;
            // 
            // assignLabel
            // 
            assignLabel.AutoSize = true;
            assignLabel.Location = new Point(82, 157);
            assignLabel.Name = "assignLabel";
            assignLabel.Size = new Size(42, 15);
            assignLabel.TabIndex = 12;
            assignLabel.Text = "Assign";
            // 
            // priorityBox
            // 
            priorityBox.Location = new Point(133, 130);
            priorityBox.Margin = new Padding(3, 2, 3, 2);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(110, 23);
            priorityBox.TabIndex = 14;
            // 
            // undoButton
            // 
            undoButton.Location = new Point(247, 277);
            undoButton.Margin = new Padding(3, 2, 3, 2);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(60, 22);
            undoButton.TabIndex = 15;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            // 
            // redoButton
            // 
            redoButton.Location = new Point(312, 277);
            redoButton.Margin = new Padding(3, 2, 3, 2);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(60, 22);
            redoButton.TabIndex = 16;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = true;
            // 
            // CreateChoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(priorityBox);
            Controls.Add(assignBox);
            Controls.Add(assignLabel);
            Controls.Add(dueDateLabel);
            Controls.Add(dueDateDateTimePicker);
            Controls.Add(priorityLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(descriptionBox);
            Controls.Add(createButton);
            Controls.Add(backButton);
            Controls.Add(nameBox);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dueDateDateTimePicker;
        private Label dueDateLabel;
        private ComboBox assignBox;
        private Label assignLabel;
        private TextBox priorityBox;
        private Button undoButton;
        private Button redoButton;
    }
}