using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Employee_Linked_List
{
    public class Employee
    {
        private string _lastname;
        private string _firstname;
        private string _gender;
        private string _department;
        private decimal _salary;
        public Employee(string lastname, string firstname, string gender, string department, decimal salary)
        {
            _lastname = lastname;
            _firstname = firstname;
            _gender = gender;
            _department = department;
            _salary = salary;
        }

        public string GetLastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string GetFirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string GetGender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string GetDepartment
        {
            get { return _department; }
            set { _department = value; }
        }

        public decimal GetSalary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}
