using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Employee_Linked_List
{
    public class BinaryTree
    {
        public TreeNode Root { get; private set; }

        private int NodeCount;
        private decimal TreeSalary;

        public int GetNodeCount
        {
            get { return NodeCount; }
            set { NodeCount = value; }
        }

        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(Employee employee)
        {
            Root = InsertNode(Root, employee);
            NodeCount = NodeCount + 1;
            TreeSalary = TreeSalary + employee.GetSalary;
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

        public TreeNode FindNode(string lastName, SearchCriteria searchCriteria)
        {
            return FindNodeRecursive(Root, lastName, searchCriteria);
        }

        public decimal GetTreeSalary
        {
            get { return TreeSalary; }
            set { TreeSalary = value; }
        }

        private TreeNode FindNodeRecursive(TreeNode node, string searchValue, SearchCriteria searchCriteria)
        {
            if (node == null)
            {
                return null; // Node not found
            }

            int comparisonResult;

            switch (searchCriteria)
            {
                case SearchCriteria.LastName:
                    comparisonResult = searchValue.CompareTo(node._employee.GetLastName);
                    break;
                case SearchCriteria.FirstName:
                    comparisonResult = searchValue.CompareTo(node._employee.GetFirstName);
                    break;
                case SearchCriteria.Department:
                    comparisonResult = searchValue.CompareTo(node._employee.GetDepartment);
                    break;
                default:
                    throw new ArgumentException("Invalid search criteria.");
            }

            if (comparisonResult == 0)
            {
                return node; // Node found
            }
            else if (comparisonResult < 0)
            {
                return FindNodeRecursive(node.Left, searchValue, searchCriteria); // Search left subtree
            }
            else
            {
                return FindNodeRecursive(node.Right, searchValue, searchCriteria); // Search right subtree
            }
        }
    }
}
