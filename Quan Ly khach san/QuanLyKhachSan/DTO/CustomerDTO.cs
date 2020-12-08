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
        private  int iD_;
        private  string iDCard_;
        private  int iDCustomerType_;
        private  string name_;
        private  DateTime dateOfBirth_;
        private  string address_;
        private  int phoneNumber_;
        private  string Sex;
        private  string nationality_;

        private  string nameCustomer;

        private  string nameCustomerType;

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

        public CustomerDTO( string iDCard_, int iDCustomerType_, string name_, DateTime dateOfBirth_, string address_, int phoneNumber_, string sex, string nationality_)
        {
           
            this.iDCard_ = iDCard_;
            this.iDCustomerType_ = iDCustomerType_;
            this.name_ = name_;
            this.dateOfBirth_ = dateOfBirth_;
            this.address_ = address_;
            this.phoneNumber_ = phoneNumber_;
            Sex = sex;
            this.nationality_ = nationality_;
        }

        public CustomerDTO(int id,string iDCard_, int iDCustomerType_, string name_, DateTime dateOfBirth_, string address_, int phoneNumber_, string sex, string nationality_)
        {
            this.iD_ = id;
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

        public string NameCustomerType => nameCustomerType;
    }
}
