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
using System.Windows.Shapes;

namespace BudgetCalculator
{
    /// <summary>
    /// Interaction logic for Money_Pool.xaml
    /// </summary>
    public partial class Money_Pool : Window
    {
        MoneyPool Pool;
        public Money_Pool(MoneyPool p_Pool)
        {
            Pool = p_Pool;
            InitializeComponent();
            UpdateBalance();
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            Transaction(true);
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Transaction(false);
        }
        void Transaction(bool isWithdrawal)
        {
            decimal transactionAmount = decimal.Parse(AmountTextBox.Text);
            try
            {
                if (0 < transactionAmount)
                {
                    if (isWithdrawal && transactionAmount < Pool.GetValue())
                    {
                        Pool.Subtract(transactionAmount);
                    }
                    else
                    {
                        Pool.Add(transactionAmount);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid transaction amount");
                }
            }
            catch (Exception f)
            {
                MessageBox.Show("ERROR: " + f.Message);
            }
            finally
            {
                UpdateBalance();
                AmountTextBox.Clear();
            }
        }

        void UpdateBalance()
        {
            AvailableMoneyTextBox.Text = "£" + Math.Round(Pool.GetValue(), 2);
        }
    }
}
