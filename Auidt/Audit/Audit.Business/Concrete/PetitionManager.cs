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
    public class PetitionManager : IPetitionService
    {
        IPetitionDal _petitionDal;

        public PetitionManager(IPetitionDal petitionDal)
        {
            _petitionDal = petitionDal;
        }

        public IResult Add(Petition petition)
        {
            _petitionDal.Add(petition);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Petition petition)
        {
            _petitionDal.Delete(petition);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Petition>> GetAll()
        {
            return new SuccessDataResult<List<Petition>>(_petitionDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Petition> GetById(int petitionId)
        {
            return new SuccessDataResult<Petition>(_petitionDal.Get(p=>p.PetitionId==petitionId), Messages.Geted);
        }

        public IDataResult<Petition> GetByPetitionerId(int petitionerId)
        {
            return new SuccessDataResult<Petition>(_petitionDal.Get(p => p.PetitionerID == petitionerId), Messages.Geted);
        }

        public IDataResult<List<Petition>> PetitionCase(bool petitionCase)
        {
            return new SuccessDataResult<List<Petition>>(_petitionDal.GetAll(p => p.PetitionCase == petitionCase), Messages.Listed);
        }

        public IResult Update(Petition petition)
        {
            _petitionDal.Update(petition);
            return new Result(true, Messages.Updated);
        }
    }
}
