namespace Martin_Employee_Linked_List
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FindEmpBtn = new Button();
            AddEmpBtn = new Button();
            DisplayAvgEmpSalBtn = new Button();
            EditEmpBtn = new Button();
            DeleteEmpBtn = new Button();
            EmployeeListBtn = new Button();
            SuspendLayout();
            // 
            // FindEmpBtn
            // 
            FindEmpBtn.Location = new Point(528, 150);
            FindEmpBtn.Name = "FindEmpBtn";
            FindEmpBtn.Size = new Size(302, 40);
            FindEmpBtn.TabIndex = 0;
            FindEmpBtn.Text = "Find Employee";
            FindEmpBtn.UseVisualStyleBackColor = true;
            FindEmpBtn.Click += FindEmpBtn_Click;
            // 
            // AddEmpBtn
            // 
            AddEmpBtn.Location = new Point(528, 230);
            AddEmpBtn.Name = "AddEmpBtn";
            AddEmpBtn.Size = new Size(302, 40);
            AddEmpBtn.TabIndex = 1;
            AddEmpBtn.Text = "Add Employee";
            AddEmpBtn.UseVisualStyleBackColor = true;
            AddEmpBtn.Click += AddEmpBtn_Click;
            // 
            // DisplayAvgEmpSalBtn
            // 
            DisplayAvgEmpSalBtn.Location = new Point(528, 310);
            DisplayAvgEmpSalBtn.Name = "DisplayAvgEmpSalBtn";
            DisplayAvgEmpSalBtn.Size = new Size(302, 40);
            DisplayAvgEmpSalBtn.TabIndex = 2;
            DisplayAvgEmpSalBtn.Text = "Display Average Employee TreeSalary";
            DisplayAvgEmpSalBtn.UseVisualStyleBackColor = true;
            DisplayAvgEmpSalBtn.Click += DisplayAvgEmpSalBtn_Click;
            // 
            // EditEmpBtn
            // 
            EditEmpBtn.Location = new Point(528, 390);
            EditEmpBtn.Name = "EditEmpBtn";
            EditEmpBtn.Size = new Size(302, 40);
            EditEmpBtn.TabIndex = 3;
            EditEmpBtn.Text = "Edit Employee";
            EditEmpBtn.UseVisualStyleBackColor = true;
            EditEmpBtn.Click += EditEmpBtn_Click;
            // 
            // DeleteEmpBtn
            // 
            DeleteEmpBtn.Location = new Point(528, 470);
            DeleteEmpBtn.Name = "DeleteEmpBtn";
            DeleteEmpBtn.Size = new Size(302, 40);
            DeleteEmpBtn.TabIndex = 4;
            DeleteEmpBtn.Text = "Delete Employee";
            DeleteEmpBtn.UseVisualStyleBackColor = true;
            DeleteEmpBtn.Click += DeleteEmpBtn_Click;
            // 
            // EmployeeListBtn
            // 
            EmployeeListBtn.Location = new Point(528, 70);
            EmployeeListBtn.Name = "EmployeeListBtn";
            EmployeeListBtn.Size = new Size(302, 40);
            EmployeeListBtn.TabIndex = 5;
            EmployeeListBtn.Text = "View Employee List";
            EmployeeListBtn.UseVisualStyleBackColor = true;
            EmployeeListBtn.Click += EmployeeListBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 630);
            Controls.Add(EmployeeListBtn);
            Controls.Add(DeleteEmpBtn);
            Controls.Add(EditEmpBtn);
            Controls.Add(DisplayAvgEmpSalBtn);
            Controls.Add(AddEmpBtn);
            Controls.Add(FindEmpBtn);
            Name = "MainForm";
            Text = "Company_Emp";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button FindEmpBtn;
        private Button AddEmpBtn;
        private Button DisplayAvgEmpSalBtn;
        private Button EditEmpBtn;
        private Button DeleteEmpBtn;
        private Button EmployeeListBtn;
    }
}