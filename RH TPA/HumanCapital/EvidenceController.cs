using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HumanCapital
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
                              StaffId = x.StaffId,
                              EvidenceText = x.EvidenceText
                          }).ToList();
            return result;
        }

        public void add(int id, string text)
        {
            Evidence e = new Evidence();
            e.StaffId = id;
            e.EvidenceText = text;
            db.Evidence.Add(e);
            db.SaveChanges();
        }

        public void update(int id, string text)
        {
            var obj = (from x in db.Evidence where x.StaffId == id select x).FirstOrDefault();
            obj.EvidenceText = text;
            db.SaveChanges();
        }

        public void delete(int id)
        {
            var obj = (from x in db.Evidence where x.StaffId == id select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
