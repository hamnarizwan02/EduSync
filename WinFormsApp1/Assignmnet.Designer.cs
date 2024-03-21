namespace WinFormsApp1
{
    partial class Assignmnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignmnet));
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            panelLeft = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            Course_comboBox1 = new ComboBox();
            Section_comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            DueDate_dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            showFiles = new Button();
            listBox1 = new ListBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 25);
            label1.Name = "label1";
            label1.Size = new Size(271, 47);
            label1.TabIndex = 0;
            label1.Text = "ASSIGNMENT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 504);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 347);
            button4.Name = "button4";
            button4.Size = new Size(175, 106);
            button4.TabIndex = 5;
            button4.Text = "Announcement";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 34);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 106);
            panelLeft.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 34);
            button1.Name = "button1";
            button1.Size = new Size(175, 106);
            button1.TabIndex = 2;
            button1.Text = "Assignment";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 243);
            button3.Name = "button3";
            button3.Size = new Size(175, 106);
            button3.TabIndex = 4;
            button3.Text = "Lecture Notes";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 139);
            button2.Name = "button2";
            button2.Size = new Size(175, 106);
            button2.TabIndex = 3;
            button2.Text = "Quiz";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Course_comboBox1
            // 
            Course_comboBox1.FormattingEnabled = true;
            Course_comboBox1.Location = new Point(502, 112);
            Course_comboBox1.Name = "Course_comboBox1";
            Course_comboBox1.Size = new Size(344, 28);
            Course_comboBox1.TabIndex = 2;
            // 
            // Section_comboBox2
            // 
            Section_comboBox2.FormattingEnabled = true;
            Section_comboBox2.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "Y", "Z" });
            Section_comboBox2.Location = new Point(502, 179);
            Section_comboBox2.Name = "Section_comboBox2";
            Section_comboBox2.Size = new Size(344, 28);
            Section_comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 103);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 4;
            label2.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(332, 170);
            label3.Name = "label3";
            label3.Size = new Size(132, 37);
            label3.TabIndex = 5;
            label3.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 238);
            label4.Name = "label4";
            label4.Size = new Size(160, 37);
            label4.TabIndex = 6;
            label4.Text = "Due Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(197, 331);
            label5.Name = "label5";
            label5.Size = new Size(0, 37);
            label5.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(713, 433);
            button5.Name = "button5";
            button5.Size = new Size(133, 33);
            button5.TabIndex = 9;
            button5.Text = "UPLOAD";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // DueDate_dateTimePicker1
            // 
            DueDate_dateTimePicker1.Location = new Point(502, 248);
            DueDate_dateTimePicker1.Name = "DueDate_dateTimePicker1";
            DueDate_dateTimePicker1.Size = new Size(344, 27);
            DueDate_dateTimePicker1.TabIndex = 10;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(862, 25);
            button6.Name = "button6";
            button6.Size = new Size(133, 33);
            button6.TabIndex = 18;
            button6.Text = "LOG OUT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(502, 433);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 21;
            showFiles.Text = "SHOW FILES";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(502, 311);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(344, 104);
            listBox1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(218, 307);
            label6.Name = "label6";
            label6.Size = new Size(241, 37);
            label6.TabIndex = 19;
            label6.Text = "Assignment file:";
            // 
            // Assignmnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 504);
            Controls.Add(showFiles);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(DueDate_dateTimePicker1);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Section_comboBox2);
            Controls.Add(Course_comboBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Assignmnet";
            Text = "ContentUpload";
            Load += Assignmnet_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private FlowLayoutPanel panelLeft;
        private ComboBox Course_comboBox1;
        private ComboBox Section_comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
        private DateTimePicker DueDate_dateTimePicker1;
        private Button button6;
        private Button showFiles;
        private ListBox listBox1;
        private Label label6;
    }
}