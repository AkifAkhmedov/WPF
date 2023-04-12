using System.Windows;
using Task02.ViewModels;

namespace Task02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
            this.Title = "Домашнее задание 6";
            this.Width= 750;
            this.Height = 500;
        }
    }
}
