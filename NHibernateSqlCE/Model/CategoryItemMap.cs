using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernateSqlCE.Domain;

namespace NHibernateSqlCE.Model
{
    public class CategoryItemMap : ClassMap<CategoryItem>
    {
        public CategoryItemMap()
        {
            Id(x => x.CategoryItemId, "CategoryItemId");

            References(x => x.Category, "CategoryId");

            References(x => x.Item, "ItemId");
        }
    }
}
