namespace Martin_Employee_Linked_List
{
    partial class FindEmployeeForm
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
            FindLastNameTxtbx = new TextBox();
            FindFirstNameTxtBx = new TextBox();
            FindDepartmentTxtBx = new TextBox();
            FindLastNameLbl = new Label();
            FindFirstNameLbl = new Label();
            FindDepartmentLbl = new Label();
            SearchLastNameBtn = new Button();
            SearchFirstNameBtn = new Button();
            SearchDepartmentBtn = new Button();
            FindLbl = new Label();
            SuspendLayout();
            // 
            // FindLastNameTxtbx
            // 
            FindLastNameTxtbx.Location = new Point(275, 117);
            FindLastNameTxtbx.Name = "FindLastNameTxtbx";
            FindLastNameTxtbx.Size = new Size(175, 35);
            FindLastNameTxtbx.TabIndex = 0;
            // 
            // FindFirstNameTxtBx
            // 
            FindFirstNameTxtBx.Location = new Point(275, 226);
            FindFirstNameTxtBx.Name = "FindFirstNameTxtBx";
            FindFirstNameTxtBx.Size = new Size(175, 35);
            FindFirstNameTxtBx.TabIndex = 1;
            // 
            // FindDepartmentTxtBx
            // 
            FindDepartmentTxtBx.Location = new Point(275, 333);
            FindDepartmentTxtBx.Name = "FindDepartmentTxtBx";
            FindDepartmentTxtBx.Size = new Size(175, 35);
            FindDepartmentTxtBx.TabIndex = 2;
            // 
            // FindLastNameLbl
            // 
            FindLastNameLbl.AutoSize = true;
            FindLastNameLbl.Location = new Point(145, 119);
            FindLastNameLbl.Name = "FindLastNameLbl";
            FindLastNameLbl.Size = new Size(112, 30);
            FindLastNameLbl.TabIndex = 3;
            FindLastNameLbl.Text = "Last Name";
            // 
            // FindFirstNameLbl
            // 
            FindFirstNameLbl.AutoSize = true;
            FindFirstNameLbl.Location = new Point(145, 228);
            FindFirstNameLbl.Name = "FindFirstNameLbl";
            FindFirstNameLbl.Size = new Size(113, 30);
            FindFirstNameLbl.TabIndex = 4;
            FindFirstNameLbl.Text = "First Name";
            // 
            // FindDepartmentLbl
            // 
            FindDepartmentLbl.AutoSize = true;
            FindDepartmentLbl.Location = new Point(145, 335);
            FindDepartmentLbl.Name = "FindDepartmentLbl";
            FindDepartmentLbl.Size = new Size(124, 30);
            FindDepartmentLbl.TabIndex = 5;
            FindDepartmentLbl.Text = "Department";
            // 
            // SearchLastNameBtn
            // 
            SearchLastNameBtn.Location = new Point(456, 114);
            SearchLastNameBtn.Name = "SearchLastNameBtn";
            SearchLastNameBtn.Size = new Size(131, 40);
            SearchLastNameBtn.TabIndex = 6;
            SearchLastNameBtn.Text = "Search";
            SearchLastNameBtn.UseVisualStyleBackColor = true;
            SearchLastNameBtn.Click += SearchLastNameBtn_Click;
            // 
            // SearchFirstNameBtn
            // 
            SearchFirstNameBtn.Location = new Point(456, 223);
            SearchFirstNameBtn.Name = "SearchFirstNameBtn";
            SearchFirstNameBtn.Size = new Size(131, 40);
            SearchFirstNameBtn.TabIndex = 7;
            SearchFirstNameBtn.Text = "Search";
            SearchFirstNameBtn.UseVisualStyleBackColor = true;
            SearchFirstNameBtn.Click += SearchFirstNameBtn_Click;
            // 
            // SearchDepartmentBtn
            // 
            SearchDepartmentBtn.Location = new Point(456, 330);
            SearchDepartmentBtn.Name = "SearchDepartmentBtn";
            SearchDepartmentBtn.Size = new Size(131, 40);
            SearchDepartmentBtn.TabIndex = 8;
            SearchDepartmentBtn.Text = "Search";
            SearchDepartmentBtn.UseVisualStyleBackColor = true;
            SearchDepartmentBtn.Click += SearchDepartmentBtn_Click;
            // 
            // FindLbl
            // 
            FindLbl.AutoSize = true;
            FindLbl.Location = new Point(327, 59);
            FindLbl.Name = "FindLbl";
            FindLbl.Size = new Size(85, 30);
            FindLbl.TabIndex = 9;
            FindLbl.Text = "Find By:";
            // 
            // FindEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FindLbl);
            Controls.Add(SearchDepartmentBtn);
            Controls.Add(SearchFirstNameBtn);
            Controls.Add(SearchLastNameBtn);
            Controls.Add(FindDepartmentLbl);
            Controls.Add(FindFirstNameLbl);
            Controls.Add(FindLastNameLbl);
            Controls.Add(FindDepartmentTxtBx);
            Controls.Add(FindFirstNameTxtBx);
            Controls.Add(FindLastNameTxtbx);
            Name = "FindEmployeeForm";
            Text = "FindEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FindLastNameTxtbx;
        private TextBox FindFirstNameTxtBx;
        private TextBox FindDepartmentTxtBx;
        private Label FindLastNameLbl;
        private Label FindFirstNameLbl;
        private Label FindDepartmentLbl;
        private Button SearchLastNameBtn;
        private Button SearchFirstNameBtn;
        private Button SearchDepartmentBtn;
        private Label FindLbl;
    }
}