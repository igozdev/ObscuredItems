namespace ObscuredItems
{
    public struct ObscuredShort
    {
        public ObscuredShort(short value)
        {
            _mod = Global.RandomShort();
            _value = (short)(value + _mod);
        }

        public short Value
        {
            get => (short)(_value - _mod);
            set
            {
                _mod = Global.RandomShort();
                _value = (short)(value + _mod);
            }
        }

        private short _value;
        private short _mod;

        public void Clear()
        {
            _value = 0;
            _mod = 0;
        }

        public void Update()
        {
            short value = (short)(_value - _mod);
            _mod = Global.RandomShort();
            _value = (short)(value + _mod);
        }

        public static explicit operator short(ObscuredShort obscuredShort)
            => obscuredShort.Value;
        public static explicit operator ObscuredShort(short s)
            => new ObscuredShort(s);

        public static bool operator <(ObscuredShort lhs, ObscuredShort rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredShort lhs, ObscuredShort rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredShort lhs, ObscuredShort rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredShort lhs, ObscuredShort rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredShort lhs, ObscuredShort rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredShort lhs, ObscuredShort rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredShort && this == (ObscuredShort)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredShort obscuredShort)
            => Value.CompareTo(obscuredShort.Value);
    }
}