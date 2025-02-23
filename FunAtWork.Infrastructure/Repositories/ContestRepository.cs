using FunAtWork.Core.Entities;
using FunAtWork.Core.Repositories;
using FunAtWork.Infrastructure.FunAtWorkDb;
using Microsoft.EntityFrameworkCore;

namespace FunAtWork.Infrastructure.Repositories
{
    public class ContestRepository : ApplicationDbBaseRepository<Contest>, IContestRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ContestRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Contest>> GetContestsByOrganizerAsync(string organizer)
        {
            return await _applicationDbContext.Contests
                                  .Where(c => c.Organizer == organizer)
                                  .ToListAsync();
        }
    }
}