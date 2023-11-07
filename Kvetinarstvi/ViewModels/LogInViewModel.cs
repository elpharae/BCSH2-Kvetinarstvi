using CommunityToolkit.Mvvm.ComponentModel;

namespace Kvetinarstvi.ViewModels;

public partial class LogInViewModel : ViewModelBase
{
    [ObservableProperty]
    public string email;
    [ObservableProperty] 
    public string password;
}