using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.Model
{
    class MainModel : Changed

    {
        public string _text { get; set; }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public string _readOnlyText { get; set; }

        public string ReadOnlyText
        {
            get { return _readOnlyText; }
            set
            {
                _readOnlyText = value;
                OnPropertyChanged("ReadOnlyText");
            }
        }



        public decimal _digitalA { get; set; }
        public decimal DigitalA
        {
            get { return _digitalA; }
            set
            {
                _digitalA = value;
                OnPropertyChanged("DigitalA");
            }
        }
        public decimal _digitalB = 0m;
        public decimal DigitalB
        {
            get { return _digitalB; }
            set
            {
                _digitalB = value;
                OnPropertyChanged("DigitalB");
            }
        }


    }
}
