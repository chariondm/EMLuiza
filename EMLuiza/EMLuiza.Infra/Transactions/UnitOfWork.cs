using EMLuiza.Infra.Persistence;

namespace EMLuiza.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EMLuizaContext _context;

        public UnitOfWork(EMLuizaContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
