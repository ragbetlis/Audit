using Audit.Business.Abstract;
using Audit.Business.Constants;
using Audit.DataAccess.Abstract;
using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult Add(Person person)
        {
            _personDal.Add(person);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Person person)
        {
            _personDal.Add(person);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Person>> GetAll()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Person> GetAllByTelephoneNo(string telephoneNo)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p=>p.Telephone==telephoneNo), Messages.Geted);
        }

        public IDataResult<Person> GetById(int personId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.PersonId == personId), Messages.Geted);
        }

        public IDataResult<Person> GetByIdentificationNo(string identificationNo)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.IdentificationNo == identificationNo), Messages.Geted);
        }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new Result(true, Messages.Updated);
        }
    }
}
