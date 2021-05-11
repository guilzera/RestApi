using RestApi.Dato.VO;
using System.Collections.Generic;

namespace RestApi.Services
{
    public interface IBookService
    {
        BookVO Create(BookVO book);
        BookVO FindById(int id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(int id);
    }
}
