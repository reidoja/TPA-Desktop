using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Receptionist
{
    class ReservationController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadData()
        {
            var result = (from x in db.Reservation
                          where x.Deleted == 0
                          select new
            {
                ReservationId = x.ReservationId,
                GuestName = x.GuestName,
                CheckInDate = x.CheckInDate,
                Nights = x.Nights
            }).ToList();
            return result;
        }

        public void addReservation(string guestName, string checkindate, int nights)
        {
            Reservation r = new Reservation();
            r.GuestName = guestName;
            r.CheckInDate = checkindate;
            r.Nights = nights;
            r.Deleted = 0;
            db.Reservation.Add(r);
            db.SaveChanges();
        }
        public void updateReservation(int reservationId, string guestName, string checkindate, int nights)
        {
            var obj = (from x in db.Reservation
                       where x.ReservationId == reservationId
                       select x).FirstOrDefault();
            obj.GuestName = guestName;
            obj.CheckInDate = checkindate;
            obj.Nights = nights;
            db.SaveChanges();
        }
        public void deleteReservation(int reservationId)
        {
            var obj = (from x in db.Reservation
                       where x.ReservationId == reservationId
                       select x.Deleted).FirstOrDefault();
            obj = 1;
            db.SaveChanges();
        }
    }
}
