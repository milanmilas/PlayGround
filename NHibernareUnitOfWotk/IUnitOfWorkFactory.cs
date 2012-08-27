using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernareUnitOfWotk
{
    public interface IUnitOfWorkFactory
    {
        Configuration Configuration { get;}
        ISession CurrentSession { get; set; }
        ISessionFactory SessionFactory { get; }

        IUnitOfWork Create();
        void DisposeUnitOfWork(IUnitOfWork unitOfWork);
    }
}
