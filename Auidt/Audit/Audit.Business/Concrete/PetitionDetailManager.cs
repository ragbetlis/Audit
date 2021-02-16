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
    public class PetitionDetailManager : IPetitionDetailService
    {
        IPetitionDetailDal _petitionDetailDal;

        public PetitionDetailManager(IPetitionDetailDal petitionDetailDal)
        {
            _petitionDetailDal = petitionDetailDal;
        }

        public IDataResult<List<PetitionDetail>> GetAll()
        {
            return new SuccessDataResult<List<PetitionDetail>>(_petitionDetailDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<PetitionDetail>> GetByHealthcareProviderId(int healthcareProviderId)
        {
            return new SuccessDataResult<List<PetitionDetail>>(_petitionDetailDal.GetAll(p=>p.HealtcareProviderID==healthcareProviderId), Messages.Listed);
        }

        public IDataResult<List<PetitionDetail>> GetByPetitionId(int petitionId)
        {
            return new SuccessDataResult<List<PetitionDetail>>(_petitionDetailDal.GetAll(p => p.PetitionID == petitionId), Messages.Listed);
        }
    }
}
