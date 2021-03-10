using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.repository
{
    interface IRepository<T>
    {
        void save(T entity);    // CREATE

        List<T> getAll();       // READ

        void update(T entity);  // UPDATE

        void delete(T entity);  // DELETE


                                // CRUD
    }
}
