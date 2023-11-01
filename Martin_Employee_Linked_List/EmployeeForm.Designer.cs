namespace Martin_Employee_Linked_List
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitBtn = new Button();
            FirstNameTxtBx = new TextBox();
            LastNameTxtBx = new TextBox();
            DepartmentTxtBx = new TextBox();
            SalaryTxtBx = new TextBox();
            GenderCmbBx = new ComboBox();
            FirstNameLbl = new Label();
            LastNameLbl = new Label();
            SalaryLbl = new Label();
            DepartmentLbl = new Label();
            GenderLbl = new Label();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(341, 283);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(175, 52);
            SubmitBtn.TabIndex = 0;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // FirstNameTxtBx
            // 
            FirstNameTxtBx.Location = new Point(341, 75);
            FirstNameTxtBx.Name = "FirstNameTxtBx";
            FirstNameTxtBx.Size = new Size(175, 35);
            FirstNameTxtBx.TabIndex = 1;
            // 
            // LastNameTxtBx
            // 
            LastNameTxtBx.Location = new Point(341, 116);
            LastNameTxtBx.Name = "LastNameTxtBx";
            LastNameTxtBx.Size = new Size(175, 35);
            LastNameTxtBx.TabIndex = 2;
            // 
            // DepartmentTxtBx
            // 
            DepartmentTxtBx.Location = new Point(341, 201);
            DepartmentTxtBx.Name = "DepartmentTxtBx";
            DepartmentTxtBx.Size = new Size(175, 35);
            DepartmentTxtBx.TabIndex = 3;
            // 
            // SalaryTxtBx
            // 
            SalaryTxtBx.Location = new Point(341, 242);
            SalaryTxtBx.Name = "SalaryTxtBx";
            SalaryTxtBx.Size = new Size(175, 35);
            SalaryTxtBx.TabIndex = 4;
            // 
            // GenderCmbBx
            // 
            GenderCmbBx.FormattingEnabled = true;
            GenderCmbBx.Location = new Point(341, 157);
            GenderCmbBx.Name = "GenderCmbBx";
            GenderCmbBx.Size = new Size(175, 38);
            GenderCmbBx.TabIndex = 5;
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.Location = new Point(194, 77);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(113, 30);
            FirstNameLbl.TabIndex = 6;
            FirstNameLbl.Text = "First Name";
            // 
            // LastNameLbl
            // 
            LastNameLbl.AutoSize = true;
            LastNameLbl.Location = new Point(194, 118);
            LastNameLbl.Name = "LastNameLbl";
            LastNameLbl.Size = new Size(112, 30);
            LastNameLbl.TabIndex = 7;
            LastNameLbl.Text = "Last Name";
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.Location = new Point(194, 244);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(68, 30);
            SalaryLbl.TabIndex = 8;
            SalaryLbl.Text = "TreeSalary";
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.Location = new Point(194, 203);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(124, 30);
            DepartmentLbl.TabIndex = 9;
            DepartmentLbl.Text = "Department";
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Location = new Point(194, 161);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(80, 30);
            GenderLbl.TabIndex = 10;
            GenderLbl.Text = "Gender";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GenderLbl);
            Controls.Add(DepartmentLbl);
            Controls.Add(SalaryLbl);
            Controls.Add(LastNameLbl);
            Controls.Add(FirstNameLbl);
            Controls.Add(GenderCmbBx);
            Controls.Add(SalaryTxtBx);
            Controls.Add(DepartmentTxtBx);
            Controls.Add(LastNameTxtBx);
            Controls.Add(FirstNameTxtBx);
            Controls.Add(SubmitBtn);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private TextBox FirstNameTxtBx;
        private TextBox LastNameTxtBx;
        private TextBox DepartmentTxtBx;
        private TextBox SalaryTxtBx;
        private ComboBox GenderCmbBx;
        private Label FirstNameLbl;
        private Label LastNameLbl;
        private Label SalaryLbl;
        private Label DepartmentLbl;
        private Label GenderLbl;
    }
}