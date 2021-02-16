using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Abstract
{
   public interface IHealthcareProviderService
    {
        IDataResult<List<HealthcareProvider>> GetAll();
        IDataResult<HealthcareProvider> GetById(int healthcareProviderId);
        IDataResult<HealthcareProvider> GetByName(string healthcareProviderName);
        IDataResult<List<HealthcareProvider>> GetAllByType(int typeId);
        IResult Add(HealthcareProvider healthcareProvider);
        IResult Update(HealthcareProvider healthcareProvider);
        IResult Delete(HealthcareProvider healthcareProvider);

    }
}
