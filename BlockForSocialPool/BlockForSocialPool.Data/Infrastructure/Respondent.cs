using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Infrastructure
{
    public class Respondent: Entity<Guid>
    {
        public string Name { get; set; }
        public string TelegramId { get; set; }
        public string FacebookId { get; set; }
    }
}
