using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Model;

namespace Training.Common
{
    public class TrainingContext : DbContext
    {

        public TrainingContext()
            : base()
        {

        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<TrainingGuide> TrainingGuides { get; set; }        
        public DbSet<User> Users { get; set; }
        public DbSet<UserTraining> UserTrainings { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            //one-to-many
            modelBuilder.Entity<UserTraining>().HasMany<TrainingGuide>(tg => tg.Trainings)
            .WithRequired(us => us.UserTraining).HasForeignKey(s => s.Id);
        }
    }
}
