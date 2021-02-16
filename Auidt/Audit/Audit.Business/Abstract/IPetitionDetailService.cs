using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Abstract
{
    public interface IPetitionDetailService
    {
        IDataResult<List<PetitionDetail>> GetAll();
        IDataResult<List<PetitionDetail>> GetByPetitionId(int petitionId);
        IDataResult<List<PetitionDetail>> GetByHealthcareProviderId(int healthcareProviderId);
    }
}
