using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class Form1 : Form
    {
        qlrapchieuphimEntities db = new qlrapchieuphimEntities();
        public Form1()
        {
            InitializeComponent();
        }
        public void show()
        {
            using (var context = new qlrapchieuphimEntities())
            {
                var phims = context.Phims.ToList();

                foreach (var phim in phims)
                {
                    ListViewItem item = new ListViewItem(phim.MaDon);
                    item.Tag = phim;  
                    item.SubItems.Add(phim.TenPhim);
                    item.SubItems.Add(phim.TheLoai);
                    item.SubItems.Add(phim.NgayCongChieu?.ToString()); 
                    lvDSPhim.Items.Add(item);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            rad2D.Checked = true;
            radTinhCam.Checked = true;
            dtpNgayCongChieu.Value = DateTime.Now;
            lblPhuThuSuatChieuDacBiet.Visible = false;
            txtPhuThuSuatChieuDacBiet.Visible = false;
            txtMaDon.Clear();
            txtTenPhim.Clear();
            txtQuocGia.Clear();
            txtDoTuoiQuiDinh.Clear();
            txtPhuThuSuatChieuDacBiet.Clear();
            txtPhuThuGheDoi.Clear();
            txtMaDon.Focus();
            btnLuu.Enabled = false;
            show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn tắt chương trình?", "Xác nhận tắt chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rad2D_CheckedChanged(object sender, EventArgs e)
        {
            if(rad2D.Checked)
            {
                lblPhuThuGheDoi.Visible = true;
                txtPhuThuGheDoi.Visible = true;
                lblPhuThuSuatChieuDacBiet.Visible = false;
                txtPhuThuSuatChieuDacBiet.Visible = false;
            }
           
        }

        private void rad3D_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3D.Checked)
            {
                
                lblPhuThuSuatChieuDacBiet.Visible = true;
                txtPhuThuSuatChieuDacBiet.Visible = true;
                lblPhuThuGheDoi.Visible = false;
                txtPhuThuGheDoi.Visible = false;
            }
            
        }
        int doTuoiQuiDinh;
        

        

        private void txtMaDon_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoTuoiQuiDinh.Text, out doTuoiQuiDinh) || doTuoiQuiDinh < 0 || doTuoiQuiDinh > 100 || txtMaDon.Text == "" || txtTenPhim.Text == "" || txtQuocGia.Text == "" || txtDoTuoiQuiDinh.Text == "" || txtPhuThuGheDoi.Text == "" && txtPhuThuSuatChieuDacBiet.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void txtTenPhim_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoTuoiQuiDinh.Text, out doTuoiQuiDinh) || doTuoiQuiDinh < 0 || doTuoiQuiDinh > 100 || txtMaDon.Text == "" || txtTenPhim.Text == "" || txtQuocGia.Text == "" || txtDoTuoiQuiDinh.Text == "" || txtPhuThuGheDoi.Text == "" && txtPhuThuSuatChieuDacBiet.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void txtQuocGia_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoTuoiQuiDinh.Text, out doTuoiQuiDinh) || doTuoiQuiDinh < 0 || doTuoiQuiDinh > 100 || txtMaDon.Text == "" || txtTenPhim.Text == "" || txtQuocGia.Text == "" || txtDoTuoiQuiDinh.Text == "" || txtPhuThuGheDoi.Text == "" && txtPhuThuSuatChieuDacBiet.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void txtDoTuoiQuiDinh_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoTuoiQuiDinh.Text, out doTuoiQuiDinh) || doTuoiQuiDinh < 0 || doTuoiQuiDinh > 100 || txtMaDon.Text == "" || txtTenPhim.Text == "" || txtQuocGia.Text == "" || txtDoTuoiQuiDinh.Text == "" || txtPhuThuGheDoi.Text == "" && txtPhuThuSuatChieuDacBiet.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void txtPhuThuSuatChieuDacBiet_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoTuoiQuiDinh.Text, out doTuoiQuiDinh) || doTuoiQuiDinh < 0 || doTuoiQuiDinh > 100 || txtMaDon.Text == "" || txtTenPhim.Text == "" || txtQuocGia.Text == "" || txtDoTuoiQuiDinh.Text == "" || txtPhuThuGheDoi.Text == "" && txtPhuThuSuatChieuDacBiet.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }
        private void txtPhuThuGheDoi_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoTuoiQuiDinh.Text, out doTuoiQuiDinh) || doTuoiQuiDinh < 0 || doTuoiQuiDinh > 100 || txtMaDon.Text == "" || txtTenPhim.Text == "" || txtQuocGia.Text == "" || txtDoTuoiQuiDinh.Text == "" || txtPhuThuGheDoi.Text == "" && txtPhuThuSuatChieuDacBiet.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }
        private bool KiemTraTrungMaDon(string maDon)
        {
           
            return db.Phims.Any(p => p.MaDon == maDon);
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            lvDSPhim.Items.Clear();
            reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDon = txtMaDon.Text;

            // Kiểm tra xem mã đơn đã tồn tại chưa
            if (KiemTraTrungMaDon(maDon))
            {
                MessageBox.Show("Mã đơn đã tồn tại. Vui lòng chọn mã đơn khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Phim p = new Phim();
            p.MaDon = txtMaDon.Text;
            p.TenPhim = txtTenPhim.Text;
            p.QuocGia = txtQuocGia.Text;
            if (radTinhCam.Checked)
            {
                p.TheLoai = radTinhCam.Text;
            }
            else p.TheLoai = radHanhDong.Text;
            p.NgayCongChieu = dtpNgayCongChieu.Value;
            p.DoTuoiQuiDinh = Convert.ToInt32(txtDoTuoiQuiDinh.Text);
            if (rad2D.Checked)
            {
                p.DinhDang = rad2D.Text;
                p.PhuThu = lblPhuThuGheDoi.Text;
                p.GiaTienPhuThu = Convert.ToDecimal(txtPhuThuGheDoi.Text);
            }
            else
            {
                p.DinhDang = rad3D.Text;
                p.PhuThu = lblPhuThuSuatChieuDacBiet.Text;
                p.GiaTienPhuThu = Convert.ToDecimal(txtPhuThuSuatChieuDacBiet.Text);
            }

            db.Phims.Add(p);
            db.SaveChanges();
            lvDSPhim.Items.Clear();
            show();

        }
        private void lvDSPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSPhim.SelectedItems.Count > 0)
            {
                string maDon = lvDSPhim.SelectedItems[0].SubItems[0].Text;
                Phim p = db.Phims.FirstOrDefault(x => x.MaDon == maDon);

                if (p != null)
                {

                    txtMaDon.Text = p.MaDon;
                    txtTenPhim.Text = p.TenPhim;
                    txtQuocGia.Text = p.QuocGia;
                    txtDoTuoiQuiDinh.Text = p.DoTuoiQuiDinh.ToString();
                    if (p.TheLoai == "Tình Cảm")
                    {
                        radTinhCam.Checked = true;
                    }
                    else if (p.TheLoai == "Hành Động")
                    {
                        radHanhDong.Checked = true;
                    }
                    dtpNgayCongChieu.Value = p.NgayCongChieu.Value;
                    if (p.DinhDang == "2D")
                    {
                        rad2D.Checked = true;
                        txtPhuThuGheDoi.Text = p.GiaTienPhuThu.ToString();
                    }
                    else if (p.DinhDang == "3D")
                    {
                        rad3D.Checked = true;
                        txtPhuThuSuatChieuDacBiet.Text = p.GiaTienPhuThu.ToString();
                    }

                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSPhim.SelectedItems.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string maDon = lvDSPhim.SelectedItems[0].SubItems[0].Text;

                    
                    Phim p = db.Phims.FirstOrDefault(x => x.MaDon == maDon);

                    if (p != null)
                    {
                        
                        db.Phims.Remove(p);
                        db.SaveChanges();

                        
                        lvDSPhim.SelectedItems[0].Remove();

                        
                        if (lvDSPhim.Items.Count == 0)
                        {
                            reset();
                        }
                    }
                }
            }
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDSPhim.SelectedItems.Count > 0)
            {
                string maDon = lvDSPhim.SelectedItems[0].SubItems[0].Text;
                Phim p = db.Phims.FirstOrDefault(x => x.MaDon == maDon);

                if (p != null)
                {
                    p.TenPhim = txtTenPhim.Text;
                    p.QuocGia = txtQuocGia.Text;

                    if (radTinhCam.Checked)
                    {
                        p.TheLoai = radTinhCam.Text;
                    }
                    else if (radHanhDong.Checked)
                    {
                        p.TheLoai = radHanhDong.Text;
                    }

                    p.NgayCongChieu = dtpNgayCongChieu.Value;
                    p.DoTuoiQuiDinh = Convert.ToInt32(txtDoTuoiQuiDinh.Text);

  
                    if (rad2D.Checked)
                    {
                        p.DinhDang = rad2D.Text;
                        p.PhuThu = lblPhuThuGheDoi.Text;
                        p.GiaTienPhuThu = Convert.ToDecimal(txtPhuThuGheDoi.Text);
                    }
                    else if (rad3D.Checked)
                    {
                        p.DinhDang = rad3D.Text;
                        p.PhuThu = lblPhuThuSuatChieuDacBiet.Text;
                        p.GiaTienPhuThu = Convert.ToDecimal(txtPhuThuSuatChieuDacBiet.Text);
                    }

                    
                    db.Entry(p).State = EntityState.Modified;
                    db.SaveChanges();

                    
                    lvDSPhim.SelectedItems[0].SubItems[1].Text = p.TenPhim;
                    lvDSPhim.SelectedItems[0].SubItems[2].Text = p.QuocGia;
                    
                }
            }
        }
        private void SapXepDanhSach()
        {
            
            List<Phim> danhSachPhim = lvDSPhim.Items.Cast<ListViewItem>()
                .Select(item => item.Tag as Phim)
                .Where(phim => phim != null && phim.NgayCongChieu != null && phim.DoTuoiQuiDinh != null)
                .ToList();

            // Sắp xếp danh sách theo ngày công chiếu tăng dần, độ tuổi qui định giảm dần
            danhSachPhim = danhSachPhim
                .OrderBy(phim => phim.NgayCongChieu)
                .ThenByDescending(phim => phim.DoTuoiQuiDinh)
                .ToList();

            
            lvDSPhim.Items.Clear();

            
            foreach (var phim in danhSachPhim)
            {
                ListViewItem item = new ListViewItem(phim.MaDon);
                item.Tag = phim;  
                item.SubItems.Add(phim.TenPhim);
                item.SubItems.Add(phim.TheLoai);
                item.SubItems.Add(phim.NgayCongChieu?.ToString()); 
                
                lvDSPhim.Items.Add(item);
            }
        }



        private void btnSapXep_Click(object sender, EventArgs e)
        {
            SapXepDanhSach();
        }
        private void ThongKePhim()
        {
            
            List<Phim> danhSachPhim = lvDSPhim.Items.Cast<ListViewItem>()
                .Select(item => item.Tag as Phim)
                .Where(phim => phim != null)
                .ToList();

            
            decimal doanhThu2D = 0;
            decimal doanhThu3D = 0;
            int soLuong2D = 0;
            int soLuong3D = 0;

            foreach (var phim in danhSachPhim)
            {
                if (phim.DinhDang == "2D")
                {
                    soLuong2D++;

                    
                    doanhThu2D += phim.GiaTienPhuThu ?? 0;
                }
                else if (phim.DinhDang == "3D")
                {
                    soLuong3D++;

                    
                    doanhThu3D += phim.GiaTienPhuThu ?? 0;
                }
            }

            
            string thongTin = $"2D: Số lượng phim: {soLuong2D}, Doanh thu: {doanhThu2D:C}\n";
            thongTin += $"3D: Số lượng phim: {soLuong3D}, Doanh thu: {doanhThu3D:C}";

            MessageBox.Show(thongTin, "Thống kê phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKePhim();
        }
    }
}
