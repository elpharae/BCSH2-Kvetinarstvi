using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Kvetinarstvi.ViewModels;

public partial class LogInViewModel : ViewModelBase
{
    [ObservableProperty]
    public string username;
    [ObservableProperty] 
    public string password;

}