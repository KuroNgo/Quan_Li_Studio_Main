namespace DTO_QuanLiStudio
{
    public class DTO_Service
    {
        //DichVu(ID,TenGoiQuay,LoaiGoiQuay,DonGia,SoNguoiQuay,Mota,Enable)
        private int _DichVu_ID;
        private string _DichVu_Name;
        private int _DichVu_CategoryService;
        private double _DichVu_Price;
        private int _DichVu_PhotographerNumber;
        private string _DichVu_Content;
        private int _DichVu_Enable;
        /*====================== GETTER/ SETTER ===========================*/
        //ID
        public int DichVu_ID
        {
            get
            {
                return _DichVu_ID;
            }
            set
            {
                _DichVu_ID = value;
            }
        }

        //Name
        public string DichVu_Name
        {
            get
            {
                return _DichVu_Name;
            }
            set
            {
                _DichVu_Name = value;
            }
        }

        //Price
        public double DichVu_Price
        {
            get
            {
                return _DichVu_Price;
            }
            set
            {
                _DichVu_Price = value;
            }
        }

        //Photographer_Number
        public int DichVu_PhotographerNumber
        {
            get
            {
                return _DichVu_PhotographerNumber;
            }
            set
            {
                _DichVu_PhotographerNumber = value;
            }
        }

        //Category_Serive
        public int DichVu_CategoryService
        {
            get
            {
                return _DichVu_CategoryService;
            }
            set
            {
                _DichVu_CategoryService = value;
            }
        }

        //Enable
        public int DichVu_Enable
        {
            get
            {
                return _DichVu_Enable;
            }
            set
            {
                _DichVu_Enable = value;
            }
        }

        //Content
        public string DichVu_Content
        {
            get 
            {
                return _DichVu_Content;
            }
            set
            { _DichVu_Content = value;}
        }

        /*============ CONSTRUCTOR =====================*/
        public DTO_Service()
        {

        }
        public DTO_Service(int dichVu_ID, string dichVu_Name, int dichVu_CategoryService, double dichVu_Price , int dichVu_PhotographerNumber,   string dichVu_Content, int dichVu_Enable)
        {
            DichVu_ID = dichVu_ID;
            DichVu_Name = dichVu_Name;
            DichVu_CategoryService = dichVu_CategoryService;
            DichVu_Price = dichVu_Price;
            DichVu_PhotographerNumber = dichVu_PhotographerNumber;
            DichVu_Content = dichVu_Content;
            DichVu_Enable = dichVu_Enable;
        }
    }
}
