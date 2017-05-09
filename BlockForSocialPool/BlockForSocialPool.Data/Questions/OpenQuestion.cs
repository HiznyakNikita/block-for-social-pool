using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Questions
{
    public class OpenQuestion : Question
    {
        public virtual string PositiveMask { get; set; }
        public virtual string NegativeMask { get; set; }

        public OpenQuestion(string name, QuestionType type, string text)
        {
            Name = name;
            Type = type;
            Text = text;
        }
    }
}
