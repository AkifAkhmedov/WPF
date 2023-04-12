using System.Collections.ObjectModel;
using System.Windows;
using Task02.Command;
using Task02.Model;

namespace Task02.ViewModels
{
    class MainViewModel : Changed
    {
        public ObservableCollection<Model.Color> Colors { get; set; } = new();
        public Main MainModel { get; set; } = new();

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

        public void Show()
        {
            Color color = new Model.Color();
            color.Code = MainModel.NewColor;
            color.Colors = Colors;
            Colors.Add(color); 
        }
    }
}
