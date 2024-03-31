namespace CSCN72040_Project_Group11_ChoreMe
{
    partial class Form1
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(489, 166);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Scroll View";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ScrollViewBtn;
            // 
            // button1
            // 
            button1.Location = new Point(145, 166);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Sign out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += LoginFormBtn;
            // 
            // button5
            // 
            button5.Location = new Point(353, 260);
            button5.Name = "button5";
            button5.Size = new Size(94, 64);
            button5.TabIndex = 4;
            button5.Text = "Group Menu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button1;
        private Button button5;
    }
}
