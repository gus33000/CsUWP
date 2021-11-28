namespace WUXIND
{
#if !DISABLE_XAML_GENERATED_MAIN
    /// <summary>
    /// Program class
    /// </summary>
    public static class Program
    {
        static void Main(string[] args)
        {
            Windows.UI.Xaml.Application.Start((p) => new App());
        }
    }
#endif

    partial class App : Windows.UI.Xaml.Application
    {
        private bool _contentLoaded;
        /// <summary>
        /// InitializeComponent()
        /// </summary>
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
/*#if DEBUG && !DISABLE_XAML_GENERATED_BINDING_DEBUG_OUTPUT
            DebugSettings.BindingFailed += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine(args.Message);
            };
#endif
#if DEBUG && !DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION
            UnhandledException += (sender, e) =>
            {
                if (System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debugger.Break();
            };
#endif*/
        }
    }
}

