using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Abstract
{
    public interface IPetitionService
    {
        IDataResult<List<Petition>> GetAll();
        IDataResult<Petition> GetById(int petitionId);
        IDataResult<Petition> GetByPetitionerId(int petitionerId);
        IDataResult<List<Petition>> PetitionCase(bool petitionCase);
        IResult Add(Petition petition);
        IResult Update(Petition petition);
        IResult Delete(Petition petition);
    }
}
