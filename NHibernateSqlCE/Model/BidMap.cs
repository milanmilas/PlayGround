using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernateSqlCE.Domain;

namespace NHibernateSqlCE.Model
{
    public class BidMap : ClassMap<Bid>
    {
        public BidMap()
        {
            Id(x => x.BidId, "BidId");
            References<Item>(x => x.Item, "ItemIdFk");
        }
    }
}
