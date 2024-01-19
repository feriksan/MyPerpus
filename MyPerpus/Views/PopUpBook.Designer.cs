namespace MyPerpus.Views
{
    partial class PopUpBook
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
            KodeBuku = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Penulis = new DataGridViewTextBoxColumn();
            Penerbit = new DataGridViewTextBoxColumn();
            Tahun = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodeBuku, Judul, Penulis, Penerbit, Tahun });
            dataGridView1.Location = new Point(169, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 190);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KodeBuku
            // 
            KodeBuku.HeaderText = "KodeBuku";
            KodeBuku.Name = "KodeBuku";
            KodeBuku.ReadOnly = true;
            KodeBuku.Visible = false;
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
            // Tahun
            // 
            Tahun.HeaderText = "Tahun Rilis";
            Tahun.Name = "Tahun";
            // 
            // PopUpBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "PopUpBook";
            Text = "Form1";
            Load += PopUpBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Penulis;
        private DataGridViewTextBoxColumn Penerbit;
        private DataGridViewTextBoxColumn Tahun;
    }
}