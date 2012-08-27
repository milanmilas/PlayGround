using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateSqlCE.Domain
{
    public class Item
    {
        public Item()
        {
            Bids = new List<Bid>();
            Categories = new List<Category>();
        }
        public virtual int ItemId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual int InitialPrice { get; set; }

        public virtual IList<Bid> Bids { get; set; }

        public virtual IList<Category> Categories { get; set; } 
    }
}
