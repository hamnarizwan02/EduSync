namespace WinFormsApp1
{
    partial class AnnouncementView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnouncementView));
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panelLeft = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            textBox1 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(161, 282);
            label5.Name = "label5";
            label5.Size = new Size(0, 29);
            label5.TabIndex = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 193);
            dataGridView1.TabIndex = 48;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 26);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(9, 80);
            panelLeft.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(16, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 80);
            button1.TabIndex = 2;
            button1.Text = "Assignment";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(16, 182);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(153, 80);
            button3.TabIndex = 4;
            button3.Text = "Lecture Notes";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(16, 104);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(153, 80);
            button2.TabIndex = 3;
            button2.Text = "Quiz";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-11, -5);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 461);
            panel1.TabIndex = 49;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Maroon;
            flowLayoutPanel1.Location = new Point(0, 260);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(23, 80);
            flowLayoutPanel1.TabIndex = 43;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(16, 260);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 80);
            button4.TabIndex = 5;
            button4.Text = "Announcement";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(199, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 20);
            textBox1.TabIndex = 52;
            textBox1.Text = "Announcement";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(696, 47);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 25);
            button6.TabIndex = 51;
            button6.Text = "LOG OUT";
            button6.UseVisualStyleBackColor = false;
            // 
            // AnnouncementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Name = "AnnouncementView";
            Text = "AnnouncementView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private FlowLayoutPanel panelLeft;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
        private TextBox textBox1;
        private Button button6;
    }
}