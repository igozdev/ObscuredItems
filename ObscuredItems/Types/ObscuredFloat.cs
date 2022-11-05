namespace ObscuredItems
{
    public struct ObscuredFloat
    {
        public ObscuredFloat(float value)
        {
            _mod = Global.RandomFloat();
            _value = value + _mod;
        }

        public float Value
        {
            get => _value - _mod;
            set
            {
                _mod = Global.RandomFloat();
                _value = value + _mod;
            }
        }

        private float _value;
        private float _mod;

        public void Clear()
        {
            _value = 0.0f;
            _mod = 0.0f;
        }

        public void Update()
        {
            float value = _value - _mod;
            _mod = Global.RandomFloat();
            _value = value + _mod;
        }

        public static explicit operator float(ObscuredFloat obscuredFloat)
            => obscuredFloat.Value;
        public static explicit operator ObscuredFloat(float f)
            => new ObscuredFloat(f);

        public static ObscuredFloat operator ++(ObscuredFloat obscuredFloat)
            => new ObscuredFloat(obscuredFloat.Value + 1);
        public static ObscuredFloat operator --(ObscuredFloat obscuredFloat)
            => new ObscuredFloat(obscuredFloat.Value - 1);
        public static ObscuredFloat operator +(ObscuredFloat lhs, ObscuredFloat rhs)
            => new ObscuredFloat(lhs.Value + rhs.Value);
        public static ObscuredFloat operator -(ObscuredFloat lhs, ObscuredFloat rhs)
            => new ObscuredFloat(lhs.Value - rhs.Value);
        public static ObscuredFloat operator *(ObscuredFloat lhs, ObscuredFloat rhs)
            => new ObscuredFloat(lhs.Value * rhs.Value);
        public static ObscuredFloat operator /(ObscuredFloat lhs, ObscuredFloat rhs)
            => new ObscuredFloat(lhs.Value / rhs.Value);
        public static ObscuredFloat operator %(ObscuredFloat lhs, ObscuredFloat rhs)
            => new ObscuredFloat(lhs.Value % rhs.Value);

        public static bool operator <(ObscuredFloat lhs, ObscuredFloat rhs)
            => lhs.Value < rhs.Value;
        public static bool operator >(ObscuredFloat lhs, ObscuredFloat rhs)
            => lhs.Value > rhs.Value;
        public static bool operator <=(ObscuredFloat lhs, ObscuredFloat rhs)
            => lhs.Value <= rhs.Value;
        public static bool operator >=(ObscuredFloat lhs, ObscuredFloat rhs)
            => lhs.Value >= rhs.Value;
        public static bool operator ==(ObscuredFloat lhs, ObscuredFloat rhs)
            => lhs.Value == rhs.Value;
        public static bool operator !=(ObscuredFloat lhs, ObscuredFloat rhs)
            => lhs.Value != rhs.Value;

        public override string ToString()
            => Value.ToString();
        public override bool Equals(object obj)
            => obj is ObscuredFloat && this == (ObscuredFloat)obj;
        public override int GetHashCode()
            => Value.GetHashCode();

        public int CompareTo(ObscuredFloat obscuredFloat)
            => Value.CompareTo(obscuredFloat.Value);
    }
}