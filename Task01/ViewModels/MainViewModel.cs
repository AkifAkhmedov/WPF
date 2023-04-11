
using Task01.Command;
using Task01.Model;

namespace Task01.ViewModels
{
    internal class MainViewModel
    {
        public MainModel Main { get; set; } = new();
        private RelayCommand? _showCommand;
        public RelayCommand ShowCommand
        {
            get
            {
                return _showCommand ?? (_showCommand = new RelayCommand(obj => {
                    Show();
                }));
            }
        }
        private RelayCommand? _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new RelayCommand(obj => {
                    Save();
                }));
            }
        }
        public MainViewModel() {
            Main.Name = "Akif1111111111";
            Main.Age++;
        }
        private void Show()
        {
            Main.Symbols.Add(new Symbol() { Name = "BTC", Price = 0.5m });
        }
        private void Save()
        {
            Main.Name = Main.Text.ToString();
        }
    }
}
