using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Kvetinarstvi.Views;

public partial class LogInView : Window
{
    public LogInView()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}