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
    public partial class DisplayEmployeeForm : Form
    {

        public DisplayEmployeeForm(Employee _displayemployee)
        {
            InitializeComponent();
            DisplayFirstNameLbl.Text = _displayemployee.GetFirstName;
            DisplayLastNameLbl.Text = _displayemployee.GetLastName;
            DisplayGenderLbl.Text = _displayemployee.GetGender;
            DisplayDepartmentLbl.Text = _displayemployee.GetDepartment;
            DisplaySalaryLbl.Text = _displayemployee.GetSalary.ToString("C");
        }

        private void DisplayEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
