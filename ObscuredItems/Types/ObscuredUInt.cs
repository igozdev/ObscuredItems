namespace ObscuredItems
{
    public struct ObscuredUInt
    {
        public ObscuredUInt(uint value)
        {
            _mod = Global.RandomUInt();
            _value = value + _mod;
        }

        public uint Value
        {
            get => _value - _mod;
            set
            {
                _mod = Global.RandomUInt();
                _value = value + _mod;
            }
        }

        private uint _value;
        private uint _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            uint value = _value - _mod;
            _mod = Global.RandomUInt();
            _value = value + _mod;
        }

        public static explicit operator uint(ObscuredUInt obscuredInt)
            => obscuredInt.Value;
        public static explicit operator ObscuredUInt(uint u)
            => new ObscuredUInt(u);

        public static ObscuredUInt operator ++(ObscuredUInt obscuredInt)
            => new ObscuredUInt(obscuredInt.Value + 1);
        public static ObscuredUInt operator --(ObscuredUInt obscuredInt)
            => new ObscuredUInt(obscuredInt.Value - 1);
        public static ObscuredUInt operator +(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value + rhs.Value);
        public static ObscuredUInt operator -(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value - rhs.Value);
        public static ObscuredUInt operator *(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value * rhs.Value);
        public static ObscuredUInt operator /(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value / rhs.Value);
        public static ObscuredUInt operator %(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value % rhs.Value);

        public static bool operator <(ObscuredUInt lhs, ObscuredUInt rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredUInt lhs, ObscuredUInt rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredUInt lhs, ObscuredUInt rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredUInt lhs, ObscuredUInt rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredUInt lhs, ObscuredUInt rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredUInt lhs, ObscuredUInt rhs)
            => lhs.Value != rhs.Value;

        public static ObscuredUInt operator &(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value & rhs.Value);
        public static ObscuredUInt operator |(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value | rhs.Value);
        public static ObscuredUInt operator ^(ObscuredUInt lhs, ObscuredUInt rhs)
            => new ObscuredUInt(lhs.Value ^ rhs.Value);
        public static ObscuredUInt operator ~(ObscuredUInt obscuredInt)
            => new ObscuredUInt(~obscuredInt.Value);
        public static ObscuredUInt operator <<(ObscuredUInt lhs, int rhs)
            => new ObscuredUInt(lhs.Value << rhs);
        public static ObscuredUInt operator >>(ObscuredUInt lhs, int rhs)
            => new ObscuredUInt(lhs.Value >> rhs);

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredUInt && this == (ObscuredUInt)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredUInt obscuredInt)
            => Value.CompareTo(obscuredInt.Value);
    }
}