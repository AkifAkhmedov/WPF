
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Task04.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
            {
                ((dynamic)DataContext).StartTimer();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((dynamic)DataContext).StopTimer();
        }

    }
}
