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
            fmenu = new FlowLayoutPanel();
            panel9 = new Panel();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            ibtndocgia = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ibtnMenu = new FontAwesome.Sharp.IconButton();
            timechuyen = new System.Windows.Forms.Timer(components);
            pamain = new Panel();
            fmenu.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblchao
            // 
            lblchao.AutoSize = true;
            lblchao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblchao.Location = new Point(417, 12);
            lblchao.Name = "lblchao";
            lblchao.Size = new Size(612, 37);
            lblchao.TabIndex = 0;
            lblchao.Text = "Chào mừng đến với ứng dụng quản lý thư viện";
            // 
            // lblthoigian
            // 
            lblthoigian.AutoSize = true;
            lblthoigian.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblthoigian.Location = new Point(845, 615);
            lblthoigian.Name = "lblthoigian";
            lblthoigian.Size = new Size(135, 37);
            lblthoigian.TabIndex = 1;
            lblthoigian.Text = "HH:mm:ss";
            // 
            // timethoigian
            // 
            timethoigian.Tick += timethoigian_Tick;
            // 
            // fmenu
            // 
            fmenu.BackColor = Color.FromArgb(25, 40, 45);
            fmenu.Controls.Add(panel9);
            fmenu.Controls.Add(iconButton1);
            fmenu.Location = new Point(0, 70);
            fmenu.MaximumSize = new Size(240, 530);
            fmenu.MinimumSize = new Size(67, 530);
            fmenu.Name = "fmenu";
            fmenu.Size = new Size(240, 530);
            fmenu.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(iconButton7);
            panel9.Controls.Add(iconButton6);
            panel9.Controls.Add(iconButton5);
            panel9.Controls.Add(iconButton4);
            panel9.Controls.Add(iconButton3);
            panel9.Controls.Add(ibtndocgia);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(233, 367);
            panel9.TabIndex = 9;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.Black;
            iconButton7.Dock = DockStyle.Top;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(0, 215);
            iconButton7.Name = "iconButton7";
            iconButton7.RightToLeft = RightToLeft.No;
            iconButton7.Size = new Size(233, 43);
            iconButton7.TabIndex = 14;
            iconButton7.Text = "iconButton7";
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.Black;
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 172);
            iconButton6.Name = "iconButton6";
            iconButton6.RightToLeft = RightToLeft.No;
            iconButton6.Size = new Size(233, 43);
            iconButton6.TabIndex = 13;
            iconButton6.Text = "iconButton6";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Black;
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 129);
            iconButton5.Name = "iconButton5";
            iconButton5.RightToLeft = RightToLeft.No;
            iconButton5.Size = new Size(233, 43);
            iconButton5.TabIndex = 12;
            iconButton5.Text = "iconButton5";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Black;
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 86);
            iconButton4.Name = "iconButton4";
            iconButton4.RightToLeft = RightToLeft.No;
            iconButton4.Size = new Size(233, 43);
            iconButton4.TabIndex = 11;
            iconButton4.Text = "iconButton4";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Black;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 43);
            iconButton3.Name = "iconButton3";
            iconButton3.RightToLeft = RightToLeft.No;
            iconButton3.Size = new Size(233, 43);
            iconButton3.TabIndex = 10;
            iconButton3.Text = "iconButton3";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // ibtndocgia
            // 
            ibtndocgia.BackColor = Color.Black;
            ibtndocgia.Dock = DockStyle.Top;
            ibtndocgia.FlatAppearance.BorderColor = Color.Red;
            ibtndocgia.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            ibtndocgia.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            ibtndocgia.FlatStyle = FlatStyle.Popup;
            ibtndocgia.ForeColor = Color.White;
            ibtndocgia.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            ibtndocgia.IconColor = Color.White;
            ibtndocgia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtndocgia.ImageAlign = ContentAlignment.MiddleLeft;
            ibtndocgia.Location = new Point(0, 0);
            ibtndocgia.Name = "ibtndocgia";
            ibtndocgia.RightToLeft = RightToLeft.No;
            ibtndocgia.Size = new Size(233, 43);
            ibtndocgia.TabIndex = 9;
            ibtndocgia.Text = "Độc giả";
            ibtndocgia.UseVisualStyleBackColor = false;
            ibtndocgia.Click += ibtndocgia_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Black;
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 376);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(237, 0);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Menu";
            iconButton1.UseVisualStyleBackColor = false;
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
            ibtnMenu.BackColor = Color.Black;
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
            pamain.Size = new Size(1105, 530);
            pamain.TabIndex = 6;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 661);
            Controls.Add(lblthoigian);
            Controls.Add(fmenu);
            Controls.Add(panel1);
            Controls.Add(lblchao);
            Controls.Add(pamain);
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            fmenu.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblchao;
        private Label lblthoigian;
        private System.Windows.Forms.Timer timethoigian;
        private FlowLayoutPanel fmenu;
        private Panel panel1;
        private System.Windows.Forms.Timer timechuyen;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ibtndocgia;
        private Panel pamain;
    }
}