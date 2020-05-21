using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl
{
    class Mult : IPlugin
    {
        public string PluginName { get; } = "Multiply";
        public string Version { get; } = "1.0";
        public Image Image { get; } = new Bitmap(50, 50);
        public string Description { get; } = "Returns the multiply of 2 integers";
        public int Run(int input1, int input2) =>
            input1 * input2;
    }
}
