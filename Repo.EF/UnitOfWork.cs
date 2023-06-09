using RepositoryPatternWithUOW.Core;
using Repo.Core.Interfaces;
using Repo.Core.Models;
using Repo.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

    
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}