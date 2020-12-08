using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class StaffDAL : IReposityDAL<StaffDTO>
    {

        private readonly static StaffDAL instance;
        public static StaffDAL Instance { get { if (instance == null) return new StaffDAL(); return instance; } }
        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }
        private List<StaffDTO> listStaff = null;

        public bool Insert(StaffDTO obj)
        {

            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertStaff @user , @name , @pass , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber @startDay",
                                                      new object[] { obj.UserName, obj.Name, obj.Pass, obj.IdStaff , obj.IdCard , obj.NgaySinh , obj.Sex , obj.Address ,obj.PhoneNumber , obj.CreateDate });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public StaffDAL() { listStaff = new List<StaffDTO>(); }

        public IEnumerable<StaffDTO> readAll()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullStaff");
            foreach (DataRow row in dataTable.Rows)
            {
                StaffDTO staff = new StaffDTO(row, dataTable);
                listStaff.Add(staff);
            }
            return listStaff;

        }

        public bool UpdateById(StaffDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertStaff @user , @name , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber @startDay",
                                                      new object[] { obj.UserName, obj.Name,  obj.IdStaff, obj.IdCard, obj.NgaySinh, obj.Sex, obj.Address, obj.PhoneNumber, obj.CreateDate });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
