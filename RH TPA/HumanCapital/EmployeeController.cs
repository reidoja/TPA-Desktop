using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HumanCapital
{
    class EmployeeController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadData()
        {
            var result = (from x in db.Staff
                          where x.Deleted == 0
                          select new
                          {
                              StaffId = x.StaffId,
                              StaffName = x.StaffName,
                              StaffPassword = x.StaffPassword,
                              StaffSalary = x.StaffSalary,
                              StaffPosition = x.StaffPosition
                          }).ToList();
            return result;
        }

        public object loadCandidate()
        {
            var result = (from x in db.Candidate
                          where x.CandidateStep == 3 && x.Deleted == 0
                          select new
                          {
                              CandidateId = x.CandidateId,
                              CandidateName = x.CandidateName,
                          }).ToList();
            return result;
        }

        public object loadFire()
        {
            var result = (from x in db.Evidence
                          join y in db.Staff
                          on x.StaffId equals y.StaffId
                          where x.Deleted == 2
                          select new
                          {
                              EvidenceId = x.Id,
                              StaffId = x.StaffId,
                              StaffName = y.StaffName,
                              EvidenceText = x.EvidenceText
                          }).ToList();
            return result;
        }

        public object loadResignation()
        {
            var result = (from x in db.Resignation
                          join y in db.Staff
                          on x.StaffId equals y.StaffId
                          where x.Deleted == 2
                          select new
                          {
                              ResignationId = x.RegignationId,
                              StaffId = x.StaffId,
                              StaffName = y.StaffName
                          }).ToList();
            return result;
        }

        public void updateEmployee(int id, string name, string pass, int salary, string pos)
        {
            var obj = (from x in db.Staff where x.StaffId == id select x).FirstOrDefault();
            obj.StaffName = name;
            obj.StaffPassword = pass;
            obj.StaffSalary = salary;
            obj.StaffPosition = pos;
            db.SaveChanges();
        }

        public void addEmployee(int candidateId, string name, string pass, int salary, string pos)
        {
            Staff s = new Staff();
            s.StaffName = name;
            s.StaffPassword = pass;
            s.StaffSalary = salary;
            s.StaffPosition = pos;
            db.Staff.Add(s);
            db.SaveChanges();
            var obj = (from x in db.Candidate where x.CandidateId == candidateId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();

        }

        public void deleteEmployee(int id, int evId)
        {
            var obj = (from x in db.Staff where x.StaffId == id select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
            var obj1 = (from x in db.Evidence where x.Id == evId select x).FirstOrDefault();
            obj1.Deleted = 3;
            db.SaveChanges();
        }

        public void deleteResign(int id, int resId)
        {
            var obj = (from x in db.Staff where x.StaffId == id select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
            var obj1 = (from x in db.Resignation where x.RegignationId == resId select x).FirstOrDefault();
            obj1.Deleted = 3;
            db.SaveChanges();
        }
    }
}
