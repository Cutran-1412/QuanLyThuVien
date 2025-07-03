namespace Quanlythuvien.Views
{
    partial class frmLogin
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
            lbldanghap = new Label();
            txtusername = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ipican = new FontAwesome.Sharp.IconPictureBox();
            ipichien = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            txtpassword = new TextBox();
            btndangnhap = new Button();
            btnthoat = new Button();
            lbllammoi = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipican).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ipichien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbldanghap
            // 
            lbldanghap.AutoSize = true;
            lbldanghap.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbldanghap.Location = new Point(61, 20);
            lbldanghap.Name = "lbldanghap";
            lbldanghap.Size = new Size(179, 32);
            lbldanghap.TabIndex = 1;
            lbldanghap.Text = "ĐĂNG NHẬP";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Control;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(37, 21);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(189, 16);
            txtusername.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtusername);
            panel1.Location = new Point(24, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 44);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(37, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 1);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(ipican);
            panel3.Controls.Add(ipichien);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtpassword);
            panel3.Location = new Point(24, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 49);
            panel3.TabIndex = 5;
            // 
            // ipican
            // 
            ipican.BackColor = SystemColors.Control;
            ipican.ForeColor = SystemColors.ControlText;
            ipican.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            ipican.IconColor = SystemColors.ControlText;
            ipican.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipican.IconSize = 25;
            ipican.Location = new Point(201, 9);
            ipican.Name = "ipican";
            ipican.Size = new Size(25, 25);
            ipican.TabIndex = 10;
            ipican.TabStop = false;
            ipican.Click += ipican_Click;
            // 
            // ipichien
            // 
            ipichien.BackColor = SystemColors.Control;
            ipichien.ForeColor = SystemColors.ControlText;
            ipichien.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ipichien.IconColor = SystemColors.ControlText;
            ipichien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipichien.IconSize = 25;
            ipichien.Location = new Point(201, 9);
            ipichien.Name = "ipichien";
            ipichien.Size = new Size(25, 25);
            ipichien.TabIndex = 9;
            ipichien.TabStop = false;
            ipichien.Click += ipichien_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(37, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 1);
            panel4.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Control;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(37, 21);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(189, 16);
            txtpassword.TabIndex = 2;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = SystemColors.Control;
            btndangnhap.FlatAppearance.BorderColor = Color.Black;
            btndangnhap.FlatAppearance.BorderSize = 2;
            btndangnhap.FlatAppearance.MouseOverBackColor = Color.Gray;
            btndangnhap.FlatStyle = FlatStyle.Flat;
            btndangnhap.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndangnhap.ForeColor = Color.Black;
            btndangnhap.Location = new Point(61, 290);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(189, 38);
            btndangnhap.TabIndex = 6;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btnthoat
            // 
            btnthoat.FlatAppearance.BorderColor = Color.Black;
            btnthoat.FlatAppearance.MouseOverBackColor = Color.Red;
            btnthoat.FlatStyle = FlatStyle.Flat;
            btnthoat.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnthoat.Location = new Point(61, 334);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(189, 38);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // lbllammoi
            // 
            lbllammoi.AutoSize = true;
            lbllammoi.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lbllammoi.Location = new Point(194, 253);
            lbllammoi.Name = "lbllammoi";
            lbllammoi.Size = new Size(57, 15);
            lbllammoi.TabIndex = 8;
            lbllammoi.Text = "Làm mới";
            lbllammoi.Click += lbllammoi_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 91;
            iconPictureBox1.Location = new Point(103, 55);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(92, 91);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 403);
            Controls.Add(iconPictureBox1);
            Controls.Add(lbllammoi);
            Controls.Add(btnthoat);
            Controls.Add(btndangnhap);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lbldanghap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipican).EndInit();
            ((System.ComponentModel.ISupportInitialize)ipichien).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbldanghap;
        private TextBox txtusername;
        private TextBox textBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtpassword;
        private Button btndangnhap;
        private Button btnthoat;
        private Label lbllammoi;
        private FontAwesome.Sharp.IconPictureBox ipichien;
        private FontAwesome.Sharp.IconPictureBox ipican;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}