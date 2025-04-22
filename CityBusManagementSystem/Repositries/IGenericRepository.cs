namespace CityBusManagementSystem.Repositries
{
    public interface IGenericRepository<T> where T : class
    {
        bool Add(T model); 
        bool Update(T model); 
        bool Delete(T model); 
        List<T> GetAll(); 
        T GetById(int Id); 
    }
}
