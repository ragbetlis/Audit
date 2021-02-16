using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
    public class HealthcareProvider :IEntity
    {
        public int HealthcareProviderId { get; set; }
        public int ManagerID { get; set; }
        public int HealtcareProviderTypeID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
