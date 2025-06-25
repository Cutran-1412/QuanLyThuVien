namespace Quanlythuvien.Views.Logins
{
    partial class Login
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
            btnthoat = new Button();
            btndangnhap = new Button();
            cboanhien = new CheckBox();
            txtpass = new TextBox();
            lblpass = new Label();
            txtuser = new TextBox();
            lbluser = new Label();
            lbldangnhap = new Label();
            SuspendLayout();
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(259, 158);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(114, 31);
            btnthoat.TabIndex = 15;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(124, 158);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(114, 31);
            btndangnhap.TabIndex = 14;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // cboanhien
            // 
            cboanhien.AutoSize = true;
            cboanhien.Location = new Point(343, 117);
            cboanhien.Name = "cboanhien";
            cboanhien.Size = new Size(70, 20);
            cboanhien.TabIndex = 13;
            cboanhien.Text = "Ẩn\\hiện";
            cboanhien.UseVisualStyleBackColor = true;
            cboanhien.CheckedChanged += cboanhien_CheckedChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(200, 114);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(137, 22);
            txtpass.TabIndex = 12;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(124, 117);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(61, 16);
            lblpass.TabIndex = 11;
            lblpass.Text = "Mật khẩu";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(200, 75);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(137, 22);
            txtuser.TabIndex = 10;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(109, 78);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(85, 16);
            lbluser.TabIndex = 9;
            lbluser.Text = "Tên tài khoản";
            // 
            // lbldangnhap
            // 
            lbldangnhap.AutoSize = true;
            lbldangnhap.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldangnhap.Location = new Point(151, 21);
            lbldangnhap.Name = "lbldangnhap";
            lbldangnhap.Size = new Size(173, 32);
            lbldangnhap.TabIndex = 8;
            lbldangnhap.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 218);
            Controls.Add(btnthoat);
            Controls.Add(btndangnhap);
            Controls.Add(cboanhien);
            Controls.Add(txtpass);
            Controls.Add(lblpass);
            Controls.Add(txtuser);
            Controls.Add(lbluser);
            Controls.Add(lbldangnhap);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnthoat;
        private Button btndangnhap;
        private CheckBox cboanhien;
        private TextBox txtpass;
        private Label lblpass;
        private TextBox txtuser;
        private Label lbluser;
        private Label lbldangnhap;
    }
}