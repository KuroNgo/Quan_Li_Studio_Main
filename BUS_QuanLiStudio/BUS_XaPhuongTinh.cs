using DAL_QuanLiStudio;
using System.Data;

namespace BUS_QuanLiStudio
{
    public class BUS_XaPhuongTinh
    {
        DAL_XaPhuongTinh dAL_XaPhuongTinh = new DAL_XaPhuongTinh();
        public DataTable getTinh()
        {
            return dAL_XaPhuongTinh.getTinh();
        }
        public DataTable getHuyen(string maTinh)
        {
            return dAL_XaPhuongTinh.getHuyen(maTinh);
        }
        public DataTable getXa(string maHuyen)
        {
            return dAL_XaPhuongTinh.getXa(maHuyen);
        }
       
    }
}
