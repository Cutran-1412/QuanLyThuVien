namespace Quanlythuvien.Views
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
            txtMaDocGia = new TextBox();
            label3 = new Label();
            dtpNgayMuon = new DateTimePicker();
            label4 = new Label();
            dgvSach = new DataGridView();
            button2 = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu mượn";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.AcceptsReturn = true;
            txtMaPhieu.Location = new Point(366, 33);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(125, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(239, 332);
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
            label2.Location = new Point(219, 75);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã độc giả";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Location = new Point(366, 75);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.Size = new Size(125, 27);
            txtMaDocGia.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 122);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày mượn";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Location = new Point(366, 117);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(250, 27);
            dtpNgayMuon.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 166);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 7;
            label4.Text = "Chọn sách mượn";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(37, 189);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 29;
            dgvSach.Size = new Size(742, 137);
            dgvSach.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(397, 332);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(239, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PhieuMuonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(button2);
            Controls.Add(dgvSach);
            Controls.Add(label4);
            Controls.Add(dtpNgayMuon);
            Controls.Add(label3);
            Controls.Add(txtMaDocGia);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtMaPhieu);
            Controls.Add(label1);
            Name = "PhieuMuonForm";
            Text = "phieumuon";
            Load += phieumuon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaPhieu;
        private Button btnAdd;
        private Label label2;
        private TextBox txtMaDocGia;
        private Label label3;
        private DateTimePicker dtpNgayMuon;
        private Label label4;
        private DataGridView dgvSach;
        private Button button2;
        private Button btnSave;
    }
}