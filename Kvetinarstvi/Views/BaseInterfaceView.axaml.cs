using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Kvetinarstvi.Views;

public partial class BaseInterfaceView : Window
{
    public BaseInterfaceView()
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