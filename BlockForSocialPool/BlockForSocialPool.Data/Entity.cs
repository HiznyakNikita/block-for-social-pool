using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data
{
    public class Entity<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}
