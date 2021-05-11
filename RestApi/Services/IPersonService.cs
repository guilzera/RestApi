using System.Collections.Generic;
using RestApi.Dato.VO;

namespace RestApi.Services
{
    public interface IPersonService
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(int id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(int id);
    }
}
