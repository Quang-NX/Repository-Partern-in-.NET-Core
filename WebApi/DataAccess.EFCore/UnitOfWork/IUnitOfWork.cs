using DataAccess.EFCore.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDeveloperRepository Developer { get; }
        IProjectRepository Project { get; }
        int Complete();
    }
}
