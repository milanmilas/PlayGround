using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernateSqlCE.Domain;

namespace NHibernateSqlCE.Model
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Id(x => x.ItemId, "ItemId").GeneratedBy.Identity();

            Map(x => x.Description, "Description");

            Map(x => x.Name, "Name");

            Map(x => x.InitialPrice, "InitialPrice");

            HasMany<Bid>(x => x.Bids)
                .KeyColumn("ItemIdFk")
                .Cascade.SaveUpdate();

            HasManyToMany<Category>(x => x.Categories)
                .Table("CategoryItem")
                .ParentKeyColumn("ItemId")
                .ChildKeyColumn("CategoryId")
                .Cascade.SaveUpdate();
        }
    }
}
