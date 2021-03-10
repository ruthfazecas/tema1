using System;
using System.Collections.Generic;
using System.Text;
using tema1.src.model;
using tema1.src.repository;

namespace tema1.src.controller
{
    class StreetController
    {
        private IRepository<Street> repository;

        public StreetController(IRepository<Street> repository)
        {
            this.repository = repository;
        }

        public void addStreet(Street street)
        {
            repository.save(street);
        }

        public List<Street> getAll()
        {
            return repository.getAll();
        }

        public void deleteStreetById(int id)
        {
            Street toDelete = null;
            List<Street> allStreets = repository.getAll();
            foreach(Street s in allStreets)
            {
                if(s.Id == id)
                {
                    toDelete = s;
                }
            }
            if(toDelete == null)
            {
                throw new Exception("Cannot delete a unexistent car");
            }
            repository.delete(toDelete);
        }

        public void updateStreet(Street street)
        {
            repository.update(street);
        }

    }
}
