using System;
using System.Collections.Generic;
using System.Text;
using tema1.src.controller;
using tema1.src.model;

namespace tema1.src.view
{
    class ConsoleView
    {

        private StreetController streetController;

        public ConsoleView(StreetController streetController)
        {
            this.streetController = streetController;
        }

        private static void printMenu()
        {
            Console.WriteLine("\n\n");
            System.Console.WriteLine("1. Add a street");
            System.Console.WriteLine("2. Update a street");
            System.Console.WriteLine("3. Delete a street");
            System.Console.WriteLine("4. See all streets");
            System.Console.WriteLine("0. Exit the application");
        }


        public void run()
        {
            
            while (true)
            {
                printMenu();
                System.Console.WriteLine("Input: ");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                else if (input == "1")
                {
                    addStreet();
                }
                else if (input == "2")
                {
                    updateStreet();
                }
                else if (input == "3")
                {
                    deleteStreet();
                }
                else if (input == "4")
                {
                    seeAllStreets();
                }
                else
                {
                    Console.WriteLine("Please write a valid input");
                }

            }
        }


        private void addStreet()
        {
            Console.WriteLine("Enter the id:");
            string idString = Console.ReadLine();
            int result;
            try
            {
                result = Int32.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{idString}'");
                return;
            }

            Console.WriteLine("Enter the street name:");
            string nameString = Console.ReadLine();

            try
            {
                streetController.addStreet(new model.Street(result, nameString));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void seeAllStreets()
        {
            foreach (Street s in streetController.getAll())
            {
                Console.WriteLine(s);
            }
        }

        private void deleteStreet()
        {
            Console.WriteLine("Enter the id:");
            string idString = Console.ReadLine();
            int result;
            try
            {
                result = Int32.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{idString}'");
                return;
            }
            try
            {
                streetController.deleteStreetById(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void updateStreet()
        {
            Console.WriteLine("Enter the id:");
            string idString = Console.ReadLine();
            int result;
            try
            {
                result = Int32.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{idString}'");
                return;
            }

            Console.WriteLine("Enter the new street name:");
            string nameString = Console.ReadLine();

            try
            {
                streetController.updateStreet(new model.Street(result, nameString));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
