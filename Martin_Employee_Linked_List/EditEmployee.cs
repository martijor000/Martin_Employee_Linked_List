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
        public EditEmployee(Employee _editemployee)
        {
            InitializeComponent();
            EditFirstNameTxtbx.Text = _editemployee.GetFirstName;
            EditLastNameTxtbx.Text = _editemployee.GetLastName;
            EditGenderCmb.Text = _editemployee.GetGender;
            EditDepartmentTxtbx.Text = _editemployee.GetDepartment;
            EditSalaryTxtbx.Text = _editemployee.GetSalary.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
