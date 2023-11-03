using CsvHelper;
using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;

namespace Martin_Employee_Linked_List
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private decimal ConvertSalary(string salaryText)
        {
            // Remove dollar sign and commas, and convert to decimal
            salaryText = salaryText.Replace("$", "").Replace(",", "").Trim();
            if (decimal.TryParse(salaryText, out decimal salary))
            {
                return salary;
            }
            return 0;
        }

        private void FindEmpBtn_Click(object sender, EventArgs e)
        {
            FindEmployeeForm findEmployeeForm = new FindEmployeeForm();
            this.Hide();
            findEmployeeForm.ShowDialog();
            this.Show();
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            this.Hide();
            empForm.ShowDialog();
            this.Show();
        }

        private void DisplayAvgEmpSalBtn_Click(object sender, EventArgs e)
        {
            AverageSalaryForm avgEmpForm = new AverageSalaryForm();
            this.Hide();
            avgEmpForm.ShowDialog();
            this.Show();
        }

        private void EditEmpBtn_Click(object sender, EventArgs e)
        {
            FindEmployeeForm empForm = new FindEmployeeForm();
            empForm.SetEditMode();
            this.Hide();
            empForm.ShowDialog();
            this.Show();
        }

        private void DeleteEmpBtn_Click(object sender, EventArgs e)
        {
            FindEmployeeForm empForm = new FindEmployeeForm();
            empForm.SetEditMode();
            this.Hide();
            empForm.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();

            using (var streamReader = new StreamReader(Path.Combine("Data", "employees.csv")))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    while (csvReader.Read())
                    {
                        string[] fullName = csvReader.GetField<string>(0).Split(' ');
                        string salaryText = csvReader.GetField<string>(2);
                        decimal salary = ConvertSalary(salaryText);

                        if (fullName.Length == 2)
                        {
                            Employee employee = new Employee(
                                firstname: fullName[0],
                                lastname: fullName[1],
                                gender: csvReader.GetField(1),
                                department: csvReader.GetField<string>(3),
                                salary: salary
                            );

                            employees.Add(employee); // Add the employee to the list
                        }
                    }
                }
            }

            // Assuming 'company' is an instance of the Company class
            foreach (Employee employee in employees)
            {
                Company.Instance.AddEmployee(employee);
            }
        }

        private void EmployeeListBtn_Click(object sender, EventArgs e)
        {
            List<Employee> employees;
            employees = Company.Instance.GetAllEmployees();
            DisplayAllEmployeesForm displayAllEmployeesForm = new DisplayAllEmployeesForm(employees);
            this.Hide();
            displayAllEmployeesForm.Show();
            displayAllEmployeesForm.FormClosed += (s, args) => this.Show();
        }
    }



}