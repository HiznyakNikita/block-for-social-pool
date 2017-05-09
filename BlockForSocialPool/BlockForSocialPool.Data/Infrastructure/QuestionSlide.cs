using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Infrastructure
{
    public class QuestionSlide : Entity<Guid>
    {
        public string Text { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public string ImageUrl { get; set; }
    }
}
