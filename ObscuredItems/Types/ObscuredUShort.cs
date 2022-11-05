namespace ObscuredItems
{
    public struct ObscuredUShort
    {
        public ObscuredUShort(ushort value)
        {
            _mod = Global.RandomUShort();
            _value = (ushort)(value + _mod);
        }

        public ushort Value
        {
            get => (ushort)(_value - _mod);
            set
            {
                _mod = Global.RandomUShort();
                _value = (ushort)(value + _mod);
            }
        }

        private ushort _value;
        private ushort _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            ushort value = (ushort)(_value - _mod);
            _mod = Global.RandomUShort();
            _value = (ushort)(value + _mod);
        }

        public static explicit operator ushort(ObscuredUShort obscuredUShort)
            => obscuredUShort.Value;
        public static explicit operator ObscuredUShort(ushort u)
            => new ObscuredUShort(u);

        public static bool operator <(ObscuredUShort lhs, ObscuredUShort rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredUShort lhs, ObscuredUShort rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredUShort lhs, ObscuredUShort rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredUShort lhs, ObscuredUShort rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredUShort lhs, ObscuredUShort rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredUShort lhs, ObscuredUShort rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredUShort && this == (ObscuredUShort)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredUShort obscuredUShort)
            => Value.CompareTo(obscuredUShort.Value);
    }
}