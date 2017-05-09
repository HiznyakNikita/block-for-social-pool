using BlockForSocialPool.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Questions
{
    public class CatalogQuestion : Question
    {
        public List<QuestionSlide> Slides { get; set; }
    }
}
