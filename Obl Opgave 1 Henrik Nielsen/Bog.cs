using System;

namespace Obl_Opgave_1_Henrik_Nielsen
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public Bog()
        {
            
        }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
        }

        public string Titel
        {
            get { return _titel; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Titel must be 2 or more characters");
                }
                else
                {
                    _titel = value;
                }
            }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }

        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                if (value < 10 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Sidetal must be a value between 10 and 1000");
                }
                else
                {
                    _sidetal = value;
                }
            }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set {
                if (value.Length != 13)
                {
                    throw new ArgumentOutOfRangeException("Isbn13 must be precisely 13 characters long");
                }
                else
                {
                    _isbn13 = value;
                }
            }
        }
    }
}
