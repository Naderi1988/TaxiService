using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel.Route
{
    public class RouteListItem
    {
        public int RouteID { get; set; }


        public int OriginID { get; set; }


        public int DestinationID { get; set; }
        public int Price { get; set; }

    }
}
