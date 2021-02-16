using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Abstract
{
    public interface IReportService
    {
        IDataResult<List<Report>> GetAll();
        IDataResult<Report> GetById(int reportId);
        IDataResult<Report> GetByReportNumber(string reportNumber);
        IDataResult<List<Report>> GetReportByDate(DateTime reportDate);
        IResult Add(Report report);
        IResult Update(Report report);
        IResult Delete(Report report);
    }
}
