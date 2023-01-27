namespace DTO_QuanLiStudio
{
    public class DTO_Staff
    {
        //NhanVien(ID,TenNV,SDT,NgaySinh,Email,IDQuocGia,SoCCCD,Enable)
        private int _Staff_ID;
        private string _Staff_NameST;
        private string _Staff_Phone;
        private string _Staff_Email;
        private int _Staff_IDQuocGia;
        private string _Staff_SoCCCD;
        private int _Staff_enable;

        /*=============== GETTER/ SETTER ====================*/
        public int Staff_ID
        {
            get
            {
                return _Staff_ID;
            }
            set
            {
                _Staff_ID=value;
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
        public int enable
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
        /*============= CONSTRUCTOR ======================*/
        public DTO_Staff()
        {

        }
        public DTO_Staff(int staff_ID, string staff_NameST, string staff_Phone, string staff_Email, int staff_IDQuocGia, string staff_SoCCCD, int staff_enable)
        {
            Staff_ID = staff_ID;
            Staff_NameST = staff_NameST;
            Staff_Phone = staff_Phone;
            Staff_Email = staff_Email;
            Staff_IDQuocGia = staff_IDQuocGia;
            Staff_SoCCCD = staff_SoCCCD;
            _Staff_enable = staff_enable;
        }
    }
}
