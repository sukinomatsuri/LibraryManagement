namespace QuanLyThuVienApp
{
    partial class frmReportHoaDonPhat
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
            this.picHoaDon = new System.Windows.Forms.PictureBox();
            this.pnlCongCu = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuuPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHoaDon)).BeginInit();
            this.pnlCongCu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHoaDon
            // 
            this.picHoaDon.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.picHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHoaDon.Location = new System.Drawing.Point(0, 48);
            this.picHoaDon.Name = "picHoaDon";
            this.picHoaDon.Size = new System.Drawing.Size(1000, 672);
            this.picHoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHoaDon.TabIndex = 0;
            this.picHoaDon.TabStop = false;
            // 
            // pnlCongCu
            // 
            this.pnlCongCu.BackColor = System.Drawing.Color.White;
            this.pnlCongCu.Controls.Add(this.btnIn);
            this.pnlCongCu.Controls.Add(this.btnLuuPdf);
            this.pnlCongCu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCongCu.Location = new System.Drawing.Point(0, 0);
            this.pnlCongCu.Name = "pnlCongCu";
            this.pnlCongCu.Size = new System.Drawing.Size(1000, 48);
            this.pnlCongCu.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnIn.Location = new System.Drawing.Point(774, 9);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(96, 30);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuuPdf
            // 
            this.btnLuuPdf.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLuuPdf.Location = new System.Drawing.Point(876, 9);
            this.btnLuuPdf.Name = "btnLuuPdf";
            this.btnLuuPdf.Size = new System.Drawing.Size(112, 30);
            this.btnLuuPdf.TabIndex = 1;
            this.btnLuuPdf.Text = "Lưu PDF";
            this.btnLuuPdf.UseVisualStyleBackColor = true;
            this.btnLuuPdf.Click += new System.EventHandler(this.btnLuuPdf_Click);
            // 
            // frmReportHoaDonPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.picHoaDon);
            this.Controls.Add(this.pnlCongCu);
            this.Name = "frmReportHoaDonPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn tiền phạt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReportHoaDonPhat_FormClosed);
            this.Load += new System.EventHandler(this.frmReportHoaDonPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHoaDon)).EndInit();
            this.pnlCongCu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHoaDon;
        private System.Windows.Forms.Panel pnlCongCu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLuuPdf;
    }
}
