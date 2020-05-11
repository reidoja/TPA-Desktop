using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HotelManager
{
    class ResignationController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public void submit(int staffId)
        {
            Resignation r = new Resignation();
            r.StaffId = staffId;
            r.Deleted = 0;
            db.Resignation.Add(r);
            db.SaveChanges();
        }
        
        public object loadData()
        {
            var result = (from x in db.Resignation
                          join y in db.Staff
                          on x.StaffId equals y.StaffId
                          where x.Deleted == 0
                          select new
                          {
                              ResignationId = x.RegignationId,
                              StaffId = x.StaffId,
                              StaffName = y.StaffName
                          }).ToList();
            return result;
        }

        public void approve(int resId)
        {
            var obj = (from x in db.Resignation where x.RegignationId == resId select x).FirstOrDefault();
            obj.Deleted = 2;
            db.SaveChanges();
        }

        public void refuse(int resId)
        {
            var obj = (from x in db.Resignation where x.RegignationId == resId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
