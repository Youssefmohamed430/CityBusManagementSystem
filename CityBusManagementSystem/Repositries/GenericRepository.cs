
using CityBusManagementSystem.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace CityBusManagementSystem.Repositries
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entity = null;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public bool Add(T model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(T model)
        {
            try
            {
                _entity.Remove(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<T> GetAll()
            => _entity.ToList();

        public T GetById(int Id)
        {
            var entity = _entity.Find(Id);

            if (entity == null)
                throw new KeyNotFoundException($"Entity with ID {Id} not found.");

            return entity;
        }

        public bool Update(T model)
        {
            try
            {
                _entity.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
