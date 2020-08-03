using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalaryToPay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            calculate(double.Parse(txtSalary.Text), double.Parse(txtExpense.Text), double.Parse(txtPrice.Text));
        }

        private void calculate(double income, double expense, double price)
        {
            double balance = income - expense;
            double result = price / balance;

            if(result < 0)
            {
                string error = result.ToString();
                error = "ERROR";
                txtResult.Text = error.ToString();
            }
            else
            {
                txtResult.Text = result.ToString();
            } 
        }

        private void txtClear_Click(object sender, RoutedEventArgs e)
        {
            txtSalary.Text = "";
            txtExpense.Text = "";
            txtPrice.Text = "";
            txtResult.Text = "";
        }
    }
}
