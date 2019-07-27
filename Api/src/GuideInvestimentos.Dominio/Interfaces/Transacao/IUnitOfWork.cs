using System;
using System.Collections.Generic;
using System.Text;

namespace GuideInvestimentos.Dominio.Interfaces.Transacao
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void RollBack();
        bool Save();
    }
}
