using DataAccess.EFCore.Core.Repository;
using DataAccess.EFCore.Core.Service.Interface;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Core.Service.Implement
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
