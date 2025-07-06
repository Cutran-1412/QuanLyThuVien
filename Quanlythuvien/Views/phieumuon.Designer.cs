<<<<<<< HEAD
﻿namespace Quanlythuvien.Views
{
    partial class PhieuMuonForm
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
            label1 = new Label();
            txtMaPhieu = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            dtpNgayMuon = new DateTimePicker();
            label4 = new Label();
            dgvSach = new DataGridView();
            button2 = new Button();
            btnSave = new Button();
            dgvDocGia = new DataGridView();
            txtSoLuong = new TextBox();
            label5 = new Label();
            dtpNgaytra = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu mượn";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.AcceptsReturn = true;
            txtMaPhieu.Location = new Point(519, 29);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(250, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(749, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 164);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 92);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày mượn";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Location = new Point(519, 92);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(250, 27);
            dtpNgayMuon.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(801, 164);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 7;
            label4.Text = "Chọn sách mượn";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(632, 197);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 29;
            dgvSach.Size = new Size(438, 137);
            dgvSach.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(887, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(532, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvDocGia
            // 
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Location = new Point(118, 197);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.RowTemplate.Height = 29;
            dgvDocGia.Size = new Size(438, 137);
            dgvDocGia.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(856, 348);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(749, 351);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 13;
            label5.Text = "Số lượng";
            // 
            // dtpNgaytra
            // 
            dtpNgaytra.Location = new Point(519, 144);
            dtpNgaytra.Name = "dtpNgaytra";
            dtpNgaytra.Size = new Size(250, 27);
            dtpNgaytra.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 144);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 14;
            label6.Text = "Ngày phải trả";
            // 
            // PhieuMuonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 493);
            Controls.Add(dtpNgaytra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSoLuong);
            Controls.Add(dgvDocGia);
            Controls.Add(btnSave);
            Controls.Add(button2);
            Controls.Add(dgvSach);
            Controls.Add(label4);
            Controls.Add(dtpNgayMuon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtMaPhieu);
            Controls.Add(label1);
            Name = "PhieuMuonForm";
            Text = "phieumuon";
            Load += phieumuon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaPhieu;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpNgayMuon;
        private Label label4;
        private DataGridView dgvSach;
        private Button button2;
        private Button btnSave;
        private DataGridView dgvDocGia;
        private TextBox txtSoLuong;
        private Label label5;
        private DateTimePicker dtpNgaytra;
        private Label label6;
    }
=======
﻿namespace Quanlythuvien.Views
{
    partial class PhieuMuonForm
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
            label1 = new Label();
            txtMaPhieu = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            dtpNgayMuon = new DateTimePicker();
            label4 = new Label();
            dgvSach = new DataGridView();
            button2 = new Button();
            btnSave = new Button();
            dgvDocGia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu mượn";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.AcceptsReturn = true;
            txtMaPhieu.Location = new Point(519, 29);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(250, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(782, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 164);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 92);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày mượn";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Location = new Point(519, 92);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(250, 27);
            dtpNgayMuon.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(801, 164);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 7;
            label4.Text = "Chọn sách mượn";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(632, 197);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 29;
            dgvSach.Size = new Size(438, 137);
            dgvSach.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(916, 357);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(532, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvDocGia
            // 
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Location = new Point(111, 197);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.RowTemplate.Height = 29;
            dgvDocGia.Size = new Size(438, 137);
            dgvDocGia.TabIndex = 11;
            // 
            // PhieuMuonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 493);
            Controls.Add(dgvDocGia);
            Controls.Add(btnSave);
            Controls.Add(button2);
            Controls.Add(dgvSach);
            Controls.Add(label4);
            Controls.Add(dtpNgayMuon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtMaPhieu);
            Controls.Add(label1);
            Name = "PhieuMuonForm";
            Text = "phieumuon";
            Load += phieumuon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaPhieu;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpNgayMuon;
        private Label label4;
        private DataGridView dgvSach;
        private Button button2;
        private Button btnSave;
        private DataGridView dgvDocGia;
    }
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
}