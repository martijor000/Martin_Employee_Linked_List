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
    public partial class EmployeeForm : Form
    {
        private Company company = Company.Instance;

        public EmployeeForm()
        {
            InitializeComponent();
            GenderCmbBx.Items.Add("M");
            GenderCmbBx.Items.Add("F");
            GenderCmbBx.Text = GenderCmbBx.Items[0].ToString();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(LastNameTxtBx.Text, FirstNameTxtBx.Text, GenderCmbBx.Text, DepartmentTxtBx.Text, ConvertSalary(SalaryTxtBx.Text));
            company.AddEmployee(employee);
            this.Close();
        }

        private decimal ConvertSalary(string salaryText)
        {
            if (decimal.TryParse(salaryText, out decimal salary))
            {
                return salary;
            }
            return 0;
        }
    }
}
