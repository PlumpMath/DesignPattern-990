using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class Group: Party
    {
        public string Name { get; set; }

        public List<Party> Members{get; set; }

        public Group()
        {
            Members = new List<Party>();
        }

        public int Gold 
        { 
            get
            {
                return Members.Sum(member => member.Gold);
            }

            set
            {
                var eachSplit = value/Members.Count;
                var leftOver = value%Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }

        }
        public void Stats() 
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}
