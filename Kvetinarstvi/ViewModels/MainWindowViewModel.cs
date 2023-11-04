using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Kvetinarstvi.Models;

namespace Kvetinarstvi.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    [ObservableProperty] 
    public ObservableCollection<KvetinaModel> kvetiny;

    public MainWindowViewModel()
    {
        kvetiny = new ObservableCollection<KvetinaModel>();
        kvetiny.Add(new KvetinaModel(1,"ruze",15,"popis ruze", new BarvaModel(1,"cervena")));
        kvetiny.Add(new KvetinaModel(2,"tulipan",5,"popis tulipan", new BarvaModel(2,"ruzova")));
        kvetiny.Add(new KvetinaModel(3,"slunecnice",8,"popis slunecnice", new BarvaModel(3,"zluta")));
        kvetiny.Add(new KvetinaModel(4,"lilie",13,"popis lilie", new BarvaModel(4,"bila")));
        
    }
}