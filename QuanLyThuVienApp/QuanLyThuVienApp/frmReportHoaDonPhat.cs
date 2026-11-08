using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVienApp
{
    public partial class frmReportHoaDonPhat : Form
    {
        private readonly int ID_NguoiBiPhat, soNgay;
        private readonly string hanTra;
        private byte[] pdfBytes;
        private Image previewImage;

        public frmReportHoaDonPhat()
        {
            InitializeComponent();
        }

        public frmReportHoaDonPhat(int _ID_NguoiBiPhat, string _hanTra, int _soNgay)
        {
            ID_NguoiBiPhat = _ID_NguoiBiPhat;
            soNgay = _soNgay;
            hanTra = _hanTra;
            InitializeComponent();
        }


        private void frmReportHoaDonPhat_Load(object sender, EventArgs e)
        {
            try
            {
                NguoiDung nguoiBiPhat;
                NguoiDung nguoiIn;
                using (var db = new QLTVEntities())
                {
                    nguoiBiPhat = db.NguoiDungs.FirstOrDefault(p => p.ID == ID_NguoiBiPhat);
                    nguoiIn = db.NguoiDungs.FirstOrDefault(p => p.ID == frmMainAdmin.ID);
                }
                if (nguoiBiPhat == null || nguoiIn == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin để lập hóa đơn tiền phạt.");
                    Close();
                    return;
                }
                using (var report = new LocalReport())
                {
                    report.ReportEmbeddedResource = "QuanLyThuVienApp.rpHoaDonPhat.rdlc";
                    report.SetParameters(new[]
                    {
                        new ReportParameter("NguoiIn", nguoiIn.HoTen ?? ""),
                        new ReportParameter("NguoiBiPhat", nguoiBiPhat.HoTen ?? ""),
                        new ReportParameter("HanTra", hanTra ?? ""),
                        new ReportParameter("Email", nguoiBiPhat.Email ?? ""),
                        new ReportParameter("SoNgay", soNgay.ToString())
                    });
                    pdfBytes = report.Render("PDF");
                    var imageBytes = report.Render("IMAGE",
                        "<DeviceInfo><OutputFormat>PNG</OutputFormat><DpiX>160</DpiX><DpiY>160</DpiY></DeviceInfo>");
                    using (var stream = new MemoryStream(imageBytes))
                    using (var image = Image.FromStream(stream))
                        previewImage = new Bitmap(image);
                }
                picHoaDon.Image = previewImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị hóa đơn: " + ex.Message);
                Close();
            }
        }

        private void btnLuuPdf_Click(object sender, EventArgs e)
        {
            if (pdfBytes == null) return;
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "PDF (*.pdf)|*.pdf";
                dialog.FileName = "HoaDonTienPhat.pdf";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    File.WriteAllBytes(dialog.FileName, pdfBytes);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (previewImage == null) return;
            using (var document = new PrintDocument())
            {
                document.DocumentName = "Hóa đơn tiền phạt";
                document.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
                document.PrintPage += (source, args) =>
                {
                    args.Graphics.DrawImage(previewImage, args.MarginBounds);
                    args.HasMorePages = false;
                };
                using (var dialog = new PrintDialog())
                {
                    dialog.Document = document;
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                        document.Print();
                }
            }
        }

        private void frmReportHoaDonPhat_FormClosed(object sender, FormClosedEventArgs e)
        {
            picHoaDon.Image = null;
            if (previewImage != null) previewImage.Dispose();
        }
    }
}
