using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
   public class PetitionDetail : IEntity
    {
        public int PetitionDetailId { get; set; }
        public int PetitionID { get; set; }
        public int HealtcareProviderID { get; set; }
    }
}
