namespace Quanlythuvien.Views
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
            lbldangnhap = new Label();
            lbluser = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            lblpass = new Label();
            cboanhien = new CheckBox();
            btndangnhap = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // lbldangnhap
            // 
            lbldangnhap.AutoSize = true;
            lbldangnhap.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldangnhap.Location = new Point(163, 31);
            lbldangnhap.Name = "lbldangnhap";
            lbldangnhap.Size = new Size(173, 32);
            lbldangnhap.TabIndex = 0;
            lbldangnhap.Text = "ĐĂNG NHẬP";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(121, 84);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(85, 16);
            lbluser.TabIndex = 1;
            lbluser.Text = "Tên tài khoản";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(212, 81);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(137, 22);
            txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(212, 118);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(137, 22);
            txtpass.TabIndex = 4;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(136, 121);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(61, 16);
            lblpass.TabIndex = 3;
            lblpass.Text = "Mật khẩu";
            // 
            // cboanhien
            // 
            cboanhien.AutoSize = true;
            cboanhien.Location = new Point(355, 121);
            cboanhien.Name = "cboanhien";
            cboanhien.Size = new Size(70, 20);
            cboanhien.TabIndex = 5;
            cboanhien.Text = "Ẩn\\hiện";
            cboanhien.UseVisualStyleBackColor = true;
            cboanhien.CheckedChanged += cboanhien_CheckedChanged;
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(136, 159);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(114, 29);
            btndangnhap.TabIndex = 6;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(271, 159);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(114, 29);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 239);
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

        private Label lbldangnhap;
        private Label lbluser;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label lblpass;
        private CheckBox cboanhien;
        private Button btndangnhap;
        private Button btnthoat;
    }
}