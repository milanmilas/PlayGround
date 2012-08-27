using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernateSqlCE.Domain;

namespace NHibernateSqlCE.Model
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.CategoryId, "CategoryId").GeneratedBy.Identity();
            Map(x => x.Name, "Name");
            HasManyToMany<Item>(x => x.Items)          
                .ParentKeyColumn("CategoryId")
                .ChildKeyColumn("ItemId")
                .Cascade.SaveUpdate();
        }
    }
}
