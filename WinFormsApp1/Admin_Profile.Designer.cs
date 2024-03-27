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
            button1 = new Button();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button5 = new Button();
            label5 = new Label();
            passwordBox = new TextBox();
            showFiles = new Button();
            textBox4 = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, -29);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 508);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-3, 340);
            button1.Name = "button1";
            button1.Size = new Size(175, 107);
            button1.TabIndex = 6;
            button1.Text = "Enroll Student";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 107);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 107);
            panelLeft.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1, 211);
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
            button2.Location = new Point(1, 91);
            button2.Name = "button2";
            button2.Size = new Size(175, 107);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 23);
            label1.Name = "label1";
            label1.Size = new Size(271, 46);
            label1.TabIndex = 5;
            label1.Text = "Admin Profile";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(886, 23);
            button5.Name = "button5";
            button5.Size = new Size(112, 31);
            button5.TabIndex = 39;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 230);
            label5.Name = "label5";
            label5.Size = new Size(236, 36);
            label5.TabIndex = 55;
            label5.Text = "New Password:";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(558, 236);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(217, 27);
            passwordBox.TabIndex = 54;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(605, 322);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 56;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(199, 85);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 172);
            label2.Name = "label2";
            label2.Size = new Size(177, 36);
            label2.TabIndex = 59;
            label2.Text = "New Name:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(558, 182);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(217, 27);
            nameBox.TabIndex = 58;
            // 
            // Admin_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 477);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(textBox4);
            Controls.Add(showFiles);
            Controls.Add(label5);
            Controls.Add(passwordBox);
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
        private Label label5;
        private TextBox passwordBox;
        private Button showFiles;
        private TextBox textBox4;    // display name on run time 
        private Button button1;
        private Label label2;
        private TextBox nameBox;
    }
}