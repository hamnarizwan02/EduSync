namespace WinFormsApp1
{
    partial class CreateCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCourse));
            label1 = new Label();
            panel1 = new Panel();
            createcoursebutton = new Button();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            SectionBox = new ComboBox();
            instBox = new ComboBox();
            label6 = new Label();
            CourseBox = new TextBox();
            CourseName = new Label();
            label3 = new Label();
            button5 = new Button();
            showFiles = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 16);
            label1.Name = "label1";
            label1.Size = new Size(407, 46);
            label1.TabIndex = 38;
            label1.Text = "Create a new course";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(createcoursebutton);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, -46);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 562);
            panel1.TabIndex = 37;
            // 
            // createcoursebutton
            // 
            createcoursebutton.FlatAppearance.BorderSize = 0;
            createcoursebutton.FlatStyle = FlatStyle.Flat;
            createcoursebutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createcoursebutton.ForeColor = Color.White;
            createcoursebutton.Image = (Image)resources.GetObject("createcoursebutton.Image");
            createcoursebutton.Location = new Point(12, 424);
            createcoursebutton.Name = "createcoursebutton";
            createcoursebutton.Size = new Size(150, 108);
            createcoursebutton.TabIndex = 7;
            createcoursebutton.Text = "Create Course";
            createcoursebutton.TextAlign = ContentAlignment.BottomCenter;
            createcoursebutton.UseVisualStyleBackColor = true;
            createcoursebutton.Click += createcoursebutton_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(3, 425);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 107);
            panelLeft.TabIndex = 3;
            panelLeft.Paint += panelLeft_Paint;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1, 300);
            button4.Name = "button4";
            button4.Size = new Size(175, 107);
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
            button3.Location = new Point(0, 173);
            button3.Name = "button3";
            button3.Size = new Size(175, 107);
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
            button2.Location = new Point(0, 62);
            button2.Name = "button2";
            button2.Size = new Size(175, 107);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SectionBox
            // 
            SectionBox.FormattingEnabled = true;
            SectionBox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "Y", "Z" });
            SectionBox.Location = new Point(497, 237);
            SectionBox.Name = "SectionBox";
            SectionBox.Size = new Size(206, 28);
            SectionBox.TabIndex = 53;
            // 
            // instBox
            // 
            instBox.FormattingEnabled = true;
            instBox.Location = new Point(497, 301);
            instBox.Name = "instBox";
            instBox.Size = new Size(206, 28);
            instBox.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(341, 229);
            label6.Name = "label6";
            label6.Size = new Size(131, 36);
            label6.TabIndex = 51;
            label6.Text = "Section:";
            label6.Click += label6_Click;
            // 
            // CourseBox
            // 
            CourseBox.Location = new Point(497, 180);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(206, 27);
            CourseBox.TabIndex = 50;
            CourseBox.TextChanged += Password_TextChanged;
            // 
            // CourseName
            // 
            CourseName.AutoSize = true;
            CourseName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseName.Location = new Point(256, 170);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(216, 36);
            CourseName.TabIndex = 49;
            CourseName.Text = "Course Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 291);
            label3.Name = "label3";
            label3.Size = new Size(159, 36);
            label3.TabIndex = 48;
            label3.Text = "Instructor:";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(855, 30);
            button5.Name = "button5";
            button5.Size = new Size(133, 33);
            button5.TabIndex = 59;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(538, 364);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 60;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click;
            // 
            // CreateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 491);
            Controls.Add(showFiles);
            Controls.Add(button5);
            Controls.Add(SectionBox);
            Controls.Add(instBox);
            Controls.Add(label6);
            Controls.Add(CourseBox);
            Controls.Add(CourseName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CreateCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCourse";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button createcoursebutton;
        private FlowLayoutPanel panelLeft;
        private Button button4;
        private Button button3;
        private Button button2;
        private ComboBox SectionBox;
        private ComboBox instBox;
        private Label label6;
        private TextBox CourseBox;
        private Label CourseName;
        private Label label3;
        private Button button5;
        private Button showFiles;
    }
}