using System.Collections.ObjectModel;

namespace Task01.Model
{
    internal class MainModel : Changed
    {
        public ObservableCollection<Symbol> Symbols { get; set; } = new();
        private string _name { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private int _age { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        private string _text { get; set; }
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }
    }
}
