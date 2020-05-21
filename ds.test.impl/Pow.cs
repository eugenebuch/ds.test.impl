using System.Drawing;

namespace ds.test.impl
{
    class Pow : IPlugin
    {
        public string PluginName { get; } = "Power";
        public string Version { get; } = "1.0";
        public Image Image { get; } = new Bitmap(50, 50);
        public string Description { get; } = "Returns the first number to the power of the second";
        public int Run(int input1, int input2) =>
            input2 == 0 ? 1 : input1 * Run(input1, input2-1);
        // Рекурсия была выбрана из-за удобочитаемости кода. Итеративный способ был бы быстрее и выгоднее по памяти
    }
}
