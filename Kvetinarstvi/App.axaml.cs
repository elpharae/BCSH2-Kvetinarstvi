using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Kvetinarstvi.Models;
using Kvetinarstvi.ViewModels;
using Kvetinarstvi.Views;

namespace Kvetinarstvi;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        //DatabaseConnector.Connect();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
            desktop.MainWindow.Show();
        } 

        base.OnFrameworkInitializationCompleted();
    }
}