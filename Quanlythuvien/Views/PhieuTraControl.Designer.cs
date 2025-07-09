
namespace Quanlythuvien.Views
{
    partial class PhieuTraControl
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dgvChiTietPhieuMuon = new DataGridView();
            btnTraSach = new Button();
            label5 = new Label();
            txtMaPhieuTra = new TextBox();
            dgvPhieuMuon = new DataGridView();
            txtSoLuongTra = new TextBox();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 11);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "TRẢ SÁCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 52);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(774, 148);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 4;
            label4.Text = "Chi tiết phiếu mượn";
            // 
            // dgvChiTietPhieuMuon
            // 
            dgvChiTietPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuMuon.Location = new Point(543, 171);
            dgvChiTietPhieuMuon.Name = "dgvChiTietPhieuMuon";
            dgvChiTietPhieuMuon.ReadOnly = true;
            dgvChiTietPhieuMuon.RowHeadersWidth = 51;
            dgvChiTietPhieuMuon.RowTemplate.Height = 29;
            dgvChiTietPhieuMuon.Size = new Size(538, 150);
            dgvChiTietPhieuMuon.TabIndex = 5;
            // 
            // btnTraSach
            // 
            btnTraSach.Location = new Point(774, 397);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(155, 29);
            btnTraSach.TabIndex = 6;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 148);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 8;
            label5.Text = "Chọn phiếu mượn";
            // 
            // txtMaPhieuTra
            // 
            txtMaPhieuTra.Location = new Point(543, 49);
            txtMaPhieuTra.Name = "txtMaPhieuTra";
            txtMaPhieuTra.ReadOnly = true;
            txtMaPhieuTra.Size = new Size(239, 27);
            txtMaPhieuTra.TabIndex = 11;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(42, 171);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.ReadOnly = true;
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.RowTemplate.Height = 29;
            dgvPhieuMuon.Size = new Size(451, 150);
            dgvPhieuMuon.TabIndex = 12;
            dgvPhieuMuon.CellClick += dgvPhieuMuon_CellClick;
            // 
            // txtSoLuongTra
            // 
            txtSoLuongTra.Location = new Point(707, 342);
            txtSoLuongTra.Name = "txtSoLuongTra";
            txtSoLuongTra.Size = new Size(125, 27);
            txtSoLuongTra.TabIndex = 13;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(584, 342);
            lbl.Name = "lbl";
            lbl.Size = new Size(91, 20);
            lbl.TabIndex = 14;
            lbl.Text = "Số lượng trả";
            // 
            // PhieuTraControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl);
            Controls.Add(txtSoLuongTra);
            Controls.Add(dgvPhieuMuon);
            Controls.Add(txtMaPhieuTra);
            Controls.Add(label5);
            Controls.Add(btnTraSach);
            Controls.Add(dgvChiTietPhieuMuon);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PhieuTraControl";
            Size = new Size(1100, 540);
            Load += PhieuTraControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private DataGridView dgvChiTietPhieuMuon;
        private Button btnTraSach;
        private Label label5;
        private TextBox txtMaPhieuTra;
        private DataGridView dgvPhieuMuon;
        private TextBox txtSoLuongTra;
        private Label lbl;
    }
}
