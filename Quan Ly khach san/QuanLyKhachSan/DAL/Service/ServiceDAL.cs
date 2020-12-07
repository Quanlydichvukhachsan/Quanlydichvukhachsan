using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO.Service;

namespace DAL.Service
{
    public class ServiceDAL : IReposityDAL<ServiceDTO>
    {
        private readonly static ServiceDAL instance;
        public static ServiceDAL Instance { get { if (instance == null) return new ServiceDAL(); return instance; } }
        public List<ServiceDTO> ListService = null;
        public List<ServiceTypeDTO> ListServiceType = null;
        public ServiceDAL() {
            ListService = new List<ServiceDTO>();
            ListServiceType = new List<ServiceTypeDTO>();
        }
        public bool DeleteById( string id)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("delete from Service where ID ="+ id);
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool Insert(ServiceDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertService @name , @idServiceType , @price", new object[] { obj.Name ,obj.IdService,obj.Price  });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool InsertServiceType(ServiceTypeDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertServiceType @name", new object[] { obj.Name });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        public IEnumerable<ServiceDTO> readAll()
        {

            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullService");
            foreach (DataRow row in dataTable.Rows)
            {
                ServiceDTO room = new ServiceDTO(row, dataTable);
                ListService.Add(room);
            }
            return ListService;
        }

        public IEnumerable<ServiceTypeDTO> readAllServiceType()
        {

            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullServiceType");
            foreach (DataRow row in dataTable.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(row, dataTable);
                ListServiceType.Add(service);
            }
            return ListServiceType;
        }

        public bool UpdateById(ServiceDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_UpdateService @id , @name , @idServiceType , @price",
                                                      new object[] { obj.ID, obj.Name, obj.IdService, obj.Price });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool UpdateServiceTypeById(ServiceTypeDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_UpdateServiceType @id , @name",
                                                      new object[] { obj.ID, obj.Name });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
