﻿using BitMiracle.LibTiff.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelManagement.View.BookingRoomManagement
{
    /// <summary>
    /// Interaction logic for BookingRoomManagementPage.xaml
    /// </summary>
    public partial class BookingRoomManagementPage : Page
    {
        public BookingRoomManagementPage()
        {
            InitializeComponent();
        }
        //private void Search_SearchTextChange(object sender, EventArgs e)
        //{
        //    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(BookingRoomListView.ItemsSource);
        //    if (view != null)
        //    {
        //        view.Filter = Filter;
        //        result.Content = BookingRoomListView.Items.Count;
        //        CollectionViewSource.GetDefaultView(BookingRoomListView.ItemsSource).Refresh();
        //    }
        //}
    }
}
