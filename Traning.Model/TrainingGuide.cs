using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Model
{
    public class TrainingGuide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DayOfWeek { get; set; }
        public int Interval { get; set; }
        public List<Exercise> Exercises { get; set; }

        public virtual UserTraining UserTraining { get; set; }
    }
}
