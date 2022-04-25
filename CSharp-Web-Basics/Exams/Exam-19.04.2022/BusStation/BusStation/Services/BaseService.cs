using BusStation.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BusStation.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected BaseService(BusStationDbContext data, IValidator validator, IPasswordHasher passwordHasher)
        {
            this.Data = data;
            this.Validator = validator;
            this.PasswordHasher = passwordHasher;
        }

        protected BusStationDbContext Data { get; }
        protected IValidator Validator { get; }
        protected IPasswordHasher PasswordHasher { get; }

        protected DbSet<TEntity> DbSet() => this.Data.Set<TEntity>();
        public void Add(TEntity entity) => DbSet().Add(entity);

        public IQueryable<TEntity> All() => this.Data.Set<TEntity>();

        public IQueryable<TEntity> AllAsNoTracking() => this.All().AsNoTracking();

        public int SaveChanges() => this.Data.SaveChanges();



    }
}
