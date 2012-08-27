using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateSqlCE.Domain
{
    public class CategoryItem
    {
        public virtual int CategoryItemId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Item Item { get; set; }

    }
}
