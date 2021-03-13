﻿using RestApi.Data;
using RestApi.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace RestApi.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private readonly RestApiContext _context;

        public PersonServiceImplementation(RestApiContext context)
        {
            _context = context;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(int id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return person;
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id))
            {
                return new Person();
            }

            var result = _context.Persons.SingleOrDefault(x => x.Id.Equals(person.Id));
            if(result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return person;
        }

        public void Delete(int id)
        {
            var result = _context.Persons.SingleOrDefault(x => x.Id.Equals(id));
            if(result == null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private bool Exists(int id)
        {
            return _context.Persons.Any(x => x.Id.Equals(id));
        }
    }
}
