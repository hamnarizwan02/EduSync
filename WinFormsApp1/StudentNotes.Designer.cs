namespace WinFormsApp1
{
    partial class StudentNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentNotes));
            showFiles = new Button();
            listBox1 = new ListBox();
            label6 = new Label();
            button6 = new Button();
            openNotes = new Button();
            label5 = new Label();
            panel1 = new Panel();
            button7 = new Button();
            panelLeft = new FlowLayoutPanel();
            button8 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            create_new_doc = new Button();
            label3 = new Label();
            filename_textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button9 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(528, 522);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 35;
            showFiles.Text = "SHOW FILES";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(516, 191);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(350, 84);
            listBox1.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(292, 206);
            label6.Name = "label6";
            label6.Size = new Size(158, 36);
            label6.TabIndex = 33;
            label6.Text = "Notes file:";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(859, 43);
            button6.Name = "button6";
            button6.Size = new Size(133, 33);
            button6.TabIndex = 32;
            button6.Text = "LOG OUT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // openNotes
            // 
            openNotes.BackColor = Color.Black;
            openNotes.FlatAppearance.BorderSize = 0;
            openNotes.FlatStyle = FlatStyle.Flat;
            openNotes.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openNotes.ForeColor = Color.White;
            openNotes.Location = new Point(733, 522);
            openNotes.Name = "openNotes";
            openNotes.Size = new Size(133, 33);
            openNotes.TabIndex = 30;
            openNotes.Text = "OPEN ";
            openNotes.UseVisualStyleBackColor = false;
            openNotes.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(197, 331);
            label5.Name = "label5";
            label5.Size = new Size(0, 36);
            label5.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 602);
            panel1.TabIndex = 23;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 0, 64);
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(0, 553);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(175, 44);
            button7.TabIndex = 42;
            button7.Text = "Bookmarks";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(0, 444);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 107);
            panelLeft.TabIndex = 3;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(0, 439);
            button8.Name = "button8";
            button8.Size = new Size(175, 107);
            button8.TabIndex = 6;
            button8.Text = "Student Notes";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 329);
            button4.Name = "button4";
            button4.Size = new Size(175, 107);
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
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 107);
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
            button3.Location = new Point(0, 222);
            button3.Name = "button3";
            button3.Size = new Size(175, 107);
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
            button2.Location = new Point(0, 115);
            button2.Name = "button2";
            button2.Size = new Size(175, 107);
            button2.TabIndex = 3;
            button2.Text = "Quiz";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 43);
            label1.Name = "label1";
            label1.Size = new Size(314, 47);
            label1.TabIndex = 22;
            label1.Text = "STUDENT NOTES";
            // 
            // create_new_doc
            // 
            create_new_doc.BackColor = Color.Black;
            create_new_doc.FlatAppearance.BorderSize = 0;
            create_new_doc.FlatStyle = FlatStyle.Flat;
            create_new_doc.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create_new_doc.ForeColor = Color.White;
            create_new_doc.Location = new Point(733, 146);
            create_new_doc.Name = "create_new_doc";
            create_new_doc.Size = new Size(133, 33);
            create_new_doc.TabIndex = 36;
            create_new_doc.Text = "NEW ";
            create_new_doc.UseVisualStyleBackColor = false;
            create_new_doc.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 140);
            label3.Name = "label3";
            label3.Size = new Size(179, 36);
            label3.TabIndex = 37;
            label3.Text = "New Notes:";
            // 
            // filename_textBox1
            // 
            filename_textBox1.Location = new Point(516, 150);
            filename_textBox1.Name = "filename_textBox1";
            filename_textBox1.PlaceholderText = "filename";
            filename_textBox1.Size = new Size(196, 27);
            filename_textBox1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(292, 295);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 200);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(292, 262);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 40;
            textBox1.Text = "Notes:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(292, 522);
            button9.Name = "button9";
            button9.Size = new Size(170, 33);
            button9.TabIndex = 43;
            button9.Text = "DashBoard";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // StudentNotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 598);
            Controls.Add(button9);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(filename_textBox1);
            Controls.Add(label3);
            Controls.Add(create_new_doc);
            Controls.Add(showFiles);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(openNotes);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "StudentNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentNotes";
            Load += LectureNotes_STUDENT_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showFiles;
        private ListBox listBox1;
        private Label label6;
        private Button button6;
        private Button openNotes;
        private Label label5;
        private Panel panel1;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label1;
        private Button create_new_doc;
        private Label label3;
        private FlowLayoutPanel panelLeft;
        private Button button8;
        private TextBox filename_textBox1;
        private Button button7;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button9;
    }
}