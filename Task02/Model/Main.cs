
namespace Task02.Model
{
    class Main : Changed
    {
        private void ToRgbHex()
        {
            System.Drawing.Color color = System.Drawing.Color.FromArgb(AlphaNum, RedNum, GreenNum, BlueNum);
            NewColor = ToHexString(color);
        }
        private string ToHexString(System.Drawing.Color color)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
        }
        private string _newColor { get; set; }
        public string NewColor
        {
            get { return _newColor; }
            set
            {
                _newColor = value;
                OnPropertyChanged("NewColor");
            }
        }

        private int _alphaNum { get; set; }
        public int AlphaNum
        {
            get { return _alphaNum; }
            set
            {
                _alphaNum = value;
                OnPropertyChanged("AlphaNum");
                ToRgbHex();
            }
        }
        private int _redNum { get; set; }
        public int RedNum
        {
            get { return _redNum; }
            set
            {
                _redNum = value;
                OnPropertyChanged("RedNum");
                ToRgbHex();
            }
        }
        private int _greenNum { get; set; }
        public int GreenNum
        {
            get { return _greenNum; }
            set
            {
                _greenNum = value;
                OnPropertyChanged("GreenNum");
                ToRgbHex();
            }
        }
        private int _blueNum { get; set; }
        public int BlueNum
        {
            get { return _blueNum; }
            set
            {
                _blueNum = value;
                OnPropertyChanged("BlueNum");
                ToRgbHex();
            }
        }

        private bool _alpha { get; set; }
        public bool Alpha
        {
            get { return _alpha; }
            set
            {
                _alpha = value;
                OnPropertyChanged("Alpha");
            }
        }
        private bool _red { get; set; }
        public bool Red
        {
            get { return _red; }
            set
            {
                _red = value;
                OnPropertyChanged("Red");
            }
        }
        private bool _green { get; set; }
        public bool Green
        {
            get { return _green; }
            set
            {
                _green = value;
                OnPropertyChanged("Green");
            }
        }
        private bool _blue { get; set; }
        public bool Blue
        {
            get { return _blue; }
            set
            {
                _blue = value;
                OnPropertyChanged("Blue");
            }
        }


    }
}
