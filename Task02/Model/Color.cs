using System.Collections.ObjectModel;
using System.Windows;
using Task02.Command;

namespace Task02.Model
{
    class Color
    {
        public ObservableCollection<Model.Color> Colors { get; set; }
        public string Code { get; set; }

        private RelayCommand? _deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new RelayCommand(obj => {
                    Delete();
                }));
            }
        }

        public void Delete()
        {
            Colors.Remove(this);
        }
    }
}
