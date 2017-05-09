using BlockForSocialPool.Data;
using BlockForSocialPool.Data.Infrastructure;
using BlockForSocialPool.Data.Questions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.DAL
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("ApplicationDbContext")
        {
        }

        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionSlide> QuestionSlides { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
