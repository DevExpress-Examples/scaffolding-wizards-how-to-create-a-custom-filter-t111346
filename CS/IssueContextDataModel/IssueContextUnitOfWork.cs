using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Common.DataModel.EntityFramework;
using Scaffolding.CustomFilter.Model;

namespace Scaffolding.CustomFilter.IssueContextDataModel {
    /// <summary>
    /// A IssueContextUnitOfWork instance that represents the run-time implementation of the IIssueContextUnitOfWork interface.
    /// </summary>
    public class IssueContextUnitOfWork : DbUnitOfWork<IssueContext>, IIssueContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the IssueContextUnitOfWork class.
        /// </summary>
        /// <param name="context">An underlying DbContext.</param>
        public IssueContextUnitOfWork(IssueContext context)
            : base(context) {
        }

        IRepository<Issue, int> IIssueContextUnitOfWork.Issues {
            get { return GetRepository(x => x.Set<Issue>(), x => x.ID); }
        }
    }
}