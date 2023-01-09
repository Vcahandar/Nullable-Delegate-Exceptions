using ServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class PersonController
    {
        private readonly PersonService _service;
        public PersonController()
        {
            _service = new PersonService();
        }

        public void GetPersons()
        {
            int number = 1000;
            _service.GetPerson(number);
        }
    }
}
