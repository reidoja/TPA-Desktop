using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.DiningRoom
{
    class CheckTicketController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        
        public object loadData()
        {
            var result = (from x in db.Guest
                          join y in db.BrunchTicket on x.GuestId equals y.GuestId
                          where x.Deleted == 0
                          select new
                          {
                              GuestId = x.GuestId,
                              GuestName = x.GuestName,
                              BrunchRemaining = y.BrunchRemaining
                          }).ToList();
            return result;

        }

        public bool checkEligibility(int guestId)
        {
            var search = (from x in db.Guest where x.GuestId == guestId select x.GuestId).FirstOrDefault();
            if(search == guestId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void updateRemaining(int guestId, int remaining)
        {
            var obj = (from x in db.BrunchTicket where x.GuestId == guestId select x).FirstOrDefault();
            obj.BrunchRemaining = remaining;
            db.SaveChanges();
        }
    }
}
