using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
   public class Petition : IEntity
    {
        public int PetitionId { get; set; }
        public int PetitionerID { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public DateTime PetitionDate { get; set; }

        private bool _petitionCase = true;
        public bool PetitionCase
        {
            get { return _petitionCase; }
            set
            {
                _petitionCase = value;
            }
        }
    }
}
