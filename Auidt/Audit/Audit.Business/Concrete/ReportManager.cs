using Audit.Business.Abstract;
using Audit.Business.Constants;
using Audit.DataAccess.Abstract;
using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Concrete
{
    public class ReportManager : IReportService
    {
        IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public IResult Add(Report report)
        {
            _reportDal.Add(report);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Report report)
        {
            _reportDal.Delete(report);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Report>> GetAll()
        {
            return new SuccessDataResult<List<Report>>(_reportDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Report> GetById(int reportId)
        {
            return new SuccessDataResult<Report>(_reportDal.Get(p=>p.ReportId==reportId), Messages.Geted);
        }

        public IDataResult<Report> GetByReportNumber(string reportNumber)
        {
            return new SuccessDataResult<Report>(_reportDal.Get(p => p.ReportNumber == reportNumber), Messages.Geted);
        }

        public IDataResult<List<Report>> GetReportByDate(DateTime reportDate)
        {
            return new SuccessDataResult<List<Report>>(_reportDal.GetAll(p=>p.ReportDate==reportDate), Messages.Listed);
        }

        public IResult Update(Report report)
        {
            _reportDal.Add(report);
            return new Result(true, Messages.Added);
        }
    }
}
