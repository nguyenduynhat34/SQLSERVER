using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.v1
{
    static class Message
    {
        //Error messages
        public static string E001 = "Tên đăng nhập hoặc mật khẩu không chính xác";
        public static string E002 = "Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n";
        public static string E004 = "Thông tin đã được đăng ký.";
        public static string E005 = "Thông tin nhập chưa chính xác";
        public static string E006 = "Mã nhập đã tồn tại";
        public static string E007 = "Không lấy được dữ liệu";
        public static string E008 = "Mã nhập không tồn tại";

        //Info messages
        public static string I005 = "Xóa thành công";
    }

    static class Params
    {
        public static string ISBN = " ISBN";
        public static string TEN_SACH = " Tên sách";
        public static string MA_TAC_GIA = " Mã tác giả";
        public static string MA_NGON_NGU = " Mã ngôn ngữ";
        public static string MA_THE_LOAI = " Mã thể loại";
        public static string MA_SACH = " Mã sách";
        public static string MA_NGAN_TU = " Mã ngăn tủ";
        public static string MA_DOC_GIA = " Mã độc giả";
    }
}
