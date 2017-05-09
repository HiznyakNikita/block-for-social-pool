using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Questions
{
    public enum QuestionType
    {
        Open = 1,
        WithAnswer = 2,
        Slide = 3,
        Identity = 4
    }

    public abstract class Question : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual QuestionType Type { get; set; }
        public virtual string Text { get; set; }
        public virtual bool IsIdentified { get; set; }

        public Question()
        {
        }

        public Question(string name, QuestionType type, string text)
        {
            Name = name;
            Type = type;
            Text = text;
        }
    }
}
