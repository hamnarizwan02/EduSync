﻿namespace WinFormsApp1
{
    partial class enrollTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enrollTeacher));
            panel1 = new Panel();
            createcoursebutton = new Button();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            label1 = new Label();
            SectioncomboBox = new ComboBox();
            CoursecomboBox = new ComboBox();
            label6 = new Label();
            Password = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            Email = new TextBox();
            NameT = new TextBox();
            showFiles = new Button();
            errortextBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(createcoursebutton);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, -20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 390);
            panel1.TabIndex = 5;
            // 
            // createcoursebutton
            // 
            createcoursebutton.FlatAppearance.BorderSize = 0;
            createcoursebutton.FlatStyle = FlatStyle.Flat;
            createcoursebutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createcoursebutton.ForeColor = Color.White;
            createcoursebutton.Image = (Image)resources.GetObject("createcoursebutton.Image");
            createcoursebutton.Location = new Point(-3, 299);
            createcoursebutton.Margin = new Padding(3, 2, 3, 2);
            createcoursebutton.Name = "createcoursebutton";
            createcoursebutton.Size = new Size(153, 81);
            createcoursebutton.TabIndex = 6;
            createcoursebutton.Text = "Create Course";
            createcoursebutton.TextAlign = ContentAlignment.BottomCenter;
            createcoursebutton.UseVisualStyleBackColor = true;
            createcoursebutton.Click += createcoursebutton_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(2, 126);
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
            button4.Location = new Point(0, 218);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 76);
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
            button3.Location = new Point(2, 121);
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
            button2.Location = new Point(1, 29);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(153, 80);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(757, 22);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(116, 25);
            button5.TabIndex = 58;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 22);
            label1.Name = "label1";
            label1.Size = new Size(269, 37);
            label1.TabIndex = 57;
            label1.Text = "Enroll Instructor ";
            // 
            // SectioncomboBox
            // 
            SectioncomboBox.FormattingEnabled = true;
            SectioncomboBox.Location = new Point(451, 215);
            SectioncomboBox.Margin = new Padding(3, 2, 3, 2);
            SectioncomboBox.Name = "SectioncomboBox";
            SectioncomboBox.Size = new Size(181, 23);
            SectioncomboBox.TabIndex = 69;
            SectioncomboBox.SelectedIndexChanged += SectioncomboBox_SelectedIndexChanged;
            // 
            // CoursecomboBox
            // 
            CoursecomboBox.FormattingEnabled = true;
            CoursecomboBox.Location = new Point(451, 253);
            CoursecomboBox.Margin = new Padding(3, 2, 3, 2);
            CoursecomboBox.Name = "CoursecomboBox";
            CoursecomboBox.Size = new Size(181, 23);
            CoursecomboBox.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(314, 208);
            label6.Name = "label6";
            label6.Size = new Size(108, 29);
            label6.TabIndex = 67;
            label6.Text = "Section:";
            // 
            // Password
            // 
            Password.Location = new Point(451, 172);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Size = new Size(181, 23);
            Password.TabIndex = 66;
            Password.TextChanged += Password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(284, 167);
            label4.Name = "label4";
            label4.Size = new Size(135, 29);
            label4.TabIndex = 65;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(339, 127);
            label5.Name = "label5";
            label5.Size = new Size(86, 29);
            label5.TabIndex = 64;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 244);
            label3.Name = "label3";
            label3.Size = new Size(104, 29);
            label3.TabIndex = 63;
            label3.Text = "Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(329, 85);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 62;
            label2.Text = "Name:";
            // 
            // Email
            // 
            Email.Location = new Point(451, 134);
            Email.Margin = new Padding(3, 2, 3, 2);
            Email.Name = "Email";
            Email.Size = new Size(181, 23);
            Email.TabIndex = 61;
            // 
            // NameT
            // 
            NameT.Location = new Point(451, 93);
            NameT.Margin = new Padding(3, 2, 3, 2);
            NameT.Name = "NameT";
            NameT.Size = new Size(181, 23);
            NameT.TabIndex = 60;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(471, 298);
            showFiles.Margin = new Padding(3, 2, 3, 2);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(116, 25);
            showFiles.TabIndex = 59;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click_1;
            // 
            // errortextBox1
            // 
            errortextBox1.BackColor = SystemColors.Control;
            errortextBox1.BorderStyle = BorderStyle.None;
            errortextBox1.Font = new Font("Century Gothic", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errortextBox1.ForeColor = Color.Red;
            errortextBox1.Location = new Point(451, 197);
            errortextBox1.Margin = new Padding(3, 2, 3, 2);
            errortextBox1.Name = "errortextBox1";
            errortextBox1.Size = new Size(330, 10);
            errortextBox1.TabIndex = 71;
            // 
            // enrollTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 368);
            Controls.Add(errortextBox1);
            Controls.Add(SectioncomboBox);
            Controls.Add(CoursecomboBox);
            Controls.Add(label6);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(NameT);
            Controls.Add(showFiles);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "enrollTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "enrollTeacher";
            Load += enrollTeacher_Load_1;
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
        private Button button5;
        private Label label1;
        private ComboBox SectioncomboBox;
        private ComboBox CoursecomboBox;
        private Label label6;
        private TextBox Password;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox Email;
        private TextBox NameT;
        private Button showFiles;
        private Button createcoursebutton;
        private TextBox errortextBox1;
    }
}