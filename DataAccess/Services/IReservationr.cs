using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Reservationr;

namespace DataAccess.Services
{
    interface IReservationr
    {
        int RegisterReservationr(Reservation NReservationr);
        bool Remove(int IdReservationr);
        bool Update(Reservation NReservationr);
        Reservation Get(int IdReservationr);
        List<Reservation> GetAll();
        List<Reservation> Search(ReservationrSearchModel sm);
        Reservation Login(string UserName, string Password);
        List<ResevartionerFulInformation> GetReservationrList();
    }
}
