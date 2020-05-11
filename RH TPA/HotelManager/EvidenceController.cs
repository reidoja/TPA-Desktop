using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HotelManager
{
    class EvidenceController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadData()
        {
            var result = (from x in db.Evidence
                          where x.Deleted == 0
                          select new
                          {
                              EvidenceId = x.Id,
                              StaffId = x.StaffId,
                              EvidenceText = x.EvidenceText
                          }).ToList();
            return result;
        }

        public void approve(int evId)
        {
            var obj = (from x in db.Evidence where x.Id == evId select x).FirstOrDefault();
            obj.Deleted = 2;
            db.SaveChanges();
        }

        public void refuse(int evId)
        {
            var obj = (from x in db.Evidence where x.Id == evId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }

    }
}
