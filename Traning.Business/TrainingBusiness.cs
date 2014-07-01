using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Common;
using Training.Model;

namespace Training.Business
{
    public class TrainingBusiness
    {
       
        public List<TrainingGuide> GetTraining(int userId)
        {
            using (var ctx = new TrainingContext())
            {
                var trainings = ctx.UserTrainings.Where(s => s.UserId == userId).Select(s => s.Trainings).FirstOrDefault();
                if (trainings != null && trainings.Count > 0)
                {
                    return trainings;
                }
            }

            return null;
        }

        public bool SaveTraining(TrainingGuide t, int userId)
        {
            using (var ctx = new TrainingContext())
            {
                ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }

            return false;
        }
    }
}
