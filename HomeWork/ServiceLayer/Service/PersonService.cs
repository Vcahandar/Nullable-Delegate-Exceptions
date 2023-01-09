using DomainLayer.Models;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class PersonService : IPersonService
    {

        public List<Person> SumListPerson(Predicate<Person> func, List<Person> person)
        {
            
            List<Person> persons = new();
            foreach(var item in person)
            {
                if (func(item))
                {
                    persons.Add(item);
                }
            }
            return persons;

        }



        public void GetPerson(int salary)
        {
            var persons = GetAllPerson();
            var res=SumListPerson(m => m.Salary > salary, persons);
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");

            }

        }

       


        List<Person> GetAllPerson()
        {
            List<Person> persons = new();

            Person person1 = new Person
            {
                Id = 1,
                Name = "Cahandar",
                Surname = "Velibeyli",
                Address = "Ehmedli",
                Salary = 1500
            };
            Person person2 = new Person
            {
                Id = 2,
                Name = "Nurlan",
                Surname = "Mecidli",
                Address = "Zengilan",
                Salary = 900
            };
            Person person3 = new Person
            {
                Id = 3,
                Name = "Ismayil",
                Surname = "Yusifov",
                Address = "Bineqedi",
                Salary = 1700
            };
            Person person4 = new Person
            {
                Id = 4,
                Name = "Elcin",
                Surname = "Abbasov",
                Address = "Hovsan",
                Salary = 950
            };

            persons.Add(person1);
            persons.Add(person2);
            persons .Add(person3);
            persons.Add(person4);
            return persons;
        }
    }
}
