using CommunityToolkit.Mvvm.ComponentModel;

namespace Kvetinarstvi.ViewModels;

public partial class BaseInterfaceViewModel : ViewModelBase
{
    [ObservableProperty]
    private string testText = "Hello World!";
}