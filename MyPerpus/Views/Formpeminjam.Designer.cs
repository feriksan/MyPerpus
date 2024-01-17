using FontAwesome.Sharp;

namespace MyPerpus.Views
{
    partial class Formpeminjam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formpeminjam));
            panel1 = new Panel();
            label12 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            KodePinjam = new DataGridViewTextBoxColumn();
            KodeBuku = new DataGridViewTextBoxColumn();
            NIM = new DataGridViewTextBoxColumn();
            TanggalPinjam = new DataGridViewTextBoxColumn();
            LamaPinjam = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(148, 48);
            label12.Name = "label12";
            label12.Size = new Size(437, 32);
            label12.TabIndex = 5;
            label12.Text = "Institut Teknologi dan Bisnis STIKOM Bali";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 52);
            label1.TabIndex = 4;
            label1.Text = "Input Peminjam Buku";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 46);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 112);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Input Peminjam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 202);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "NIM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 170);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "KODE BUKU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 136);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 5;
            label5.Text = "KODE PINJAM";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 199);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(453, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(453, 170);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 178);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "LAMA PINJAM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 141);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 12;
            label7.Text = "TANGGAL PINJAM";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(694, 133);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(65, 64);
            iconButton1.TabIndex = 13;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 224);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 14;
            label8.Text = "Data Peminjam ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodePinjam, KodeBuku, NIM, TanggalPinjam, LamaPinjam });
            dataGridView1.Location = new Point(28, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 150);
            dataGridView1.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(707, 198);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 23;
            label11.Text = "Save";
            // 
            // KodePinjam
            // 
            KodePinjam.HeaderText = "KodePinjam";
            KodePinjam.Name = "KodePinjam";
            KodePinjam.Width = 300;
            // 
            // KodeBuku
            // 
            KodeBuku.HeaderText = "KudeBuku";
            KodeBuku.Name = "KodeBuku";
            // 
            // NIM
            // 
            NIM.HeaderText = "NIM";
            NIM.Name = "NIM";
            // 
            // TanggalPinjam
            // 
            TanggalPinjam.HeaderText = "TanggalPinjam";
            TanggalPinjam.Name = "TanggalPinjam";
            // 
            // LamaPinjam
            // 
            LamaPinjam.HeaderText = "LamaPinjam";
            LamaPinjam.Name = "LamaPinjam";
            // 
            // Formpeminjam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(iconButton1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formpeminjam";
            Text = "Formpeminjam";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label1;
        private Label label11;
        private DataGridViewTextBoxColumn KodePinjam;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn NIM;
        private DataGridViewTextBoxColumn TanggalPinjam;
        private DataGridViewTextBoxColumn LamaPinjam;
    }
}