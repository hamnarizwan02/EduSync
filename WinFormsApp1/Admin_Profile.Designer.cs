namespace WinFormsApp1
{
    partial class Admin_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Profile));
            panel1 = new Panel();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button5 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            showFiles = new Button();
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
            panel1.Location = new Point(0, -30);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 504);
            panel1.TabIndex = 4;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 106);
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
            button4.Location = new Point(2, 333);
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
            button3.Location = new Point(1, 211);
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
            button2.Location = new Point(1, 90);
            button2.Name = "button2";
            button2.Size = new Size(175, 106);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 23);
            label1.Name = "label1";
            label1.Size = new Size(277, 47);
            label1.TabIndex = 5;
            label1.Text = "Admin Profile";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(659, 23);
            button5.Name = "button5";
            button5.Size = new Size(133, 33);
            button5.TabIndex = 39;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 87);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 45;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(255, 158);
            label4.Name = "label4";
            label4.Size = new Size(187, 37);
            label4.TabIndex = 51;
            label4.Text = "New Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(266, 227);
            label3.Name = "label3";
            label3.Size = new Size(176, 37);
            label3.TabIndex = 53;
            label3.Text = "New Email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(477, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(208, 300);
            label5.Name = "label5";
            label5.Size = new Size(234, 37);
            label5.TabIndex = 55;
            label5.Text = "New Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(477, 310);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 54;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(403, 377);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 56;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            // 
            // Admin_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 466);
            Controls.Add(showFiles);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Admin_Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
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
        private Label label1;
        private Button button5;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Button showFiles;
    }
}