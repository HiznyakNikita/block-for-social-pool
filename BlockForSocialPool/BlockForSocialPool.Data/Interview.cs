using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data
{
    public enum InterviewType
    {
        Promo,
        SociologicalResearch,
        Service
    }

    public class Interview : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual InterviewType Type { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? DueDate { get; set; }
        public virtual int MaxTriesOfSpending { get; set; }

        public Interview()
        {
        }

        public Interview(string name, InterviewType type)
        {
            Name = name;
            Type = type;
        }
    }
}
