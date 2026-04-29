namespace SynopticApp;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    // Overrides default settings, and sets the window to an appropriate size when executed.
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = 550;
        const int newHeight = 650;

        window.X = 500;
        window.Y = 200;

        window.Width = newWidth;
        window.Height = newHeight;

        window.MinimumHeight = newHeight;
        window.MinimumWidth = newWidth;

        window.MinimumHeight = newHeight;
        window.MaximumWidth = newWidth;

        return window;
    }
}


