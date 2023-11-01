using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Martin_Employee_Linked_List
{
    public class Company
    {
        private static Company instance;
        private Dictionary<char, BinaryTree> AlphaTree = new Dictionary<char, BinaryTree>();
        private string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     
        public Company() 
        {
            foreach (char c in _alphabet)
            {
                AlphaTree.Add(c, new BinaryTree());
            }
        }
        public static Company Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Company();
                }
                return instance;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (AlphaTree.ContainsKey(employee.GetLastName[0]))
            {
                AlphaTree[employee.GetLastName[0]].Insert(employee);
            }
        }

        public Employee FindEmployee(string searchValue, SearchCriteria criteria)
        {
            if (criteria == SearchCriteria.LastName && AlphaTree.ContainsKey(searchValue[0]))
            {
                TreeNode node = AlphaTree[searchValue[0]].FindNode(searchValue, criteria);
                return node._employee;
            }

            // If the search criteria is not last name we iterate through each branch for first name or department
            foreach (var kvp in AlphaTree)
            {
                TreeNode node = kvp.Value.FindNode(searchValue, criteria);
                if (node != null)
                {
                    return node._employee;
                }
            }

            return null;
        }

        public Decimal AverageSalaryEmployees()
        {
            decimal total = 0;
            int totalNodes = 0;

            foreach (var kvp in AlphaTree)
            {
                total += kvp.Value.GetTreeSalary;
                totalNodes += kvp.Value.GetNodeCount; 
            }

            return total / totalNodes;
        }
    }
}
