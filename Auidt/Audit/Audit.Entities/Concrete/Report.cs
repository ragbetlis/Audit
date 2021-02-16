using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Entities.Concrete
{
   public class Report : IEntity
    {
        public int ReportId { get; set; }
        public string Description { get; set; }
        public string ReportNumber { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
