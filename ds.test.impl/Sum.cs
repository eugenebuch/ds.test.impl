using System.Drawing;

namespace ds.test.impl
{
    class Sum : IPlugin
    {
        public string PluginName { get; } = "Sum";
        public string Version { get; } = "1.0";
        public Image Image { get; } = new Bitmap(50, 50);
        public string Description { get; } = "Returns the sum of 2 integers";
        public int Run(int input1, int input2) =>
            input1 + input2;
    }
}
