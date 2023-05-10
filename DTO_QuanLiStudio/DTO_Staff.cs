using System;

namespace DTO_QuanLiStudio
{
    public class DTO_Staff
    {
        //NhanVien(ID,TenNV,SDT,NgaySinh,Email,IDQuocGia,SoCCCD,Enable,GioiTinh,Luong,LoaiMucLuong,TinhTrangLamViec,NgayThoiViec,NgayVaoLam,ThongTinHopDong,LyDoThoiViec)
        private int _Staff_ID;
        private string _Staff_NameST;
        private string _Staff_Phone;
        private DateTime _DateTime_Staff_Date;
        private string _Staff_Email;
        private int _Staff_IDQuocGia;
        private string _Staff_SoCCCD;
        private int _Staff_enable;
        private string _Staff_Xa;
        private string _Staff_Huyen;
        private string _Staff_Tinh;
        private string _Staff_GioiTinh;
        private float _Staff_Luong;
        private string _Staff_LoaiMucLuong;
        private string _Staff_TinhTrangLamViec;
        private DateTime _Staff_NgayThoiViec;
        private DateTime _Staff_NgayVaoLam;
        private string _Staff_ThongTinHopDong;
        private string _Staff_LyDoThoiViec;
        /*=============== GETTER/ SETTER ====================*/
        public int Staff_ID
        {
            get
            {
                return _Staff_ID;
            }
            set
            {
                _Staff_ID = value;
            }
        }
        public string Staff_NameST
        {
            get
            {
                return _Staff_NameST;
            }
            set
            {
                _Staff_NameST = value;
            }
        }
        public string Staff_Phone
        {
            get
            {
                return _Staff_Phone;
            }
            set { _Staff_Phone = value; }
        }
        public DateTime DateTime_Staff_Date
        {
            get
            {
                return _DateTime_Staff_Date;
            }
            set
            {
                _DateTime_Staff_Date = value;
            }
        }
        public string Staff_Email
        {
            get { return _Staff_Email; }
            set
            {
                _Staff_Email = value;
            }
        }
        public int Staff_IDQuocGia
        {
            get
            {
                return _Staff_IDQuocGia;
            }
            set
            {
                _Staff_IDQuocGia = value;
            }
        }
        public string Staff_SoCCCD
        {
            get
            {
                return _Staff_SoCCCD;
            }
            set
            {
                _Staff_SoCCCD = value;
            }
        }
        public int Staff_enable
        {
            get
            {
                return _Staff_enable;
            }
            set
            {
                _Staff_enable = value;
            }
        }
        //Xa
        public string Staff_Xa
        {
            get
            {
                return _Staff_Xa;
            }
            set
            {
                _Staff_Xa = value;
            }
        }

        //Huyen
        public string Staff_Huyen
        {
            get
            {
                return _Staff_Huyen;
            }
            set
            {
                _Staff_Huyen = value;
            }
        }

        //Tinh
        public string Staff_Tinh
        {
            get
            {
                return _Staff_Tinh;
            }
            set
            {
                _Staff_Tinh = value;
            }
        }

        public string Staff_GioiTinh
        {
            get
            {
                return _Staff_GioiTinh;
            }
            set
            {
                _Staff_GioiTinh= value;
            }
        }
        public float Staff_Luong
        {
            get
            {
                return _Staff_Luong;
            }
            set
            {
                _Staff_Luong = value;
            }
        }
        public string Staff_LoaiMucLuong
        {
            get
            {
                return _Staff_LoaiMucLuong;
            }
            set
            {
                _Staff_LoaiMucLuong = value;
            }
        }
        public string Staff_TinhTrangLamViec
        {
            get
            {
                return _Staff_TinhTrangLamViec;
            }
            set
            {
                _Staff_TinhTrangLamViec = value;
            }
        }
        public DateTime Staff_NgayThoiViec
        {
            get
            {
                return _Staff_NgayThoiViec;
            }
            set
            {
                _Staff_NgayThoiViec = value;
            }
        }
        public DateTime Staff_NgayVaoLam
        {
            get
            {
                return _Staff_NgayVaoLam;
            }
            set
            {
                _Staff_NgayVaoLam = value;
            }
        }
        public string Staff_ThongTinHopDong
        {
            get
            {
                return _Staff_ThongTinHopDong;
            }
            set
            {
                _Staff_ThongTinHopDong = value;
            }
        }
        public string Staff_LyDoThoiViec
        {
            get
            {
                return _Staff_LyDoThoiViec;
            }
            set
            {
                _Staff_LyDoThoiViec = value;
            }
        }
        /*============= CONSTRUCTOR ======================*/
        public DTO_Staff()
        {

        }
        public DTO_Staff(int staff_ID, string staff_NameST, string staff_Phone, DateTime dateTime_Staff_Date, string staff_Email, int staff_IDQuocGia, string staff_SoCCCD, int staff_enable, string staff_Xa, string staff_Huyen, string staff_Tinh,string staff_GioiTinh,float staff_Luong,string staff_LoaiMucLuong, string staff_TinhTrangLamViec, DateTime staff_NgayThoiViec,DateTime staff_NgayVaoLam,string staff_ThongTinHopDong,string staff_LyDoThoiViec)
        {
            Staff_ID = staff_ID;
            Staff_NameST = staff_NameST;
            Staff_Phone = staff_Phone;
            DateTime_Staff_Date = dateTime_Staff_Date;
            Staff_Email = staff_Email;
            Staff_IDQuocGia = staff_IDQuocGia;
            Staff_SoCCCD = staff_SoCCCD;
            Staff_enable = staff_enable;
            Staff_Xa = staff_Xa;
            Staff_Huyen = staff_Huyen;
            Staff_Tinh = staff_Tinh;
            Staff_Luong= staff_Luong;
            Staff_LoaiMucLuong = staff_LoaiMucLuong;
            Staff_TinhTrangLamViec = staff_TinhTrangLamViec;
            Staff_NgayThoiViec = staff_NgayThoiViec;
            Staff_NgayVaoLam= staff_NgayVaoLam;
            Staff_ThongTinHopDong = staff_ThongTinHopDong;
            Staff_LyDoThoiViec = staff_LyDoThoiViec;
        }
    }
}
