using System.Diagnostics;
using System.Threading;
using Windows.System;
using WinRT;

namespace WUXIND
{
#if DISABLE_XAML_GENERATED_MAIN
    /// <summary>
    /// Program class
    /// </summary>
    public static class Program
    {
        static void Main(string[] args)
        {
            //Debugger.Launch();
            ComWrappersSupport.InitializeComWrappers();
            Windows.UI.Xaml.Application.Start((p) =>
            {
                new App();
            });
        }
    }
#endif
}