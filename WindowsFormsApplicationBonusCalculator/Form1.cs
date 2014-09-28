using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationBonusCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double bonusAmount = 0;
        private void showBonusButton_Click(object sender, EventArgs e)
        {
            double Salary = Convert.ToDouble(bonusInputTextBox.Text);

            if (Salary> 10000)
            {
                bonusAmount = (Salary * 5) / 100;
                Salary += bonusAmount;
                afterBonusTextBox.Text = Salary.ToString();
            }
            else if (8000 <= Salary && Salary<= 10000)
            {
                bonusAmount = (Salary * 6) / 100;
                Salary += bonusAmount;
                afterBonusTextBox.Text = Salary.ToString();
            }
            else
                bonusAmount=  (Salary * 7) / 100;
                Salary += bonusAmount;
                afterBonusTextBox.Text = Salary.ToString();
        }
    }
}
