using BlockForSocialPool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.DAL
{
    public class ApplicationDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var students = new List<Interview>
            {
                new Interview("Interview1", InterviewType.Promo),
                new Interview("Interview2", InterviewType.Service),
                new Interview("Interview3", InterviewType.Promo),
                new Interview("Interview4", InterviewType.SociologicalResearch),
                new Interview("Interview5", InterviewType.Service),
            };

            students.ForEach(s => context.Interviews.Add(s));
            context.SaveChanges();
        }
    }
}
