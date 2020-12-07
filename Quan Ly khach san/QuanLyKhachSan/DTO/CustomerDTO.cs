using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
   public class CustomerDTO
    {
        private readonly int iD_;
        private readonly string iDCard_;
        private readonly int iDCustomerType_;
        private readonly string name_;
        private readonly DateTime dateOfBirth_;
        private readonly string address_;
        private readonly int phoneNumber_;
        private readonly string Sex;
        private readonly string nationality_;
        private readonly string nameCustomer;
        List<string> listName = null;

        public CustomerDTO() { }
        public CustomerDTO(DataRow row, DataTable data)
        {
            listName = InitNameColumn.init(data);
            this.iD_ = int.Parse(row[listName[0]].ToString());
            this.name_ = row[listName[1]].ToString();
            this.iDCard_ = row[listName[2]].ToString();
            this.nameCustomer = row[listName[3]].ToString();
            Sex = row[listName[4]].ToString();
            this.dateOfBirth_ = DateTime.Parse(row[listName[5]].ToString());
            this.phoneNumber_ = int.Parse(row[listName[6]].ToString());
            this.address_ = row[listName[7]].ToString();
            this.nationality_ = row[listName[8]].ToString();
            this.iDCustomerType_ = int.Parse(row[listName[9]].ToString());
        }

        public CustomerDTO(int iD_, string iDCard_, int iDCustomerType_, string name_, DateTime dateOfBirth_, string address_, int phoneNumber_, string sex, string nationality_)
        {
            this.iD_ = iD_;
            this.iDCard_ = iDCard_;
            this.iDCustomerType_ = iDCustomerType_;
            this.name_ = name_;
            this.dateOfBirth_ = dateOfBirth_;
            this.address_ = address_;
            this.phoneNumber_ = phoneNumber_;
            Sex = sex;
            this.nationality_ = nationality_;
        }
        
        public int ID_ => iD_;

        public string IDCard_ => iDCard_;

        public int IDCustomerType_ => iDCustomerType_;

        public string Name_ => name_;

        public DateTime DateOfBirth_ => dateOfBirth_;

        public string Address_ => address_;

        public int PhoneNumber_ => phoneNumber_;

        public string Sex1 => Sex;

        public string Nationality_ => nationality_;
    }
}
