namespace ObscuredItems
{
    public struct ObscuredChar
    {
        public ObscuredChar(char value)
        {
            _mod = Global.RandomChar();
            _value = (char)(value + _mod);
        }

        public char Value
        {
            get => (char)(_value - _mod);
            set
            {
                _mod = Global.RandomChar();
                _value = (char)(value + _mod);
            }
        }

        private char _value;
        private char _mod;

        public void Clear()
        {
            _value = '\0';
            _mod = '\0';
        }

        public void Update()
        {
            char value = (char)(_value - _mod);
            _mod = Global.RandomChar();
            _value = (char)(value + _mod);
        }

        public static explicit operator char(ObscuredChar obscuredChar)
            => obscuredChar.Value;
        public static explicit operator ObscuredChar(char c)
            => new ObscuredChar(c);

        public static bool operator ==(ObscuredChar lhs, ObscuredChar rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredChar lhs, ObscuredChar rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredChar && this == (ObscuredChar)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredChar obscuredChar)
            => Value.CompareTo(obscuredChar.Value);
    }
}