using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Kvetinarstvi.ViewModels;

public partial class RegisterViewModel : ViewModelBase
{
    [ObservableProperty]
    public string jmeno;
    [ObservableProperty]
    public string prijmeni;
    [ObservableProperty]
    public string email;
    [ObservableProperty]
    public string mesto;
    [ObservableProperty]
    public string ulice;
    [ObservableProperty]
    public string cp;
    [ObservableProperty]
    public string psc;
    [ObservableProperty]
    public string heslo;
    [ObservableProperty]
    public string hesloZnovu;


    [RelayCommand]
    public void Registrovat()
    {
        
    }
}