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
            lbldanghap.Location = new Point(70, 27);
            lbldanghap.Name = "lbldanghap";
            lbldanghap.Size = new Size(225, 39);
            lbldanghap.TabIndex = 1;
            lbldanghap.Text = "ĐĂNG NHẬP";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Control;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(42, 28);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(216, 20);
            txtusername.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtusername);
            panel1.Location = new Point(27, 203);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 59);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(42, 48);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 1);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(ipican);
            panel3.Controls.Add(ipichien);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtpassword);
            panel3.Location = new Point(27, 260);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 65);
            panel3.TabIndex = 5;
            // 
            // ipican
            // 
            ipican.BackColor = SystemColors.Control;
            ipican.ForeColor = SystemColors.ControlText;
            ipican.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            ipican.IconColor = SystemColors.ControlText;
            ipican.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipican.IconSize = 29;
            ipican.Location = new Point(230, 12);
            ipican.Margin = new Padding(3, 4, 3, 4);
            ipican.Name = "ipican";
            ipican.Size = new Size(29, 33);
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
            ipichien.IconSize = 29;
            ipichien.Location = new Point(230, 12);
            ipichien.Margin = new Padding(3, 4, 3, 4);
            ipichien.Name = "ipichien";
            ipichien.Size = new Size(29, 33);
            ipichien.TabIndex = 9;
            ipichien.TabStop = false;
            ipichien.Click += ipichien_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(42, 48);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 1);
            panel4.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Control;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(42, 28);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(216, 20);
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
            btndangnhap.Location = new Point(70, 387);
            btndangnhap.Margin = new Padding(3, 4, 3, 4);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(216, 51);
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
            btnthoat.Location = new Point(70, 445);
            btnthoat.Margin = new Padding(3, 4, 3, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(216, 51);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // lbllammoi
            // 
            lbllammoi.AutoSize = true;
            lbllammoi.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lbllammoi.Location = new Point(222, 337);
            lbllammoi.Name = "lbllammoi";
            lbllammoi.Size = new Size(67, 17);
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
            iconPictureBox1.IconSize = 105;
            iconPictureBox1.Location = new Point(118, 73);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(105, 121);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 537);
            Controls.Add(iconPictureBox1);
            Controls.Add(lbllammoi);
            Controls.Add(btnthoat);
            Controls.Add(btndangnhap);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lbldanghap);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
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