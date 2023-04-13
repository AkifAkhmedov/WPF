using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Task03.Command;
using Task03.Model;
using static System.Net.Mime.MediaTypeNames;

namespace Task03.ViewModel
{
    class MainViewModel
    {

        public MainViewModel() {}
        public Button ButtonButton { get; set; } = new Button();

        public MainModel MainModel { get; set; } = new();
        //private RelayCommand? _showCommand;
        //public RelayCommand ShowCommand
        //{
        //    get
        //    {
        //        return _showCommand ?? (_showCommand = new RelayCommand(obj => {
        //            if(obj != null)
        //            MessageBox.Show(obj.GetType().ToString());
        //            //Button button = (Button)obj;
        //            //PressButton(button);
        //        }));
        //    }
        //}

        public string Action = "";
        public string ReplaceSymbol = "";


        decimal plus = 0m;

        decimal PlusA = 0m;
        decimal PlusB = 0m;
        decimal PlusRes = 0m;

        decimal MinusA = 0m;
        decimal MinusB = 0m;
        decimal MinusRes = 0m;

        decimal MultiplyA = 0m;
        decimal MultiplyB = 0m;
        decimal MultiplyRes = 0m;

        decimal DivisionA = 0m;
        decimal DivisionB = 0m;
        decimal DivisionRes = 0m;





        string[] arr = { "0", "1", "2", "3", "4", "5", "6","7", "8", "9", }; 
        public void PressButton(Button button)
        {
            if (arr.Contains(button.Content))
            {
                MainModel.Text += button.Content;
            }
            else if (button.Content.ToString() == "/")
            {
                Action = "/";
                if (MainModel.Text != null)
                {
                    if (MainModel.Text == "")
                    {
                        return;
                    }
                    MainModel.ReadOnlyText += MainModel.Text + "/";
                    DivisionA = Convert.ToDecimal(MainModel.Text);
                    MainModel.Text = "";
                }
            }
            else if (button.Content.ToString() == "*")
            {
                Action = "*";
                if (MainModel.Text != null)
                {
                    if (MainModel.Text == "")
                    {
                        return;
                    }
                    MainModel.ReadOnlyText += MainModel.Text + "*";
                    MultiplyA = Convert.ToDecimal(MainModel.Text);
                    MainModel.Text = "";
                }
            }
            else if (button.Content.ToString() == "-")
            {
                Action = "-";
                if (MainModel.Text != null)
                {
                    if (MainModel.Text == "")
                    {
                        return;
                    }
                    MainModel.ReadOnlyText += MainModel.Text + "-";
                    MinusA = Convert.ToDecimal(MainModel.Text);
                    MainModel.Text = "";
                }
            }
            else if (button.Content.ToString() == "+")
            {
                Action = "+";
                if (MainModel.Text != null)
                {
                    if (MainModel.Text == "")
                    {
                        return;
                    }
                    MainModel.ReadOnlyText += MainModel.Text + "+";
                    PlusA = Convert.ToDecimal(MainModel.Text);
                    MainModel.Text = "";
                }
            }   
            else if (button.Content.ToString() == "=")
            {
                if (MainModel.Text != null)
                {
                    if(MainModel.Text != "" && Action == "+") 
                    {
                        PlusB = Convert.ToDecimal(MainModel.Text);
                        PlusRes = PlusA + PlusB;
                        MainModel.Text = PlusRes.ToString();
                        MainModel.ReadOnlyText = "";
                    }
                    else if (MainModel.Text != "" && Action == "-")
                    {
                        MinusB = Convert.ToDecimal(MainModel.Text);
                        MinusRes = MinusA - MinusB;
                        MainModel.Text = MinusRes.ToString();
                        MainModel.ReadOnlyText = "";
                    }
                    else if (MainModel.Text != "" && Action == "*")
                    {
                        MultiplyB = Convert.ToDecimal(MainModel.Text);
                        MultiplyRes = MultiplyA * MultiplyB;
                        MainModel.Text = MultiplyRes.ToString();
                        MainModel.ReadOnlyText = "";
                    }
                    else if (MainModel.Text != "" && Action == "/")
                    {
                        DivisionB = Convert.ToDecimal(MainModel.Text);
                        DivisionRes = DivisionA / DivisionB;
                        MainModel.Text = DivisionRes.ToString();
                        MainModel.ReadOnlyText = "";
                    }
                }
            }
            else if (button.Content.ToString() == ",")
            {
                if (MainModel.Text != "" && MainModel.Text != null )
                {
                   if(MainModel.Text.Contains(","))
                    {
                        return;
                    }
                    MainModel.Text += button.Content;
                }
            }

            else if (button.Content.ToString() == "CE")
            {
                MainModel.ReadOnlyText = "";
                MainModel.Text = "";
                plus = 0m;
                PlusA = 0m;
                PlusB = 0m;
                PlusRes = 0m;

                MinusA = 0m;
                MinusB = 0m;
                MinusRes = 0m;

                MultiplyA = 0m;
                MultiplyB = 0m;
                MultiplyRes = 0m;

                DivisionA = 0m;
                DivisionB = 0m;
                DivisionRes = 0m;
            }
            else if (button.Content.ToString() == "C")
            {
                MainModel.ReadOnlyText = "";
                MainModel.Text = "";

                plus = 0m;
                PlusA = 0m;
                PlusB = 0m;
                PlusRes = 0m;

                MinusA = 0m;
                MinusB = 0m;
                MinusRes = 0m;

                MultiplyA = 0m;
                MultiplyB = 0m;
                MultiplyRes = 0m;

                DivisionA = 0m;
                DivisionB = 0m;
                DivisionRes = 0m;
            }
            else if (button.Content.ToString() == "˂")
            {
                if (MainModel.Text != "" && MainModel.Text != null)
                {
                    MainModel.Text = MainModel.Text[..^1];
                }
            }
        }
    }
}
