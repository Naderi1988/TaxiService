using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Services;
using DomainModel.ViewModel;
using DomainModel.Model;
using DomainModel.ViewModel.Reservationr;

namespace DataAccess.Repositories
{
    public class ReservationRepository : IReservationr, IDisposable
    {
        Model4 db = new Model4();
        public void Dispose()
        {
            this.db.Dispose();
        }

        public Reservation Get(int IdReservation)
        {
            var reservation = db.Reservations.FirstOrDefault(x => x.ReservationID == IdReservation);
            return reservation;
        }

        public List<Reservation> GetAll()
        {
            return db.Reservations.ToList();
        }

        public List<ResevartionerFulInformation> GetReservationrList()
        {
            throw new NotImplementedException();
        }

        public Reservation Login(string UserName, string Password)
        {
            Reservation reservation = db.Reservations.FirstOrDefault(x => x.ReservationUserName == UserName && x.ReservationPassword == Password);
            return reservation;
        }

        public int RegisterReservationr(Reservation NReservation)
        {
            db.Reservations.Add(NReservation);
            db.SaveChanges();
            return NReservation.ReservationID;
        }

        public bool Remove(int IdReservation)
        {
            try
            {
                var reservation = db.Reservations.FirstOrDefault(x => x.ReservationID == IdReservation);
                db.Reservations.Remove(reservation);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Reservation NReservation)
        {
            try
            {
                var old = db.Reservations.FirstOrDefault(x => x.ReservationID == NReservation.ReservationID);
                old.ReservationFirstName = NReservation.ReservationFirstName;
                old.ReservationLastName = NReservation.ReservationLastName;
                old.ReservationUserName = NReservation.ReservationUserName;
                old.ReservationPassword = NReservation.ReservationPassword;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        List<Reservation> IReservationr.Search(ReservationrSearchModel sm)
        {
            var q = from Item in db.Reservations select Item;
            if (!string.IsNullOrEmpty(sm.ReservationFirstName))
            {
                q = q.Where(x => x.ReservationFirstName.StartsWith(sm.ReservationFirstName));
            }
            if (!string.IsNullOrEmpty(sm.ReservationLastName))
            {
                q = q.Where(x => x.ReservationLastName.StartsWith(sm.ReservationLastName));
            }
            return q.ToList();
        }
    }
}
