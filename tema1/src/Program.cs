using System;
using tema1.src.model;
using tema1.src.repository;
using tema1.src.controller;
using tema1.src.view;

namespace tema1
{
    class Program
    {
        static void Main(string[] args)
        {

            IRepository<Street> inMemoryRepository = new InMemoryRepository<Street>();
            StreetController streetContorller = new StreetController(inMemoryRepository);
            ConsoleView view = new ConsoleView(streetContorller);


            view.run();

        }
    }
}
