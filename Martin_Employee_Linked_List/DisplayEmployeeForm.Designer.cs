namespace Martin_Employee_Linked_List
{
    partial class DisplayEmployeeForm
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
            DisplayFirstNameLbl = new Label();
            DisplayLastNameLbl = new Label();
            DisplayGenderLbl = new Label();
            DisplaySalaryLbl = new Label();
            DisplayDepartmentLbl = new Label();
            SuspendLayout();
            // 
            // DisplayFirstNameLbl
            // 
            DisplayFirstNameLbl.AutoSize = true;
            DisplayFirstNameLbl.Location = new Point(324, 140);
            DisplayFirstNameLbl.Name = "DisplayFirstNameLbl";
            DisplayFirstNameLbl.Size = new Size(51, 30);
            DisplayFirstNameLbl.TabIndex = 0;
            DisplayFirstNameLbl.Text = "Null";
            // 
            // DisplayLastNameLbl
            // 
            DisplayLastNameLbl.AutoSize = true;
            DisplayLastNameLbl.Location = new Point(324, 187);
            DisplayLastNameLbl.Name = "DisplayLastNameLbl";
            DisplayLastNameLbl.Size = new Size(51, 30);
            DisplayLastNameLbl.TabIndex = 1;
            DisplayLastNameLbl.Text = "Null";
            // 
            // DisplayGenderLbl
            // 
            DisplayGenderLbl.AutoSize = true;
            DisplayGenderLbl.Location = new Point(324, 234);
            DisplayGenderLbl.Name = "DisplayGenderLbl";
            DisplayGenderLbl.Size = new Size(51, 30);
            DisplayGenderLbl.TabIndex = 2;
            DisplayGenderLbl.Text = "Null";
            // 
            // DisplaySalaryLbl
            // 
            DisplaySalaryLbl.AutoSize = true;
            DisplaySalaryLbl.Location = new Point(324, 328);
            DisplaySalaryLbl.Name = "DisplaySalaryLbl";
            DisplaySalaryLbl.Size = new Size(51, 30);
            DisplaySalaryLbl.TabIndex = 3;
            DisplaySalaryLbl.Text = "Null";
            // 
            // DisplayDepartmentLbl
            // 
            DisplayDepartmentLbl.AutoSize = true;
            DisplayDepartmentLbl.Location = new Point(324, 281);
            DisplayDepartmentLbl.Name = "DisplayDepartmentLbl";
            DisplayDepartmentLbl.Size = new Size(51, 30);
            DisplayDepartmentLbl.TabIndex = 4;
            DisplayDepartmentLbl.Text = "Null";
            // 
            // DisplayEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayDepartmentLbl);
            Controls.Add(DisplaySalaryLbl);
            Controls.Add(DisplayGenderLbl);
            Controls.Add(DisplayLastNameLbl);
            Controls.Add(DisplayFirstNameLbl);
            Name = "DisplayEmployeeForm";
            Text = "DisplayEmployeeForm";
            Load += DisplayEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DisplayFirstNameLbl;
        private Label DisplayLastNameLbl;
        private Label DisplayGenderLbl;
        private Label DisplaySalaryLbl;
        private Label DisplayDepartmentLbl;
    }
}