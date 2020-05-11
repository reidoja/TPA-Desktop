using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HumanCapital
{
    class SalaryController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadSalary()
        {
            var result = (from x in db.Staff
                          where x.Deleted == 0
                          select new
                          {
                              StaffId = x.StaffId,
                              StaffName = x.StaffName,
                              StaffSalary = x.StaffSalary
                          }).ToList();
            return result;
        }

        public object loadApproval()
        {
            var result = (from x in db.RaiseRequest
                          join y in db.Staff
                          on x.StaffId equals y.StaffId
                          where x.Deleted == 2
                          select new
                          {
                              StaffId = x.Staff,
                              StaffName = y.StaffName,
                              Raise = x.RaiseTotal
                          }).ToList();
            return result;
        }

        public bool checkApproval(int staffId)
        {
            var approval = (from x in db.RaiseRequest where x.StaffId == staffId select x.Deleted).FirstOrDefault();
            if (approval == 2) return true;
            else return false;
        }

        public void requestRaise(int staffId, int raiseTotal)
        {
            RaiseRequest rr = new RaiseRequest();
            rr.StaffId = staffId;
            rr.RaiseTotal = raiseTotal;
            db.RaiseRequest.Add(rr);
            db.SaveChanges();
        }

        public void update(int staffId, int raiseTotal)
        {
            FundRequest fr = new FundRequest();
            fr.ItemName = "Raise Salary";
            fr.Total = raiseTotal;
            fr.Deleted = 2;

            var req = (from x in db.RaiseRequest where x.StaffId == staffId select x).FirstOrDefault();
            req.Deleted = 3;
            db.SaveChanges();

            var obj = (from x in db.Staff where x.StaffId == staffId select x).FirstOrDefault();
            obj.StaffSalary += raiseTotal;
            db.SaveChanges();
        }


    }
}
