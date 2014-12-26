using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SlalaryCalculator : Form
    {
        public SlalaryCalculator()
        {
            InitializeComponent();
        }

        Employee aEmployee=new Employee();
        void TakeInput()
        {
            aEmployee.name = nameTextBox.Text;
            aEmployee.allowance = Convert.ToDouble(allowanceTextBox.Text);
            aEmployee.rent = Convert.ToDouble(rentTextBox.Text);
            aEmployee.amount = Convert.ToDouble(amountTextBox.Text);
        }
        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            TakeInput();
            MessageBox.Show(aEmployee.name + " , your balance is :: " + aEmployee.GetFullSalary()+" Taka");
        }

       


       
    }
}
