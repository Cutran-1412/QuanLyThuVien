namespace Quanlythuvien.Views
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            lblchao = new Label();
            timethoigian = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            ibtnMenu = new FontAwesome.Sharp.IconButton();
            pamain = new Panel();
            fmenu = new Panel();
            ibtnthongke = new FontAwesome.Sharp.IconButton();
            ibtntra = new FontAwesome.Sharp.IconButton();
            ibtnmuon = new FontAwesome.Sharp.IconButton();
            ibtnmuontra = new FontAwesome.Sharp.IconButton();
            ibtnsach = new FontAwesome.Sharp.IconButton();
            ibtndocgia = new FontAwesome.Sharp.IconButton();
            ibtnthoat = new FontAwesome.Sharp.IconButton();
            tbtnadmin = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            pcodeby = new Panel();
            lblcodeby = new Label();
            lblthoigian = new Label();
            timerChayChu = new System.Windows.Forms.Timer(components);
            timerdoimau = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            fmenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pcodeby.SuspendLayout();
            SuspendLayout();
            // 
            // lblchao
            // 
            lblchao.AutoSize = true;
            lblchao.BackColor = Color.DarkGray;
            lblchao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblchao.ForeColor = Color.White;
            lblchao.Location = new Point(136, 12);
            lblchao.Name = "lblchao";
            lblchao.Size = new Size(717, 37);
            lblchao.TabIndex = 0;
            lblchao.Text = "CHÀO MỪNG ĐẾN VỚI ỨNG DỤNG QUẢN LÝ THƯ VIỆN";
            // 
            // timethoigian
            // 
            timethoigian.Tick += timethoigian_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(ibtnMenu);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 65);
            panel1.TabIndex = 5;
            // 
            // ibtnMenu
            // 
            ibtnMenu.BackColor = Color.DeepSkyBlue;
            ibtnMenu.Dock = DockStyle.Left;
            ibtnMenu.FlatAppearance.BorderSize = 0;
            ibtnMenu.FlatStyle = FlatStyle.Flat;
            ibtnMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnMenu.ForeColor = Color.White;
            ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            ibtnMenu.IconColor = Color.White;
            ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnMenu.Location = new Point(0, 0);
            ibtnMenu.Name = "ibtnMenu";
            ibtnMenu.Size = new Size(240, 65);
            ibtnMenu.TabIndex = 0;
            ibtnMenu.Text = "QLTV";
            ibtnMenu.UseVisualStyleBackColor = false;
            ibtnMenu.Click += ibtnMenu_Click;
            // 
            // pamain
            // 
            pamain.Location = new Point(239, 65);
            pamain.Name = "pamain";
            pamain.Size = new Size(1100, 540);
            pamain.TabIndex = 6;
            // 
            // fmenu
            // 
            fmenu.BackColor = Color.FromArgb(236, 240, 241);
            fmenu.Controls.Add(ibtnthongke);
            fmenu.Controls.Add(ibtntra);
            fmenu.Controls.Add(ibtnmuon);
            fmenu.Controls.Add(ibtnmuontra);
            fmenu.Controls.Add(ibtnsach);
            fmenu.Controls.Add(ibtndocgia);
            fmenu.Controls.Add(ibtnthoat);
            fmenu.Controls.Add(tbtnadmin);
            fmenu.ForeColor = Color.White;
            fmenu.Location = new Point(0, 65);
            fmenu.MaximumSize = new Size(240, 590);
            fmenu.MinimumSize = new Size(67, 590);
            fmenu.Name = "fmenu";
            fmenu.Size = new Size(240, 590);
            fmenu.TabIndex = 12;
            // 
            // ibtnthongke
            // 
            ibtnthongke.AutoSize = true;
            ibtnthongke.BackColor = Color.DodgerBlue;
            ibtnthongke.Dock = DockStyle.Top;
            ibtnthongke.FlatAppearance.BorderColor = Color.White;
            ibtnthongke.FlatAppearance.BorderSize = 0;
            ibtnthongke.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtnthongke.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtnthongke.FlatStyle = FlatStyle.Flat;
            ibtnthongke.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnthongke.ForeColor = Color.White;
            ibtnthongke.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            ibtnthongke.IconColor = Color.White;
            ibtnthongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnthongke.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnthongke.Location = new Point(0, 324);
            ibtnthongke.Name = "ibtnthongke";
            ibtnthongke.Size = new Size(240, 54);
            ibtnthongke.TabIndex = 14;
            ibtnthongke.Text = "Thống kê";
            ibtnthongke.UseCompatibleTextRendering = true;
            ibtnthongke.UseVisualStyleBackColor = false;
            ibtnthongke.Click += ibtnthongke_Click;
            // 
            // ibtntra
            // 
            ibtntra.AutoSize = true;
            ibtntra.BackColor = Color.DodgerBlue;
            ibtntra.Dock = DockStyle.Top;
            ibtntra.FlatAppearance.BorderColor = Color.White;
            ibtntra.FlatAppearance.BorderSize = 0;
            ibtntra.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtntra.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtntra.FlatStyle = FlatStyle.Flat;
            ibtntra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtntra.ForeColor = Color.White;
            ibtntra.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            ibtntra.IconColor = Color.White;
            ibtntra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtntra.Location = new Point(0, 270);
            ibtntra.Name = "ibtntra";
            ibtntra.Size = new Size(240, 54);
            ibtntra.TabIndex = 13;
            ibtntra.Text = "Trả";
            ibtntra.TextAlign = ContentAlignment.MiddleRight;
            ibtntra.UseCompatibleTextRendering = true;
            ibtntra.UseVisualStyleBackColor = false;
            ibtntra.Click += ibtntra_Click;
            // 
            // ibtnmuon
            // 
            ibtnmuon.AutoSize = true;
            ibtnmuon.BackColor = Color.DodgerBlue;
            ibtnmuon.Dock = DockStyle.Top;
            ibtnmuon.FlatAppearance.BorderColor = Color.White;
            ibtnmuon.FlatAppearance.BorderSize = 0;
            ibtnmuon.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtnmuon.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtnmuon.FlatStyle = FlatStyle.Flat;
            ibtnmuon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnmuon.ForeColor = Color.White;
            ibtnmuon.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            ibtnmuon.IconColor = Color.White;
            ibtnmuon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnmuon.Location = new Point(0, 216);
            ibtnmuon.Name = "ibtnmuon";
            ibtnmuon.Size = new Size(240, 54);
            ibtnmuon.TabIndex = 12;
            ibtnmuon.Text = "Mượn";
            ibtnmuon.TextAlign = ContentAlignment.MiddleRight;
            ibtnmuon.UseCompatibleTextRendering = true;
            ibtnmuon.UseVisualStyleBackColor = false;
            ibtnmuon.Click += ibtnmuon_Click;
            // 
            // ibtnmuontra
            // 
            ibtnmuontra.AutoSize = true;
            ibtnmuontra.BackColor = Color.DodgerBlue;
            ibtnmuontra.Dock = DockStyle.Top;
            ibtnmuontra.FlatAppearance.BorderColor = Color.White;
            ibtnmuontra.FlatAppearance.BorderSize = 0;
            ibtnmuontra.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtnmuontra.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtnmuontra.FlatStyle = FlatStyle.Flat;
            ibtnmuontra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnmuontra.ForeColor = Color.White;
            ibtnmuontra.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            ibtnmuontra.IconColor = Color.White;
            ibtnmuontra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnmuontra.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnmuontra.Location = new Point(0, 162);
            ibtnmuontra.Name = "ibtnmuontra";
            ibtnmuontra.Size = new Size(240, 54);
            ibtnmuontra.TabIndex = 11;
            ibtnmuontra.Text = "Mượn trả";
            ibtnmuontra.UseCompatibleTextRendering = true;
            ibtnmuontra.UseVisualStyleBackColor = false;
            ibtnmuontra.Click += ibtnmuontra_Click;
            // 
            // ibtnsach
            // 
            ibtnsach.AutoSize = true;
            ibtnsach.BackColor = Color.DodgerBlue;
            ibtnsach.Dock = DockStyle.Top;
            ibtnsach.FlatAppearance.BorderColor = Color.White;
            ibtnsach.FlatAppearance.BorderSize = 0;
            ibtnsach.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtnsach.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtnsach.FlatStyle = FlatStyle.Flat;
            ibtnsach.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnsach.ForeColor = Color.White;
            ibtnsach.IconChar = FontAwesome.Sharp.IconChar.Book;
            ibtnsach.IconColor = Color.White;
            ibtnsach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnsach.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnsach.Location = new Point(0, 108);
            ibtnsach.Name = "ibtnsach";
            ibtnsach.Size = new Size(240, 54);
            ibtnsach.TabIndex = 10;
            ibtnsach.Text = "Sách";
            ibtnsach.UseCompatibleTextRendering = true;
            ibtnsach.UseVisualStyleBackColor = false;
            ibtnsach.Click += ibtnsach_Click;
            // 
            // ibtndocgia
            // 
            ibtndocgia.AutoSize = true;
            ibtndocgia.BackColor = Color.DodgerBlue;
            ibtndocgia.Dock = DockStyle.Top;
            ibtndocgia.FlatAppearance.BorderColor = Color.White;
            ibtndocgia.FlatAppearance.BorderSize = 0;
            ibtndocgia.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtndocgia.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtndocgia.FlatStyle = FlatStyle.Flat;
            ibtndocgia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtndocgia.ForeColor = Color.White;
            ibtndocgia.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            ibtndocgia.IconColor = Color.White;
            ibtndocgia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtndocgia.ImageAlign = ContentAlignment.MiddleLeft;
            ibtndocgia.Location = new Point(0, 54);
            ibtndocgia.Name = "ibtndocgia";
            ibtndocgia.Size = new Size(240, 54);
            ibtndocgia.TabIndex = 9;
            ibtndocgia.Text = "Độc giả";
            ibtndocgia.UseCompatibleTextRendering = true;
            ibtndocgia.UseVisualStyleBackColor = false;
            ibtndocgia.Click += ibtndocgia_Click;
            // 
            // ibtnthoat
            // 
            ibtnthoat.AutoSize = true;
            ibtnthoat.BackColor = Color.DodgerBlue;
            ibtnthoat.Dock = DockStyle.Bottom;
            ibtnthoat.FlatAppearance.BorderColor = Color.White;
            ibtnthoat.FlatAppearance.BorderSize = 0;
            ibtnthoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            ibtnthoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            ibtnthoat.FlatStyle = FlatStyle.Flat;
            ibtnthoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnthoat.ForeColor = Color.White;
            ibtnthoat.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            ibtnthoat.IconColor = Color.White;
            ibtnthoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnthoat.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnthoat.Location = new Point(0, 536);
            ibtnthoat.Name = "ibtnthoat";
            ibtnthoat.Size = new Size(240, 54);
            ibtnthoat.TabIndex = 8;
            ibtnthoat.Text = "Thoát";
            ibtnthoat.UseCompatibleTextRendering = true;
            ibtnthoat.UseVisualStyleBackColor = false;
            ibtnthoat.Click += ibtnthoat_Click;
            // 
            // tbtnadmin
            // 
            tbtnadmin.AutoSize = true;
            tbtnadmin.BackColor = Color.DodgerBlue;
            tbtnadmin.Dock = DockStyle.Top;
            tbtnadmin.FlatAppearance.BorderColor = Color.White;
            tbtnadmin.FlatAppearance.BorderSize = 0;
            tbtnadmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            tbtnadmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            tbtnadmin.FlatStyle = FlatStyle.Flat;
            tbtnadmin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbtnadmin.ForeColor = Color.White;
            tbtnadmin.IconChar = FontAwesome.Sharp.IconChar.User;
            tbtnadmin.IconColor = Color.White;
            tbtnadmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tbtnadmin.ImageAlign = ContentAlignment.MiddleLeft;
            tbtnadmin.Location = new Point(0, 0);
            tbtnadmin.Name = "tbtnadmin";
            tbtnadmin.Size = new Size(240, 54);
            tbtnadmin.TabIndex = 2;
            tbtnadmin.Text = "Admin";
            tbtnadmin.UseCompatibleTextRendering = true;
            tbtnadmin.UseVisualStyleBackColor = false;
            tbtnadmin.Click += tbtnadmin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(lblchao);
            panel2.Location = new Point(239, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 65);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(pcodeby);
            panel3.Controls.Add(lblthoigian);
            panel3.Location = new Point(239, 601);
            panel3.Name = "panel3";
            panel3.Size = new Size(1100, 54);
            panel3.TabIndex = 14;
            // 
            // pcodeby
            // 
            pcodeby.Controls.Add(lblcodeby);
            pcodeby.Location = new Point(3, 15);
            pcodeby.Name = "pcodeby";
            pcodeby.Size = new Size(850, 39);
            pcodeby.TabIndex = 2;
            // 
            // lblcodeby
            // 
            lblcodeby.AutoSize = true;
            lblcodeby.Location = new Point(823, 14);
            lblcodeby.Name = "lblcodeby";
            lblcodeby.Size = new Size(0, 15);
            lblcodeby.TabIndex = 0;
            // 
            // lblthoigian
            // 
            lblthoigian.AutoSize = true;
            lblthoigian.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblthoigian.ForeColor = Color.Black;
            lblthoigian.Location = new Point(859, 15);
            lblthoigian.Name = "lblthoigian";
            lblthoigian.Size = new Size(67, 32);
            lblthoigian.TabIndex = 1;
            lblthoigian.Text = "Time";
            // 
            // timerChayChu
            // 
            timerChayChu.Tick += timerChayChu_Tick;
            // 
            // timerdoimau
            // 
            timerdoimau.Tick += timerdoimau_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(242, 243, 244);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1340, 656);
            Controls.Add(pamain);
            Controls.Add(fmenu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1340, 656);
            MinimumSize = new Size(1340, 656);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            fmenu.ResumeLayout(false);
            fmenu.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pcodeby.ResumeLayout(false);
            pcodeby.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblchao;
        private System.Windows.Forms.Timer timethoigian;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private Panel pamain;
        private Button gbtnSach;
        private Panel fmenu;
        private Panel panel2;
        private Panel panel3;
        private Label lblthoigian;
        private Panel pcodeby;
        private Label lblcodeby;
        private System.Windows.Forms.Timer timerChayChu;
        private System.Windows.Forms.Timer timerdoimau;
        private FontAwesome.Sharp.IconButton ibtnthoat;
        private FontAwesome.Sharp.IconButton tbtnadmin;
        private FontAwesome.Sharp.IconButton ibtnthongke;
        private FontAwesome.Sharp.IconButton ibtntra;
        private FontAwesome.Sharp.IconButton ibtnmuon;
        private FontAwesome.Sharp.IconButton ibtnmuontra;
        private FontAwesome.Sharp.IconButton ibtnsach;
        private FontAwesome.Sharp.IconButton ibtndocgia;
    }
}