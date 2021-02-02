using QLBanSach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLBanSach.ViewModel
{
    public class StatisticsViewModel : BaseViewModel
    {
        List<KeyValuePair<string, int>> productList = new List<KeyValuePair<string, int>>();

        private ObservableCollection<Product> _ProductList;
        public ObservableCollection<Product> ProductList { get => _ProductList; set { _ProductList = value; OnPropertyChanged(); } }

        public StatisticsViewModel()
        {
            //Showchart();
        }

        //public void Showchart()
        //{
        //    List<KeyValuePair<string, int>> ProductList = new List<KeyValuePair<string, int>>();
        //    List<KeyValuePair<string, int>> soldquantityList = new List<KeyValuePair<string, int>>();
        //    List<KeyValuePair<DateTime, int>> incomeList = new List<KeyValuePair<DateTime, int>>();
        //    foreach (Product item in DataProvider.Ins.DB.Products)
        //    {
        //        ProductList.Add(new KeyValuePair<string, int>(item.ProductName, Convert.ToInt32(item.NumberOfBook)));
        //    }

        //    ProductColumnChart.DataContext = ProductList;
        //}
        
    }
}
