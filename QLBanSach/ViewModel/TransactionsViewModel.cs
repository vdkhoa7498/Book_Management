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
    public class TransactionViewModel : BaseViewModel
    {
        private ObservableCollection<Transaction> _List;
        public ObservableCollection<Transaction> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<Product> _ProductList;
        public ObservableCollection<Product> ProductList { get => _ProductList; set { _ProductList = value; OnPropertyChanged(); } }

        private Transaction _SelectedItem;
        public Transaction SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    ProductId = SelectedItem.ProductId;
                    SelectedProduct = SelectedItem.Product;
                    Quantity = SelectedItem.Quantity;
                    ContractDate = SelectedItem.ContractDate;
                    BooksDelivery = SelectedItem.BooksDelivery;
                    Discount = SelectedItem.Discount;
                    TotalPrice = SelectedItem.TotalPrice;
                }
            }
        }

        private Product _SelectedProduct;
        public Product SelectedProduct
        {
            get => _SelectedProduct;
            set
            {
                _SelectedProduct = value;
                OnPropertyChanged();
            }
        }
        

        private int _ProductId;
        public int ProductId { get => _ProductId; set { _ProductId = value; OnPropertyChanged(); } }


        private int _Quantity;
        public int Quantity { get => _Quantity; set { _Quantity = value; OnPropertyChanged(); } }


        private string _BooksDelivery;
        public string BooksDelivery { get => _BooksDelivery; set { _BooksDelivery = value; OnPropertyChanged(); } }


        private DateTime _ContractDate;
        public DateTime ContractDate { get => _ContractDate; set { _ContractDate = value; OnPropertyChanged(); } }


        private int _Discount;
        public  int Discount { get => _Discount; set { _Discount = value; OnPropertyChanged(); } }

        private int _TotalPrice;
        public int TotalPrice { get => _TotalPrice; set { _TotalPrice = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public ICommand StatisticCommand { get; set; }

        public TransactionViewModel()
        {
            List = new ObservableCollection<Transaction>(DataProvider.Ins.DB.Transactions);
            ProductList = new ObservableCollection<Product>(DataProvider.Ins.DB.Products);
            ContractDate = DateTime.Now;

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(SelectedProduct.ProductName.ToString()))
                    return false;
                
                if (Quantity <= 0)
                    return false;
                
                return true;

            }, (p) =>
            {
               
                var Transaction = new Transaction() { ProductId = SelectedProduct.Id, Quantity = Quantity, ContractDate = ContractDate, BooksDelivery = BooksDelivery, Discount = Discount, TotalPrice = SelectedProduct.SoldQuantity*SelectedProduct.Price };

                DataProvider.Ins.DB.Transactions.Add(Transaction);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(Transaction);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.Transactions.Where(x => x.Id == SelectedItem.Id);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var Transaction = DataProvider.Ins.DB.Transactions.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                Transaction.ProductId = SelectedProduct.Id;
                Transaction.Quantity = Quantity;
                Transaction.BooksDelivery = BooksDelivery;
                Transaction.ContractDate = ContractDate;
                Transaction.Discount = Discount;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.ProductId = SelectedProduct.Id;
                List = new ObservableCollection<Transaction>(DataProvider.Ins.DB.Transactions);
            });

            StatisticCommand = new RelayCommand<object>((p) =>
            {
                
                return true;

            }, (p) =>
            {
                Statistics statistics = new Statistics();
                statistics.ShowDialog();
            });

        }
      
    }
}
