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
            label3 = new Label();
            label4 = new Label();
            dgvSach = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            dgvPhieuMuon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "TRẢ SÁCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 44);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu trả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 291);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Ngày trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(774, 79);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 4;
            label4.Text = "Danh sách sách đã mượn";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(614, 107);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 29;
            dgvSach.Size = new Size(466, 150);
            dgvSach.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(793, 304);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 6;
            button1.Text = "Trả sách đã chọn";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(528, 435);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 84);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 8;
            label5.Text = "Chọn phiếu mượn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(222, 291);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 11;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(82, 107);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.RowTemplate.Height = 29;
            dgvPhieuMuon.Size = new Size(466, 150);
            dgvPhieuMuon.TabIndex = 12;
            // 
            // PhieuTraControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPhieuMuon);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvSach);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PhieuTraControl";
            Size = new Size(1100, 540);
      
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvSach;
        private Button button1;
        private Button button2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private DataGridView dgvPhieuMuon;
    }
}
