using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martin_Employee_Linked_List
{
    public partial class FindEmployeeForm : Form
    {
        private Company company = Company.Instance;
        public FindEmployeeForm()
        {
            InitializeComponent();
        }

        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayEmployeeForm display = new DisplayEmployeeForm(company.FindEmployee(FindLastNameTxtbx.Text, SearchCriteria.LastName));
            display.ShowDialog();
            this.Close();
        }

        private void SearchFirstNameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayEmployeeForm display = new DisplayEmployeeForm(company.FindEmployee(FindFirstNameTxtBx.Text, SearchCriteria.FirstName));
            display.ShowDialog();
            this.Close();
        }

        private void SearchDepartmentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayEmployeeForm display = new DisplayEmployeeForm(company.FindEmployee(FindDepartmentTxtBx.Text, SearchCriteria.Department));
            display.ShowDialog();
            this.Close();
        }
    }
}
