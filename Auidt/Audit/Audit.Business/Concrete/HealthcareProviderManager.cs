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
    public class HealthcareProviderManager : IHealthcareProviderService
    {
        IHealthcareProviderDal _healthcareProviderDal;

        public HealthcareProviderManager(IHealthcareProviderDal healthcareProviderDal)
        {
            _healthcareProviderDal = healthcareProviderDal;
        }

        public IResult Add(HealthcareProvider healthcareProvider)
        {
            _healthcareProviderDal.Add(healthcareProvider);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(HealthcareProvider healthcareProvider)
        {
            _healthcareProviderDal.Delete(healthcareProvider);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<HealthcareProvider>> GetAll()
        {
            return new SuccessDataResult<List<HealthcareProvider>>(_healthcareProviderDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<HealthcareProvider>> GetAllByType(int typeId)
        {
            return new SuccessDataResult<List<HealthcareProvider>>(_healthcareProviderDal.GetAll(p => p.HealtcareProviderTypeID == typeId), Messages.Listed);
        }

        public IDataResult<HealthcareProvider> GetById(int healthcareProviderId)
        {
            return new SuccessDataResult<HealthcareProvider>(_healthcareProviderDal.Get(p => p.HealthcareProviderId == healthcareProviderId), Messages.Geted);
        }

        public IDataResult<HealthcareProvider> GetByName(string healthcareProviderName)
        {
            return new SuccessDataResult<HealthcareProvider>(_healthcareProviderDal.Get(p => p.Name == healthcareProviderName), Messages.Geted);
        }

        public IResult Update(HealthcareProvider healthcareProvider)
        {
            _healthcareProviderDal.Update(healthcareProvider);
            return new Result(true, Messages.Updated);
        }
    }
}
