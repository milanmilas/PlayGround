using System;
using System.Data;

namespace NHibernareUnitOfWotk
{
    public interface IUnitOfWork : IDisposable
    {
        bool IsInActiveTransaction { get; }

        IGenericTransaction BeginTransaction();
        IGenericTransaction BeginTransaction(IsolationLevel isolationLevel);
        void Flush();
        void TransactionalFlush();
        void TransactionalFlush(IsolationLevel isolationLevel);
    }
}