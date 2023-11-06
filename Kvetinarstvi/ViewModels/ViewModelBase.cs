﻿using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Kvetinarstvi.ViewModels;

public class ViewModelBase : ObservableObject
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
    }
}