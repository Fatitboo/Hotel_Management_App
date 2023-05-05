﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTOs
{
    public class RentalContractDTO
    {
        public string RentalContractId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string RoomId { get; set; }
        public string RoomNumber { get; set; }  
        public string PriceRental { get; set; }
        public Nullable<bool> Validated { get; set; }
        public int PersonNumber { get; set; }
        public string PersonNumberStr
        {
            get { return PersonNumber.ToString(); } 
        }
        public IList<CustomerDTO> CustomersOfRoom { get; set; }
        public string StartDateStr
        {
            get { return ((DateTime)StartDate).ToString("dd/MM/yyyy");}
        }
        public string CheckOutDateStr
        {
            get { return ((DateTime)CheckOutDate).ToString("dd/MM/yyyy"); }
        }
        public string TotalDateRental
        {
            get { return NumberDateRental(); }
        }
        public string NumberDateRental ()
        {
            DateTime ngaymuon = Convert.ToDateTime(StartDateStr);
            DateTime ngaytra = Convert.ToDateTime(CheckOutDateStr);
            TimeSpan Time = ngaytra - ngaymuon;
            return Time.Days.ToString();
        }
    }
}
