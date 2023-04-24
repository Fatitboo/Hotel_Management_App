﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTOs
{
    public class RoomSettingDTO
    {
        public string RoomId { get; set; }
        public Nullable<int> RoomNumber { get; set; }
        public string RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string Note { get; set; }
        public string RoomStatus { get; set; }
        public string RoomCleaningStatus { get; set; }
        public Nullable<double> Price { get; set; }
        public string RentalContractId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int DayNumber
        {
            get
            {
                if (CheckOutDate == null || StartDate == null) return 0;
                TimeSpan t = (TimeSpan)(CheckOutDate - StartDate);
                int res = (int)t.TotalDays;
                return res;
            }
        }
     
        public Nullable<bool> Validated { get; set; }
        public string RoomName
        {
            get { return "P "+RoomNumber.ToString(); }
            set { }
        }
        

    }
}
