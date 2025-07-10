namespace Quanlythuvien.Views
{
    partial class phieumuoncontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbPhieuMuon = new GroupBox();
            btnHuyPhieuMuon = new Button();
            cboMaDG = new ComboBox();
            btnThemPhieuMuon = new Button();
            label4 = new Label();
            dtpNgayHenTra = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dtpNgayMuon = new DateTimePicker();
            txtMaPhieuLeft = new TextBox();
            Max = new Label();
            btnChoMuon = new Button();
            groupBox2 = new GroupBox();
            txtSoLuongMuon = new TextBox();
            label1 = new Label();
            cbbMaSach = new ComboBox();
            btnThemChiTiet = new Button();
            label6 = new Label();
            txtMaPhieuCenter = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            txtTacGia = new TextBox();
            label11 = new Label();
            txtSoLuongCon = new TextBox();
            label8 = new Label();
            txtTheLoai = new TextBox();
            label10 = new Label();
            txtTenSach = new TextBox();
            label5 = new Label();
            txtMaSach = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dgvDanhSachMuon = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            groupBox5 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            grbPhieuMuon.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachMuon).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // grbPhieuMuon
            // 
            grbPhieuMuon.Controls.Add(btnHuyPhieuMuon);
            grbPhieuMuon.Controls.Add(cboMaDG);
            grbPhieuMuon.Controls.Add(btnThemPhieuMuon);
            grbPhieuMuon.Controls.Add(label4);
            grbPhieuMuon.Controls.Add(dtpNgayHenTra);
            grbPhieuMuon.Controls.Add(label3);
            grbPhieuMuon.Controls.Add(label2);
            grbPhieuMuon.Controls.Add(dtpNgayMuon);
            grbPhieuMuon.Controls.Add(txtMaPhieuLeft);
            grbPhieuMuon.Controls.Add(Max);
            grbPhieuMuon.Location = new Point(17, 20);
            grbPhieuMuon.Name = "grbPhieuMuon";
            grbPhieuMuon.Size = new Size(283, 261);
            grbPhieuMuon.TabIndex = 0;
            grbPhieuMuon.TabStop = false;
            grbPhieuMuon.Text = "Phiếu  mượn";
            // 
            // btnHuyPhieuMuon
            // 
            btnHuyPhieuMuon.Enabled = false;
            btnHuyPhieuMuon.Location = new Point(168, 219);
            btnHuyPhieuMuon.Name = "btnHuyPhieuMuon";
            btnHuyPhieuMuon.Size = new Size(79, 29);
            btnHuyPhieuMuon.TabIndex = 11;
            btnHuyPhieuMuon.Text = "Hủy";
            btnHuyPhieuMuon.UseVisualStyleBackColor = true;
            btnHuyPhieuMuon.Click += btnHuyPhieuMuon_Click;
            // 
            // cboMaDG
            // 
            cboMaDG.Enabled = false;
            cboMaDG.FormattingEnabled = true;
            cboMaDG.Location = new Point(136, 75);
            cboMaDG.MaxDropDownItems = 5;
            cboMaDG.Name = "cboMaDG";
            cboMaDG.Size = new Size(133, 28);
            cboMaDG.TabIndex = 10;
            // 
            // btnThemPhieuMuon
            // 
            btnThemPhieuMuon.Location = new Point(79, 219);
            btnThemPhieuMuon.Name = "btnThemPhieuMuon";
            btnThemPhieuMuon.Size = new Size(72, 29);
            btnThemPhieuMuon.TabIndex = 8;
            btnThemPhieuMuon.Text = "Thêm";
            btnThemPhieuMuon.UseVisualStyleBackColor = true;
            btnThemPhieuMuon.Click += btnThemPhieuMuon_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 173);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày hẹn trả";
            // 
            // dtpNgayHenTra
            // 
            dtpNgayHenTra.Enabled = false;
            dtpNgayHenTra.Format = DateTimePickerFormat.Short;
            dtpNgayHenTra.Location = new Point(135, 173);
            dtpNgayHenTra.Name = "dtpNgayHenTra";
            dtpNgayHenTra.Size = new Size(134, 27);
            dtpNgayHenTra.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 129);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày mượn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 75);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã ĐG";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Enabled = false;
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(136, 129);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(132, 27);
            dtpNgayMuon.TabIndex = 2;
            // 
            // txtMaPhieuLeft
            // 
            txtMaPhieuLeft.Location = new Point(136, 31);
            txtMaPhieuLeft.Name = "txtMaPhieuLeft";
            txtMaPhieuLeft.ReadOnly = true;
            txtMaPhieuLeft.Size = new Size(132, 27);
            txtMaPhieuLeft.TabIndex = 1;
            // 
            // Max
            // 
            Max.AutoSize = true;
            Max.Location = new Point(31, 33);
            Max.Name = "Max";
            Max.Size = new Size(71, 20);
            Max.TabIndex = 0;
            Max.Text = "Mã phiếu";
            // 
            // btnChoMuon
            // 
            btnChoMuon.Enabled = false;
            btnChoMuon.Location = new Point(612, 298);
            btnChoMuon.Name = "btnChoMuon";
            btnChoMuon.Size = new Size(164, 29);
            btnChoMuon.TabIndex = 9;
            btnChoMuon.Text = "Cho mượn";
            btnChoMuon.UseVisualStyleBackColor = true;
            btnChoMuon.Click += btnLuuPhieuMuon_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuongMuon);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbbMaSach);
            groupBox2.Controls.Add(btnThemChiTiet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMaPhieuCenter);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(306, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 250);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu mượn";
            // 
            // txtSoLuongMuon
            // 
            txtSoLuongMuon.Location = new Point(140, 122);
            txtSoLuongMuon.Name = "txtSoLuongMuon";
            txtSoLuongMuon.ReadOnly = true;
            txtSoLuongMuon.Size = new Size(145, 27);
            txtSoLuongMuon.TabIndex = 12;
            txtSoLuongMuon.TextChanged += txtSoLuongMuon_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 124);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 11;
            label1.Text = "Số lượng  mượn";
            // 
            // cbbMaSach
            // 
            cbbMaSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaSach.Enabled = false;
            cbbMaSach.FormattingEnabled = true;
            cbbMaSach.Location = new Point(140, 77);
            cbbMaSach.Name = "cbbMaSach";
            cbbMaSach.Size = new Size(146, 28);
            cbbMaSach.TabIndex = 10;
            cbbMaSach.SelectedValueChanged += cbbMaSach_SelectedValueChanged;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Enabled = false;
            btnThemChiTiet.Location = new Point(138, 208);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(94, 29);
            btnThemChiTiet.TabIndex = 8;
            btnThemChiTiet.Text = "Thêm";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 83);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 3;
            label6.Text = "Mã sách";
            // 
            // txtMaPhieuCenter
            // 
            txtMaPhieuCenter.Location = new Point(140, 35);
            txtMaPhieuCenter.Name = "txtMaPhieuCenter";
            txtMaPhieuCenter.ReadOnly = true;
            txtMaPhieuCenter.Size = new Size(145, 27);
            txtMaPhieuCenter.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 42);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 0;
            label7.Text = "Mã  phiếu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTacGia);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtSoLuongCon);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtTheLoai);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtTenSach);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtMaSach);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(612, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 250);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách";
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(126, 120);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.ReadOnly = true;
            txtTacGia.Size = new Size(144, 27);
            txtTacGia.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 122);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 8;
            label11.Text = "Tác giả";
            // 
            // txtSoLuongCon
            // 
            txtSoLuongCon.Location = new Point(126, 215);
            txtSoLuongCon.Name = "txtSoLuongCon";
            txtSoLuongCon.ReadOnly = true;
            txtSoLuongCon.Size = new Size(144, 27);
            txtSoLuongCon.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 217);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 6;
            label8.Text = "Số lượng còn";
            // 
            // txtTheLoai
            // 
            txtTheLoai.Location = new Point(126, 166);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.ReadOnly = true;
            txtTheLoai.Size = new Size(144, 27);
            txtTheLoai.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 168);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 4;
            label10.Text = "Thể loại";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(126, 77);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.ReadOnly = true;
            txtTenSach.Size = new Size(144, 27);
            txtTenSach.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 79);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 2;
            label5.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(126, 30);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(144, 27);
            txtMaSach.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 32);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 0;
            label9.Text = "Mã sách";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvDanhSachMuon);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button6);
            groupBox4.Location = new Point(444, 333);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(635, 188);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách mượn";
            // 
            // dgvDanhSachMuon
            // 
            dgvDanhSachMuon.AllowUserToAddRows = false;
            dgvDanhSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachMuon.BackgroundColor = SystemColors.Control;
            dgvDanhSachMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachMuon.Location = new Point(20, 27);
            dgvDanhSachMuon.Name = "dgvDanhSachMuon";
            dgvDanhSachMuon.ReadOnly = true;
            dgvDanhSachMuon.RowHeadersWidth = 51;
            dgvDanhSachMuon.RowTemplate.Height = 29;
            dgvDanhSachMuon.Size = new Size(598, 155);
            dgvDanhSachMuon.TabIndex = 10;
            dgvDanhSachMuon.CellContentClick += dgvPhieuMuon_CellContentClick;
            dgvDanhSachMuon.RowsAdded += dgvDanhSachMuon_RowsAdded;
            // 
            // button5
            // 
            button5.Location = new Point(251, 226);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(135, 226);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "Thêm";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button7);
            groupBox5.Controls.Add(button8);
            groupBox5.Location = new Point(17, 333);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(411, 188);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // button7
            // 
            button7.Location = new Point(251, 226);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 9;
            button7.Text = "Lưu";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(135, 226);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 8;
            button8.Text = "Thêm";
            button8.UseVisualStyleBackColor = true;
            // 
            // phieumuoncontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(btnChoMuon);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grbPhieuMuon);
            Name = "phieumuoncontrol";
            Size = new Size(1100, 540);
            Load += phieumuoncontrol_Load;
            grbPhieuMuon.ResumeLayout(false);
            grbPhieuMuon.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachMuon).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbPhieuMuon;
        private Label label4;
        private DateTimePicker dtpNgayHenTra;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayMuon;
        private TextBox txtMaPhieuLeft;
        private Label Max;
        private ComboBox cboMaDG;
        private Button btnChoMuon;
        private Button btnThemPhieuMuon;
        private GroupBox groupBox2;
        private TextBox txtSoLuongMuon;
        private Label label1;
        private ComboBox cbbMaSach;
        private Button btnThemChiTiet;
        private Label label6;
        private TextBox txtMaPhieuCenter;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtSoLuongCon;
        private Label label8;
        private TextBox txtTheLoai;
        private Label label10;
        private TextBox txtTenSach;
        private Label label5;
        private TextBox txtMaSach;
        private Label label9;
        private TextBox txtTacGia;
        private Label label11;
        private GroupBox groupBox4;
        private DataGridView dgvDanhSachMuon;
        private Button button5;
        private Button button6;
        private GroupBox groupBox5;
        private Button button7;
        private Button button8;
        private Button btnHuyPhieuMuon;
    }
}
