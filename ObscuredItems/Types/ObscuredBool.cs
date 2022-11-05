namespace ObscuredItems
{
    public struct ObscuredBool
    {
        public ObscuredBool(bool value)
        {
            _mod = Global.RandomBool();
            _value = value ^ _mod;
        }

        public bool Value
        {
            get => _value ^ _mod;
            set
            {
                _mod = Global.RandomBool();
                _value = value ^ _mod;
            }
        }

        private bool _value;
        private bool _mod;

        public void Clear()
        {
            _value = false;
            _mod = false;
        }

        public void Update()
        {
            bool value = _value ^ _mod;
            _mod = Global.RandomBool();
            _value = value ^ _mod;
        }

        public static explicit operator bool(ObscuredBool obscuredBool)
            => obscuredBool.Value;
        public static explicit operator ObscuredBool(bool b)
            => new ObscuredBool(b);

        public static bool operator ==(ObscuredBool lhs, ObscuredBool rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredBool lhs, ObscuredBool rhs)
            => lhs.Value != rhs.Value;

        public static ObscuredBool operator &(ObscuredBool lhs, ObscuredBool rhs)
            => new ObscuredBool(lhs.Value & rhs.Value);
        public static ObscuredBool operator |(ObscuredBool lhs, ObscuredBool rhs)
            => new ObscuredBool(lhs.Value | rhs.Value);
        public static ObscuredBool operator ^(ObscuredBool lhs, ObscuredBool rhs)
            => new ObscuredBool(lhs.Value ^ rhs.Value);
        public static ObscuredBool operator !(ObscuredBool obscuredBool)
            => new ObscuredBool(!obscuredBool.Value);

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredInt && this == (ObscuredBool)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredBool obscuredBool)
            => Value.CompareTo(obscuredBool.Value);
    }
}