using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateSqlCE.Domain
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Item> Items { get; set; }  
    }
}
