using RestApi.Models;
using System.Collections.Generic;
using RestApi.Repository;

namespace RestApi.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonServiceImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
