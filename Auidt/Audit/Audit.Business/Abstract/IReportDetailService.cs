using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Abstract
{
  public  interface IReportDetailService
    {
        IDataResult<List<ReportDetail>> GetAll();
        IDataResult<List<ReportDetail>> GetByReportId(int reportId);
        IDataResult<List<ReportDetail>> GetByInspectorId(int inspectorId);
        IDataResult<List<ReportDetail>> GetByHealthcareProviderId(int healthcareProviderId);
        IResult Add(ReportDetail reportDetail);
        IResult Update(ReportDetail reportDetail);
        IResult Delete(ReportDetail reportDetail);
    }
}
