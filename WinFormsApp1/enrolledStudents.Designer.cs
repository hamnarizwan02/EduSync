namespace WinFormsApp1
{
    partial class enrolledStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enrolledStudents));
            panel1 = new Panel();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Email = new TextBox();
            Name = new TextBox();
            showFiles = new Button();
            label1 = new Label();
            button5 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            Password = new TextBox();
            label6 = new Label();
            CoursecomboBox = new ComboBox();
            SectioncomboBox = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, -32);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 378);
            panel1.TabIndex = 5;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 262);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(9, 80);
            panelLeft.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1, 262);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 80);
            button4.TabIndex = 5;
            button4.Text = "Enroll Student";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 171);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(153, 80);
            button3.TabIndex = 4;
            button3.Text = "Enroll Instructor";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 80);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(153, 80);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Email
            // 
            Email.Location = new Point(366, 134);
            Email.Margin = new Padding(3, 2, 3, 2);
            Email.Name = "Email";
            Email.Size = new Size(181, 23);
            Email.TabIndex = 34;
            // 
            // Name
            // 
            Name.Location = new Point(366, 92);
            Name.Margin = new Padding(3, 2, 3, 2);
            Name.Name = "Name";
            Name.Size = new Size(181, 23);
            Name.TabIndex = 33;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(386, 297);
            showFiles.Margin = new Padding(3, 2, 3, 2);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(116, 25);
            showFiles.TabIndex = 32;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 37);
            label1.TabIndex = 36;
            label1.Text = "Enroll Student ";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(573, 9);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(116, 25);
            button5.TabIndex = 37;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 243);
            label3.Name = "label3";
            label3.Size = new Size(104, 29);
            label3.TabIndex = 39;
            label3.Text = "Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 85);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 38;
            label2.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(200, 166);
            label4.Name = "label4";
            label4.Size = new Size(135, 29);
            label4.TabIndex = 41;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(254, 126);
            label5.Name = "label5";
            label5.Size = new Size(86, 29);
            label5.TabIndex = 40;
            label5.Text = "Email:";
            // 
            // Password
            // 
            Password.Location = new Point(366, 170);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Size = new Size(181, 23);
            Password.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 207);
            label6.Name = "label6";
            label6.Size = new Size(108, 29);
            label6.TabIndex = 44;
            label6.Text = "Section:";
            // 
            // CoursecomboBox
            // 
            CoursecomboBox.FormattingEnabled = true;
            CoursecomboBox.Location = new Point(366, 252);
            CoursecomboBox.Margin = new Padding(3, 2, 3, 2);
            CoursecomboBox.Name = "CoursecomboBox";
            CoursecomboBox.Size = new Size(181, 23);
            CoursecomboBox.TabIndex = 46;
            // 
            // SectioncomboBox
            // 
            SectioncomboBox.FormattingEnabled = true;
            SectioncomboBox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "Y", "Z" });
            SectioncomboBox.Location = new Point(366, 214);
            SectioncomboBox.Margin = new Padding(3, 2, 3, 2);
            SectioncomboBox.Name = "SectioncomboBox";
            SectioncomboBox.Size = new Size(181, 23);
            SectioncomboBox.TabIndex = 47;
            // 
            // enrolledStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 378);
            Controls.Add(SectioncomboBox);
            Controls.Add(CoursecomboBox);
            Controls.Add(label6);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(Name);
            Controls.Add(showFiles);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "enrolledStudents";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel panelLeft;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox Email;
        private TextBox Name;
        private Button showFiles;
        private Label label1;
        private Button button5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox Password;
        private Label label6;
        private ComboBox CoursecomboBox;
        private ComboBox SectioncomboBox;
    }
}