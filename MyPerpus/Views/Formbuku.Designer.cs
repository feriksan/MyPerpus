
namespace MyPerpus.Views
{
    partial class Formbuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formbuku));
            panel1 = new Panel();
            label12 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            KodeBuku = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Penulis = new DataGridViewTextBoxColumn();
            Penerbit = new DataGridViewTextBoxColumn();
            tahun = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxJudul = new TextBox();
            textBoxKodeBuku = new TextBox();
            textBoxPenulis = new TextBox();
            textBoxPenerbit = new TextBox();
            textBoxTahun = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
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
            label12.TabIndex = 3;
            label12.Text = "Institut Teknologi dan Bisnis STIKOM Bali";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(524, 52);
            label1.TabIndex = 1;
            label1.Text = "Input Data Buku Perpustakaan";
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
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Buku";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodeBuku, Judul, Penulis, Penerbit, tahun });
            dataGridView1.Location = new Point(12, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 232);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KodeBuku
            // 
            KodeBuku.HeaderText = "KodeBuku";
            KodeBuku.Name = "KodeBuku";
            // 
            // Judul
            // 
            Judul.HeaderText = "Judul";
            Judul.Name = "Judul";
            // 
            // Penulis
            // 
            Penulis.HeaderText = "Penulis";
            Penulis.Name = "Penulis";
            // 
            // Penerbit
            // 
            Penerbit.HeaderText = "Penerbit";
            Penerbit.Name = "Penerbit";
            // 
            // tahun
            // 
            tahun.HeaderText = "Tahun";
            tahun.Name = "tahun";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 113);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Input Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 144);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "KODE BUKU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 179);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "JUDUL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 217);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 7;
            label6.Text = "PENULIS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(477, 252);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 8;
            label7.Text = "PENERBIT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(477, 285);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 9;
            label8.Text = "TAHUN";
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(568, 173);
            textBoxJudul.Multiline = true;
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(201, 31);
            textBoxJudul.TabIndex = 11;
            // 
            // textBoxKodeBuku
            // 
            textBoxKodeBuku.Enabled = false;
            textBoxKodeBuku.Location = new Point(568, 136);
            textBoxKodeBuku.Multiline = true;
            textBoxKodeBuku.Name = "textBoxKodeBuku";
            textBoxKodeBuku.ReadOnly = true;
            textBoxKodeBuku.Size = new Size(201, 31);
            textBoxKodeBuku.TabIndex = 12;
            // 
            // textBoxPenulis
            // 
            textBoxPenulis.Location = new Point(568, 210);
            textBoxPenulis.Multiline = true;
            textBoxPenulis.Name = "textBoxPenulis";
            textBoxPenulis.Size = new Size(201, 31);
            textBoxPenulis.TabIndex = 13;
            // 
            // textBoxPenerbit
            // 
            textBoxPenerbit.Location = new Point(568, 245);
            textBoxPenerbit.Multiline = true;
            textBoxPenerbit.Name = "textBoxPenerbit";
            textBoxPenerbit.Size = new Size(201, 31);
            textBoxPenerbit.TabIndex = 14;
            // 
            // textBoxTahun
            // 
            textBoxTahun.Location = new Point(568, 282);
            textBoxTahun.Multiline = true;
            textBoxTahun.Name = "textBoxTahun";
            textBoxTahun.Size = new Size(201, 31);
            textBoxTahun.TabIndex = 15;
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(692, 319);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(56, 53);
            iconButton2.TabIndex = 18;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(608, 319);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(56, 53);
            iconButton3.TabIndex = 19;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(519, 319);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(56, 53);
            iconButton1.TabIndex = 17;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(529, 375);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 20;
            label9.Text = "Hapus";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(622, 375);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 21;
            label10.Text = "Edit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(703, 375);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 22;
            label11.Text = "Save";
            // 
            // Formbuku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(textBoxTahun);
            Controls.Add(textBoxPenerbit);
            Controls.Add(textBoxPenulis);
            Controls.Add(textBoxKodeBuku);
            Controls.Add(textBoxJudul);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formbuku";
            Text = "Formbuku";
            Load += Formbuku_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxJudul;
        private TextBox textBoxKodeBuku;
        private TextBox textBoxPenulis;
        private TextBox textBoxPenerbit;
        private TextBox textBoxTahun;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Penulis;
        private DataGridViewTextBoxColumn Penerbit;
        private DataGridViewTextBoxColumn tahun;
    }
}