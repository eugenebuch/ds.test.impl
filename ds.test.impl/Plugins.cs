using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
    public static class Plugins
    // Был вариант использовать Синглтон, но т.к. в тз написано строго про статику, то не применял его...
    {
        static List<IPlugin> pList = new List<IPlugin>()
        {
            new Sum(), new Mult(), new Div(), new Dif(), new Pow()
        };
        public static int PluginsCount { get { return pList.Count; } }
        public static string[] GetPluginNames {
            get 
            {
                return pList.Select(x => x.PluginName).ToArray();
            }
        }
        public static IPlugin GetPlugin(string pluginName)  =>
            pList.Where(x => x.PluginName == pluginName).ElementAt(0);
    }
}
