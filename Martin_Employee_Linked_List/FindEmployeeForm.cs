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
        private bool isEditMode = false;

        public FindEmployeeForm()
        {
            InitializeComponent();
        }

        public void SetEditMode()
        {
            isEditMode = true;
        }


        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                this.Hide();
                Employee checkNull = company.FindEmployee(FindLastNameTxtbx.Text, SearchCriteria.LastName);
                if(checkNull != null)
                {
                    EditEmployee editForm = new EditEmployee(checkNull);
                    editForm.ShowDialog();
                }
                else
                {
                    DisplayEmployeeForm display = new DisplayEmployeeForm(checkNull);
                    display.ShowDialog();
                }
                this.Close();
            }
            else
            {
                this.Hide();
                DisplayEmployeeForm display = new DisplayEmployeeForm(company.FindEmployee(FindLastNameTxtbx.Text, SearchCriteria.LastName));
                display.ShowDialog();
                this.Close();
            }
        }

        private void SearchFirstNameBtn_Click(object sender, EventArgs e)
        {

            if (isEditMode)
            {
                this.Hide();
                Employee checkNull = company.FindEmployee(FindFirstNameTxtBx.Text, SearchCriteria.FirstName);
                if(checkNull != null)
                {
                    EditEmployee editForm = new EditEmployee(checkNull);
                    editForm.ShowDialog();
                }
                else
                {
                    DisplayEmployeeForm display = new DisplayEmployeeForm(checkNull);
                    display.ShowDialog();
                }
                this.Close();
            }
            else
            {
                this.Hide();
                DisplayEmployeeForm display = new DisplayEmployeeForm(company.FindEmployee(FindFirstNameTxtBx.Text, SearchCriteria.FirstName));
                display.ShowDialog();
                this.Close();
            }
        }

        private void SearchDepartmentBtn_Click(object sender, EventArgs e)
        {


            if (isEditMode)
            {
                this.Hide();
                Employee checkNull = company.FindEmployee(FindDepartmentTxtBx.Text, SearchCriteria.Department);
                if (checkNull != null)
                {
                    EditEmployee editForm = new EditEmployee(checkNull);
                    editForm.ShowDialog();
                }
                else
                {
                    DisplayEmployeeForm display = new DisplayEmployeeForm(checkNull);
                    display.ShowDialog();
                }
                this.Close();
            }
            else
            {
                this.Hide();
                DisplayEmployeeForm display = new DisplayEmployeeForm(company.FindEmployee(FindDepartmentTxtBx.Text, SearchCriteria.Department));
                display.ShowDialog();
                this.Close();
            }
        }
    }
}
