using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Models;


namespace MVVM.ViewModel
{
    public class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Observable observable = new Observable();
        public ObservableCollection<TransportDTO> Transports { get; set; }
        public ObservableCollection<GoodDTO> Goods { get; set; }
        public ObservableCollection<DestinationDTO> Destinations { get; set; }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Base()
        {
            Transports = observable.Transports;
            Goods = observable.Goods;
            Destinations = observable.Destinations;
        }
        
    }
}
