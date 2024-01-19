namespace MyPerpus.Views
{
    partial class Formpengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formpengembalian));
            panel1 = new Panel();
            label13 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            iconButtonSave = new FontAwesome.Sharp.IconButton();
            textBoxKodeBuku = new TextBox();
            textBoxNim = new TextBox();
            textBoxDenda = new TextBox();
            dateTimePickerTanggalPinjam = new DateTimePicker();
            dateTimePickerTanggalKembali = new DateTimePicker();
            textBoxLamaPinjam = new TextBox();
            textBoxTotalDenda = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            KodePinjam = new DataGridViewTextBoxColumn();
            KodeBuku = new DataGridViewTextBoxColumn();
            NIM = new DataGridViewTextBoxColumn();
            JatuhTempo = new DataGridViewTextBoxColumn();
            TanggalPinjam = new DataGridViewTextBoxColumn();
            LamaPinjam = new DataGridViewTextBoxColumn();
            TanggalKembali = new DataGridViewTextBoxColumn();
            TotalDenda = new DataGridViewTextBoxColumn();
            dateTimePickerJatuhTempo = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 100);
            panel1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(148, 48);
            label13.Name = "label13";
            label13.Size = new Size(437, 32);
            label13.TabIndex = 2;
            label13.Text = "Institut Teknologi dan Bisnis STIKOM Bali";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 47);
            label1.TabIndex = 1;
            label1.Text = "Input Pengembalian Buku";
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
            panel2.Location = new Point(0, 458);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 46);
            panel2.TabIndex = 1;
            // 
            // iconButtonSave
            // 
            iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconButtonSave.IconColor = Color.Black;
            iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSave.Location = new Point(690, 177);
            iconButtonSave.Name = "iconButtonSave";
            iconButtonSave.Size = new Size(74, 67);
            iconButtonSave.TabIndex = 13;
            iconButtonSave.UseVisualStyleBackColor = true;
            iconButtonSave.Click += iconButton1_Click;
            // 
            // textBoxKodeBuku
            // 
            textBoxKodeBuku.Location = new Point(148, 147);
            textBoxKodeBuku.Name = "textBoxKodeBuku";
            textBoxKodeBuku.Size = new Size(100, 23);
            textBoxKodeBuku.TabIndex = 15;
            // 
            // textBoxNim
            // 
            textBoxNim.Location = new Point(148, 180);
            textBoxNim.Name = "textBoxNim";
            textBoxNim.Size = new Size(100, 23);
            textBoxNim.TabIndex = 16;
            // 
            // textBoxDenda
            // 
            textBoxDenda.Location = new Point(345, 257);
            textBoxDenda.Name = "textBoxDenda";
            textBoxDenda.Size = new Size(100, 23);
            textBoxDenda.TabIndex = 18;
            // 
            // dateTimePickerTanggalPinjam
            // 
            dateTimePickerTanggalPinjam.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePickerTanggalPinjam.Format = DateTimePickerFormat.Custom;
            dateTimePickerTanggalPinjam.Location = new Point(454, 141);
            dateTimePickerTanggalPinjam.Name = "dateTimePickerTanggalPinjam";
            dateTimePickerTanggalPinjam.Size = new Size(200, 23);
            dateTimePickerTanggalPinjam.TabIndex = 19;
            // 
            // dateTimePickerTanggalKembali
            // 
            dateTimePickerTanggalKembali.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePickerTanggalKembali.Format = DateTimePickerFormat.Custom;
            dateTimePickerTanggalKembali.Location = new Point(454, 213);
            dateTimePickerTanggalKembali.Name = "dateTimePickerTanggalKembali";
            dateTimePickerTanggalKembali.Size = new Size(200, 23);
            dateTimePickerTanggalKembali.TabIndex = 20;
            // 
            // textBoxLamaPinjam
            // 
            textBoxLamaPinjam.Location = new Point(148, 221);
            textBoxLamaPinjam.Name = "textBoxLamaPinjam";
            textBoxLamaPinjam.Size = new Size(100, 23);
            textBoxLamaPinjam.TabIndex = 21;
            // 
            // textBoxTotalDenda
            // 
            textBoxTotalDenda.Location = new Point(554, 256);
            textBoxTotalDenda.Name = "textBoxTotalDenda";
            textBoxTotalDenda.Size = new Size(100, 23);
            textBoxTotalDenda.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 112);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 24;
            label2.Text = "Input Pengembalian";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 147);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 26;
            label4.Text = "KODE PEMINJAMAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 183);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 27;
            label5.Text = "NIM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 183);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 28;
            label6.Text = "JATUH TEMPO";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 260);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 29;
            label7.Text = "DENDA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(467, 260);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 30;
            label8.Text = "TOTAL DENDA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 221);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 31;
            label9.Text = "LAMA PINJAM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 147);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 32;
            label10.Text = "TANGGAL PINJAM";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(341, 218);
            label11.Name = "label11";
            label11.Size = new Size(110, 15);
            label11.TabIndex = 33;
            label11.Text = "TANGGAL KEMBALI";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(711, 247);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 34;
            label12.Text = "Save";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 296);
            label14.Name = "label14";
            label14.Size = new Size(110, 15);
            label14.TabIndex = 35;
            label14.Text = "Data Pengembalian";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodePinjam, KodeBuku, NIM, JatuhTempo, TanggalPinjam, LamaPinjam, TanggalKembali, TotalDenda });
            dataGridView1.Location = new Point(29, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(735, 84);
            dataGridView1.TabIndex = 36;
            // 
            // KodePinjam
            // 
            KodePinjam.HeaderText = "KodePinjam";
            KodePinjam.Name = "KodePinjam";
            // 
            // KodeBuku
            // 
            KodeBuku.HeaderText = "KodeBuku";
            KodeBuku.Name = "KodeBuku";
            // 
            // NIM
            // 
            NIM.HeaderText = "NIM";
            NIM.Name = "NIM";
            // 
            // JatuhTempo
            // 
            JatuhTempo.HeaderText = "JatuhTempo";
            JatuhTempo.Name = "JatuhTempo";
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
            // TanggalKembali
            // 
            TanggalKembali.HeaderText = "TanggalKembali";
            TanggalKembali.Name = "TanggalKembali";
            // 
            // TotalDenda
            // 
            TotalDenda.HeaderText = "TotalDenda";
            TotalDenda.Name = "TotalDenda";
            // 
            // dateTimePickerJatuhTempo
            // 
            dateTimePickerJatuhTempo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePickerJatuhTempo.Format = DateTimePickerFormat.Custom;
            dateTimePickerJatuhTempo.Location = new Point(454, 177);
            dateTimePickerJatuhTempo.Name = "dateTimePickerJatuhTempo";
            dateTimePickerJatuhTempo.Size = new Size(191, 23);
            dateTimePickerJatuhTempo.TabIndex = 37;
            // 
            // Formpengembalian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 504);
            Controls.Add(dateTimePickerJatuhTempo);
            Controls.Add(dataGridView1);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxTotalDenda);
            Controls.Add(textBoxLamaPinjam);
            Controls.Add(dateTimePickerTanggalKembali);
            Controls.Add(dateTimePickerTanggalPinjam);
            Controls.Add(textBoxDenda);
            Controls.Add(textBoxNim);
            Controls.Add(textBoxKodeBuku);
            Controls.Add(iconButtonSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formpengembalian";
            Text = "Formpengembalian";
            Load += Formpengembalian_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private TextBox textBoxKodeBuku;
        private TextBox textBoxNim;
        private TextBox textBoxDenda;
        private DateTimePicker dateTimePickerTanggalPinjam;
        private DateTimePicker dateTimePickerTanggalKembali;
        private TextBox textBoxLamaPinjam;
        private TextBox textBoxTotalDenda;
        private Label label13;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KodePinjam;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn NIM;
        private DataGridViewTextBoxColumn JatuhTempo;
        private DataGridViewTextBoxColumn TanggalPinjam;
        private DataGridViewTextBoxColumn LamaPinjam;
        private DataGridViewTextBoxColumn TanggalKembali;
        private DataGridViewTextBoxColumn TotalDenda;
        private DateTimePicker dateTimePickerJatuhTempo;
    }
}