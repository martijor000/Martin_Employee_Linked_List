using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Employee_Linked_List
{
    public class Company
    {
        private Dictionary<char, BinaryTree> AlphaTree = new Dictionary<char, BinaryTree>();
        private string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     
        public Company() 
        {
            foreach (char c in _alphabet)
            {
                AlphaTree.Add(c, new BinaryTree());
            }
        }
        public void AddEmployee(Employee employee)
        {
            if (AlphaTree.ContainsKey(employee.GetLastName[0]))
            {
                AlphaTree[employee.GetLastName[0]].Insert(employee);
            }
        }
        public Employee FindEmployee(string lastname)
        {
            if (AlphaTree.ContainsKey(lastname[0]))
            {
                Employee employee = AlphaTree[lastname[0]].Root._employee;
                return employee;
            }
            return null;
        }
    }
}
