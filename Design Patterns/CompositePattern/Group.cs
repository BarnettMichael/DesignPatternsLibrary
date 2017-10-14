using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    public class Group : IParty
    {
        public string Name { get; set; }
        public List<IParty> Members { get; set; }
        public int Gold
        {
            get => Members.Sum(m => m.Gold);
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }

            }
        }

        public Group()
        {
            Members = new List<IParty>();
        }

        public void Stats() => Members.ForEach(m => m.Stats());        
    }
}
