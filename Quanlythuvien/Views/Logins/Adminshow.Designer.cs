namespace Quanlythuvien.Views.Login
{
    partial class Adminshow
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
            dataadmin = new DataGridView();
            grbquanlytaikhoan = new GroupBox();
            cboanhien = new CheckBox();
            txtpass = new TextBox();
            label3 = new Label();
            txtuser = new TextBox();
            label2 = new Label();
            txtma = new TextBox();
            label1 = new Label();
            grbchucnang = new GroupBox();
            button5 = new Button();
            btnthoat = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataadmin).BeginInit();
            grbquanlytaikhoan.SuspendLayout();
            grbchucnang.SuspendLayout();
            SuspendLayout();
            // 
            // dataadmin
            // 
            dataadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataadmin.Location = new Point(12, 5);
            dataadmin.Name = "dataadmin";
            dataadmin.RowTemplate.Height = 25;
            dataadmin.Size = new Size(370, 254);
            dataadmin.TabIndex = 0;
            dataadmin.CellFormatting += dataadmin_CellFormatting;
            dataadmin.SelectionChanged += dataadmin_SelectionChanged;
            // 
            // grbquanlytaikhoan
            // 
            grbquanlytaikhoan.Controls.Add(cboanhien);
            grbquanlytaikhoan.Controls.Add(txtpass);
            grbquanlytaikhoan.Controls.Add(label3);
            grbquanlytaikhoan.Controls.Add(txtuser);
            grbquanlytaikhoan.Controls.Add(label2);
            grbquanlytaikhoan.Controls.Add(txtma);
            grbquanlytaikhoan.Controls.Add(label1);
            grbquanlytaikhoan.Location = new Point(410, 5);
            grbquanlytaikhoan.Name = "grbquanlytaikhoan";
            grbquanlytaikhoan.Size = new Size(353, 123);
            grbquanlytaikhoan.TabIndex = 1;
            grbquanlytaikhoan.TabStop = false;
            grbquanlytaikhoan.Text = "Quản lý tài khoản";
            // 
            // cboanhien
            // 
            cboanhien.AutoSize = true;
            cboanhien.Location = new Point(278, 80);
            cboanhien.Name = "cboanhien";
            cboanhien.Size = new Size(70, 20);
            cboanhien.TabIndex = 6;
            cboanhien.Text = "Ẩn\\hiện";
            cboanhien.UseVisualStyleBackColor = true;
            cboanhien.CheckedChanged += cboanhien_CheckedChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(117, 80);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(152, 22);
            txtpass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 83);
            label3.Name = "label3";
            label3.Size = new Size(61, 16);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(117, 52);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(152, 22);
            txtuser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản";
            // 
            // txtma
            // 
            txtma.Location = new Point(117, 24);
            txtma.Name = "txtma";
            txtma.Size = new Size(152, 22);
            txtma.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 0;
            label1.Text = "Mã tài khoản";
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(button5);
            grbchucnang.Controls.Add(btnthoat);
            grbchucnang.Controls.Add(btnxoa);
            grbchucnang.Controls.Add(btnsua);
            grbchucnang.Controls.Add(btnthem);
            grbchucnang.Location = new Point(410, 134);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Size = new Size(353, 125);
            grbchucnang.TabIndex = 2;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "Chức năng";
            // 
            // button5
            // 
            button5.Location = new Point(133, 75);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(231, 75);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(231, 36);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 23);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(133, 36);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 23);
            btnsua.TabIndex = 1;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(29, 36);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 23);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // Adminshow
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 271);
            Controls.Add(grbchucnang);
            Controls.Add(grbquanlytaikhoan);
            Controls.Add(dataadmin);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "Adminshow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TÀI KHOẢN";
            Load += Adminshow_Load;
            ((System.ComponentModel.ISupportInitialize)dataadmin).EndInit();
            grbquanlytaikhoan.ResumeLayout(false);
            grbquanlytaikhoan.PerformLayout();
            grbchucnang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataadmin;
        private GroupBox grbquanlytaikhoan;
        private Label label1;
        private TextBox txtuser;
        private Label label2;
        private TextBox txtma;
        private TextBox txtpass;
        private Label label3;
        private GroupBox grbchucnang;
        private CheckBox cboanhien;
        private Button button5;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
    }
}