using BlockForSocialPool.Data.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Infrastructure
{
    public class RespondentAnswer : Entity<Guid>
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public Respondent Respondent { get; set; }
        public string UserAnswer { get; set; }
    }
}
