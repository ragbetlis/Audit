using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
   public class Person : IEntity
    {
        public int PersonId { get; set; }
        public int PersonTypeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string IdentificationNo { get; set; }
        public string Email { get; set; }
    }
}
