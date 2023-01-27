using DAL_QuanLiStudio;
using DTO_QuanLiStudio;
using System.Data;

namespace BUS_QuanLiStudio
{
    public class BUS_Customer
    {
        DAL_Customer dal_Customer = new DAL_Customer();
        public DataTable getCustomer()
        {
            return dal_Customer.getCustomer();
        }
        public DataTable getCustomer2()
        {
            return dal_Customer.getCustomer2();
        }
        public bool Add_Customer(DTO_Customer ctm)
        {
            return dal_Customer.Add_Customer(ctm);
        }
        public bool Update_Customer(DTO_Customer ctm)
        {
            return dal_Customer.Update_Customer(ctm);
        }
        public bool Delete_Customer(int ID)
        {
            return dal_Customer.Delete_Customer(ID);
        }
        public bool Disable_Customer(int ID)
        {
            return dal_Customer.Disable_Customer(ID);
        }
        public bool Enable_Customer(int ID)
        {
            return dal_Customer.Enable_Customer(ID);
        }
        public bool CheckExist(int ID)
        {
            return dal_Customer.CheckExist(ID);
        }
    }
}
