namespace ObscuredItems
{
    public struct ObscuredByte
    {
        public ObscuredByte(byte value)
        {
            _mod = Global.RandomByte();
            _value = (byte)(value + _mod);
        }

        public byte Value
        {
            get => (byte)(_value - _mod);
            set
            {
                _mod = Global.RandomByte();
                _value = (byte)(value + _mod);
            }
        }

        private byte _value;
        private byte _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            int value = _value - _mod;
            _mod = Global.RandomByte();
            _value = (byte)(value + _mod);
        }

        public static explicit operator byte(ObscuredByte obscuredByte)
            => obscuredByte.Value;
        public static explicit operator ObscuredByte(byte b)
            => new ObscuredByte(b);

        public static bool operator <(ObscuredByte lhs, ObscuredByte rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredByte lhs, ObscuredByte rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredByte lhs, ObscuredByte rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredByte lhs, ObscuredByte rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredByte lhs, ObscuredByte rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredByte lhs, ObscuredByte rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredByte && this == (ObscuredByte)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredByte obscuredByte)
            => Value.CompareTo(obscuredByte.Value);
    }
}