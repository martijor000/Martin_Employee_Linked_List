namespace Martin_Employee_Linked_List
{
    partial class EditEmployee
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
            EditFirstNameTxtbx = new TextBox();
            EditLastNameTxtbx = new TextBox();
            EditSalaryTxtbx = new TextBox();
            EditGenderCmb = new ComboBox();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            EditDepartmentTxtbx = new TextBox();
            SuspendLayout();
            // 
            // EditFirstNameTxtbx
            // 
            EditFirstNameTxtbx.Location = new Point(321, 76);
            EditFirstNameTxtbx.Name = "EditFirstNameTxtbx";
            EditFirstNameTxtbx.Size = new Size(182, 35);
            EditFirstNameTxtbx.TabIndex = 0;
            // 
            // EditLastNameTxtbx
            // 
            EditLastNameTxtbx.Location = new Point(321, 139);
            EditLastNameTxtbx.Name = "EditLastNameTxtbx";
            EditLastNameTxtbx.Size = new Size(182, 35);
            EditLastNameTxtbx.TabIndex = 3;
            // 
            // EditSalaryTxtbx
            // 
            EditSalaryTxtbx.Location = new Point(321, 328);
            EditSalaryTxtbx.Name = "EditSalaryTxtbx";
            EditSalaryTxtbx.Size = new Size(182, 35);
            EditSalaryTxtbx.TabIndex = 4;
            // 
            // EditGenderCmb
            // 
            EditGenderCmb.FormattingEnabled = true;
            EditGenderCmb.Location = new Point(321, 201);
            EditGenderCmb.Name = "EditGenderCmb";
            EditGenderCmb.Size = new Size(182, 38);
            EditGenderCmb.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Location = new Point(321, 380);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(92, 40);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Green;
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Location = new Point(419, 380);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(84, 40);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditDepartmentTxtbx
            // 
            EditDepartmentTxtbx.Location = new Point(321, 266);
            EditDepartmentTxtbx.Name = "EditDepartmentTxtbx";
            EditDepartmentTxtbx.Size = new Size(182, 35);
            EditDepartmentTxtbx.TabIndex = 8;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditDepartmentTxtbx);
            Controls.Add(SaveBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditGenderCmb);
            Controls.Add(EditSalaryTxtbx);
            Controls.Add(EditLastNameTxtbx);
            Controls.Add(EditFirstNameTxtbx);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EditFirstNameTxtbx;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox EditLastNameTxtbx;
        private TextBox EditSalaryTxtbx;
        private ComboBox EditGenderCmb;
        private Button DeleteBtn;
        private Button SaveBtn;
        private TextBox EditDepartmentTxtbx;
    }
}