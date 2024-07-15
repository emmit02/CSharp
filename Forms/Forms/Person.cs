using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace formManipulation
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Full_Name { get; set; }
        public string Year { get; set; }
        public String Course { get; set; }
        public String Branch { get; set; }
        public String Email_Id { get; set; }
        public int PhoneNo { get; set; }

        public Person(string reg_firstname, string reg_lastname, string dg_year, string dg_course, string dg_branch, string reg_email, int reg_phone)
        {
            Full_Name = reg_firstname+" "+reg_lastname;
            Year = dg_year;
            Course = dg_course;
            Branch = dg_branch;
            Email_Id = reg_email;
            PhoneNo = reg_phone;
        }
    }
}
