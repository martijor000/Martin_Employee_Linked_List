namespace Martin_Employee_Linked_List
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindEmpBtn_Click(object sender, EventArgs e)
        {

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

        }

        private void EditEmpBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEmpBtn_Click(object sender, EventArgs e)
        {

        }
    }

}