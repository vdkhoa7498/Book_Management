using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Fluent;

namespace QLBanSach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            var screens = new ObservableCollection<TabItem>()
            {
                new TabItem() {
                    Header ="Loại sản phẩm",
                    Content = new Frame() {
                        Content = new CategoryListPage(),
                    },
                },
                new TabItem() {
                    Header ="Sản phẩm",
                    Content = new Frame() {
                        NavigationUIVisibility = NavigationUIVisibility.Hidden,
                        Content = new ProductListPage()
                    },
                },
                new TabItem()
                {
                    Header = "Giao dịch",
                    Content = new Frame()
                    {
                        NavigationUIVisibility = NavigationUIVisibility.Hidden,
                        Content = new TransactionsPage()
                    }
                }
             };

            tabs.ItemsSource = screens;
            tabs.SelectedIndex = 0;

        }

       
    }
}
