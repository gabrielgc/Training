using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Model
{
    public class UserTraining
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<TrainingGuide> Trainings { get; set; }
    }
}
