using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.Data.Infrastructure
{
    public enum SocialNetwork
    {
        Vkontakte,
        Telegram,
        Facebook
    }
    public class Channel: Entity<Guid>
    {
        public string Name{ get; set; }
        public string URL { get; set; }
        public SocialNetwork SocialNetwork { get; set; }
        public string Topic { get; set; }
        public bool IsActive { get; set; }
        public IList<Interview> Interviews { get; set; }

        public Channel() { }
        public Channel(string name, SocialNetwork socialNetwork)
        {
            Name = name;
            SocialNetwork = socialNetwork;
            IsActive = true;
            Interviews = new List<Interview>();
        }
    }
}
