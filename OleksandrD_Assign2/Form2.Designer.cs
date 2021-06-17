
namespace OleksandrD_Assign2
{
    partial class Form2
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
            this.LabelFormTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelFormTwo
            // 
            this.LabelFormTwo.AutoSize = true;
            this.LabelFormTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFormTwo.Location = new System.Drawing.Point(229, 179);
            this.LabelFormTwo.Name = "LabelFormTwo";
            this.LabelFormTwo.Size = new System.Drawing.Size(328, 29);
            this.LabelFormTwo.TabIndex = 0;
            this.LabelFormTwo.Text = "Text will be displayed here";
            this.LabelFormTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelFormTwo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelFormTwo;
    }
}