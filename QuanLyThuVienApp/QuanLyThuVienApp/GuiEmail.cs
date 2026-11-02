using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienApp
{
    public static class GuiEmail
    {
        public static string taiKhoan = "nhvu2005@gmail.com";
        public static string matKhau = "rwwp rrag dxte yhii";

        public static bool guiEmail(string emailTo, string content)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var fromAddress = new MailAddress(taiKhoan, "Quan ly thu vien");
            var toAddress = new MailAddress(emailTo, emailTo);
            string fromPassword = matKhau.Replace(" ", "");
            string subject = "Thông báo hệ thống";
            string body = content;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            try
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }catch (Exception ex)
            {
                string error = ex.InnerException != null ? ex.Message + "\nChi tiết: " + ex.InnerException.Message : ex.Message;
                MessageBox.Show(error, "Thông báo lỗi gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
