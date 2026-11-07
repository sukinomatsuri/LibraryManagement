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
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }
     
        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            // Mặc định chọn câu hỏi đầu tiên khi mở form
            label1_Click(null, null);
        }

        private void SetActiveQuestion(Label activeLabel)
        {
            Label[] questions = { label1, label2, label3, label4, label5, label6 };
            foreach (var lbl in questions)
            {
                lbl.BackColor = Color.White;
                lbl.ForeColor = Color.FromArgb(30, 41, 59);
            }

            // Highlight câu hỏi đang được chọn
            activeLabel.BackColor = Color.FromArgb(219, 234, 254);
            activeLabel.ForeColor = Color.FromArgb(29, 78, 216);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetActiveQuestion(label1);
            lblAnswerTitle.Text = "HƯỚNG DẪN: ĐĂNG KÝ MƯỢN SÁCH";
            richTextBox1.Text = "📌 Bước 1: Nhấn vào mục 'Đăng ký mượn sách' trên thanh điều hướng.\n\n" +
                               "📌 Bước 2: Tìm kiếm cuốn sách bạn muốn mượn, chọn nút 'Đăng ký' để thêm vào danh sách mượn.\n\n" +
                               "📌 Bước 3: Kiểm tra lại danh sách các cuốn sách đã chọn, nhấn 'Xác nhận Đăng ký' để gửi yêu cầu.\n\n" +
                               "⚠️ Lưu ý quan trọng:\n" +
                               "• Vui lòng đến thư viện để nhận sách trong vòng 05 ngày kể từ ngày đăng ký thành công.\n" +
                               "• Sau 05 ngày nếu bạn không đến lấy sách, hệ thống sẽ tự động hủy phiếu đăng ký mượn.";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SetActiveQuestion(label2);
            lblAnswerTitle.Text = "QUY ĐỊNH: XỬ LÝ TRẢ SÁCH QUÁ HẠN";
            richTextBox1.Text = "📌 Quy định tính phí phạt trả muộn:\n\n" +
                               "• Mức phí phạt được tính theo công thức: 1.000 VNĐ / 01 ngày quá hạn / 01 cuốn sách.\n\n" +
                               "• Khi trả sách quá hạn, hệ thống sẽ tự động lập Phiếu phạt và in Hóa đơn phạt tương ứng.\n\n" +
                               "⚠️ Biện pháp kỷ luật:\n" +
                               "• Nếu bạn đọc để sách quá hạn kéo dài hoặc có dấu hiệu làm hư hỏng, thất lạc sách, thủ thư có quyền khóa tài khoản bạn đọc và ghi nhận vào hồ sơ vi phạm.";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SetActiveQuestion(label3);
            lblAnswerTitle.Text = "QUY ĐỊNH: GIA HẠN THỜI GIAN MƯỢN SÁCH";
            richTextBox1.Text = "📌 Quy trình gia hạn thời gian mượn sách:\n\n" +
                               "• Để đảm bảo tính công bằng cho tất cả độc giả và quản lý số lượng sách tồn kho chính xác, ứng dụng hiện tại chỉ hỗ trợ xem hạn trả.\n\n" +
                               "• Bạn đọc có nhu cầu gia hạn thêm thời gian mượn vui lòng mang sách trực tiếp đến quầy thủ thư của thư viện để được hỗ trợ gia hạn nhanh chóng.";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SetActiveQuestion(label4);
            lblAnswerTitle.Text = "HỖ TRỢ: QUÊN MẬT KHẨU HOẶC THAY ĐỔI EMAIL";
            richTextBox1.Text = "📌 Cách 1: Đặt lại mật khẩu tự động qua Email:\n" +
                               "• Tại màn hình Đăng nhập, bấm vào 'Quên mật khẩu?'.\n" +
                               "• Nhập Email bạn đã đăng ký để nhận mã OTP xác thực, sau đó tiến hành tạo mật khẩu mới.\n\n" +
                               "📌 Cách 2: Hỗ trợ trực tiếp tại quầy:\n" +
                               "• Nếu bạn quên cả tài khoản và email, vui lòng mang thẻ sinh viên / CCCD đến gặp Thủ thư.\n" +
                               "• Quản trị viên thư viện sẽ hỗ trợ reset mật khẩu hoặc liên kết địa chỉ email mới cho bạn.";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SetActiveQuestion(label5);
            lblAnswerTitle.Text = "DÀNH CHO THỦ THƯ: CHO MƯỢN SÁCH TRỰC TIẾP";
            richTextBox1.Text = "📌 Quy trình lập phiếu mượn tại quầy:\n\n" +
                               "1. Chọn chức năng 'Quản lý phiếu' trên menu chính.\n\n" +
                               "2. Tại màn hình danh sách phiếu, nhấn nút 'Mượn mới'.\n\n" +
                               "3. Tìm kiếm và chọn Bạn đọc cần mượn (nếu bạn đọc chưa có thẻ, hãy tạo tài khoản mới trước).\n\n" +
                               "4. Chọn các cuốn sách bạn đọc muốn mượn.\n\n" +
                               "5. Kiểm tra thời hạn mượn và nhấn 'Cho mượn' để hoàn tất lập phiếu.";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            SetActiveQuestion(label6);
            lblAnswerTitle.Text = "DÀNH CHO THỦ THƯ: TẠO TÀI KHOẢN BẠN ĐỌC MỚI";
            richTextBox1.Text = "📌 Hướng dẫn cấp tài khoản bạn đọc mới:\n\n" +
                               "1. Truy cập menu 'Quản lý bạn đọc'.\n\n" +
                               "2. Điền đầy đủ thông tin: Họ tên, Tên đăng nhập, Email bạn đọc.\n\n" +
                               "3. Bấm 'Gửi mã OTP' để xác thực chính chủ hòm thư của bạn đọc.\n\n" +
                               "4. Sau khi nhập đúng mã OTP, bấm 'Đăng ký'.\n\n" +
                               "• Hệ thống sẽ tự động tạo mật khẩu ngẫu nhiên an toàn và gửi về hộp thư điện tử của bạn đọc.";
        }
    }
}
