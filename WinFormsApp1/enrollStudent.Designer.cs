namespace WinFormsApp1
{
    partial class enrollStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enrollStudent));
            panel1 = new Panel();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            showFiles = new Button();
            label1 = new Label();
            button5 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
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
            panel1.Location = new Point(-1, -43);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 504);
            panel1.TabIndex = 5;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 350);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 106);
            panelLeft.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1, 350);
            button4.Name = "button4";
            button4.Size = new Size(175, 106);
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
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 228);
            button3.Name = "button3";
            button3.Size = new Size(175, 106);
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
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 107);
            button2.Name = "button2";
            button2.Size = new Size(175, 106);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(418, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 33;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(450, 381);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 32;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 23);
            label1.Name = "label1";
            label1.Size = new Size(291, 47);
            label1.TabIndex = 36;
            label1.Text = "Enroll Student ";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(645, 23);
            button5.Name = "button5";
            button5.Size = new Size(133, 33);
            button5.TabIndex = 37;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 324);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 39;
            label3.Text = "Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 113);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 38;
            label2.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(228, 222);
            label4.Name = "label4";
            label4.Size = new Size(161, 37);
            label4.TabIndex = 41;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(290, 168);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 40;
            label5.Text = "Email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(418, 334);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 43;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(418, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 27);
            textBox4.TabIndex = 42;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(418, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 27);
            textBox5.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(262, 276);
            label6.Name = "label6";
            label6.Size = new Size(132, 37);
            label6.TabIndex = 44;
            label6.Text = "Section:";
            // 
            // enrollStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(showFiles);
            Controls.Add(panel1);
            Name = "enrollStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "enrollStudent";
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Button showFiles;
        private Label label1;
        private Button button5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
    }
}