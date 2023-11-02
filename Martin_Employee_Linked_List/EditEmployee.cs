using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martin_Employee_Linked_List
{
    public partial class EditEmployee : Form
    {
        private Employee _employee;
        private Employee _editedEmployee;

        public EditEmployee(Employee _editemployee)
        {
            InitializeComponent();
            EditFirstNameTxtbx.Text = _editemployee.GetFirstName;
            EditLastNameTxtbx.Text = _editemployee.GetLastName;
            EditGenderCmb.Items.Add("F");
            EditGenderCmb.Items.Add("M");
            EditDepartmentTxtbx.Text = _editemployee.GetDepartment;
            EditSalaryTxtbx.Text = _editemployee.GetSalary.ToString();
            _employee = _editemployee;
            _editedEmployee = _employee;
        }

        public void DeleteBtn_Click(object sender, EventArgs e)
        {
            Company.Instance.DeleteEmployee(_employee);
            this.Close();
        }

        public void SaveBtn_Click(object sender, EventArgs e)
        {
            _editedEmployee.GetFirstName = EditFirstNameTxtbx.Text;
            _editedEmployee.GetLastName = EditLastNameTxtbx.Text;
            _editedEmployee.GetGender = EditGenderCmb.Text;
            _editedEmployee.GetDepartment = EditDepartmentTxtbx.Text;
            _editedEmployee.GetSalary = Convert.ToDecimal(EditSalaryTxtbx.Text);
            Company.Instance.SaveEditedEmployee(_employee, _editedEmployee);
            this.Close();
        }
    }
}
