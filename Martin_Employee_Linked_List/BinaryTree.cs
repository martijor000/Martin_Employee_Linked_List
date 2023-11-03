using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Employee_Linked_List
{
    public class BinaryTree
    {
        public TreeNode Root { get; private set; }

        private int NodeCount;
        private decimal TreeSalary;

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
            if (employee.GetLastName.CompareTo(root._employee.GetLastName) < 0 ||
                (employee.GetLastName.CompareTo(root._employee.GetLastName) == 0) && 
                employee.GetFirstName.CompareTo(root._employee.GetFirstName) < 0

                )
            {
                root.Left = InsertNode(root.Left, employee);
            }
            else if (employee.GetLastName.CompareTo(root._employee.GetLastName) > 0 ||
                employee.GetLastName.CompareTo(root._employee.GetLastName) == 0 &&
                employee.GetFirstName.CompareTo(root._employee.GetFirstName) > 0)
            {
                root.Right = InsertNode(root.Right, employee);
            }
            return root;
        }

        public TreeNode FindNode(string lastName, SearchCriteria searchCriteria)
        {
            return FindNodeRecursive(Root, lastName, searchCriteria);
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
                    comparisonResult = searchValue.ToLower().CompareTo(node._employee.GetLastName.ToLower());
                    break;
                case SearchCriteria.FirstName:
                    comparisonResult = searchValue.ToLower().CompareTo(node._employee.GetFirstName.ToLower());
                    break;
                case SearchCriteria.Department:
                    comparisonResult = searchValue.ToLower().CompareTo(node._employee.GetDepartment.ToLower());
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


        public void Delete(Employee employee)
        {
            Root = DeleteNode(Root, employee);
        }

        private TreeNode DeleteNode(TreeNode root, Employee employee)
        {
            if (root == null)
                return null;

            int comparisonResult = employee.GetLastName.ToLower().CompareTo(root._employee.GetLastName.ToLower());

            if (comparisonResult < 0)
            {
                root.Left = DeleteNode(root.Left, employee);
            }
            else if (comparisonResult > 0)
            {
                root.Right = DeleteNode(root.Right, employee);
            }
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                TreeNode temp = FindMin(root.Right);
                root._employee = temp._employee;
                root.Right = DeleteNode(root.Right, temp._employee);
            }

            return root;
        }

        private TreeNode FindMin(TreeNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public List<Employee> ReturnAllEmployeeNodes()
        {
            return ReturnAllEmployeeNodes(Root);
        }

        private List<Employee> ReturnAllEmployeeNodes(TreeNode node)
        {
            List<Employee> employeeList = new List<Employee>();

            if (node != null)
            {
                // Traverse left subtree
                employeeList.AddRange(ReturnAllEmployeeNodes(node.Left));

                // Add current node's employee to the list
                employeeList.Add(node._employee);

                // Traverse right subtree
                employeeList.AddRange(ReturnAllEmployeeNodes(node.Right));
            }

            return employeeList;
        }

        public int CalculateNodeCount()
        {
            return CalculateNodeCountRecursive(Root);
        }

        private int CalculateNodeCountRecursive(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + CalculateNodeCountRecursive(node.Left) + CalculateNodeCountRecursive(node.Right);
        }

        public decimal CalculateTreeSalary()
        {
            return CalculateTreeSalaryRecursive(Root);
        }

        private decimal CalculateTreeSalaryRecursive(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return node._employee.GetSalary + CalculateTreeSalaryRecursive(node.Left) + CalculateTreeSalaryRecursive(node.Right);
        }
    }
}
