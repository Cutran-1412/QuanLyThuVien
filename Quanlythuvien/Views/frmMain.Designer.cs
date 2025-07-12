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
            lblthoigian = new Label();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblchao
            // 
            lblchao.AutoSize = true;
            lblchao.BackColor = Color.White;
            lblchao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblchao.Location = new Point(360, 12);
            lblchao.Name = "lblchao";
            lblchao.Size = new Size(768, 46);
            lblchao.TabIndex = 0;
            lblchao.Text = "Chào mừng đến với ứng dụng quản lý thư viện";
            // 
            // lblthoigian
            // 
            lblthoigian.AutoSize = true;
            lblthoigian.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblthoigian.Location = new Point(1082, 801);
            lblthoigian.Name = "lblthoigian";
            lblthoigian.Size = new Size(168, 46);
            lblthoigian.TabIndex = 1;
            lblthoigian.Text = "HH:mm:ss";
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
            pamain.Location = new Point(83, 93);
            pamain.Margin = new Padding(3, 4, 3, 4);
            pamain.Name = "pamain";
            pamain.Size = new Size(1257, 720);
            pamain.TabIndex = 6;
            pamain.Paint += pamain_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(14, 95);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(59, 31);
            button1.TabIndex = 7;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 133);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(59, 31);
            button2.TabIndex = 8;
            button2.Text = "Docgia";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // gbtnSach
            // 
            gbtnSach.Location = new Point(14, 172);
            gbtnSach.Margin = new Padding(3, 4, 3, 4);
            gbtnSach.Name = "gbtnSach";
            gbtnSach.Size = new Size(59, 31);
            gbtnSach.TabIndex = 9;
            gbtnSach.Text = "Sách";
            gbtnSach.UseVisualStyleBackColor = true;
            gbtnSach.Click += gbtnSach_Click;
            // 
            // btnMuon
            // 
            btnMuon.Location = new Point(14, 211);
            btnMuon.Margin = new Padding(3, 4, 3, 4);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(59, 77);
            btnMuon.TabIndex = 10;
            btnMuon.Text = "Mượn";
            btnMuon.UseVisualStyleBackColor = true;
            btnMuon.Click += btnMuon_Click;
            // 
            // btnTra
            // 
            btnTra.Location = new Point(14, 296);
            btnTra.Margin = new Padding(3, 4, 3, 4);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(59, 91);
            btnTra.TabIndex = 11;
            btnTra.Text = "Trả";
            btnTra.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1351, 868);
            Controls.Add(btnTra);
            Controls.Add(btnMuon);
            Controls.Add(gbtnSach);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblthoigian);
            Controls.Add(panel1);
            Controls.Add(lblchao);
            Controls.Add(pamain);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1369, 915);
            MinimumSize = new Size(1369, 915);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblchao;
        private Label lblthoigian;
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
    }
}