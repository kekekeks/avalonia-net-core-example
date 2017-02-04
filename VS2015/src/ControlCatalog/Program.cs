using Avalonia.Logging.Serilog;
using System;
using System.Linq;
using System.Reflection;
using Avalonia;
using System.Linq;

namespace ControlCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }
    }
}
