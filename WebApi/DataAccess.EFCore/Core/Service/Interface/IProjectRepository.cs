using DataAccess.EFCore.Core.Repository;
using DataAccess.EFCore.Core.Repository.Interface;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Core.Service.Interface
{
    public interface IProjectRepository:IGenericRepository<Project>
    {

    }
}
