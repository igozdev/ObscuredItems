namespace ObscuredItems
{
    public struct ObscuredDouble
    {
        public ObscuredDouble(double value)
        {
            _mod = Global.RandomDouble();
            _value = value + _mod;
        }

        public double Value
        {
            get => _value - _mod;
            set
            {
                _mod = Global.RandomDouble();
                _value = value + _mod;
            }
        }

        private double _value;
        private double _mod;

        public void Clear()
        {
            _value = 0.0;
            _mod = 0.0;
        }

        public void Update()
        {
            double value = _value - _mod;
            _mod = Global.RandomDouble();
            _value = value + _mod;
        }

        public static explicit operator double(ObscuredDouble obscuredDouble)
            => obscuredDouble.Value;
        public static explicit operator ObscuredDouble(double d)
            => new ObscuredDouble(d);

        public static ObscuredDouble operator ++(ObscuredDouble obscuredDouble)
            => new ObscuredDouble(obscuredDouble.Value + 1);
        public static ObscuredDouble operator --(ObscuredDouble obscuredDouble)
            => new ObscuredDouble(obscuredDouble.Value - 1);
        public static ObscuredDouble operator +(ObscuredDouble lhs, ObscuredDouble rhs)
            => new ObscuredDouble(lhs.Value + rhs.Value);
        public static ObscuredDouble operator -(ObscuredDouble lhs, ObscuredDouble rhs)
            => new ObscuredDouble(lhs.Value - rhs.Value);
        public static ObscuredDouble operator *(ObscuredDouble lhs, ObscuredDouble rhs)
            => new ObscuredDouble(lhs.Value * rhs.Value);
        public static ObscuredDouble operator /(ObscuredDouble lhs, ObscuredDouble rhs)
            => new ObscuredDouble(lhs.Value / rhs.Value);
        public static ObscuredDouble operator %(ObscuredDouble lhs, ObscuredDouble rhs)
            => new ObscuredDouble(lhs.Value % rhs.Value);

        public static bool operator <(ObscuredDouble lhs, ObscuredDouble rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredDouble lhs, ObscuredDouble rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredDouble lhs, ObscuredDouble rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredDouble lhs, ObscuredDouble rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredDouble lhs, ObscuredDouble rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredDouble lhs, ObscuredDouble rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredDouble && this == (ObscuredDouble)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredDouble obscuredDouble)
            => Value.CompareTo(obscuredDouble.Value);
    }
}