using System.Windows;

namespace WPFDemo;

public partial class App : Application
{
    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var window = new MainWindow(new DemoViewModel());
        window.Show();
    }
}