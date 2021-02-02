using QLBanSach.Model;
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

namespace QLBanSach
{
    /// <summary>
    /// Interaction logic for Statistics.xaml
    /// </summary>
    public partial class Statistics : Window
    {
        List<KeyValuePair<string, int>> remainingquantityList = new List<KeyValuePair<string, int>>();
        List<KeyValuePair<string, int>> soldquantityList = new List<KeyValuePair<string, int>>();
        List<KeyValuePair<int, int>> incomeList = new List<KeyValuePair<int, int>>();

        public Statistics()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            
            foreach (Product item in DataProvider.Ins.DB.Products)
            {
                soldquantityList.Add(new KeyValuePair<string, int>(item.ProductName, Convert.ToInt32(item.NumberOfBook)));
                remainingquantityList.Add(new KeyValuePair<string, int>(item.ProductName, Convert.ToInt32(item.NumberOfBook) - Convert.ToInt32(item.SoldQuantity)));
            }
            foreach (Transaction transaction in DataProvider.Ins.DB.Transactions)
            {
                incomeList.Add(new KeyValuePair<int, int>(Convert.ToDateTime(transaction.ContractDate).Day, Convert.ToInt32(transaction.TotalPrice)));
            }

            ProductsColumnChart.DataContext = soldquantityList;
            ProductsPieChart.DataContext = soldquantityList;
            TransactionsColumnChart.DataContext = remainingquantityList;
            TransactionsPieChart.DataContext = remainingquantityList;

            IncomeLineChart.DataContext = incomeList;
        }

        private void btnDay_Click(object sender, RoutedEventArgs e)
        {
            incomeList.Clear();
            IncomeLineChart.DataContext = null;
            foreach (Transaction transaction in DataProvider.Ins.DB.Transactions)
            {
                incomeList.Add(new KeyValuePair<int, int>(Convert.ToDateTime(transaction.ContractDate).Day, Convert.ToInt32(transaction.TotalPrice)));
            }
            IncomeLineChart.DataContext = incomeList;
            LoadChart();
        }

        private void btnMonth_Click(object sender, RoutedEventArgs e)
        {
            incomeList.Clear();
            IncomeLineChart.DataContext = null;
            foreach (Transaction transaction in DataProvider.Ins.DB.Transactions)
            {
                incomeList.Add(new KeyValuePair<int, int>(Convert.ToDateTime(transaction.ContractDate).Month, Convert.ToInt32(transaction.TotalPrice)));
            }
            IncomeLineChart.DataContext = incomeList;
            LoadChart();
        }

        private void btnYear_Click(object sender, RoutedEventArgs e)
        {
            incomeList.Clear();
            IncomeLineChart.DataContext = null;
            foreach (Transaction transaction in DataProvider.Ins.DB.Transactions)
            {
                incomeList.Add(new KeyValuePair<int, int>(Convert.ToDateTime(transaction.ContractDate).Year, Convert.ToInt32(transaction.TotalPrice)));
            }
            IncomeLineChart.DataContext = incomeList;
            LoadChart();
        }

        private void btnChoice_Click(object sender, RoutedEventArgs e)
        {
            DateTime dpf = Convert.ToDateTime(DatePickerFrom.SelectedDate);
            DateTime dpt = Convert.ToDateTime(DatePickerTo.SelectedDate);
            incomeList.Clear();
            IncomeLineChart.DataContext = null;
            foreach (Transaction transaction in DataProvider.Ins.DB.Transactions)
            {
                if (Convert.ToDateTime(transaction.ContractDate).Day > dpf.Day && Convert.ToDateTime(transaction.ContractDate).Day < dpt.Day)
                {
                    incomeList.Add(new KeyValuePair<int, int>(Convert.ToDateTime(transaction.ContractDate).Day, Convert.ToInt32(transaction.TotalPrice)));
                }
            }
            IncomeLineChart.DataContext = incomeList;
            LoadChart();
        }
    }
}
