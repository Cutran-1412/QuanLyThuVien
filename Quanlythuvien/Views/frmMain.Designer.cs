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
            iconButton7 = new FontAwesome.Sharp.IconButton();
            ibtntra = new FontAwesome.Sharp.IconButton();
            ibtnmuon = new FontAwesome.Sharp.IconButton();
            ibtnmuontra = new FontAwesome.Sharp.IconButton();
            ibtnsach = new FontAwesome.Sharp.IconButton();
            ibtndocgia = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
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
            lblchao.BackColor = Color.FromArgb(174, 214, 241);
            lblchao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblchao.ForeColor = Color.FromArgb(21, 67, 96);
            lblchao.Location = new Point(120, 16);
            lblchao.Name = "lblchao";
            lblchao.Size = new Size(908, 46);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 87);
            panel1.TabIndex = 5;
            // 
            // ibtnMenu
            // 
            ibtnMenu.BackColor = Color.FromArgb(133, 193, 233);
            ibtnMenu.Dock = DockStyle.Left;
            ibtnMenu.FlatAppearance.BorderSize = 0;
            ibtnMenu.FlatStyle = FlatStyle.Flat;
            ibtnMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnMenu.ForeColor = Color.White;
            ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            ibtnMenu.IconColor = Color.White;
            ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnMenu.Location = new Point(0, 0);
            ibtnMenu.Margin = new Padding(3, 4, 3, 4);
            ibtnMenu.Name = "ibtnMenu";
            ibtnMenu.Size = new Size(274, 87);
            ibtnMenu.TabIndex = 0;
            ibtnMenu.Text = "Menu";
            ibtnMenu.UseVisualStyleBackColor = false;
            ibtnMenu.Click += ibtnMenu_Click;
            // 
            // pamain
            // 
            pamain.Location = new Point(281, 93);
            pamain.Margin = new Padding(3, 4, 3, 4);
            pamain.Name = "pamain";
            pamain.Size = new Size(1257, 720);
            pamain.TabIndex = 6;
            // 
            // fmenu
            // 
            fmenu.BackColor = Color.FromArgb(236, 240, 241);
            fmenu.Controls.Add(iconButton7);
            fmenu.Controls.Add(ibtntra);
            fmenu.Controls.Add(ibtnmuon);
            fmenu.Controls.Add(ibtnmuontra);
            fmenu.Controls.Add(ibtnsach);
            fmenu.Controls.Add(ibtndocgia);
            fmenu.Controls.Add(iconButton8);
            fmenu.Controls.Add(tbtnadmin);
            fmenu.ForeColor = Color.White;
            fmenu.Location = new Point(0, 93);
            fmenu.Margin = new Padding(3, 4, 3, 4);
            fmenu.MaximumSize = new Size(274, 787);
            fmenu.MinimumSize = new Size(77, 787);
            fmenu.Name = "fmenu";
            fmenu.Size = new Size(274, 787);
            fmenu.TabIndex = 12;
            fmenu.Paint += fmenu_Paint;
            // 
            // iconButton7
            // 
            iconButton7.AutoSize = true;
            iconButton7.BackColor = Color.FromArgb(41, 128, 185);
            iconButton7.Dock = DockStyle.Top;
            iconButton7.FlatAppearance.BorderColor = Color.White;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(0, 432);
            iconButton7.Margin = new Padding(3, 4, 3, 4);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(274, 72);
            iconButton7.TabIndex = 14;
            iconButton7.Text = "Thống kê";
            iconButton7.UseCompatibleTextRendering = true;
            iconButton7.UseVisualStyleBackColor = false;
            iconButton7.Click += iconButton7_Click;
            // 
            // ibtntra
            // 
            ibtntra.AutoSize = true;
            ibtntra.BackColor = Color.FromArgb(41, 128, 185);
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
            ibtntra.Location = new Point(0, 360);
            ibtntra.Margin = new Padding(3, 4, 3, 4);
            ibtntra.Name = "ibtntra";
            ibtntra.Size = new Size(274, 72);
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
            ibtnmuon.BackColor = Color.FromArgb(41, 128, 185);
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
            ibtnmuon.Location = new Point(0, 288);
            ibtnmuon.Margin = new Padding(3, 4, 3, 4);
            ibtnmuon.Name = "ibtnmuon";
            ibtnmuon.Size = new Size(274, 72);
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
            ibtnmuontra.BackColor = Color.FromArgb(41, 128, 185);
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
            ibtnmuontra.Location = new Point(0, 216);
            ibtnmuontra.Margin = new Padding(3, 4, 3, 4);
            ibtnmuontra.Name = "ibtnmuontra";
            ibtnmuontra.Size = new Size(274, 72);
            ibtnmuontra.TabIndex = 11;
            ibtnmuontra.Text = "Mượn trả";
            ibtnmuontra.UseCompatibleTextRendering = true;
            ibtnmuontra.UseVisualStyleBackColor = false;
            ibtnmuontra.Click += ibtnmuontra_Click;
            // 
            // ibtnsach
            // 
            ibtnsach.AutoSize = true;
            ibtnsach.BackColor = Color.FromArgb(41, 128, 185);
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
            ibtnsach.Location = new Point(0, 144);
            ibtnsach.Margin = new Padding(3, 4, 3, 4);
            ibtnsach.Name = "ibtnsach";
            ibtnsach.Size = new Size(274, 72);
            ibtnsach.TabIndex = 10;
            ibtnsach.Text = "Sách";
            ibtnsach.UseCompatibleTextRendering = true;
            ibtnsach.UseVisualStyleBackColor = false;
            ibtnsach.Click += ibtnsach_Click;
            // 
            // ibtndocgia
            // 
            ibtndocgia.AutoSize = true;
            ibtndocgia.BackColor = Color.FromArgb(41, 128, 185);
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
            ibtndocgia.Location = new Point(0, 72);
            ibtndocgia.Margin = new Padding(3, 4, 3, 4);
            ibtndocgia.Name = "ibtndocgia";
            ibtndocgia.Size = new Size(274, 72);
            ibtndocgia.TabIndex = 9;
            ibtndocgia.Text = "Độc giả";
            ibtndocgia.UseCompatibleTextRendering = true;
            ibtndocgia.UseVisualStyleBackColor = false;
            ibtndocgia.Click += ibtndocgia_Click;
            // 
            // iconButton8
            // 
            iconButton8.AutoSize = true;
            iconButton8.BackColor = Color.FromArgb(41, 128, 185);
            iconButton8.Dock = DockStyle.Bottom;
            iconButton8.FlatAppearance.BorderColor = Color.White;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 37, 47);
            iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 37, 47);
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(0, 715);
            iconButton8.Margin = new Padding(3, 4, 3, 4);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(274, 72);
            iconButton8.TabIndex = 8;
            iconButton8.Text = "Thoát";
            iconButton8.UseCompatibleTextRendering = true;
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // tbtnadmin
            // 
            tbtnadmin.AutoSize = true;
            tbtnadmin.BackColor = Color.FromArgb(41, 128, 185);
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
            tbtnadmin.Margin = new Padding(3, 4, 3, 4);
            tbtnadmin.Name = "tbtnadmin";
            tbtnadmin.Size = new Size(274, 72);
            tbtnadmin.TabIndex = 2;
            tbtnadmin.Text = "Admin";
            tbtnadmin.UseCompatibleTextRendering = true;
            tbtnadmin.UseVisualStyleBackColor = false;
            tbtnadmin.Click += tbtnadmin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(174, 214, 241);
            panel2.Controls.Add(lblchao);
            panel2.Location = new Point(281, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1257, 87);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(214, 234, 248);
            panel3.Controls.Add(pcodeby);
            panel3.Controls.Add(lblthoigian);
            panel3.Location = new Point(281, 821);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1257, 61);
            panel3.TabIndex = 14;
            // 
            // pcodeby
            // 
            pcodeby.Controls.Add(lblcodeby);
            pcodeby.Location = new Point(3, 5);
            pcodeby.Margin = new Padding(3, 4, 3, 4);
            pcodeby.Name = "pcodeby";
            pcodeby.Size = new Size(971, 52);
            pcodeby.TabIndex = 2;
            // 
            // lblcodeby
            // 
            lblcodeby.AutoSize = true;
            lblcodeby.Location = new Point(941, 19);
            lblcodeby.Name = "lblcodeby";
            lblcodeby.Size = new Size(0, 20);
            lblcodeby.TabIndex = 0;
            // 
            // lblthoigian
            // 
            lblthoigian.AutoSize = true;
            lblthoigian.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblthoigian.ForeColor = Color.Black;
            lblthoigian.Location = new Point(982, 5);
            lblthoigian.Name = "lblthoigian";
            lblthoigian.Size = new Size(83, 41);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(242, 243, 244);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1549, 893);
            Controls.Add(fmenu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pamain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1549, 893);
            MinimumSize = new Size(1549, 893);
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
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton tbtnadmin;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton ibtntra;
        private FontAwesome.Sharp.IconButton ibtnmuon;
        private FontAwesome.Sharp.IconButton ibtnmuontra;
        private FontAwesome.Sharp.IconButton ibtnsach;
        private FontAwesome.Sharp.IconButton ibtndocgia;
    }
}