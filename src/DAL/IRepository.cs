using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public T Find(int id);
        public List<T> GetAll();
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
