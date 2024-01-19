namespace MyPerpus.Views
{
    partial class Formanggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formanggota));
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textNIM = new TextBox();
            textNama = new TextBox();
            textAlamat = new TextBox();
            textJurusan = new TextBox();
            textHp = new TextBox();
            label8 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconEdit = new FontAwesome.Sharp.IconButton();
            iconSave = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            NIM = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            NoHP = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Jurusan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(144, 48);
            label9.Name = "label9";
            label9.Size = new Size(437, 32);
            label9.TabIndex = 2;
            label9.Text = "Institut Teknologi dan Bisnis STIKOM Bali";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(575, 52);
            label1.TabIndex = 1;
            label1.Text = "Input Data Anggota perpustakaan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
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
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Anggota";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NIM, Username, Nama, NoHP, Alamat, Jurusan });
            dataGridView1.Location = new Point(12, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 232);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 113);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 4;
            label3.Text = "Input Data Anggota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 146);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "NIM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 176);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "NAMA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 208);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "JURUSAN";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 237);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 8;
            label7.Text = "NO. HP";
            // 
            // textNIM
            // 
            textNIM.Location = new Point(566, 146);
            textNIM.Name = "textNIM";
            textNIM.Size = new Size(179, 23);
            textNIM.TabIndex = 9;
            // 
            // textNama
            // 
            textNama.Location = new Point(566, 176);
            textNama.Name = "textNama";
            textNama.Size = new Size(179, 23);
            textNama.TabIndex = 10;
            // 
            // textAlamat
            // 
            textAlamat.Location = new Point(566, 263);
            textAlamat.Name = "textAlamat";
            textAlamat.Size = new Size(179, 23);
            textAlamat.TabIndex = 11;
            // 
            // textJurusan
            // 
            textJurusan.Location = new Point(566, 205);
            textJurusan.Name = "textJurusan";
            textJurusan.Size = new Size(179, 23);
            textJurusan.TabIndex = 12;
            // 
            // textHp
            // 
            textHp.Location = new Point(566, 234);
            textHp.Name = "textHp";
            textHp.Size = new Size(179, 23);
            textHp.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 266);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "Alamat";
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(484, 310);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(57, 50);
            iconButton1.TabIndex = 18;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconEdit
            // 
            iconEdit.BackgroundImageLayout = ImageLayout.None;
            iconEdit.FlatStyle = FlatStyle.Flat;
            iconEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconEdit.IconColor = Color.Black;
            iconEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEdit.Location = new Point(582, 308);
            iconEdit.Name = "iconEdit";
            iconEdit.Size = new Size(57, 50);
            iconEdit.TabIndex = 19;
            iconEdit.UseVisualStyleBackColor = true;
            iconEdit.Click += iconButton2_Click;
            // 
            // iconSave
            // 
            iconSave.BackgroundImageLayout = ImageLayout.None;
            iconSave.FlatStyle = FlatStyle.Flat;
            iconSave.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconSave.IconColor = Color.Black;
            iconSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSave.Location = new Point(674, 309);
            iconSave.Name = "iconSave";
            iconSave.Size = new Size(57, 50);
            iconSave.TabIndex = 20;
            iconSave.UseVisualStyleBackColor = true;
            iconSave.Click += iconButton3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(493, 360);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 21;
            label10.Text = "Hapus";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(596, 360);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 22;
            label11.Text = "Edit";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(688, 360);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 23;
            label12.Text = "Save";
            // 
            // NIM
            // 
            NIM.HeaderText = "No";
            NIM.Name = "NIM";
            // 
            // Username
            // 
            Username.HeaderText = "NIM";
            Username.Name = "Username";
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            // 
            // NoHP
            // 
            NoHP.HeaderText = "NoHP";
            NoHP.Name = "NoHP";
            // 
            // Alamat
            // 
            Alamat.HeaderText = "Alamat";
            Alamat.Name = "Alamat";
            // 
            // Jurusan
            // 
            Jurusan.HeaderText = "Jurusan";
            Jurusan.Name = "Jurusan";
            // 
            // Formanggota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(iconSave);
            Controls.Add(iconEdit);
            Controls.Add(iconButton1);
            Controls.Add(label8);
            Controls.Add(textHp);
            Controls.Add(textJurusan);
            Controls.Add(textAlamat);
            Controls.Add(textNama);
            Controls.Add(textNIM);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formanggota";
            Text = "dataanggota";
            Load += Formangota_Load;
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
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textNIM;
        private TextBox textNama;
        private TextBox textAlamat;
        private TextBox textJurusan;
        private TextBox textHp;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconEdit;
        private FontAwesome.Sharp.IconButton iconSave;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridViewTextBoxColumn NIM;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn NoHP;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn Jurusan;
    }
}