using Avalonia.Controls;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.Input;

namespace Kvetinarstvi.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Width = 1024;
        this.Height = 768;
    }

    [RelayCommand]
    public LogInView OpenLoginViewModel()
    {
        LogInView window = new ();
        window.Show();
        return window;
    }
}