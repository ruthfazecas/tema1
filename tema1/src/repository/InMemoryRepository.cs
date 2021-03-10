using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.repository
{
    class InMemoryRepository<T> : IRepository<T>
    {
        private List<T> entities;

        public InMemoryRepository()
        {
            entities = new List<T>();
        }

        void IRepository<T>.delete(T entity)
        {
            entities.Remove(entity);
        }

        List<T> IRepository<T>.getAll()
        {
            return entities;
        }

        void IRepository<T>.save(T entity)
        {
            entities.Add(entity);
        }

        void IRepository<T>.update(T entity)
        {
            // Equals and HashCode methods from the Model only take in consideration the ID
            
            entities.Remove(entity);
            entities.Add(entity);
        }
    }
}
