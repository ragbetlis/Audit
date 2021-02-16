using Audit.DataAccess.Abstract;
using Audit.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.DataAccess.Concrete.EntityFramework
{
    public class EfPetitionDal : EfEntityRepositoryBase<Petition, AuditContext>, IPetitionDal
    {
    }
}
