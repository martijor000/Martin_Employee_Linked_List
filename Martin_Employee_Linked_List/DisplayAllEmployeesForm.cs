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
    public partial class DisplayAllEmployeesForm : Form
    {
        public DisplayAllEmployeesForm(List<Employee> employees)
        {
            InitializeComponent();
            CreateObjects(employees);
        }

        private void CreateObjects(List<Employee> employees)
        {
            int xPosition = 10;
            int yPosition = 10;

            foreach (var employee in employees)
            {
                Panel employeePanel = new Panel();
                this.AutoScroll = true;
                employeePanel.BorderStyle = BorderStyle.FixedSingle;
                employeePanel.Size = new Size(300, 200);

                Label label1 = new Label();
                label1.Text = $"Last Name: {employee.GetLastName}";
                label1.AutoSize = true;
                label1.Location = new Point(10, 10);

                Label label2 = new Label();
                label2.Text = $"First Name: {employee.GetFirstName}";
                label2.AutoSize = true;
                label2.Location = new Point(10, 40);

                Label label3 = new Label();
                label3.Text = $"Gender: {employee.GetGender}";
                label3.AutoSize = true;
                label3.Location = new Point(10, 70);

                Label label4 = new Label();
                label4.Text = $"Department: {employee.GetDepartment}";
                label4.AutoSize = true;
                label4.Location = new Point(10, 100);

                Label label5 = new Label();
                label5.Text = $"Salary: {employee.GetSalary}";
                label5.AutoSize = true;
                label5.Location = new Point(10, 130);

                employeePanel.Controls.Add(label1);
                employeePanel.Controls.Add(label2);
                employeePanel.Controls.Add(label3);
                employeePanel.Controls.Add(label4);
                employeePanel.Controls.Add(label5);

                this.Controls.Add(employeePanel);

                employeePanel.Location = new Point(xPosition, yPosition);

                xPosition += employeePanel.Width + 10;

                // Check if the next panel exceeds the form's width
                if (xPosition + employeePanel.Width > this.Width)
                {
                    // If it exceeds, reset xPosition and adjust yPosition
                    xPosition = 10;
                    yPosition += employeePanel.Height + 10;
                }


            }
        }
    }
}
