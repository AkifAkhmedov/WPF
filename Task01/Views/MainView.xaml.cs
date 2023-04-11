using System.Windows;
using System.Windows.Controls;

namespace Task01.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext != null) ((dynamic)this.DataContext).Main.Name = "valik";
        }
    }
}
