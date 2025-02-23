using FunAtWork.Core.Entities;

namespace FunAtWork.Core.Repositories
{
    public interface IContestRepository : IRepository<Contest>
    {
        Task<IEnumerable<Contest>> GetContestsByOrganizerAsync(string organizer);
    }
}