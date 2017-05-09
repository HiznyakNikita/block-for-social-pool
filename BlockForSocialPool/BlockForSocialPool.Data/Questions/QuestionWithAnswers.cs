using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Questions
{
    public class QuestionWithAnswers : Question
    {
        public int CountOfAnswers { get; set; }
        public IList<string> Answers { get; set; }
    }
}
