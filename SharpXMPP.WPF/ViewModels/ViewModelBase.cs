﻿using SharpXMPP.WPF.Models;
using System.ComponentModel;

namespace SharpXMPP.WPF.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected XMPPContext Db = new XMPPContext();

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
