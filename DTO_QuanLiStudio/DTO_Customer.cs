namespace DTO_QuanLiStudio
{
    public class DTO_Customer
    {
        // KhachHang(ID,TenKH,SDT,Email, Enable, Xa,Huyen,Tinh)
        private int _Customer_ID;
        private string _Customer_Name;
        private string _Customer_Phone;
        private string _Customer_Email;
        private int _Customer_Enable;
        private string _Customer_Xa;
        private string _Customer_Huyen;
        private string _Customer_Tinh;
        private byte[] _Customer_Image;
        /*========================== GETTER/SETTER ============================*/
        //ID
        public int Customer_ID
        {
            get
            {
                return _Customer_ID;
            }
            set
            {
                _Customer_ID = value;
            }
        }

        //Name
        public string Customer_Name
        {
            get
            {
                return _Customer_Name;
            }
            set
            {
                _Customer_Name = value;
            }
        }

        //Phone
        public string Customer_Phone
        {
            get
            {
                return _Customer_Phone;
            }
            set
            {
                _Customer_Phone = value;
            }
        }

        //Email
        public string Customer_Email
        {
            get
            {
                return _Customer_Email;
            }
            set
            {
                _Customer_Email = value;
            }
        }

       

        //Enable
        public int Customer_Enable
        {
            get
            {
                return _Customer_Enable;
            }
            set
            {
                _Customer_Enable = value;
            }
        }

        //Xa
        public string Customer_Xa
        {
            get
            {
                return _Customer_Xa;
            }
            set
            {
                _Customer_Xa = value;
            }
        }

        //Huyen
        public string Customer_Huyen
        {
            get
            {
                return _Customer_Huyen;
            }
            set
            {
                _Customer_Huyen = value;
            }
        }

        //Tinh
        public string Customer_Tinh
        {
            get
            {
                return _Customer_Tinh;
            }
            set
            {
                _Customer_Tinh = value;
            }
        }
        public byte[] Customer_Image
        {
            get 
            {
                return _Customer_Image;
            }
            set
            {
                _Customer_Image = value;
            }
        }
        /*=================== CONSTRUCTOR ==========================*/
        public DTO_Customer()
        {

        }
        public DTO_Customer(int customer_ID, string customer_Name, string customer_Phone, string customer_Email, int customer_Enable, string customer_Xa, string customer_Huyen, string customer_Tinh,byte[] customer_Image)
        {
            Customer_ID = customer_ID;
            Customer_Name = customer_Name;
            Customer_Phone = customer_Phone;
            Customer_Email = customer_Email;
            Customer_Enable = customer_Enable; 
            Customer_Xa = customer_Xa;
            Customer_Huyen = customer_Huyen;
            Customer_Tinh = customer_Tinh;
            Customer_Image = customer_Image;
        }
    }
}
