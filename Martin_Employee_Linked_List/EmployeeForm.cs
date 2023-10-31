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
            GenderCmbBx.Items.Add("Male");
            GenderCmbBx.Items.Add("Female");
            GenderCmbBx.Text = GenderCmbBx.Items[0].ToString();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(LastNameTxtBx.Text, FirstNameTxtBx.Text, GenderCmbBx.Text, DepartmentTxtBx.Text, Decimal.Parse(SalaryTxtBx.Text));
            company.AddEmployee(employee);
            this.Close();
        }
    }
}
