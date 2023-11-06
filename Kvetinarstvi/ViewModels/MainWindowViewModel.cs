using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Kvetinarstvi.Models;

namespace Kvetinarstvi.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ViewModelBase CurrentViewModel { get; set; }

    [ObservableProperty] 
    public ObservableCollection<KvetinaModel> kvetiny;

    public MainWindowViewModel()
    {
        CurrentViewModel = new LogInViewModel();
        

        KategorieModel katRezane = new KategorieModel(1, "rezane kvetiny",null);
        KategorieModel katSukulenty = new KategorieModel(2, "sukulenty",null);
        CenaModel cena1 = new CenaModel(1, 150);
        CenaModel cena2 = new CenaModel(2, 50);
        CenaModel cena3 = new CenaModel(3, 350);
        
        kvetiny = new ObservableCollection<KvetinaModel>();
        kvetiny.Add(new KvetinaModel(1,"ruze",15,"popis ruze", new BarvaModel(1,"cervena"),katRezane,cena1,null));
        kvetiny.Add(new KvetinaModel(2,"tulipan",5,"popis tulipan", new BarvaModel(2,"ruzova"),katRezane,cena2,null));
        kvetiny.Add(new KvetinaModel(3,"slunecnice",8,"popis slunecnice", new BarvaModel(3,"zluta"),katRezane,cena3,null));
        kvetiny.Add(new KvetinaModel(4,"lilie",13,"popis lilie", new BarvaModel(4,"bila"),katRezane,cena2,null));
        kvetiny.Add(new KvetinaModel(5,"kaktus",7,"popis kaktusu",new BarvaModel(4,"zelena"),katSukulenty,cena1,null));
    }
}