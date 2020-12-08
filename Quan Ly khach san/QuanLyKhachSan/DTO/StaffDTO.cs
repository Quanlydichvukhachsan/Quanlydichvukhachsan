using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class StaffDTO
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }

        public string Name { get; set; }
        public int IdCard { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Sex { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime CreateDate { get; set; }

        public string Address { get; set; }

        public int IdStaff { get; set; }

        public List<string> listName = null;
        public string Pass { get; set; }


        public StaffDTO() { listName = new List<string>(); }

        public StaffDTO(string userName, string displayName, string name, int idCard, DateTime ngaySinh, string sex, int phoneNumber, DateTime createDate, string address, int idStaff)
        {
            UserName = userName;
            DisplayName = displayName;
            Name = name;
            IdCard = idCard;
            NgaySinh = ngaySinh;
            Sex = sex;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
            Address = address;
            IdStaff = idStaff;
            
        }

        public StaffDTO(string userName, string displayName, string name, int idCard, DateTime ngaySinh, string sex, int phoneNumber, DateTime createDate, string address, int idStaff,string pass)
        {
            UserName = userName;
            DisplayName = displayName;
            Name = name;
            IdCard = idCard;
            NgaySinh = ngaySinh;
            Sex = sex;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
            Address = address;
            Pass = pass;

        }
        public StaffDTO(DataRow row, DataTable data)
        {

            listName = InitNameColumn.init(data);

            UserName  = row[listName[0]].ToString();
            DisplayName = row[listName[1]].ToString();
            Name = row[listName[2]].ToString();
            IdCard = int.Parse(row[listName[3]].ToString());
            NgaySinh = DateTime.Parse(row[listName[4]].ToString());
            Sex = row[listName[5]].ToString();
            PhoneNumber = int.Parse(row[listName[6]].ToString());
            CreateDate = DateTime.Parse(row[listName[7]].ToString());
            Address = row[listName[8]].ToString();
            IdStaff= int.Parse(row[listName[9]].ToString());
        }
    }
}
