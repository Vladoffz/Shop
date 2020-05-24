using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BLL.Impl;
using Models;

namespace MVVM.ViewModel
{
    public class Observable : INotifyPropertyChanged
    {
        private GoodDTO selectedgood;
        private DestinationDTO selecteddestination;
        private TransportDTO selectedtransport;
        public ObservableCollection<GoodDTO> Goods { get; set; }
        public ObservableCollection<DestinationDTO> Destinations { get; set; }
        public ObservableCollection<TransportDTO> Transports { get; set; }
        DestinationService destinationService = new DestinationService();
        GoodService goodService = new GoodService();
        TransportService transportService = new TransportService();
        public GoodDTO SelectedGood
        {
            get { return selectedgood; }
            set
            {
                selectedgood = value;
                OnPropertyChanged("Selected Good");
            }
        }

        public DestinationDTO SelectedDestination
        {
            get { return selecteddestination; }
            set
            {
                selecteddestination = value;
                OnPropertyChanged("Selected Destination");
            }
        }

        public TransportDTO SelectedTransport
        {
            get { return selectedtransport; }
            set
            {
                selectedtransport = value;
                OnPropertyChanged("Selected Transport");
            }
        }

        public Observable()
        {
           
            Goods = new ObservableCollection<GoodDTO>(goodService.ListEntities());
           
            Destinations = new ObservableCollection<DestinationDTO>(destinationService.ListEntities());
            
            Transports = new ObservableCollection<TransportDTO>(transportService.ListEntities());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

