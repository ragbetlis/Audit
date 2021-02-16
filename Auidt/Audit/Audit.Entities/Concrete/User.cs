using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
   public class User : IEntity
    {
        public int UserId { get; set; }
        public int PersonID { get; set; }
        public byte AuthorizeType { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
