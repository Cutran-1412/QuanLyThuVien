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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblchao = new Label();
            timethoigian = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            ibtnMenu = new FontAwesome.Sharp.IconButton();
            timechuyen = new System.Windows.Forms.Timer(components);
            pamain = new Panel();
            button1 = new Button();
            button2 = new Button();
            gbtnSach = new Button();
            btnMuon = new Button();
            btnTra = new Button();
            fmenu = new Panel();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            gbtnadmin = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            gbtndocgia = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pcodeby = new Panel();
            lblcodeby = new Label();
            lblthoigian = new Label();
            panel4 = new Panel();
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
            lblchao.BackColor = Color.FromArgb(41, 128, 185);
            lblchao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblchao.ForeColor = Color.Black;
            lblchao.Location = new Point(105, 12);
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
            ibtnMenu.BackColor = Color.FromArgb(63, 142, 252);
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
            ibtnMenu.Name = "ibtnMenu";
            ibtnMenu.Size = new Size(240, 65);
            ibtnMenu.TabIndex = 0;
            ibtnMenu.Text = "Menu";
            ibtnMenu.UseVisualStyleBackColor = false;
            ibtnMenu.Click += ibtnMenu_Click;
            // 
            // timechuyen
            // 
            timechuyen.Tick += timechuyen_Tick;
            // 
            // pamain
            // 
            pamain.Location = new Point(73, 70);
            pamain.Name = "pamain";
            pamain.Size = new Size(1100, 540);
            pamain.TabIndex = 6;
            pamain.Paint += pamain_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(103, 403);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 7;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(76, 351);
            button2.Name = "button2";
            button2.Size = new Size(52, 23);
            button2.TabIndex = 8;
            button2.Text = "Docgia";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // gbtnSach
            // 
            gbtnSach.Location = new Point(123, 450);
            gbtnSach.Name = "gbtnSach";
            gbtnSach.Size = new Size(52, 23);
            gbtnSach.TabIndex = 9;
            gbtnSach.Text = "Sách";
            gbtnSach.UseVisualStyleBackColor = true;
            gbtnSach.Click += gbtnSach_Click;
            // 
            // btnMuon
            // 
            btnMuon.Location = new Point(172, 351);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(52, 28);
            btnMuon.TabIndex = 10;
            btnMuon.Text = "Mượn";
            btnMuon.UseVisualStyleBackColor = true;
            btnMuon.Click += btnMuon_Click;
            // 
            // btnTra
            // 
            btnTra.Location = new Point(15, 403);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(52, 28);
            btnTra.TabIndex = 11;
            btnTra.Text = "Trả";
            btnTra.UseVisualStyleBackColor = true;
            // 
            // fmenu
            // 
            fmenu.BackColor = Color.FromArgb(44, 62, 80);
            fmenu.Controls.Add(guna2Button4);
            fmenu.Controls.Add(gbtnadmin);
            fmenu.Controls.Add(btnTra);
            fmenu.Controls.Add(guna2Button2);
            fmenu.Controls.Add(btnMuon);
            fmenu.Controls.Add(guna2Button1);
            fmenu.Controls.Add(gbtnSach);
            fmenu.Controls.Add(gbtndocgia);
            fmenu.Controls.Add(button1);
            fmenu.Controls.Add(button2);
            fmenu.ForeColor = Color.White;
            fmenu.Location = new Point(0, 70);
            fmenu.MaximumSize = new Size(240, 540);
            fmenu.MinimumSize = new Size(67, 540);
            fmenu.Name = "fmenu";
            fmenu.Size = new Size(240, 540);
            fmenu.TabIndex = 12;
            // 
            // guna2Button4
            // 
            guna2Button4.Animated = true;
            guna2Button4.BorderRadius = 25;
            guna2Button4.BorderThickness = 1;
            guna2Button4.CustomizableEdges = customizableEdges1;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.FromArgb(52, 152, 219);
            guna2Button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(12, 282);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button4.Size = new Size(212, 45);
            guna2Button4.TabIndex = 6;
            guna2Button4.TabStop = false;
            guna2Button4.Text = "Thoát";
            // 
            // gbtnadmin
            // 
            gbtnadmin.Animated = true;
            gbtnadmin.BorderRadius = 25;
            gbtnadmin.BorderThickness = 1;
            gbtnadmin.CustomizableEdges = customizableEdges3;
            gbtnadmin.DisabledState.BorderColor = Color.DarkGray;
            gbtnadmin.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtnadmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtnadmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtnadmin.FillColor = Color.FromArgb(52, 152, 219);
            gbtnadmin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbtnadmin.ForeColor = Color.White;
            gbtnadmin.Location = new Point(12, 211);
            gbtnadmin.Name = "gbtnadmin";
            gbtnadmin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbtnadmin.Size = new Size(212, 45);
            gbtnadmin.TabIndex = 5;
            gbtnadmin.TabStop = false;
            gbtnadmin.Text = "Admin";
            gbtnadmin.Click += gbtnadmin_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BorderRadius = 25;
            guna2Button2.BorderThickness = 1;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(52, 152, 219);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(12, 139);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(212, 45);
            guna2Button2.TabIndex = 4;
            guna2Button2.TabStop = false;
            guna2Button2.Text = "Phiếu mượn trả";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BorderRadius = 25;
            guna2Button1.BorderThickness = 1;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(52, 152, 219);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 76);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(212, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.TabStop = false;
            guna2Button1.Text = "Sách";
            // 
            // gbtndocgia
            // 
            gbtndocgia.Animated = true;
            gbtndocgia.BorderRadius = 25;
            gbtndocgia.BorderThickness = 1;
            gbtndocgia.CustomizableEdges = customizableEdges9;
            gbtndocgia.DisabledState.BorderColor = Color.DarkGray;
            gbtndocgia.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtndocgia.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtndocgia.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtndocgia.FillColor = Color.FromArgb(52, 152, 219);
            gbtndocgia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbtndocgia.ForeColor = Color.White;
            gbtndocgia.Location = new Point(12, 12);
            gbtndocgia.Name = "gbtndocgia";
            gbtndocgia.ShadowDecoration.CustomizableEdges = customizableEdges10;
            gbtndocgia.Size = new Size(212, 45);
            gbtndocgia.TabIndex = 2;
            gbtndocgia.TabStop = false;
            gbtndocgia.Text = "Độc giả";
            gbtndocgia.Click += gbtndocgia_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(lblchao);
            panel2.Location = new Point(246, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 65);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 73, 94);
            panel3.Controls.Add(pcodeby);
            panel3.Controls.Add(lblthoigian);
            panel3.Location = new Point(0, 616);
            panel3.Name = "panel3";
            panel3.Size = new Size(1173, 46);
            panel3.TabIndex = 14;
            // 
            // pcodeby
            // 
            pcodeby.Controls.Add(lblcodeby);
            pcodeby.Location = new Point(15, 4);
            pcodeby.Name = "pcodeby";
            pcodeby.Size = new Size(914, 39);
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
            lblthoigian.ForeColor = Color.White;
            lblthoigian.Location = new Point(947, 4);
            lblthoigian.Name = "lblthoigian";
            lblthoigian.Size = new Size(67, 32);
            lblthoigian.TabIndex = 1;
            lblthoigian.Text = "Time";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(47, 54, 64);
            panel4.Location = new Point(1179, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(53, 662);
            panel4.TabIndex = 15;
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
            BackColor = Color.FromArgb(30, 30, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1234, 661);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(fmenu);
            Controls.Add(panel1);
            Controls.Add(pamain);
            MaximumSize = new Size(1250, 700);
            MinimumSize = new Size(1250, 700);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            fmenu.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timechuyen;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private Panel pamain;
        private Button button1;
        private Button button2;
        private Button gbtnSach;
        private Button btnMuon;
        private Button btnTra;
        private Panel fmenu;
        private Guna.UI2.WinForms.Guna2Button gbtndocgia;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button gbtnadmin;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblthoigian;
        private Panel pcodeby;
        private Label lblcodeby;
        private System.Windows.Forms.Timer timerChayChu;
        private System.Windows.Forms.Timer timerdoimau;
    }
}