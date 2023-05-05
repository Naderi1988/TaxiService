﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel.Cartex
{
   public class CartexFulInformation
    {
        public int CartexID { get; set; }

        public int DriverID { get; set; }

        public int TripID { get; set; }

        public int DebiteTripCount { get; set; }

        public int TotalDebit { get; set; }


    }
}
