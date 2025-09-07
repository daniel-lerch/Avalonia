using System;
using ControlCatalog;
using Avalonia;

namespace WindowsInteropTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
#if NETCOREAPP3_0_OR_GREATER
            System.Windows.Forms.Application.SetHighDpiMode(System.Windows.Forms.HighDpiMode.PerMonitorV2);
#endif
            AppBuilder.Configure<App>()
                .UseWin32()
                .UseSkia()
                .SetupWithoutStarting();
            System.Windows.Forms.Application.Run(new EmbedToWinFormsDemo());
        }
    }
}
