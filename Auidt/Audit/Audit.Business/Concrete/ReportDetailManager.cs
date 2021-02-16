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
    public class ReportDetailManager : IReportDetailService
    {
        IReportDetailDal _reportDetailDal;

        public ReportDetailManager(IReportDetailDal reportDetailDal)
        {
            _reportDetailDal = reportDetailDal;
        }

        public IResult Add(ReportDetail reportDetail)
        {
            _reportDetailDal.Add(reportDetail);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(ReportDetail reportDetail)
        {
            _reportDetailDal.Delete(reportDetail);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<ReportDetail>> GetAll()
        {
            return new SuccessDataResult<List<ReportDetail>>(_reportDetailDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<ReportDetail>> GetByHealthcareProviderId(int healthcareProviderId)
        {
            return new SuccessDataResult<List<ReportDetail>>(_reportDetailDal.GetAll(p => p.HealtcareProviderID == healthcareProviderId), Messages.Listed);
        }

        public IDataResult<List<ReportDetail>> GetByInspectorId(int inspectorId)
        {
            return new SuccessDataResult<List<ReportDetail>>(_reportDetailDal.GetAll(p => p.InspectorID == inspectorId), Messages.Listed);
        }

        public IDataResult<List<ReportDetail>> GetByReportId(int reportId)
        {
            return new SuccessDataResult<List<ReportDetail>>(_reportDetailDal.GetAll(p => p.ReportID == reportId), Messages.Listed);
        }

        public IResult Update(ReportDetail reportDetail)
        {
            _reportDetailDal.Update(reportDetail);
            return new Result(true, Messages.Updated);
        }
    }
}
