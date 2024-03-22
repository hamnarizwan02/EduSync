

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
            textBox7 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox8 = new TextBox();
            button6 = new Button();
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
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(698, 11);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 25);
            button6.TabIndex = 52;
            button6.Text = "LOG OUT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(884, 378);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox textBox7;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox8;
        private Button button6;
    }
}