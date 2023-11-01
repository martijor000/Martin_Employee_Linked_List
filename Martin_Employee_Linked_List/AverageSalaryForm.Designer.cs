namespace Martin_Employee_Linked_List
{
    partial class AverageSalaryForm
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
            SalaryTitleLbl = new Label();
            AvgSalaryLbl = new Label();
            SuspendLayout();
            // 
            // SalaryTitleLbl
            // 
            SalaryTitleLbl.AutoSize = true;
            SalaryTitleLbl.Location = new Point(300, 118);
            SalaryTitleLbl.Name = "SalaryTitleLbl";
            SalaryTitleLbl.Size = new Size(150, 30);
            SalaryTitleLbl.TabIndex = 0;
            SalaryTitleLbl.Text = "Average TreeSalary";
            // 
            // AvgSalaryLbl
            // 
            AvgSalaryLbl.AutoSize = true;
            AvgSalaryLbl.Location = new Point(352, 210);
            AvgSalaryLbl.Name = "AvgSalaryLbl";
            AvgSalaryLbl.Size = new Size(47, 30);
            AvgSalaryLbl.TabIndex = 1;
            AvgSalaryLbl.Text = "null";
            // 
            // AverageSalaryForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AvgSalaryLbl);
            Controls.Add(SalaryTitleLbl);
            Name = "AverageSalaryForm";
            Text = "AverageSalaryForm";
            Load += AverageSalaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SalaryTitleLbl;
        private Label AvgSalaryLbl;
    }
}