using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.DTOs
{
   public class PetitionDetailDto : IDto
    {
        public int PetitionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNo { get; set; }
        public DateTime PetitionDate { get; set; }
        public string PetitionNumber { get; set; }
        public string PetitionDescription { get; set; }
    }
}
