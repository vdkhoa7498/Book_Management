using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using QLBanSach.Model;
using System.Windows.Input;
using System.Windows;

namespace QLBanSach.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        private ObservableCollection<Product> _List;
        public ObservableCollection<Product> List { get => _List; set { _List = value; OnPropertyChanged(); } }


        private ObservableCollection<Category> _CategoryList;
        public ObservableCollection<Category> CategoryList { get => _CategoryList; set { _CategoryList = value; OnPropertyChanged(); } }


        private Product _SelectedItem;
        public Product SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    ProductName = SelectedItem.ProductName;
                    SelectedCategory = SelectedItem.Category;
                    Author = SelectedItem.Author;
                    NumberOfBook = SelectedItem.NumberOfBook;
                    Price = SelectedItem.Price;
                }
            }
        }

        private Category _SelectedCategory;
        public Category SelectedCategory
        {
            get => _SelectedCategory;
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
        }

        private string _ProductName;
        public string ProductName { get => _ProductName; set { _ProductName = value; OnPropertyChanged(); } }
        
        
        private string _Author;
        public string Author { get => _Author; set { _Author = value; OnPropertyChanged(); } }


        private int _NumberOfBook;
        public int NumberOfBook { get => _NumberOfBook; set { _NumberOfBook = value; OnPropertyChanged(); } }


        private int _Price;
        public int Price { get => _Price; set { _Price = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ProductsViewModel()
        {
            List = new ObservableCollection<Product>(DataProvider.Ins.DB.Products);
            CategoryList = new ObservableCollection<Category>(DataProvider.Ins.DB.Categories);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(ProductName))
                    return false;
                if (string.IsNullOrEmpty(SelectedCategory.CategoryName.ToString()))
                    return false;
                
                if (NumberOfBook <=0)
                    return false;
                if (Price <= 0)
                    return false;
                if (string.IsNullOrEmpty(Author))
                    return false;
                return true;
            }, (p) =>
            {
                var product = new Product() { ProductName = ProductName, CategoryId = SelectedCategory.Id, Author = Author, NumberOfBook = NumberOfBook, Price = Price };

                DataProvider.Ins.DB.Products.Add(product);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(product);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.Products.Where(x => x.Id == SelectedItem.Id);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var product = DataProvider.Ins.DB.Products.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                product.ProductName = ProductName;
                product.CategoryId = SelectedCategory.Id;
                product.Author = Author;
                product.NumberOfBook = NumberOfBook;
                product.Price = Price;

                DataProvider.Ins.DB.SaveChanges();
                List = new ObservableCollection<Product>(DataProvider.Ins.DB.Products);
                SelectedItem.ProductName = ProductName;

            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(ProductName) || SelectedItem == null)
                    return false;

                return true;

            }, (p) =>
            {
                var Product = DataProvider.Ins.DB.Products.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                var status = MessageBox.Show("Bạn có muốn xóa Sách này không?", "Cảnh Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (status == MessageBoxResult.No) return;
                //ELSE
                List.Remove(Product);

                DataProvider.Ins.DB.Products.Remove(Product);
                DataProvider.Ins.DB.SaveChanges();

            });

        }
    }
}
