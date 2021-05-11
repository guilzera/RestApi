using RestApi.Dato.Converter.Implementations;
using RestApi.Dato.VO;
using RestApi.Models;
using RestApi.Repository;
using System.Collections.Generic;

namespace RestApi.Services.Implementation
{
    public class BookServiceImplementation :IBookService
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookServiceImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
