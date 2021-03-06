﻿using Audit.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.DataAccess.Abstract
{
   public interface IPersonDal : IEntityRepository<Person>
    {
    }
}
