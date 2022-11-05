namespace ObscuredItems
{
    public static class Global
    {
        public static int FloatModMin = -30000;
        public static int FloatModMax = 30000;
        public static int DoubleModMin = -30000;
        public static int DoubleModMax = 30000;

        public static bool RandomBool()
            => UnityEngine.Random.Range(0, 2) == 0;
        public static char RandomChar()
            => (char)UnityEngine.Random.Range(char.MinValue, char.MaxValue);
        public static byte RandomByte()
            => (byte)UnityEngine.Random.Range(byte.MinValue, byte.MaxValue);
        public static sbyte RandomSByte()
            => (sbyte)UnityEngine.Random.Range(sbyte.MinValue, sbyte.MaxValue);
        public static short RandomShort()
            => (short)UnityEngine.Random.Range(short.MinValue, short.MaxValue);
        public static ushort RandomUShort()
            => (ushort)UnityEngine.Random.Range(ushort.MinValue, short.MaxValue);
        public static int RandomInt()
            => UnityEngine.Random.Range(int.MinValue, int.MaxValue);
        public static uint RandomUInt()
            => (uint)UnityEngine.Random.Range(uint.MinValue, uint.MaxValue);
        public static long RandomLong()
            => (((long)UnityEngine.Random.Range(int.MinValue, int.MaxValue)) << 32) | (long)UnityEngine.Random.Range(int.MinValue, int.MaxValue);
        public static ulong RandomULong()
            => (ulong)(((long)(UnityEngine.Random.Range(int.MinValue, int.MaxValue)) << 32) | (long)UnityEngine.Random.Range(int.MinValue, int.MaxValue));
        public static float RandomFloat()
            => UnityEngine.Random.Range(FloatModMin, FloatModMax);
        public static double RandomDouble()
            => UnityEngine.Random.Range(DoubleModMin, DoubleModMax);
    }
}