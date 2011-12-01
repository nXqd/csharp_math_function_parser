using ktpm_bt5.helpers;

namespace ktpm_bt5 {
    internal class Program {
        private static void Main() {
            var strings = DataReader.Read();
            DataParser.Run(strings);
        }
    }
}