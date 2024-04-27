namespace WinFormsApp1
{
    partial class QuizBookMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizBookMark));
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panelLeft = new FlowLayoutPanel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 77);
            panel1.TabIndex = 54;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 11);
            button3.Name = "button3";
            button3.Size = new Size(70, 50);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(125, -15);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 92);
            button1.TabIndex = 2;
            button1.Text = "Assignment";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(210, -3);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(138, 80);
            button2.TabIndex = 3;
            button2.Text = "Quiz";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(247, 1);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(69, 10);
            panelLeft.TabIndex = 54;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(125, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 33);
            textBox1.TabIndex = 56;
            textBox1.Text = "Bookmarked";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(608, 214);
            dataGridView1.TabIndex = 55;
            // 
            // button4
            // 
            button4.Location = new Point(125, 402);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 57;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // QuizBookMark
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 457);
            Controls.Add(button4);
            Controls.Add(panelLeft);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "QuizBookMark";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizBookMark";
            Load += QuizBookMark_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private FlowLayoutPanel panelLeft;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
    }
}