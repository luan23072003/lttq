namespace OnTap
{
    partial class Form1
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
            this.lblTieude = new System.Windows.Forms.Label();
            this.grpbxTacVu = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbxDSPhim = new System.Windows.Forms.GroupBox();
            this.lvDSPhim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbxThongTinPhim = new System.Windows.Forms.GroupBox();
            this.txtPhuThuGheDoi = new System.Windows.Forms.TextBox();
            this.lblPhuThuGheDoi = new System.Windows.Forms.Label();
            this.dtpNgayCongChieu = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rad3D = new System.Windows.Forms.RadioButton();
            this.rad2D = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radHanhDong = new System.Windows.Forms.RadioButton();
            this.radTinhCam = new System.Windows.Forms.RadioButton();
            this.txtDoTuoiQuiDinh = new System.Windows.Forms.TextBox();
            this.txtPhuThuSuatChieuDacBiet = new System.Windows.Forms.TextBox();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.lblPhuThuSuatChieuDacBiet = new System.Windows.Forms.Label();
            this.lblDinhDang = new System.Windows.Forms.Label();
            this.lblDoTuoiQuiDinh = new System.Windows.Forms.Label();
            this.lblNgayCongChieu = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblQuocGia = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.grpbxTacVu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpbxDSPhim.SuspendLayout();
            this.grpbxThongTinPhim.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieude
            // 
            this.lblTieude.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieude.Location = new System.Drawing.Point(263, 18);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(513, 20);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "CHƯƠNG TRÌNH QUẢN LÝ DOANH THU PHIM CHIẾU RẠP";
            // 
            // grpbxTacVu
            // 
            this.grpbxTacVu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpbxTacVu.Controls.Add(this.btnThongKe);
            this.grpbxTacVu.Controls.Add(this.btnSapXep);
            this.grpbxTacVu.Controls.Add(this.btnSua);
            this.grpbxTacVu.Controls.Add(this.btnXoa);
            this.grpbxTacVu.Controls.Add(this.btnLuu);
            this.grpbxTacVu.Controls.Add(this.btnThem);
            this.grpbxTacVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpbxTacVu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpbxTacVu.Location = new System.Drawing.Point(109, 463);
            this.grpbxTacVu.Name = "grpbxTacVu";
            this.grpbxTacVu.Size = new System.Drawing.Size(806, 100);
            this.grpbxTacVu.TabIndex = 3;
            this.grpbxTacVu.TabStop = false;
            this.grpbxTacVu.Text = "Tác vụ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThongKe.Location = new System.Drawing.Point(601, 40);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(104, 31);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSapXep.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSapXep.Location = new System.Drawing.Point(476, 40);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(87, 31);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSua.Location = new System.Drawing.Point(352, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoa.Location = new System.Drawing.Point(241, 40);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLuu.Location = new System.Drawing.Point(130, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 31);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThem.Location = new System.Drawing.Point(19, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.grpbxDSPhim);
            this.panel1.Controls.Add(this.grpbxThongTinPhim);
            this.panel1.Location = new System.Drawing.Point(33, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 404);
            this.panel1.TabIndex = 4;
            // 
            // grpbxDSPhim
            // 
            this.grpbxDSPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxDSPhim.Controls.Add(this.lvDSPhim);
            this.grpbxDSPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpbxDSPhim.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpbxDSPhim.Location = new System.Drawing.Point(483, 3);
            this.grpbxDSPhim.Name = "grpbxDSPhim";
            this.grpbxDSPhim.Size = new System.Drawing.Size(463, 381);
            this.grpbxDSPhim.TabIndex = 4;
            this.grpbxDSPhim.TabStop = false;
            this.grpbxDSPhim.Text = "Danh sách phim";
            // 
            // lvDSPhim
            // 
            this.lvDSPhim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDSPhim.FullRowSelect = true;
            this.lvDSPhim.HideSelection = false;
            this.lvDSPhim.Location = new System.Drawing.Point(6, 23);
            this.lvDSPhim.Name = "lvDSPhim";
            this.lvDSPhim.Size = new System.Drawing.Size(451, 352);
            this.lvDSPhim.TabIndex = 0;
            this.lvDSPhim.UseCompatibleStateImageBehavior = false;
            this.lvDSPhim.View = System.Windows.Forms.View.Details;
            this.lvDSPhim.SelectedIndexChanged += new System.EventHandler(this.lvDSPhim_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Đơn";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thể Loại";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Công Chiếu";
            this.columnHeader4.Width = 130;
            // 
            // grpbxThongTinPhim
            // 
            this.grpbxThongTinPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpbxThongTinPhim.Controls.Add(this.txtPhuThuGheDoi);
            this.grpbxThongTinPhim.Controls.Add(this.lblPhuThuGheDoi);
            this.grpbxThongTinPhim.Controls.Add(this.dtpNgayCongChieu);
            this.grpbxThongTinPhim.Controls.Add(this.panel2);
            this.grpbxThongTinPhim.Controls.Add(this.panel3);
            this.grpbxThongTinPhim.Controls.Add(this.txtDoTuoiQuiDinh);
            this.grpbxThongTinPhim.Controls.Add(this.txtPhuThuSuatChieuDacBiet);
            this.grpbxThongTinPhim.Controls.Add(this.txtQuocGia);
            this.grpbxThongTinPhim.Controls.Add(this.txtTenPhim);
            this.grpbxThongTinPhim.Controls.Add(this.txtMaDon);
            this.grpbxThongTinPhim.Controls.Add(this.lblPhuThuSuatChieuDacBiet);
            this.grpbxThongTinPhim.Controls.Add(this.lblDinhDang);
            this.grpbxThongTinPhim.Controls.Add(this.lblDoTuoiQuiDinh);
            this.grpbxThongTinPhim.Controls.Add(this.lblNgayCongChieu);
            this.grpbxThongTinPhim.Controls.Add(this.lblTheLoai);
            this.grpbxThongTinPhim.Controls.Add(this.lblQuocGia);
            this.grpbxThongTinPhim.Controls.Add(this.lblTenPhim);
            this.grpbxThongTinPhim.Controls.Add(this.lblMaDon);
            this.grpbxThongTinPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpbxThongTinPhim.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpbxThongTinPhim.Location = new System.Drawing.Point(17, 23);
            this.grpbxThongTinPhim.Name = "grpbxThongTinPhim";
            this.grpbxThongTinPhim.Size = new System.Drawing.Size(460, 361);
            this.grpbxThongTinPhim.TabIndex = 3;
            this.grpbxThongTinPhim.TabStop = false;
            this.grpbxThongTinPhim.Text = "Thông tin phim";
            // 
            // txtPhuThuGheDoi
            // 
            this.txtPhuThuGheDoi.Location = new System.Drawing.Point(139, 294);
            this.txtPhuThuGheDoi.Name = "txtPhuThuGheDoi";
            this.txtPhuThuGheDoi.Size = new System.Drawing.Size(212, 24);
            this.txtPhuThuGheDoi.TabIndex = 17;
            this.txtPhuThuGheDoi.TextChanged += new System.EventHandler(this.txtPhuThuGheDoi_TextChanged);
            // 
            // lblPhuThuGheDoi
            // 
            this.lblPhuThuGheDoi.AutoSize = true;
            this.lblPhuThuGheDoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhuThuGheDoi.Location = new System.Drawing.Point(3, 300);
            this.lblPhuThuGheDoi.Name = "lblPhuThuGheDoi";
            this.lblPhuThuGheDoi.Size = new System.Drawing.Size(114, 18);
            this.lblPhuThuGheDoi.TabIndex = 16;
            this.lblPhuThuGheDoi.Text = "Phụ thu ghế đôi:";
            // 
            // dtpNgayCongChieu
            // 
            this.dtpNgayCongChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCongChieu.Location = new System.Drawing.Point(141, 181);
            this.dtpNgayCongChieu.Name = "dtpNgayCongChieu";
            this.dtpNgayCongChieu.Size = new System.Drawing.Size(190, 24);
            this.dtpNgayCongChieu.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rad3D);
            this.panel2.Controls.Add(this.rad2D);
            this.panel2.Location = new System.Drawing.Point(95, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 25);
            this.panel2.TabIndex = 14;
            // 
            // rad3D
            // 
            this.rad3D.AutoSize = true;
            this.rad3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad3D.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rad3D.Location = new System.Drawing.Point(80, 2);
            this.rad3D.Name = "rad3D";
            this.rad3D.Size = new System.Drawing.Size(44, 19);
            this.rad3D.TabIndex = 1;
            this.rad3D.Text = "3D";
            this.rad3D.UseVisualStyleBackColor = true;
            this.rad3D.CheckedChanged += new System.EventHandler(this.rad3D_CheckedChanged);
            // 
            // rad2D
            // 
            this.rad2D.AutoSize = true;
            this.rad2D.Checked = true;
            this.rad2D.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad2D.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rad2D.Location = new System.Drawing.Point(3, 1);
            this.rad2D.Name = "rad2D";
            this.rad2D.Size = new System.Drawing.Size(44, 19);
            this.rad2D.TabIndex = 0;
            this.rad2D.TabStop = true;
            this.rad2D.Text = "2D";
            this.rad2D.UseVisualStyleBackColor = true;
            this.rad2D.CheckedChanged += new System.EventHandler(this.rad2D_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radHanhDong);
            this.panel3.Controls.Add(this.radTinhCam);
            this.panel3.Location = new System.Drawing.Point(95, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 25);
            this.panel3.TabIndex = 13;
            // 
            // radHanhDong
            // 
            this.radHanhDong.AutoSize = true;
            this.radHanhDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radHanhDong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radHanhDong.Location = new System.Drawing.Point(127, 3);
            this.radHanhDong.Name = "radHanhDong";
            this.radHanhDong.Size = new System.Drawing.Size(89, 19);
            this.radHanhDong.TabIndex = 1;
            this.radHanhDong.Text = "Hành động";
            this.radHanhDong.UseVisualStyleBackColor = true;
            // 
            // radTinhCam
            // 
            this.radTinhCam.AutoSize = true;
            this.radTinhCam.Checked = true;
            this.radTinhCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radTinhCam.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radTinhCam.Location = new System.Drawing.Point(3, 3);
            this.radTinhCam.Name = "radTinhCam";
            this.radTinhCam.Size = new System.Drawing.Size(79, 19);
            this.radTinhCam.TabIndex = 0;
            this.radTinhCam.TabStop = true;
            this.radTinhCam.Text = "Tình cảm";
            this.radTinhCam.UseVisualStyleBackColor = true;
            // 
            // txtDoTuoiQuiDinh
            // 
            this.txtDoTuoiQuiDinh.Location = new System.Drawing.Point(139, 221);
            this.txtDoTuoiQuiDinh.Name = "txtDoTuoiQuiDinh";
            this.txtDoTuoiQuiDinh.Size = new System.Drawing.Size(192, 24);
            this.txtDoTuoiQuiDinh.TabIndex = 12;
            this.txtDoTuoiQuiDinh.TextChanged += new System.EventHandler(this.txtDoTuoiQuiDinh_TextChanged);
            // 
            // txtPhuThuSuatChieuDacBiet
            // 
            this.txtPhuThuSuatChieuDacBiet.Location = new System.Drawing.Point(217, 294);
            this.txtPhuThuSuatChieuDacBiet.Name = "txtPhuThuSuatChieuDacBiet";
            this.txtPhuThuSuatChieuDacBiet.Size = new System.Drawing.Size(109, 24);
            this.txtPhuThuSuatChieuDacBiet.TabIndex = 11;
            this.txtPhuThuSuatChieuDacBiet.TextChanged += new System.EventHandler(this.txtPhuThuSuatChieuDacBiet_TextChanged);
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(95, 114);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(236, 24);
            this.txtQuocGia.TabIndex = 10;
            this.txtQuocGia.TextChanged += new System.EventHandler(this.txtQuocGia_TextChanged);
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(93, 72);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(238, 24);
            this.txtTenPhim.TabIndex = 9;
            this.txtTenPhim.TextChanged += new System.EventHandler(this.txtTenPhim_TextChanged);
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(93, 32);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(238, 24);
            this.txtMaDon.TabIndex = 8;
            this.txtMaDon.TextChanged += new System.EventHandler(this.txtMaDon_TextChanged);
            // 
            // lblPhuThuSuatChieuDacBiet
            // 
            this.lblPhuThuSuatChieuDacBiet.AutoSize = true;
            this.lblPhuThuSuatChieuDacBiet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhuThuSuatChieuDacBiet.Location = new System.Drawing.Point(7, 300);
            this.lblPhuThuSuatChieuDacBiet.Name = "lblPhuThuSuatChieuDacBiet";
            this.lblPhuThuSuatChieuDacBiet.Size = new System.Drawing.Size(188, 18);
            this.lblPhuThuSuatChieuDacBiet.TabIndex = 7;
            this.lblPhuThuSuatChieuDacBiet.Text = "Phụ thu suất chiếu đặc biệt:";
            // 
            // lblDinhDang
            // 
            this.lblDinhDang.AutoSize = true;
            this.lblDinhDang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDinhDang.Location = new System.Drawing.Point(7, 266);
            this.lblDinhDang.Name = "lblDinhDang";
            this.lblDinhDang.Size = new System.Drawing.Size(78, 18);
            this.lblDinhDang.TabIndex = 6;
            this.lblDinhDang.Text = "Định dạng:";
            // 
            // lblDoTuoiQuiDinh
            // 
            this.lblDoTuoiQuiDinh.AutoSize = true;
            this.lblDoTuoiQuiDinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoTuoiQuiDinh.Location = new System.Drawing.Point(7, 227);
            this.lblDoTuoiQuiDinh.Name = "lblDoTuoiQuiDinh";
            this.lblDoTuoiQuiDinh.Size = new System.Drawing.Size(126, 18);
            this.lblDoTuoiQuiDinh.TabIndex = 5;
            this.lblDoTuoiQuiDinh.Text = "Độ Tuổi Qui Định:";
            // 
            // lblNgayCongChieu
            // 
            this.lblNgayCongChieu.AutoSize = true;
            this.lblNgayCongChieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNgayCongChieu.Location = new System.Drawing.Point(7, 186);
            this.lblNgayCongChieu.Name = "lblNgayCongChieu";
            this.lblNgayCongChieu.Size = new System.Drawing.Size(128, 18);
            this.lblNgayCongChieu.TabIndex = 4;
            this.lblNgayCongChieu.Text = "Ngày Công Chiếu:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTheLoai.Location = new System.Drawing.Point(7, 152);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(64, 18);
            this.lblTheLoai.TabIndex = 3;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // lblQuocGia
            // 
            this.lblQuocGia.AutoSize = true;
            this.lblQuocGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuocGia.Location = new System.Drawing.Point(7, 120);
            this.lblQuocGia.Name = "lblQuocGia";
            this.lblQuocGia.Size = new System.Drawing.Size(72, 18);
            this.lblQuocGia.TabIndex = 2;
            this.lblQuocGia.Text = "Quốc gia:";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenPhim.Location = new System.Drawing.Point(7, 78);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(75, 18);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên Phim:";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaDon.Location = new System.Drawing.Point(7, 37);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(65, 18);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã Đơn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(994, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpbxTacVu);
            this.Controls.Add(this.lblTieude);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6251071059 - Nguyễn Thành Luân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxTacVu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpbxDSPhim.ResumeLayout(false);
            this.grpbxThongTinPhim.ResumeLayout(false);
            this.grpbxThongTinPhim.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.GroupBox grpbxTacVu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpbxDSPhim;
        private System.Windows.Forms.ListView lvDSPhim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grpbxThongTinPhim;
        private System.Windows.Forms.DateTimePicker dtpNgayCongChieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rad3D;
        private System.Windows.Forms.RadioButton rad2D;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radHanhDong;
        private System.Windows.Forms.RadioButton radTinhCam;
        private System.Windows.Forms.TextBox txtDoTuoiQuiDinh;
        private System.Windows.Forms.TextBox txtPhuThuSuatChieuDacBiet;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label lblPhuThuSuatChieuDacBiet;
        private System.Windows.Forms.Label lblDinhDang;
        private System.Windows.Forms.Label lblDoTuoiQuiDinh;
        private System.Windows.Forms.Label lblNgayCongChieu;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblQuocGia;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtPhuThuGheDoi;
        private System.Windows.Forms.Label lblPhuThuGheDoi;
    }
}

