using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Employee_Linked_List
{
    public class BinaryTree
    {
        public TreeNode Root {  get; private set; }

        public BinaryTree() 
        {
            Root = null;
        }
        public void Insert(Employee employee)
        {
            Root = InsertNode(Root, employee);
        }
        private TreeNode InsertNode(TreeNode root, Employee employee)
        {
            if (root == null)
            {
                root = new TreeNode(employee);
                return root;
            }
            if (employee.GetLastName.CompareTo(root._employee.GetLastName) < 0) 
            { 
                root.Left = InsertNode(root.Left, employee);
            }
            else if (employee.GetLastName.CompareTo(root._employee.GetLastName) > 0)
            {
                root.Right = InsertNode(root.Right, employee);
            }
            return root;
        }
    }
}
