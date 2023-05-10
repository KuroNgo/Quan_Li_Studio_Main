using DAL_QuanLiStudio;
using DTO_QuanLiStudio;
using System.Data;

namespace BUS_QuanLiStudio
{
    public class BUS_Staff
    {
        DAL_Staff dAL_Staff = new DAL_Staff();
        public DataTable getStaff()
        {
            return dAL_Staff.getStaff();
        }
        public DataTable getStaff2()
        {
            return dAL_Staff.getStaff2();
        }
        public bool Add_Staff(DTO_Staff stf)
        {
            return dAL_Staff.Add_Staff(stf);
        }
        public bool Update_Staff(DTO_Staff stf)
        {
            return dAL_Staff.Update_Staff(stf);
        }
        //public bool Delete_Customer(int ID)
        //{
        //    return dal_Customer.Delete_Customer(ID);
        //}
        public bool Disable_Staff(int ID)
        {
            return dAL_Staff.Disable_Staff(ID);
        }
        public bool Enable_Staff(int ID)
        {
            return dAL_Staff.Enable_Staff(ID);
        }
        public bool CheckExist(int ID)
        {
            return dAL_Staff.CheckExist(ID);
        }
    }
}
