﻿using System;

namespace Registration.Commands.Orders
{
    [Serializable]
    public class SeatInfo
    {
        public Guid SeatType { get; set; }
        public string SeatName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
