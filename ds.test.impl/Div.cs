using System.Drawing;

namespace ds.test.impl
{
    class Div : IPlugin
    {
        public string PluginName { get; } = "Division";
        public string Version { get; } = "1.0";
        public Image Image { get; } = new Bitmap(50, 50);
        public string Description { get; } = "Returns the division of 2 integers (rounded down)";
        public int Run(int input1, int input2) =>
            input2 == 0 ? 0 : input1 / input2;
    }
}
