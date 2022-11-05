namespace ObscuredItems
{
    public struct ObscuredULong
    {
        public ObscuredULong(ulong value)
        {
            _mod = Global.RandomULong();
            _value = value + _mod;
        }

        public ulong Value
        {
            get => _value - _mod;
            set
            {
                _mod = Global.RandomULong();
                _value = value + _mod;
            }
        }

        private ulong _value;
        private ulong _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            ulong value = _value - _mod;
            _mod = Global.RandomULong();
            _value = value + _mod;
        }

        public static explicit operator ulong(ObscuredULong obscuredULong)
            => obscuredULong.Value;
        public static explicit operator ObscuredULong(ulong l)
            => new ObscuredULong(l);

        public static ObscuredULong operator ++(ObscuredULong obscuredULong)
            => new ObscuredULong(obscuredULong.Value + 1);
        public static ObscuredULong operator --(ObscuredULong obscuredULong)
            => new ObscuredULong(obscuredULong.Value - 1);
        public static ObscuredULong operator +(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value + rhs.Value);
        public static ObscuredULong operator -(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value - rhs.Value);
        public static ObscuredULong operator *(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value * rhs.Value);
        public static ObscuredULong operator /(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value / rhs.Value);
        public static ObscuredULong operator %(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value % rhs.Value);

        public static bool operator <(ObscuredULong lhs, ObscuredULong rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredULong lhs, ObscuredULong rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredULong lhs, ObscuredULong rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredULong lhs, ObscuredULong rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredULong lhs, ObscuredULong rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredULong lhs, ObscuredULong rhs)
            => lhs.Value != rhs.Value;

        public static ObscuredULong operator &(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value & rhs.Value);
        public static ObscuredULong operator |(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value | rhs.Value);
        public static ObscuredULong operator ^(ObscuredULong lhs, ObscuredULong rhs)
            => new ObscuredULong(lhs.Value ^ rhs.Value);
        public static ObscuredULong operator ~(ObscuredULong obscuredULong)
            => new ObscuredULong(~obscuredULong.Value);
        public static ObscuredULong operator <<(ObscuredULong lhs, int rhs)
            => new ObscuredULong(lhs.Value << rhs);
        public static ObscuredULong operator >>(ObscuredULong lhs, int rhs)
            => new ObscuredULong(lhs.Value >> rhs);

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredULong && this == (ObscuredULong)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredULong obscuredULong)
            => Value.CompareTo(obscuredULong.Value);
    }
}