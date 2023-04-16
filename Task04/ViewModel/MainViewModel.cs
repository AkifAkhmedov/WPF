
using System.Windows.Threading;
using System;
using Task04.Command;
using Task04.Models;
using System.Windows;

namespace Task04.ViewModel
{
    internal class MainViewModel
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainModel MainModel { get; set; } = new();

        public MainViewModel() {
            MainModel.PropertyChanged += MainModel_PropertyChanged;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += DispatcherTimer_Tick;

        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            int r = MainModel.Text.Length;
            Time++;
            int y = r*60 / Time;
            MainModel.SpeedText = y;
        }

        public int Time = 0;

        public void StartTimer()
        {
            MainModel.IsStart = false;
            Time = 0;
            dispatcherTimer.Start();

        }
        public void StopTimer()
        {

            dispatcherTimer.Stop();
        }



        private void MainModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "SliderValue")
            {
                // Code
            }
        }
        private RelayCommand? _showCommand;
        public RelayCommand ShowCommand
        {
            get
            {
                return _showCommand ?? (_showCommand = new RelayCommand(obj => {
                    Save();
                }));
            }
        }
        public void Save()
        {
           
        }
    } 
}
