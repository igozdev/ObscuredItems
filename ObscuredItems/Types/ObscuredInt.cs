namespace ObscuredItems
{
    public struct ObscuredInt
    {
        public ObscuredInt(int value)
        {
            _mod = Global.RandomInt();
            _value = value + _mod;
        }

        public int Value
        {
            get => _value - _mod;
            set
            {
                _mod = Global.RandomInt();
                _value = value + _mod;
            }
        }

        private int _value;
        private int _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            int value = _value - _mod;
            _mod = Global.RandomInt();
            _value = value + _mod;
        }

        public static explicit operator int(ObscuredInt obscuredInt)
            => obscuredInt.Value;
        public static explicit operator ObscuredInt(int i)
            => new ObscuredInt(i);

        public static ObscuredInt operator ++(ObscuredInt obscuredInt)
            => new ObscuredInt(obscuredInt.Value + 1);
        public static ObscuredInt operator --(ObscuredInt obscuredInt)
            => new ObscuredInt(obscuredInt.Value - 1);
        public static ObscuredInt operator +(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value + rhs.Value);
        public static ObscuredInt operator -(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value - rhs.Value);
        public static ObscuredInt operator *(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value * rhs.Value);
        public static ObscuredInt operator /(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value / rhs.Value);
        public static ObscuredInt operator %(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value % rhs.Value);

        public static bool operator <(ObscuredInt lhs, ObscuredInt rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredInt lhs, ObscuredInt rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredInt lhs, ObscuredInt rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredInt lhs, ObscuredInt rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredInt lhs, ObscuredInt rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredInt lhs, ObscuredInt rhs)
            => lhs.Value != rhs.Value;

        public static ObscuredInt operator &(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value & rhs.Value);
        public static ObscuredInt operator |(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value | rhs.Value);
        public static ObscuredInt operator ^(ObscuredInt lhs, ObscuredInt rhs)
            => new ObscuredInt(lhs.Value ^ rhs.Value);
        public static ObscuredInt operator ~(ObscuredInt obscuredInt)
            => new ObscuredInt(~obscuredInt.Value);
        public static ObscuredInt operator <<(ObscuredInt lhs, int rhs)
            => new ObscuredInt(lhs.Value << rhs);
        public static ObscuredInt operator >>(ObscuredInt lhs, int rhs)
            => new ObscuredInt(lhs.Value >> rhs);

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredInt && this == (ObscuredInt)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredInt obscuredInt)
            => Value.CompareTo(obscuredInt.Value);
    }
}