
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Task04.Models;
using Task04.ViewModel;

namespace Task04
{
    public partial class MainWindow : Window
    {


        // public int d = 10;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            MainModel mainModel = new MainModel();
            this.Title = "Keyboard training";
            this.Height = 500;
            this.Width = 1000;
            this.KeyDown += MainWindow_KeyDown;
            ((dynamic)DataContext).MainModel.Text = "Text: ";
            ((dynamic)DataContext).MainModel.IsStart = true;
            ((dynamic)DataContext).MainModel.SliderValue = 0;
           
        }
        public void ErrorShow()
        {
            
            if (((dynamic)DataContext) == null)
            {
                return;
            }
            string str1 = ((dynamic)DataContext).MainModel.Text;
            string str2 = ((dynamic)DataContext).MainModel.TextRead;
            
            if (str2.StartsWith(str1))
            {
                ((dynamic)DataContext).MainModel.ChangeColor = "#75ff8c";
            }
            else
            {
                //int i = ((dynamic)DataContext).MainModel.FailsCount + 1;
                ((dynamic)DataContext).MainModel.FailsCount += 1;
                ((dynamic)DataContext).MainModel.ChangeColor = "#FFF07795";
            }
        }

        Key[] arr = { Key.A, Key.B, Key.C, Key.D, Key.E, Key.F, Key.G, Key.H, Key.I, Key.J, Key.K, Key.L, Key.M,
            Key.N, Key.O, Key.P, Key.Q, Key.R, Key.S, Key.T, Key.U, Key.V, Key.W, Key.X, Key.Y, Key.Z, };

        Key[] arrDigitals = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7, Key.D8, Key.D9 };
        //Key[] arrSpace = { Key.Space };

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (arrDigitals.Contains(e.Key))
            {

                ((dynamic)DataContext).MainModel.Text += e.Key.ToString().ToLower().Trim('d');
            }
            else if (e.Key == Key.Space)
            {
                ((dynamic)DataContext).MainModel.Text += " ";
            }
            else if (arr.Contains(e.Key))
            {
                ((dynamic)DataContext).MainModel.Text += e.Key.ToString().ToLower();
            }
            else if (e.Key == Key.Back)
            {
                if (((dynamic)DataContext).MainModel.Text == "Text: ")
                {
                    return;
                }
                else if (((dynamic)DataContext).MainModel.Text != null)
                {
                    string text = ((dynamic)DataContext).MainModel.Text;
                    ((dynamic)DataContext).MainModel.Text = text[..^1];
                }
            }
            ErrorShow();
        }
    }
}
