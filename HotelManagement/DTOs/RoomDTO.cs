﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTOs
{
    public class RoomDTO
    {
        public string RoomId { get; set; }
        public Nullable<int> RoomNumber { get; set; }
        public string RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string Note { get; set; }
        public string RoomStatus { get; set; }
        public string RoomCleaningStatus { get; set; }
        public Nullable<double> Price { get; set; }
        public bool IsDeleted { get; set; }

    }
}
