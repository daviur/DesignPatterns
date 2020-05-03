namespace DesignPatterns.Creational.Monostate
{
    public class Monostate
    {
        // All data is static. All instances will use the same "state"
        private static int _data1;
        private static string _data2;
        private static long _data3;
        private static bool _initialized;
        private static readonly object Lock = new object();

        public Monostate()
        {
            if (_initialized) return;
            lock (Lock)
            {
                if (_initialized) return;
                _data3 = 1000000;
                _initialized = true;
            }
        }

        public int Data1
        {
            get => _data1;
            set => _data1 = value;
        }

        public string Data2
        {
            get => _data2;
            set => _data2 = value;
        }

        public long Data3 => _data3;

        public override string ToString()
        {
            return $"{nameof(Monostate)}=[{Data1}:{Data2}:{Data3}]";
        }
    }
}