using System.Collections.Generic;
using RestApi.Models;
namespace RestApi.Repository
{
    public interface IBookService
    {
        Book Create(Book book);
        Book FindById(int id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(int id);
    }
}
