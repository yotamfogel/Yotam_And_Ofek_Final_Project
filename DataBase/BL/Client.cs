using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_phoneNum;
        private int m_zipCode;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int PhoneNum { get => m_phoneNum; set => m_phoneNum = value; }
        public int ZipCode { get => m_zipCode; set => m_zipCode = value; }
    }
}
