using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext ctx;

        public GenericRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public T Get(Guid id)
        {
            var data = ctx.Set<T>().Find(id);
            return data;
        }

        public IEnumerable<T> GetAll()
        {
            return ctx.Set<T>();
        }
    }
}
