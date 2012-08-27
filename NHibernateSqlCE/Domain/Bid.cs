using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateSqlCE.Domain
{
    public class Bid
    {
        public virtual int BidId { get; set; }

        public virtual Item Item { get; set; }
    }
}
