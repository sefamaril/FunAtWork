using FunAtWork.Core.Entities;
using FunAtWork.Core.Repositories;
using FunAtWork.Infrastructure.FunAtWorkDb;

namespace FunAtWork.Infrastructure.Repositories
{
    public class ContestTypeRepository : ApplicationDbBaseRepository<ContestType>, IContestTypeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ContestTypeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}