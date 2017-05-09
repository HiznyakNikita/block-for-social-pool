using BlockForSocialPool.Data;
using BlockForSocialPool.Data.Questions;
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
            var interviews = new List<Interview>
            {
                new Interview("Interview1", InterviewType.Promo),
                new Interview("Interview2", InterviewType.Service)
            };

            var questionsInterview1 = new List<Question>
            {
                new OpenQuestion("Question1", QuestionType.Identity, "QuestionText1"),
                new OpenQuestion("Question2", QuestionType.Open, "QuestionText2")
            };
            var questionsInterview2 = new List<Question>
            {
                new OpenQuestion("Question3", QuestionType.Identity, "QuestionText5"),
                new OpenQuestion("Question4", QuestionType.Open, "QuestionText6")
            };
            interviews[0].Questions = questionsInterview1;
            interviews[1].Questions = questionsInterview2;

            interviews.ForEach(s => context.Interviews.Add(s));
            context.SaveChanges();
        }
    }
}
