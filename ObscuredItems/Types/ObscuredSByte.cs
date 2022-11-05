namespace ObscuredItems
{
    public struct ObscuredSByte
    {
        public ObscuredSByte(sbyte value)
        {
            _mod = Global.RandomSByte();
            _value = (sbyte)(value + _mod);
        }

        public sbyte Value
        {
            get => (sbyte)(_value - _mod);
            set
            {
                _mod = Global.RandomSByte();
                _value = (sbyte)(value + _mod);
            }
        }

        private sbyte _value;
        private sbyte _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            int value = _value - _mod;
            _mod = Global.RandomSByte();
            _value = (sbyte)(value + _mod);
        }

        public static explicit operator sbyte(ObscuredSByte obscuredSByte)
            => obscuredSByte.Value;
        public static explicit operator ObscuredSByte(sbyte b)
            => new ObscuredSByte(b);

        public static bool operator <(ObscuredSByte lhs, ObscuredSByte rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredSByte lhs, ObscuredSByte rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredSByte lhs, ObscuredSByte rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredSByte lhs, ObscuredSByte rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredSByte lhs, ObscuredSByte rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredSByte lhs, ObscuredSByte rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredSByte && this == (ObscuredSByte)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredSByte obscuredSByte)
            => Value.CompareTo(obscuredSByte.Value);
    }
}