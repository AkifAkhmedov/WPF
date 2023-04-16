using System;
using Task04.Model;

namespace Task04.Models
{

    internal class MainModel : Changed
    {

        public MainModel() {
           
        }
        public int _speedText { get; set; }

        public int SpeedText
        {
            get { return _speedText; }
            set
            {
                _speedText = value;
                OnPropertyChanged("SpeedText");

            }
        }

        public bool _isStart{ get; set; }
        public bool IsStart
        {
            get { return _isStart; }
            set
            {
                _isStart = value;
                OnPropertyChanged("IsStart");
            }
        }

        public int _failsCount { get; set; }

        public int FailsCount
        {
            get { return _failsCount; }
            set
            {
                _failsCount = value;
                OnPropertyChanged("FailsCount");

            }
        }

        public string _changeColor { get; set; }
        public string ChangeColor
        {
            get { return _changeColor; }
            set
            {
                _changeColor = value;
                OnPropertyChanged("ChangeColor");

            }
        }



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


        public int _sliderValue { get; set; }

        public int SliderValue
        {
            get { return _sliderValue; }
            set
            {
                _sliderValue = value;
                OnPropertyChanged("SliderValue");
                TextRead = RandomCode(value);

                //int w = ((dynamic)DataContext).MainModel.SliderValue;
                //((dynamic)DataContext).MainModel.TextRead += mainModel.RandomCode(w);
            }
        }


        public string _textRead { get; set; }
        public string TextRead
        {
            get { return _textRead; }
            set
            {
                _textRead = value;
                OnPropertyChanged("TextRead");
            }
        }

        public string RandomCode(int symbols)
        {
            //QWERTYUIOPASDFGHJKLZXCVBNM
            string alphabet = " qwerty uiopas dfghjk lzxcvbnm 0123456789 ";
            string token = "Text: ";
            for (int i = 0; i < symbols; i++)
            {
                token += alphabet[new Random().Next(0, alphabet.Length - 1)];
            }
            return token;
        }
    }

}

