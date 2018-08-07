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
    /// Interaction logic for Initial_Setup.xaml
    /// </summary>
    public partial class Initial_Setup : Window
    {
        private List<string> ToReturn = new List<string>();
        public List<string> GetList()
        {
            return ToReturn;
        }
        public Initial_Setup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToReturn.Add("Maintenance Loan: " + MaintenanceTextBox.Text);
                ToReturn.Add("Housing Cost: " + HousingTextBox.Text);
                ToReturn.Add("Pool Transactions: 0,0");
                ToReturn.Add("Start Date: " + StartTextBox.Text);
                ToReturn.Add("End Date: " + EndTextBox.Text);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}
