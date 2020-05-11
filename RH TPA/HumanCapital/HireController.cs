using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HumanCapital
{
    class HireController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public static int step = 0;

        public void addCandidate(string name)
        {
            Candidate c = new Candidate();
            c.CandidateName = name;
            c.CandidateStep = 1;
            c.Deleted = 0;
            db.Candidate.Add(c);
            db.SaveChanges();
        }

        public object loadStep1()
        {
            var result = (from x in db.Candidate
                          where x.CandidateStep == 1 && x.Deleted == 0
                          select new
                          {
                              CandidateId = x.CandidateId,
                              CandidateName = x.CandidateName,
                              CandidateStep = x.CandidateStep
                          }).ToList();

            return result;
        }
        public void updateStep1(int canId)
        {
            var obj = (from x in db.Candidate
                       where x.CandidateId == canId && x.Deleted == 0
                       select x).FirstOrDefault();
            obj.CandidateStep = 2;
            db.SaveChanges();
        }

        public object loadStep2()
        {
            var result = (from x in db.Candidate
                          where x.CandidateStep == 2 && x.Deleted == 0
                          select new
                          {
                              CandidateId = x.CandidateId,
                              CandidateName = x.CandidateName,
                              CandidateStep = x.CandidateStep
                          }).ToList();

            return result;
        }

        public void updateStep2(int canId)
        {
            var obj = (from x in db.Candidate
                       where x.CandidateId == canId && x.Deleted == 0
                       select x).FirstOrDefault();
            obj.CandidateStep = 3;
            db.SaveChanges();
        }

        public void currStep(int curr)
        {
            if(curr == 1)
            {
                step = 2;
            }
            else if(curr == 2)
            {
                step = 3;
            }
            else if(curr == 3)
            {
                step = 1;
            }
        }

    }
}
