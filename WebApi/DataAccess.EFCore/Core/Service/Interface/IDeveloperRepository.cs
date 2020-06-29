using DataAccess.EFCore.Core.Repository.Interface;
using Domain;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Core.Service.Interface
{
    public interface IDeveloperRepository:IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
