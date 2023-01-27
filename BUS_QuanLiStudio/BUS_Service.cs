using DAL_QuanLiStudio;
using DTO_QuanLiStudio;
using System.Data;

namespace BUS_QuanLiStudio
{
    public class BUS_Service
    {
        DAL_Service dal_service = new DAL_Service();
        #region Get Information of Service
        //Get service
        public DataTable getService()
        {
            return dal_service.getService();
        }
        public DataTable getCategoryService()
        {
            return dal_service.getCategoryService();
        }
        public DataTable getServiceOfDisabled()
        {
            return dal_service.getServiceOfDisabled();
        }

        #endregion
        #region Add
        //Add service
        public bool AddService(DTO_Service sv)
        {
            return dal_service.AddService(sv);
        }
        #endregion
        #region Update
        //Update Service
        public bool UpdateService(DTO_Service sv)
        {
            return dal_service.UpdateService(sv);
        }
        #endregion
        #region Delete
        //Del service
        public bool DeleteService(int sv_ID)
        {
            return dal_service.DeleteService(sv_ID);
        }
        #endregion
        #region Disable
        //Disable
        public bool DisableService(int ID)
        {
            return dal_service.Disable(ID);
        }
        public bool EnableService(int ID)
        {
            return dal_service.Enable(ID);
        }
        #endregion
        #region Search
        //Search to Photographer Number
        public bool Search_PhotographerNumber(int soNguoiQuay)
        {
            return dal_service.Search_PhotographerNumber(soNguoiQuay);
        }
        //Search to Name
        public bool SearchName(string text)
        {
            return dal_service.SearchName(text);
        }

        //Search to Price
        public bool SearchPrice(float num)
        {
            return dal_service.SearchPrice(num);
        }
        #endregion
        public bool CheckExist(int ID)
        {
            return dal_service.CheckExist(ID);
        }

    }
}
