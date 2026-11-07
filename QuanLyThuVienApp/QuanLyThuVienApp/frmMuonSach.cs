using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienApp
{
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }
     
        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            themNutDGV();
            loadDuLieu();
        }
        private void themNutDGV()
        {
            // Tạo nút đăng ký
            DataGridViewButtonColumn nutDangKy = new DataGridViewButtonColumn();
            nutDangKy.HeaderText = "";
            nutDangKy.Text = "Đăng ký";
            nutDangKy.Name = "btnDangKy";
            nutDangKy.Width = 70;
            nutDangKy.UseColumnTextForButtonValue = true;

            // Tạo nút xóa
            DataGridViewButtonColumn nutXoa = new DataGridViewButtonColumn();
            nutXoa.HeaderText = "";
            nutXoa.Text = "Xóa";
            nutXoa.Name = "btnXoa";
            nutXoa.Width = 45;
            nutXoa.UseColumnTextForButtonValue = true;

            // Thêm nút
            dgvSach.Columns.Add(nutDangKy);
            dgvSachMuon.Columns.Add(nutXoa);
        }

        private void loadDuLieu()
        {
            QLTVEntities db = new QLTVEntities();
            dgvSach.DataSource = db.Saches.Select(p => new
            {
                MaSach = "S" + p.ID,
                p.TenSach,
                p.TacGia.TenTG,
                p.NhaXuatBan.TenNXB,
                p.TheLoai.TenTheLoai,
                CoSan = p.SoLuong - p.SoSachMuon
            }).ToList();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvSach.Columns[e.ColumnIndex].Name == "btnDangKy")
            {
                ThemSachVaoDanhSachMuon(e.RowIndex);
            }
        }

        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ThemSachVaoDanhSachMuon(e.RowIndex);
            }
        }

        private void ThemSachVaoDanhSachMuon(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvSach.Rows.Count) return;

            var row = dgvSach.Rows[rowIndex];
            int coSan = 0;
            if (row.Cells["CoSan"].Value != null)
            {
                int.TryParse(row.Cells["CoSan"].Value.ToString(), out coSan);
            }

            if (coSan <= 0)
            {
                MessageBox.Show("Sách này hiện đã hết (Còn: 0), không thể đăng ký mượn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSach = row.Cells["MaSach"].Value != null ? row.Cells["MaSach"].Value.ToString() : "";
            string tenSach = row.Cells["TenSach"].Value != null ? row.Cells["TenSach"].Value.ToString() : "";

            foreach (DataGridViewRow r in dgvSachMuon.Rows)
            {
                if (r.Cells["MaSach2"].Value != null && r.Cells["MaSach2"].Value.ToString() == maSach)
                {
                    int soLuong = 1;
                    if (r.Cells["SoLuong2"].Value != null)
                    {
                        int.TryParse(r.Cells["SoLuong2"].Value.ToString(), out soLuong);
                    }
                    if (soLuong + 1 > coSan)
                    {
                        MessageBox.Show("Số lượng đăng ký mượn không được vượt quá số sách có sẵn (" + coSan + ")!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    r.Cells["SoLuong2"].Value = soLuong + 1;
                    return;
                }
            }

            dgvSachMuon.Rows.Add(maSach, tenSach, 1);
        }

        private void dgvSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;

            if (e.ColumnIndex == 2)
                dgvSachMuon.BeginEdit(true);
            else if (e.ColumnIndex == 3)
                dgvSachMuon.Rows.RemoveAt(e.RowIndex);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string luaChon = cbTimKiem.Text;
            if (luaChon == "") return;

            QLTVEntities db = new QLTVEntities();
            List<Sach> sach = new List<Sach>();

            if (luaChon == "Mã sách")
                sach = db.Saches.Where(p => ("S" + p.ID.ToString()).Contains(txtTimKiem.Text)).ToList();
            else if (luaChon == "Tên sách")
                sach = db.Saches.Where(p => p.TenSach.Contains(txtTimKiem.Text)).ToList();
            else if (luaChon == "Tác giả")
                sach = db.Saches.Where(p => p.TacGia.TenTG.Contains(txtTimKiem.Text)).ToList();
            else if (luaChon == "Nhà xuất bản")
                sach = db.Saches.Where(p => p.NhaXuatBan.TenNXB.Contains(txtTimKiem.Text)).ToList();
            else if (luaChon == "Thể loại")
                sach = db.Saches.Where(p => p.TheLoai.TenTheLoai.Contains(txtTimKiem.Text)).ToList();

            dgvSach.DataSource = sach.Select(p => new
            {
                MaSach = "S" + p.ID,
                p.TenSach,
                p.TacGia.TenTG,
                p.NhaXuatBan.TenNXB,
                p.TheLoai.TenTheLoai,
                CoSan = p.SoLuong - p.SoSachMuon
            }).ToList();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            dgvSachMuon.Rows.Clear();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (dgvSachMuon.Rows.Count == 0)
            {
                if (dgvSach.CurrentRow != null && dgvSach.CurrentRow.Index >= 0)
                {
                    ThemSachVaoDanhSachMuon(dgvSach.CurrentRow.Index);
                }

                if (dgvSachMuon.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một cuốn sách vào danh sách đăng ký mượn!\n(Nhấn nút 'Đăng ký' hoặc nhấp đúp vào sách ở bảng 1)", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult result = MessageBox.Show(
               "Bạn có muốn đăng ký mượn các sách đã chọn không?",
               "Xác nhận đăng ký",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.No) return;

            QLTVEntities db = new QLTVEntities();
            int userId = frmMainUser.ID;
            if (userId <= 0)
            {
                var firstUser = db.NguoiDungs.FirstOrDefault(p => p.QuyenHan == "user") ?? db.NguoiDungs.FirstOrDefault();
                if (firstUser != null) userId = firstUser.ID;
            }

            NguoiDung nguoiDung = db.NguoiDungs.Where(p => p.ID == userId).SingleOrDefault();
            if (nguoiDung == null)
            {
                MessageBox.Show("Không tìm thấy thông tin bạn đọc!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongMuon = 0;
            foreach (DataGridViewRow row in dgvSachMuon.Rows)
            {
                if (row.Cells["SoLuong2"].Value != null)
                {
                    int qty = 0;
                    int.TryParse(row.Cells["SoLuong2"].Value.ToString(), out qty);
                    soLuongMuon += qty;
                }
            }

            int currentSoSachMuon = nguoiDung.SoSachMuon ?? 0;
            if (soLuongMuon + currentSoSachMuon > 10)
            {
                MessageBox.Show("Quá giới hạn sách có thể mượn! Bạn đang mượn " + currentSoSachMuon + " cuốn, chỉ có thể mượn thêm tối đa " + (10 - currentSoSachMuon) + " cuốn.", "Thông báo!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Lưu phiếu mượn trước để sinh MaPhieu Identity
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.IDBanDoc = nguoiDung.ID;
            phieuMuon.NgayDangKyMuon = DateTime.Now;
            phieuMuon.TrangThai = 0; // 0: Đăng ký mượn (chờ duyệt)
            db.PhieuMuons.Add(phieuMuon);
            db.SaveChanges();

            // 2. Lưu chi tiết phiếu mượn & cập nhật số lượng sách
            foreach (DataGridViewRow row in dgvSachMuon.Rows)
            {
                if (row.Cells["MaSach2"].Value == null) continue;
                string maStr = row.Cells["MaSach2"].Value.ToString();
                int idSach = int.Parse(maStr.StartsWith("S") ? maStr.Substring(1) : maStr);
                int soLuong = 1;
                if (row.Cells["SoLuong2"].Value != null)
                {
                    int.TryParse(row.Cells["SoLuong2"].Value.ToString(), out soLuong);
                }

                ChiTietPhieuMuon chiTiet = new ChiTietPhieuMuon();
                chiTiet.MaPhieu = phieuMuon.MaPhieu;
                chiTiet.IDSach = idSach;
                chiTiet.SoLuong = soLuong;
                chiTiet.PhieuMuon = phieuMuon;
                db.ChiTietPhieuMuons.Add(chiTiet);

                Sach sach = db.Saches.Where(p => p.ID == idSach).SingleOrDefault();
                if (sach != null)
                {
                    sach.SoSachMuon = (sach.SoSachMuon ?? 0) + soLuong;
                }
            }

            nguoiDung.SoSachMuon = currentSoSachMuon + soLuongMuon;
            db.SaveChanges();

            // Tạm tắt event CellValidating để clear dgv
            dgvSachMuon.CellValidating -= dgvSachMuon_CellValidating;
            dgvSachMuon.Rows.Clear();
            dgvSachMuon.CellValidating += dgvSachMuon_CellValidating;

            loadDuLieu();
            MessageBox.Show("Đăng ký mượn sách thành công! Phiếu mượn đã được ghi nhận ở trạng thái chờ duyệt.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvSachMuon_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != 2) return;
            string soLuong = e.FormattedValue.ToString();
            int result;
            if (int.TryParse(soLuong, out result) && result > 0)
            {
                QLTVEntities db = new QLTVEntities();
                int maSach = int.Parse(dgvSachMuon.Rows[e.RowIndex].Cells["MaSach2"].Value.ToString().Substring(1));
                Sach sach = db.Saches.Where(p => p.ID == maSach).SingleOrDefault();
                if (sach != null && (sach.SoLuong - sach.SoSachMuon) < result)
                {
                    MessageBox.Show("Không đủ số lượng sách!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
