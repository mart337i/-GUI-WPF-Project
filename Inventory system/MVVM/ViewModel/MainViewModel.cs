using Inventory_system.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system.MVVM.ViewModel
{
    class MainViewModel : ObserableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private ObserableObject _currentView;

        public ObserableObject? CurrentView
        {
            get => _currentView;
            set { _currentView = value; onPropertyChanged();}
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;

            //what the fuck 
            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            DiscoveryCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
        }
    }
}
