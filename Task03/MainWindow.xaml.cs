
using System.Windows;
using Task03.ViewModel;

namespace Task03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            this.Title = "Calculator";
            this.Height= 335;
            this.Width = 225;
        }
    }
}
