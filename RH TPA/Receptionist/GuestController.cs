using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Receptionist
{
    class GuestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public string searchReservation(int reservationId)
        {
            var search = (from x in db.Reservation
                          where x.ReservationId == reservationId
                          select x).FirstOrDefault();
            if(search != null)
            {
                return search.GuestName;
            }
            else
            {
                return "nihil";
            }
        }

        public void addGuest(string guestName, string documentId, string roomNumber, int reservationId, int paymentTotal, int deposit)
        {
            var room = (from x in db.Room where x.RoomNumber.Equals(roomNumber) select x).FirstOrDefault();
            room.Available = 1;
            Guest g = new Guest();
            g.GuestName = guestName;
            g.DocumentId = documentId;
            g.RoomId = room.RoomId;
            g.ReservationId = reservationId;
            g.Deleted = 0;
            db.Guest.Add(g);
            db.SaveChanges();
            var guestId = (from x in db.Guest where x.GuestName.Equals(guestName) select x.GuestId).FirstOrDefault();
            addPayment(guestId, paymentTotal, deposit);       
            var searchNight = (from x in db.Reservation where x.GuestName.Equals(guestName) select x.Nights).FirstOrDefault();
            BrunchTicket b = new BrunchTicket();
            b.GuestId = guestId;
            b.BrunchRemaining = searchNight;
            db.BrunchTicket.Add(b);
            db.SaveChanges();
        }
        public void updateGuest(int guestId, string guestName, string documentId, string oldRoomNumber, string newRoomNumber, int paymentTotal, int deposit)
        {
            var oldRoom = (from x in db.Room where x.RoomNumber.Equals(oldRoomNumber) select x).FirstOrDefault();
            oldRoom.Available = 0;
            var newRoom = (from x in db.Room where x.RoomNumber.Equals(newRoomNumber) select x).FirstOrDefault();
            newRoom.Available = 1;
            updatePayment(guestId, paymentTotal, deposit);
            var obj = (from x in db.Guest
                       where x.GuestId == guestId
                       select x).FirstOrDefault();
            obj.GuestName = guestName;
            obj.DocumentId = documentId;
            obj.RoomId = newRoom.RoomId;
            db.SaveChanges();
           
        }
        public object loadData()
        {
            var result = (from x in db.Guest
                          where x.Deleted == 0 
                          select new
                          {
                              GuestId = x.GuestId,
                              GuestName = x.GuestName,
                              DocumentId = x.DocumentId,
                              RoomId = x.RoomId,
                              ReservationId = x.ReservationId
                          }).ToList();
            return result;
        }

        public object loadRoom()
        {
            var result = (from x in db.Room select x).ToList();
            return result;
        }

        public void deleteGuest(int guestId, string review)
        {
            var obj = (from x in db.Guest join y in db.PaymentDetail
                       on x.GuestId equals y.GuestId
                       where x.GuestId == guestId select y).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();

            SalesReport sr = new SalesReport();
            sr.TotalPayment = obj.PaymentTotal;
            sr.Deleted = 0;
            db.SalesReport.Add(sr);
            db.SaveChanges();

            GuestReviewReport grr = new GuestReviewReport();
            grr.GuestId = guestId;
            grr.GuestReview = review;
            grr.Deleted = 0;
            db.GuestReviewReport.Add(grr);
            db.SaveChanges();
            var room = (from x in db.Guest
                        join y in db.Room
                        on x.RoomId equals y.RoomId
                        where x.GuestId == guestId
                        select y).FirstOrDefault();
            room.Available = 0;
            deletePayment(obj.PaymentId);
            db.SaveChanges();
        }

        public void addPayment(int guestId, int paymentTotal, int deposit)
        {
            PaymentDetail p = new PaymentDetail();
            p.GuestId = guestId;
            p.PaymentTotal = paymentTotal;
            p.DepositMoney = deposit;
            db.PaymentDetail.Add(p);
            db.SaveChanges();
        }
        public void updatePayment(int guestId, int paymentTotal, int deposit)
        {
            var obj = (from x in db.Guest
                       join y in db.PaymentDetail
    on x.GuestId equals y.GuestId
                       where x.GuestId == guestId
                       select y).FirstOrDefault();
            obj.PaymentTotal = paymentTotal;
            obj.DepositMoney = deposit;
            db.SaveChanges();
        }

        public void deletePayment(int paymentId)
        {
            var obj = (from x in db.PaymentDetail
                       where x.PaymentId == paymentId
                       select x).FirstOrDefault();
            obj.Deleted = 1;
            //db.PaymentDetail.Remove(obj);
            db.SaveChanges();
        }
    }
}
