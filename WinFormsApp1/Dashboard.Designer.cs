

namespace WinFormsApp1
{
    partial class Dashboard
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 159);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("League Spartan", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(340, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 24);
            textBox1.TabIndex = 1;
            textBox1.Text = "Dashboard";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDark;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(74, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 15);
            textBox2.TabIndex = 2;
            textBox2.Text = "SR.NO";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlDark;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(167, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 15);
            textBox3.TabIndex = 3;
            textBox3.Text = "Course Title";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlDark;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(318, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(87, 15);
            textBox4.TabIndex = 4;
            textBox4.Text = "Course Code";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlDark;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(463, 62);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(87, 15);
            textBox5.TabIndex = 5;
            textBox5.Text = "Class";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ControlDark;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(595, 62);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(87, 15);
            textBox6.TabIndex = 6;
            textBox6.Text = "Semester";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("League Spartan", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(595, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 22);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Semester";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(3, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(75, 15);
            textBox7.TabIndex = 9;
            textBox7.Text = "Course ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(textBox7, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox8, 1, 0);
            tableLayoutPanel1.Location = new Point(49, 245);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tableLayoutPanel1.Size = new Size(280, 102);
            tableLayoutPanel1.TabIndex = 10;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("League Spartan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(101, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(102, 15);
            textBox8.TabIndex = 11;
            textBox8.Text = "Announcement";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox8;
    }
}