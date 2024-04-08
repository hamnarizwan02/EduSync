namespace WinFormsApp1
{
    partial class ForgotPass
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
            Name1 = new Label();
            button5 = new Button();
            label1 = new Label();
            Name2 = new Label();
            SuspendLayout();
            // 
            // Name1
            // 
            Name1.AutoSize = true;
            Name1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name1.Location = new Point(57, 113);
            Name1.Name = "Name1";
            Name1.Size = new Size(0, 23);
            Name1.TabIndex = 31;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 276);
            button5.Name = "button5";
            button5.Size = new Size(115, 33);
            button5.TabIndex = 32;
            button5.Text = "<< Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 18);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 33;
            label1.Text = "Forgot Password :(";
            label1.Click += label1_Click;
            // 
            // Name2
            // 
            Name2.AutoSize = true;
            Name2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name2.Location = new Point(272, 113);
            Name2.Name = "Name2";
            Name2.Size = new Size(0, 23);
            Name2.TabIndex = 34;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 247, 253);
            ClientSize = new Size(778, 321);
            Controls.Add(Name2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(Name1);
            Name = "ForgotPass";
            Text = "forgotpass";
            Load += ForgotPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name1;
        private Button button5;
        private Label label1;
        private Label Name2;
    }
}