namespace MyPerpus.Views
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            panelLeftSide = new Panel();
            btnSetting = new FontAwesome.Sharp.IconButton();
            panelMaster = new Panel();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnBuku = new FontAwesome.Sharp.IconButton();
            btnPeminjam = new FontAwesome.Sharp.IconButton();
            btnPengembalian = new FontAwesome.Sharp.IconButton();
            btnMaster = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            labelAppName = new Label();
            panelTopSide = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            labelActiveModule = new Label();
            iconActiveModule = new FontAwesome.Sharp.IconButton();
            panelMain = new Panel();
            statusStripMain = new StatusStrip();
            toolStripProgressBarMain = new ToolStripProgressBar();
            toolStripUserActive = new ToolStripStatusLabel();
            panelLeftSide.SuspendLayout();
            panelMaster.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTopSide.SuspendLayout();
            panelMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeftSide
            // 
            panelLeftSide.AutoScroll = true;
            panelLeftSide.BackColor = Color.MidnightBlue;
            panelLeftSide.Controls.Add(btnSetting);
            panelLeftSide.Controls.Add(panelMaster);
            panelLeftSide.Controls.Add(btnMaster);
            panelLeftSide.Controls.Add(btnHome);
            panelLeftSide.Controls.Add(panelLogo);
            panelLeftSide.Dock = DockStyle.Left;
            panelLeftSide.Location = new Point(0, 0);
            panelLeftSide.Name = "panelLeftSide";
            panelLeftSide.Size = new Size(200, 561);
            panelLeftSide.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.DarkViolet;
            btnSetting.Dock = DockStyle.Bottom;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = SystemColors.ControlLightLight;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnSetting.IconColor = SystemColors.ControlLightLight;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.IconSize = 36;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 521);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(200, 40);
            btnSetting.TabIndex = 8;
            btnSetting.Text = "Settings";
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // panelMaster
            // 
            panelMaster.BackColor = Color.DarkOrchid;
            panelMaster.Controls.Add(btnUser);
            panelMaster.Controls.Add(btnBuku);
            panelMaster.Controls.Add(btnPeminjam);
            panelMaster.Controls.Add(btnPengembalian);
            panelMaster.Dock = DockStyle.Top;
            panelMaster.Location = new Point(0, 150);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(200, 150);
            panelMaster.TabIndex = 7;
            panelMaster.Visible = false;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.ForeColor = SystemColors.ControlLightLight;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            btnUser.IconColor = SystemColors.ControlLightLight;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 32;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 108);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(16, 0, 0, 0);
            btnUser.Size = new Size(200, 36);
            btnUser.TabIndex = 8;
            btnUser.Text = "Users";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnBuku
            // 
            btnBuku.Dock = DockStyle.Top;
            btnBuku.FlatAppearance.BorderSize = 0;
            btnBuku.FlatStyle = FlatStyle.Flat;
            btnBuku.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuku.ForeColor = SystemColors.ControlLightLight;
            btnBuku.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnBuku.IconColor = SystemColors.ControlLightLight;
            btnBuku.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuku.IconSize = 32;
            btnBuku.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuku.Location = new Point(0, 72);
            btnBuku.Name = "btnBuku";
            btnBuku.Padding = new Padding(16, 0, 0, 0);
            btnBuku.Size = new Size(200, 36);
            btnBuku.TabIndex = 7;
            btnBuku.Text = "Buku";
            btnBuku.TextAlign = ContentAlignment.MiddleLeft;
            btnBuku.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuku.UseVisualStyleBackColor = true;
            btnBuku.Click += btnBuku_Click;
            // 
            // btnPeminjam
            // 
            btnPeminjam.Dock = DockStyle.Top;
            btnPeminjam.FlatAppearance.BorderSize = 0;
            btnPeminjam.FlatStyle = FlatStyle.Flat;
            btnPeminjam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeminjam.ForeColor = SystemColors.ControlLightLight;
            btnPeminjam.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnPeminjam.IconColor = SystemColors.ControlLightLight;
            btnPeminjam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPeminjam.IconSize = 32;
            btnPeminjam.ImageAlign = ContentAlignment.MiddleLeft;
            btnPeminjam.Location = new Point(0, 36);
            btnPeminjam.Name = "btnPeminjam";
            btnPeminjam.Padding = new Padding(16, 0, 0, 0);
            btnPeminjam.Size = new Size(200, 36);
            btnPeminjam.TabIndex = 6;
            btnPeminjam.Text = "Peminjam";
            btnPeminjam.TextAlign = ContentAlignment.MiddleLeft;
            btnPeminjam.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPeminjam.UseVisualStyleBackColor = true;
            btnPeminjam.Click += btnPeminjam_Click;
            // 
            // btnPengembalian
            // 
            btnPengembalian.Dock = DockStyle.Top;
            btnPengembalian.FlatAppearance.BorderSize = 0;
            btnPengembalian.FlatStyle = FlatStyle.Flat;
            btnPengembalian.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengembalian.ForeColor = SystemColors.ControlLightLight;
            btnPengembalian.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnPengembalian.IconColor = SystemColors.ControlLightLight;
            btnPengembalian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPengembalian.IconSize = 32;
            btnPengembalian.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengembalian.Location = new Point(0, 0);
            btnPengembalian.Name = "btnPengembalian";
            btnPengembalian.Padding = new Padding(16, 0, 0, 0);
            btnPengembalian.Size = new Size(200, 36);
            btnPengembalian.TabIndex = 5;
            btnPengembalian.Text = "Pengembalian";
            btnPengembalian.TextAlign = ContentAlignment.MiddleLeft;
            btnPengembalian.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPengembalian.UseVisualStyleBackColor = true;
            btnPengembalian.Click += btnPengembalian_Click;
            // 
            // btnMaster
            // 
            btnMaster.Dock = DockStyle.Top;
            btnMaster.FlatAppearance.BorderSize = 0;
            btnMaster.FlatStyle = FlatStyle.Flat;
            btnMaster.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaster.ForeColor = SystemColors.ControlLightLight;
            btnMaster.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnMaster.IconColor = SystemColors.ControlLightLight;
            btnMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaster.IconSize = 36;
            btnMaster.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaster.Location = new Point(0, 110);
            btnMaster.Name = "btnMaster";
            btnMaster.Size = new Size(200, 40);
            btnMaster.TabIndex = 6;
            btnMaster.Text = "Master Data";
            btnMaster.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaster.UseVisualStyleBackColor = true;
            btnMaster.Click += btnMaster_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseLock;
            btnHome.IconColor = SystemColors.ControlLightLight;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 36;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 70);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 40);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(labelAppName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 70);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAppName.ForeColor = SystemColors.ControlLightLight;
            labelAppName.Location = new Point(75, 21);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(115, 29);
            labelAppName.TabIndex = 1;
            labelAppName.Text = "MyPerpus";
            labelAppName.Click += labelAppName_Click;
            // 
            // panelTopSide
            // 
            panelTopSide.BackColor = Color.MidnightBlue;
            panelTopSide.Controls.Add(btnLogout);
            panelTopSide.Controls.Add(labelActiveModule);
            panelTopSide.Controls.Add(iconActiveModule);
            panelTopSide.Dock = DockStyle.Top;
            panelTopSide.Location = new Point(200, 0);
            panelTopSide.Name = "panelTopSide";
            panelTopSide.Size = new Size(584, 50);
            panelTopSide.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnLogout.IconColor = SystemColors.ControlLightLight;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 36;
            btnLogout.Location = new Point(534, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(50, 50);
            btnLogout.TabIndex = 6;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // labelActiveModule
            // 
            labelActiveModule.AutoSize = true;
            labelActiveModule.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelActiveModule.ForeColor = Color.WhiteSmoke;
            labelActiveModule.Location = new Point(56, 12);
            labelActiveModule.Name = "labelActiveModule";
            labelActiveModule.Size = new Size(72, 30);
            labelActiveModule.TabIndex = 5;
            labelActiveModule.Text = "Home";
            // 
            // iconActiveModule
            // 
            iconActiveModule.Dock = DockStyle.Left;
            iconActiveModule.FlatAppearance.BorderSize = 0;
            iconActiveModule.FlatStyle = FlatStyle.Flat;
            iconActiveModule.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconActiveModule.ForeColor = SystemColors.ControlLightLight;
            iconActiveModule.IconChar = FontAwesome.Sharp.IconChar.HouseLock;
            iconActiveModule.IconColor = SystemColors.ControlLightLight;
            iconActiveModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconActiveModule.IconSize = 36;
            iconActiveModule.Location = new Point(0, 0);
            iconActiveModule.Name = "iconActiveModule";
            iconActiveModule.Size = new Size(50, 50);
            iconActiveModule.TabIndex = 4;
            iconActiveModule.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.LightCyan;
            panelMain.Controls.Add(statusStripMain);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 50);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(584, 511);
            panelMain.TabIndex = 2;
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripProgressBarMain, toolStripUserActive });
            statusStripMain.Location = new Point(0, 489);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(584, 22);
            statusStripMain.TabIndex = 0;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripProgressBarMain
            // 
            toolStripProgressBarMain.Name = "toolStripProgressBarMain";
            toolStripProgressBarMain.Size = new Size(100, 16);
            // 
            // toolStripUserActive
            // 
            toolStripUserActive.BackColor = SystemColors.Control;
            toolStripUserActive.Name = "toolStripUserActive";
            toolStripUserActive.Size = new Size(112, 17);
            toolStripUserActive.Text = "User Active: Clarissa";
            toolStripUserActive.Click += toolStripUserActive_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panelMain);
            Controls.Add(panelTopSide);
            Controls.Add(panelLeftSide);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyPerpus";
            WindowState = FormWindowState.Maximized;
            Load += FormHome_Load;
            panelLeftSide.ResumeLayout(false);
            panelMaster.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTopSide.ResumeLayout(false);
            panelTopSide.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeftSide;
        private Panel panelTopSide;
        private Panel panelMain;
        private Label labelAppName;
        private PictureBox pictureBox1;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMaster;
        private Panel panelMaster;
        private FontAwesome.Sharp.IconButton btnPeminjam;
        private FontAwesome.Sharp.IconButton btnPengembalian;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnBuku;
        private FontAwesome.Sharp.IconButton iconActiveModule;
        private Label labelActiveModule;
        private StatusStrip statusStripMain;
        private ToolStripProgressBar toolStripProgressBarMain;
        private ToolStripStatusLabel toolStripUserActive;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}