namespace WinFormsApp1
{
    partial class Announcement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            panel1 = new Panel();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            Section_comboBox2 = new ComboBox();
            Course_comboBox1 = new ComboBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button6 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 378);
            panel1.TabIndex = 3;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 266);
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
            button4.Location = new Point(0, 266);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 80);
            button4.TabIndex = 5;
            button4.Text = "Announcement";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 80);
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
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 182);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(153, 80);
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
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 104);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(153, 80);
            button2.TabIndex = 3;
            button2.Text = "Quiz";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 14);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 2;
            label1.Text = "ANNOUNCEMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 138);
            label3.Name = "label3";
            label3.Size = new Size(108, 29);
            label3.TabIndex = 9;
            label3.Text = "Section:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 88);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 8;
            label2.Text = "Course:";
            // 
            // Section_comboBox2
            // 
            Section_comboBox2.FormattingEnabled = true;
            Section_comboBox2.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "Y", "Z", "All Sections" });
            Section_comboBox2.Location = new Point(457, 145);
            Section_comboBox2.Margin = new Padding(3, 2, 3, 2);
            Section_comboBox2.Name = "Section_comboBox2";
            Section_comboBox2.Size = new Size(307, 23);
            Section_comboBox2.TabIndex = 7;
            // 
            // Course_comboBox1
            // 
            Course_comboBox1.FormattingEnabled = true;
            Course_comboBox1.Location = new Point(457, 94);
            Course_comboBox1.Margin = new Padding(3, 2, 3, 2);
            Course_comboBox1.Name = "Course_comboBox1";
            Course_comboBox1.Size = new Size(307, 23);
            Course_comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(200, 186);
            label4.Name = "label4";
            label4.Size = new Size(192, 29);
            label4.TabIndex = 10;
            label4.Text = "Announcement:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(461, 193);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(302, 138);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(647, 339);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 25);
            button6.TabIndex = 26;
            button6.Text = "UPLOAD";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(802, 14);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(116, 25);
            button5.TabIndex = 27;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 378);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Section_comboBox2);
            Controls.Add(Course_comboBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Announcement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Announcement";
            Load += Announcement_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label1;
        private FlowLayoutPanel panelLeft;
        private Label label3;
        private Label label2;
        private ComboBox Section_comboBox2;
        private ComboBox Course_comboBox1;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button6;
        private Button button5;
    }
}