using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IDataResult<Person> GetById(int personId);
        IDataResult<Person> GetByIdentificationNo(string identificationNo);
        IDataResult<Person> GetAllByTelephoneNo(string telephoneNo);
        IResult Add(Person person);
        IResult Update(Person person);
        IResult Delete(Person person);
    }
}
