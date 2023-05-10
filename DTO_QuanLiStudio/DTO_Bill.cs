using System;

namespace DTO_QuanLiStudio
{
    public class DTO_Bill
    {
        // HoaDon(ID,ngaylap,ngayTra, TienCoc, SoTienConLai, MaNV,MaKH, TongTien, GiamGia, Enable)
        private int _HoaDon_ID;
        private DateTime _HoaDon_ngayLap;
        private DateTime _HoaDon_ngayTra;
        private double _HoaDon_TienCoc;
        private double _HoaDon_SoTienConLai;
        private double _HoaDon_TongTien;
        private float _HoaDon_GiamGia;
        private int _HoaDon_Enable;

        public int HoaDon_ID
        {
            get
            {
                return _HoaDon_ID;
            }
            set
            {
                _HoaDon_ID = value;
            }
        }

        public DateTime HoaDon_ngayLap
        {
            get
            {
                return _HoaDon_ngayLap;
            }
            set
            {
                _HoaDon_ngayLap = value;
            }
        }
        public DateTime HoaDon_ngayTra
        {
            get
            {
                return _HoaDon_ngayTra;
            }
            set
            {
                _HoaDon_ngayTra= value;
            }
        }
        public double HoaDon_TienCoc
        {
            get
            {
                return _HoaDon_TienCoc;
            }
            set
            {
                _HoaDon_TienCoc = value;
            }
        }
        public double HoaDon_SoTienConLai
        {
            get
            {
                return _HoaDon_SoTienConLai;
            }
            set
            {
                _HoaDon_SoTienConLai = value;
            }
        }

        public double HoaDon_TongTien
        {
            get
            {
                return _HoaDon_TongTien;
            }
            set
            {
                _HoaDon_TongTien= value;
            }
        }
        public float HoaDon_GiamGia
        {
            get
            {
                return _HoaDon_GiamGia;
            }
            set
            {
                _HoaDon_GiamGia = value;
            }
        }
        public int HoaDon_Enable
        {
            get
            {
                return _HoaDon_Enable;
            }
            set
            {
                _HoaDon_Enable = value;
            }
        }

        public DTO_Bill()
        {

        }
        public DTO_Bill(int hoaDon_ID, DateTime hoaDon_ngayLap, DateTime hoaDon_ngayTra, double hoaDon_TienCoc, double hoaDon_SoTienConLai,double hoaDon_TongTien, float hoaDon_GiamGia, int hoaDon_Enable)
        {
            HoaDon_ID = hoaDon_ID;
            HoaDon_ngayLap = hoaDon_ngayLap;
            HoaDon_ngayTra = hoaDon_ngayTra;
            HoaDon_TienCoc = hoaDon_TienCoc;
            HoaDon_SoTienConLai = hoaDon_SoTienConLai;
            HoaDon_TongTien = hoaDon_TongTien;
            HoaDon_GiamGia = hoaDon_GiamGia;
            HoaDon_Enable = hoaDon_Enable;
        }
    }
}
