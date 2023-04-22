﻿using CinemaManagementProject.Utilities;
using HotelManagement.ViewModel.StaffVM.RoomCatalogManagementVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace HotelManagement.ViewModel.AdminVM
{
    public class AdminVM : BaseVM
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand FirstLoadCM { get; set; }
        private void Furniture(object obj) => CurrentView = new FurnitureManagementVM.FurnitureManagementVM();
        private void Service(object obj) => CurrentView = new ServiceManagementVM.ServiceManagementVM();
        private void RoomCatalog(object obj) => CurrentView = new RoomCatalogManagementVM();

        public ICommand FurnitureCommand { get; set; }
        public ICommand ServiceCommand { get; set; }
        public ICommand RoomCatalogCommand { get; set; }
        public AdminVM()
        {
            _currentView = new ServiceManagementVM.ServiceManagementVM();

            FurnitureCommand = new RelayCommand(Furniture);
            ServiceCommand = new RelayCommand(Service);
            RoomCatalogCommand = new RelayCommand(RoomCatalog);
        }
    }
}
