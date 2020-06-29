using DataAccess.EFCore.Core.Repository;
using DataAccess.EFCore.Core.Service.Interface;
using Domain;
using Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Core.Service.Implement
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationContext context)
            :base(context)
        {

        }
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}
