namespace ObscuredItems
{
    public struct ObscuredLong
    {
        public ObscuredLong(long value)
        {
            _mod = Global.RandomLong();
            _value = value + _mod;
        }

        public long Value
        {
            get => _value - _mod;
            set
            {
                _mod = Global.RandomLong();
                _value = value + _mod;
            }
        }

        private long _value;
        private long _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            long value = _value - _mod;
            _mod = Global.RandomLong();
            _value = value + _mod;
        }

        public static explicit operator long(ObscuredLong obscuredLong)
            => obscuredLong.Value;
        public static explicit operator ObscuredLong(long l)
            => new ObscuredLong(l);

        public static ObscuredLong operator ++(ObscuredLong obscuredLong)
            => new ObscuredLong(obscuredLong.Value + 1);
        public static ObscuredLong operator --(ObscuredLong obscuredLong)
            => new ObscuredLong(obscuredLong.Value - 1);
        public static ObscuredLong operator +(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value + rhs.Value);
        public static ObscuredLong operator -(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value - rhs.Value);
        public static ObscuredLong operator *(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value * rhs.Value);
        public static ObscuredLong operator /(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value / rhs.Value);
        public static ObscuredLong operator %(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value % rhs.Value);

        public static bool operator <(ObscuredLong lhs, ObscuredLong rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredLong lhs, ObscuredLong rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredLong lhs, ObscuredLong rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredLong lhs, ObscuredLong rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredLong lhs, ObscuredLong rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredLong lhs, ObscuredLong rhs)
            => lhs.Value != rhs.Value;

        public static ObscuredLong operator &(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value & rhs.Value);
        public static ObscuredLong operator |(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value | rhs.Value);
        public static ObscuredLong operator ^(ObscuredLong lhs, ObscuredLong rhs)
            => new ObscuredLong(lhs.Value ^ rhs.Value);
        public static ObscuredLong operator ~(ObscuredLong obscuredLong)
            => new ObscuredLong(~obscuredLong.Value);
        public static ObscuredLong operator <<(ObscuredLong lhs, int rhs)
            => new ObscuredLong(lhs.Value << rhs);
        public static ObscuredLong operator >>(ObscuredLong lhs, int rhs)
            => new ObscuredLong(lhs.Value >> rhs);

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredLong && this == (ObscuredLong)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredLong obscuredLong)
            => Value.CompareTo(obscuredLong.Value);
    }
}