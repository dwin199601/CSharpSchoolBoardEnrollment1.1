
namespace OleksandrD_Assign2
{
    partial class Form1
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
            this.SchoolListBox = new System.Windows.Forms.ListBox();
            this.LoadDataBox = new System.Windows.Forms.GroupBox();
            this.ReadSchoolInfoButton = new System.Windows.Forms.Button();
            this.UpdatingData = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SchoolNameTextBox = new System.Windows.Forms.TextBox();
            this.SchoolNameLabel = new System.Windows.Forms.Label();
            this.SortDescendOrderTotFundButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.NumStudsJoiningButton = new System.Windows.Forms.Button();
            this.NumStudJoiningBox = new System.Windows.Forms.TextBox();
            this.NumStudJoiningLabel = new System.Windows.Forms.Label();
            this.UpdateNumStudLeavingButton = new System.Windows.Forms.Button();
            this.NumStudLeavingLabel = new System.Windows.Forms.Label();
            this.NumberofStudleaveTextBox = new System.Windows.Forms.TextBox();
            this.GroupBoxSavingData = new System.Windows.Forms.GroupBox();
            this.SavingSchoolFundInfButton = new System.Windows.Forms.Button();
            this.SaveSchoolExceedMaxEnrolBut = new System.Windows.Forms.Button();
            this.SaveSchookOutputButton = new System.Windows.Forms.Button();
            this.StatusUpdateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadDataBox.SuspendLayout();
            this.UpdatingData.SuspendLayout();
            this.GroupBoxSavingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchoolListBox
            // 
            this.SchoolListBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolListBox.FormattingEnabled = true;
            this.SchoolListBox.ItemHeight = 15;
            this.SchoolListBox.Location = new System.Drawing.Point(68, 65);
            this.SchoolListBox.Name = "SchoolListBox";
            this.SchoolListBox.Size = new System.Drawing.Size(972, 184);
            this.SchoolListBox.TabIndex = 0;
            this.SchoolListBox.SelectedIndexChanged += new System.EventHandler(this.SchoolListBox_SelectedIndexChanged);
            // 
            // LoadDataBox
            // 
            this.LoadDataBox.BackColor = System.Drawing.Color.Teal;
            this.LoadDataBox.Controls.Add(this.ReadSchoolInfoButton);
            this.LoadDataBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadDataBox.Location = new System.Drawing.Point(68, 264);
            this.LoadDataBox.Name = "LoadDataBox";
            this.LoadDataBox.Size = new System.Drawing.Size(283, 122);
            this.LoadDataBox.TabIndex = 1;
            this.LoadDataBox.TabStop = false;
            this.LoadDataBox.Text = "Load Data";
            // 
            // ReadSchoolInfoButton
            // 
            this.ReadSchoolInfoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReadSchoolInfoButton.Location = new System.Drawing.Point(78, 39);
            this.ReadSchoolInfoButton.Name = "ReadSchoolInfoButton";
            this.ReadSchoolInfoButton.Size = new System.Drawing.Size(119, 45);
            this.ReadSchoolInfoButton.TabIndex = 0;
            this.ReadSchoolInfoButton.Text = "Read School Info";
            this.ReadSchoolInfoButton.UseVisualStyleBackColor = true;
            this.ReadSchoolInfoButton.Click += new System.EventHandler(this.ReadSchoolInfoButton_Click);
            // 
            // UpdatingData
            // 
            this.UpdatingData.BackColor = System.Drawing.Color.Teal;
            this.UpdatingData.Controls.Add(this.ExitButton);
            this.UpdatingData.Controls.Add(this.SchoolNameTextBox);
            this.UpdatingData.Controls.Add(this.SchoolNameLabel);
            this.UpdatingData.Controls.Add(this.SortDescendOrderTotFundButton);
            this.UpdatingData.Controls.Add(this.DeleteSelectedButton);
            this.UpdatingData.Controls.Add(this.NumStudsJoiningButton);
            this.UpdatingData.Controls.Add(this.NumStudJoiningBox);
            this.UpdatingData.Controls.Add(this.NumStudJoiningLabel);
            this.UpdatingData.Controls.Add(this.UpdateNumStudLeavingButton);
            this.UpdatingData.Controls.Add(this.NumStudLeavingLabel);
            this.UpdatingData.Controls.Add(this.NumberofStudleaveTextBox);
            this.UpdatingData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdatingData.Location = new System.Drawing.Point(434, 264);
            this.UpdatingData.Name = "UpdatingData";
            this.UpdatingData.Size = new System.Drawing.Size(619, 241);
            this.UpdatingData.TabIndex = 2;
            this.UpdatingData.TabStop = false;
            this.UpdatingData.Text = "Updating Data";
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(477, 127);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 53);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Quit App";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SchoolNameTextBox
            // 
            this.SchoolNameTextBox.Location = new System.Drawing.Point(127, 197);
            this.SchoolNameTextBox.Name = "SchoolNameTextBox";
            this.SchoolNameTextBox.Size = new System.Drawing.Size(303, 22);
            this.SchoolNameTextBox.TabIndex = 9;
            // 
            // SchoolNameLabel
            // 
            this.SchoolNameLabel.AutoSize = true;
            this.SchoolNameLabel.Location = new System.Drawing.Point(16, 197);
            this.SchoolNameLabel.Name = "SchoolNameLabel";
            this.SchoolNameLabel.Size = new System.Drawing.Size(92, 17);
            this.SchoolNameLabel.TabIndex = 8;
            this.SchoolNameLabel.Text = "School Name";
            // 
            // SortDescendOrderTotFundButton
            // 
            this.SortDescendOrderTotFundButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SortDescendOrderTotFundButton.Location = new System.Drawing.Point(200, 127);
            this.SortDescendOrderTotFundButton.Name = "SortDescendOrderTotFundButton";
            this.SortDescendOrderTotFundButton.Size = new System.Drawing.Size(180, 53);
            this.SortDescendOrderTotFundButton.TabIndex = 7;
            this.SortDescendOrderTotFundButton.Text = "Sorting By Des Order TotalFund";
            this.SortDescendOrderTotFundButton.UseVisualStyleBackColor = true;
            this.SortDescendOrderTotFundButton.Click += new System.EventHandler(this.SortDescendOrderTotFundButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(16, 127);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(144, 53);
            this.DeleteSelectedButton.TabIndex = 6;
            this.DeleteSelectedButton.Text = "Delete Selected School";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // NumStudsJoiningButton
            // 
            this.NumStudsJoiningButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumStudsJoiningButton.Location = new System.Drawing.Point(354, 65);
            this.NumStudsJoiningButton.Name = "NumStudsJoiningButton";
            this.NumStudsJoiningButton.Size = new System.Drawing.Size(241, 35);
            this.NumStudsJoiningButton.TabIndex = 5;
            this.NumStudsJoiningButton.Text = "Update Number Students Joining";
            this.NumStudsJoiningButton.UseVisualStyleBackColor = true;
            this.NumStudsJoiningButton.Click += new System.EventHandler(this.NumStudsJoiningButton_Click);
            // 
            // NumStudJoiningBox
            // 
            this.NumStudJoiningBox.Location = new System.Drawing.Point(200, 66);
            this.NumStudJoiningBox.Name = "NumStudJoiningBox";
            this.NumStudJoiningBox.Size = new System.Drawing.Size(127, 22);
            this.NumStudJoiningBox.TabIndex = 4;
            // 
            // NumStudJoiningLabel
            // 
            this.NumStudJoiningLabel.AutoSize = true;
            this.NumStudJoiningLabel.Location = new System.Drawing.Point(13, 66);
            this.NumStudJoiningLabel.Name = "NumStudJoiningLabel";
            this.NumStudJoiningLabel.Size = new System.Drawing.Size(176, 17);
            this.NumStudJoiningLabel.TabIndex = 3;
            this.NumStudJoiningLabel.Text = "Number of Student Joining";
            // 
            // UpdateNumStudLeavingButton
            // 
            this.UpdateNumStudLeavingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateNumStudLeavingButton.Location = new System.Drawing.Point(354, 21);
            this.UpdateNumStudLeavingButton.Name = "UpdateNumStudLeavingButton";
            this.UpdateNumStudLeavingButton.Size = new System.Drawing.Size(241, 38);
            this.UpdateNumStudLeavingButton.TabIndex = 2;
            this.UpdateNumStudLeavingButton.Text = "Update Num Students Leaving";
            this.UpdateNumStudLeavingButton.UseVisualStyleBackColor = true;
            this.UpdateNumStudLeavingButton.Click += new System.EventHandler(this.UpdateNumStudLeavingButton_Click);
            // 
            // NumStudLeavingLabel
            // 
            this.NumStudLeavingLabel.AutoSize = true;
            this.NumStudLeavingLabel.Location = new System.Drawing.Point(10, 26);
            this.NumStudLeavingLabel.Name = "NumStudLeavingLabel";
            this.NumStudLeavingLabel.Size = new System.Drawing.Size(184, 17);
            this.NumStudLeavingLabel.TabIndex = 1;
            this.NumStudLeavingLabel.Text = "Number Of Student Leaving";
            // 
            // NumberofStudleaveTextBox
            // 
            this.NumberofStudleaveTextBox.Location = new System.Drawing.Point(200, 26);
            this.NumberofStudleaveTextBox.Name = "NumberofStudleaveTextBox";
            this.NumberofStudleaveTextBox.Size = new System.Drawing.Size(127, 22);
            this.NumberofStudleaveTextBox.TabIndex = 0;
            // 
            // GroupBoxSavingData
            // 
            this.GroupBoxSavingData.BackColor = System.Drawing.Color.Teal;
            this.GroupBoxSavingData.Controls.Add(this.SavingSchoolFundInfButton);
            this.GroupBoxSavingData.Controls.Add(this.SaveSchoolExceedMaxEnrolBut);
            this.GroupBoxSavingData.Controls.Add(this.SaveSchookOutputButton);
            this.GroupBoxSavingData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxSavingData.Location = new System.Drawing.Point(68, 390);
            this.GroupBoxSavingData.Name = "GroupBoxSavingData";
            this.GroupBoxSavingData.Size = new System.Drawing.Size(283, 239);
            this.GroupBoxSavingData.TabIndex = 3;
            this.GroupBoxSavingData.TabStop = false;
            this.GroupBoxSavingData.Text = "Saving Data";
            // 
            // SavingSchoolFundInfButton
            // 
            this.SavingSchoolFundInfButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SavingSchoolFundInfButton.Location = new System.Drawing.Point(57, 152);
            this.SavingSchoolFundInfButton.Name = "SavingSchoolFundInfButton";
            this.SavingSchoolFundInfButton.Size = new System.Drawing.Size(179, 58);
            this.SavingSchoolFundInfButton.TabIndex = 2;
            this.SavingSchoolFundInfButton.Text = "Save School Funding Info";
            this.SavingSchoolFundInfButton.UseVisualStyleBackColor = true;
            this.SavingSchoolFundInfButton.Click += new System.EventHandler(this.SavingSchoolFundInfButton_Click);
            // 
            // SaveSchoolExceedMaxEnrolBut
            // 
            this.SaveSchoolExceedMaxEnrolBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveSchoolExceedMaxEnrolBut.Location = new System.Drawing.Point(57, 86);
            this.SaveSchoolExceedMaxEnrolBut.Name = "SaveSchoolExceedMaxEnrolBut";
            this.SaveSchoolExceedMaxEnrolBut.Size = new System.Drawing.Size(179, 59);
            this.SaveSchoolExceedMaxEnrolBut.TabIndex = 1;
            this.SaveSchoolExceedMaxEnrolBut.Text = "Save Enrolment Exceeded School Data";
            this.SaveSchoolExceedMaxEnrolBut.UseVisualStyleBackColor = true;
            this.SaveSchoolExceedMaxEnrolBut.Click += new System.EventHandler(this.SaveSchoolExceedMaxEnrolBut_Click);
            // 
            // SaveSchookOutputButton
            // 
            this.SaveSchookOutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveSchookOutputButton.Location = new System.Drawing.Point(57, 28);
            this.SaveSchookOutputButton.Name = "SaveSchookOutputButton";
            this.SaveSchookOutputButton.Size = new System.Drawing.Size(179, 52);
            this.SaveSchookOutputButton.TabIndex = 0;
            this.SaveSchookOutputButton.Text = "Save School Info Output";
            this.SaveSchookOutputButton.UseVisualStyleBackColor = true;
            this.SaveSchookOutputButton.Click += new System.EventHandler(this.SaveSchookOutputButton_Click);
            // 
            // StatusUpdateLabel
            // 
            this.StatusUpdateLabel.AutoSize = true;
            this.StatusUpdateLabel.BackColor = System.Drawing.Color.Olive;
            this.StatusUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusUpdateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusUpdateLabel.Location = new System.Drawing.Point(442, 542);
            this.StatusUpdateLabel.Name = "StatusUpdateLabel";
            this.StatusUpdateLabel.Size = new System.Drawing.Size(335, 29);
            this.StatusUpdateLabel.TabIndex = 4;
            this.StatusUpdateLabel.Text = "Status will be displayed here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vancouver School Board Enrollment and Funds Management Software";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusUpdateLabel);
            this.Controls.Add(this.GroupBoxSavingData);
            this.Controls.Add(this.UpdatingData);
            this.Controls.Add(this.LoadDataBox);
            this.Controls.Add(this.SchoolListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoadDataBox.ResumeLayout(false);
            this.UpdatingData.ResumeLayout(false);
            this.UpdatingData.PerformLayout();
            this.GroupBoxSavingData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SchoolListBox;
        private System.Windows.Forms.GroupBox LoadDataBox;
        private System.Windows.Forms.GroupBox UpdatingData;
        private System.Windows.Forms.GroupBox GroupBoxSavingData;
        private System.Windows.Forms.Button ReadSchoolInfoButton;
        private System.Windows.Forms.Button UpdateNumStudLeavingButton;
        private System.Windows.Forms.Label NumStudLeavingLabel;
        private System.Windows.Forms.TextBox NumberofStudleaveTextBox;
        private System.Windows.Forms.Button SortDescendOrderTotFundButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button NumStudsJoiningButton;
        private System.Windows.Forms.TextBox NumStudJoiningBox;
        private System.Windows.Forms.Label NumStudJoiningLabel;
        private System.Windows.Forms.Button SavingSchoolFundInfButton;
        private System.Windows.Forms.Button SaveSchoolExceedMaxEnrolBut;
        private System.Windows.Forms.Button SaveSchookOutputButton;
        private System.Windows.Forms.Label StatusUpdateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SchoolNameTextBox;
        private System.Windows.Forms.Label SchoolNameLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

