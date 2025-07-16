namespace Quanlythuvien.Views
{
    partial class ucMain
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
            lblmon = new Label();
            lblmamon = new Label();
            lblgiangvien = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblmon
            // 
            lblmon.AutoSize = true;
            lblmon.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblmon.ForeColor = Color.Black;
            lblmon.Location = new Point(400, 134);
            lblmon.Name = "lblmon";
            lblmon.Size = new Size(185, 37);
            lblmon.TabIndex = 14;
            lblmon.Text = "Môn : Đồ án 1";
            // 
            // lblmamon
            // 
            lblmamon.AutoSize = true;
            lblmamon.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblmamon.ForeColor = Color.Black;
            lblmamon.Location = new Point(400, 233);
            lblmamon.Name = "lblmamon";
            lblmamon.Size = new Size(316, 37);
            lblmamon.TabIndex = 15;
            lblmamon.Text = "Mã môn : 010100185508";
            // 
            // lblgiangvien
            // 
            lblgiangvien.AutoSize = true;
            lblgiangvien.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblgiangvien.ForeColor = Color.Black;
            lblgiangvien.Location = new Point(400, 282);
            lblgiangvien.Name = "lblgiangvien";
            lblgiangvien.Size = new Size(321, 37);
            lblgiangvien.TabIndex = 16;
            lblgiangvien.Text = "Giảng viên :  Vũ Anh Tuấn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(400, 186);
            label1.Name = "label1";
            label1.Size = new Size(242, 37);
            label1.TabIndex = 17;
            label1.Text = "Lớp : DHTI16A6HN";
            // 
            // ucMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(lblgiangvien);
            Controls.Add(lblmamon);
            Controls.Add(lblmon);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "ucMain";
            Size = new Size(1105, 530);
            Load += ucMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblmon;
        private Label lblmamon;
        private Label lblgiangvien;
        private Label label1;
    }
}
