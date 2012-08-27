using System;

namespace NHibernareUnitOfWotk
{
    public interface IGenericTransaction : IDisposable
    {

        void Commit();

        void Rollback();

    }
}