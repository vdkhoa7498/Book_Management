using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using QLBanSach.Model;

namespace QLBanSach.ViewModel
{
    public class CategoriesViewModel : BaseViewModel
    {
        private ObservableCollection<Category> _List;
        public ObservableCollection<Category> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private Category _SelectedItem;
        public Category SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.CategoryName;
                }
            }
        }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public CategoriesViewModel()
        {
            List = new ObservableCollection<Category>(DataProvider.Ins.DB.Categories);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName))
                    return false;

                var displayList = DataProvider.Ins.DB.Categories.Where(x => x.CategoryName == DisplayName);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var Category = new Category() { CategoryName = DisplayName };

                DataProvider.Ins.DB.Categories.Add(Category);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(Category);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.Categories.Where(x => x.CategoryName == DisplayName);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var Category = DataProvider.Ins.DB.Categories.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                Category.CategoryName = DisplayName;
                SelectedItem.CategoryName = DisplayName;

                DataProvider.Ins.DB.SaveChanges();
                List= new ObservableCollection<Category>(DataProvider.Ins.DB.Categories);
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || SelectedItem == null)
                    return false;

                return true;

            }, (p) =>
            {
                var Category = DataProvider.Ins.DB.Categories.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                var status = MessageBox.Show("Bạn có muốn xóa Thể loại này không?", "Cảnh Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (status == MessageBoxResult.No) return;
                //ELSE
                List.Remove(Category);

                DataProvider.Ins.DB.Categories.Remove(Category);
                DataProvider.Ins.DB.SaveChanges();
                
            });
        }
    }
}
