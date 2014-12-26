namespace SalaryCalculatorApp
{
    partial class SlalaryCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.showSalaryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allowanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // showSalaryButton
            // 
            this.showSalaryButton.Location = new System.Drawing.Point(146, 181);
            this.showSalaryButton.Name = "showSalaryButton";
            this.showSalaryButton.Size = new System.Drawing.Size(139, 60);
            this.showSalaryButton.TabIndex = 2;
            this.showSalaryButton.Text = "Show Me Salary";
            this.showSalaryButton.UseVisualStyleBackColor = true;
            this.showSalaryButton.Click += new System.EventHandler(this.showSalaryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basic Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(146, 57);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "House rent";
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(146, 92);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(100, 20);
            this.rentTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Alowance";
            // 
            // allowanceTextBox
            // 
            this.allowanceTextBox.Location = new System.Drawing.Point(146, 128);
            this.allowanceTextBox.Name = "allowanceTextBox";
            this.allowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.allowanceTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "% basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "% basic";
            // 
            // SlalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.showSalaryButton);
            this.Controls.Add(this.allowanceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "SlalaryCalculator";
            this.Text = "salary calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button showSalaryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox allowanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

