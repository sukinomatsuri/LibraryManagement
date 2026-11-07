namespace QuanLyThuVienApp
{
    partial class frmQuanLyPhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grpDanhSachPhieu = new System.Windows.Forms.GroupBox();
            this.grpChiTietPhieu = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.radioPhieuDangKy = new System.Windows.Forms.RadioButton();
            this.radioPhieuTra = new System.Windows.Forms.RadioButton();
            this.radioPhieuMuon = new System.Windows.Forms.RadioButton();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.MaPhieu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBanDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoMuon = new System.Windows.Forms.Button();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.btnMuonMoi = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.lbTienPhat1 = new System.Windows.Forms.Label();
            this.lbTienPhat2 = new System.Windows.Forms.Label();
            this.btnHoaDonPhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.grpDanhSachPhieu.SuspendLayout();
            this.grpChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Location = new System.Drawing.Point(0, 8);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(915, 26);
            this.labelTitle.TabIndex = 43;
            this.labelTitle.Text = "QUẢN LÝ PHIẾU MƯỢN";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThai.Location = new System.Drawing.Point(10, 42);
            this.labelTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(117, 16);
            this.labelTrangThai.TabIndex = 44;
            this.labelTrangThai.Text = "Trạng thái phiếu:";
            // 
            // radioPhieuDangKy
            // 
            this.radioPhieuDangKy.AutoSize = true;
            this.radioPhieuDangKy.Location = new System.Drawing.Point(128, 41);
            this.radioPhieuDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.radioPhieuDangKy.Name = "radioPhieuDangKy";
            this.radioPhieuDangKy.Size = new System.Drawing.Size(65, 17);
            this.radioPhieuDangKy.TabIndex = 34;
            this.radioPhieuDangKy.TabStop = true;
            this.radioPhieuDangKy.Text = "Đăng ký";
            this.radioPhieuDangKy.UseVisualStyleBackColor = true;
            this.radioPhieuDangKy.CheckedChanged += new System.EventHandler(this.radioPhieuDangKy_CheckedChanged);
            // 
            // radioPhieuMuon
            // 
            this.radioPhieuMuon.AutoSize = true;
            this.radioPhieuMuon.Location = new System.Drawing.Point(202, 41);
            this.radioPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.radioPhieuMuon.Name = "radioPhieuMuon";
            this.radioPhieuMuon.Size = new System.Drawing.Size(80, 17);
            this.radioPhieuMuon.TabIndex = 34;
            this.radioPhieuMuon.TabStop = true;
            this.radioPhieuMuon.Text = "Đang mượn";
            this.radioPhieuMuon.UseVisualStyleBackColor = true;
            this.radioPhieuMuon.CheckedChanged += new System.EventHandler(this.radioPhieuMuon_CheckedChanged);
            // 
            // radioPhieuTra
            // 
            this.radioPhieuTra.AutoSize = true;
            this.radioPhieuTra.Location = new System.Drawing.Point(292, 41);
            this.radioPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.radioPhieuTra.Name = "radioPhieuTra";
            this.radioPhieuTra.Size = new System.Drawing.Size(54, 17);
            this.radioPhieuTra.TabIndex = 34;
            this.radioPhieuTra.TabStop = true;
            this.radioPhieuTra.Text = "Đã trả";
            this.radioPhieuTra.UseVisualStyleBackColor = true;
            this.radioPhieuTra.CheckedChanged += new System.EventHandler(this.radioPhieuTra_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã phiếu",
            "Mã bạn đọc",
            "Tên bạn đọc"});
            this.cbTimKiem.Location = new System.Drawing.Point(465, 39);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(100, 24);
            this.cbTimKiem.TabIndex = 31;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(570, 40);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(145, 22);
            this.txtTimKiem.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTimKiem.IconSize = 16;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(725, 38);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 26);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btnLamMoi.IconColor = System.Drawing.Color.Black;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLamMoi.IconSize = 16;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(815, 38);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 26);
            this.btnLamMoi.TabIndex = 32;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpDanhSachPhieu
            // 
            this.grpDanhSachPhieu.Controls.Add(this.dgvPhieuMuon);
            this.grpDanhSachPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachPhieu.ForeColor = System.Drawing.Color.Navy;
            this.grpDanhSachPhieu.Location = new System.Drawing.Point(10, 72);
            this.grpDanhSachPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.grpDanhSachPhieu.Name = "grpDanhSachPhieu";
            this.grpDanhSachPhieu.Padding = new System.Windows.Forms.Padding(3);
            this.grpDanhSachPhieu.Size = new System.Drawing.Size(500, 348);
            this.grpDanhSachPhieu.TabIndex = 28;
            this.grpDanhSachPhieu.TabStop = false;
            this.grpDanhSachPhieu.Text = "1. Danh sách phiếu";
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuMuon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(3, 18);
            this.dgvPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(494, 327);
            this.dgvPhieuMuon.TabIndex = 1;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            this.dgvPhieuMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieuMuon_CellFormatting);
            this.dgvPhieuMuon.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPhieuMuon_RowPrePaint);
            // 
            // grpChiTietPhieu
            // 
            this.grpChiTietPhieu.Controls.Add(this.dgvChiTiet);
            this.grpChiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiTietPhieu.ForeColor = System.Drawing.Color.Navy;
            this.grpChiTietPhieu.Location = new System.Drawing.Point(520, 72);
            this.grpChiTietPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.grpChiTietPhieu.Name = "grpChiTietPhieu";
            this.grpChiTietPhieu.Padding = new System.Windows.Forms.Padding(3);
            this.grpChiTietPhieu.Size = new System.Drawing.Size(385, 348);
            this.grpChiTietPhieu.TabIndex = 37;
            this.grpChiTietPhieu.TabStop = false;
            this.grpChiTietPhieu.Text = "2. Chi tiết phiếu";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AllowUserToResizeRows = false;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu2,
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.IDBanDoc,
            this.HanTra});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 18);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(379, 327);
            this.dgvChiTiet.TabIndex = 37;
            // 
            // MaPhieu2
            // 
            this.MaPhieu2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaPhieu2.DataPropertyName = "MaPhieu";
            this.MaPhieu2.HeaderText = "Mã phiếu";
            this.MaPhieu2.MinimumWidth = 6;
            this.MaPhieu2.Name = "MaPhieu2";
            this.MaPhieu2.ReadOnly = true;
            this.MaPhieu2.Visible = false;
            this.MaPhieu2.Width = 87;
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 83;
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 140;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 85;
            // 
            // IDBanDoc
            // 
            this.IDBanDoc.DataPropertyName = "IDBanDoc";
            this.IDBanDoc.HeaderText = "ID bạn đọc";
            this.IDBanDoc.MinimumWidth = 6;
            this.IDBanDoc.Name = "IDBanDoc";
            this.IDBanDoc.ReadOnly = true;
            this.IDBanDoc.Visible = false;
            this.IDBanDoc.Width = 125;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            this.HanTra.Visible = false;
            // 
            // btnChoMuon
            // 
            this.btnChoMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnChoMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoMuon.ForeColor = System.Drawing.Color.White;
            this.btnChoMuon.Location = new System.Drawing.Point(415, 426);
            this.btnChoMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoMuon.Name = "btnChoMuon";
            this.btnChoMuon.Size = new System.Drawing.Size(120, 38);
            this.btnChoMuon.TabIndex = 39;
            this.btnChoMuon.Text = "Cho mượn";
            this.btnChoMuon.UseVisualStyleBackColor = false;
            this.btnChoMuon.Click += new System.EventHandler(this.btnChoMuon_Click);
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuyPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieu.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHuyPhieu.Location = new System.Drawing.Point(285, 426);
            this.btnHuyPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(115, 38);
            this.btnHuyPhieu.TabIndex = 39;
            this.btnHuyPhieu.Text = "Hủy phiếu";
            this.btnHuyPhieu.UseVisualStyleBackColor = false;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            // 
            // btnMuonMoi
            // 
            this.btnMuonMoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMuonMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonMoi.Location = new System.Drawing.Point(550, 426);
            this.btnMuonMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuonMoi.Name = "btnMuonMoi";
            this.btnMuonMoi.Size = new System.Drawing.Size(115, 38);
            this.btnMuonMoi.TabIndex = 40;
            this.btnMuonMoi.Text = "Mượn mới";
            this.btnMuonMoi.UseVisualStyleBackColor = false;
            this.btnMuonMoi.Click += new System.EventHandler(this.btnMuonMoi_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.Location = new System.Drawing.Point(415, 426);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(100, 38);
            this.btnGiaHan.TabIndex = 41;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Location = new System.Drawing.Point(530, 426);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(105, 38);
            this.btnTraSach.TabIndex = 41;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // lbTienPhat1
            // 
            this.lbTienPhat1.AutoSize = true;
            this.lbTienPhat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienPhat1.ForeColor = System.Drawing.Color.Red;
            this.lbTienPhat1.Location = new System.Drawing.Point(655, 436);
            this.lbTienPhat1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTienPhat1.Name = "lbTienPhat1";
            this.lbTienPhat1.Size = new System.Drawing.Size(86, 17);
            this.lbTienPhat1.TabIndex = 42;
            this.lbTienPhat1.Text = "Tiền phạt: ";
            // 
            // lbTienPhat2
            // 
            this.lbTienPhat2.AutoSize = true;
            this.lbTienPhat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienPhat2.ForeColor = System.Drawing.Color.Red;
            this.lbTienPhat2.Location = new System.Drawing.Point(740, 436);
            this.lbTienPhat2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTienPhat2.Name = "lbTienPhat2";
            this.lbTienPhat2.Size = new System.Drawing.Size(54, 17);
            this.lbTienPhat2.TabIndex = 42;
            this.lbTienPhat2.Text = "0 VNĐ";
            // 
            // btnHoaDonPhat
            // 
            this.btnHoaDonPhat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHoaDonPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonPhat.Location = new System.Drawing.Point(285, 426);
            this.btnHoaDonPhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoaDonPhat.Name = "btnHoaDonPhat";
            this.btnHoaDonPhat.Size = new System.Drawing.Size(115, 38);
            this.btnHoaDonPhat.TabIndex = 41;
            this.btnHoaDonPhat.Text = "Hóa đơn phạt";
            this.btnHoaDonPhat.UseVisualStyleBackColor = false;
            this.btnHoaDonPhat.Click += new System.EventHandler(this.btnHoaDonPhat_Click);
            // 
            // frmQuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 475);
            this.Controls.Add(this.lbTienPhat2);
            this.Controls.Add(this.lbTienPhat1);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnHoaDonPhat);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnMuonMoi);
            this.Controls.Add(this.btnHuyPhieu);
            this.Controls.Add(this.btnChoMuon);
            this.Controls.Add(this.grpChiTietPhieu);
            this.Controls.Add(this.grpDanhSachPhieu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioPhieuTra);
            this.Controls.Add(this.radioPhieuMuon);
            this.Controls.Add(this.radioPhieuDangKy);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyPhieuMuon";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.grpDanhSachPhieu.ResumeLayout(false);
            this.grpChiTietPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grpDanhSachPhieu;
        private System.Windows.Forms.GroupBox grpChiTietPhieu;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.RadioButton radioPhieuDangKy;
        private System.Windows.Forms.RadioButton radioPhieuTra;
        private System.Windows.Forms.RadioButton radioPhieuMuon;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnChoMuon;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.Button btnMuonMoi;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Label lbTienPhat1;
        private System.Windows.Forms.Label lbTienPhat2;
        private System.Windows.Forms.Button btnHoaDonPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBanDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
    }
}