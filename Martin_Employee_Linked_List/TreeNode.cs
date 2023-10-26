using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Employee_Linked_List
{
    public class TreeNode
    {
        public Employee _employee;
        public TreeNode Right;
        public TreeNode Left;

        public TreeNode(Employee employee) 
        {
            _employee = employee;
            Right = null;
            Left = null;
        }
    }
}
