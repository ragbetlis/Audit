using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
    public class ReportDetail : IEntity
    {
        public int ReportDetailId { get; set; }
        public int ResultType { get; set; }
        public int PersonID { get; set; }
        public int PetitionID { get; set; }
        public int HealtcareProviderID { get; set; }
        public int InspectorID { get; set; }
        public int ReportID { get; set; }
    }
}
