﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Scaffolding.CustomFilter.IssueContextDataModel;
using Scaffolding.CustomFilter.Common;
using Scaffolding.CustomFilter.Model;

namespace Scaffolding.CustomFilter.ViewModels {

    /// <summary>
    /// Represents the Issues collection view model.
    /// </summary>
    public partial class IssueCollectionViewModel : CollectionViewModel<Issue, int, IIssueContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of IssueCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static IssueCollectionViewModel Create(IUnitOfWorkFactory<IIssueContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new IssueCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the IssueCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the IssueCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected IssueCollectionViewModel(IUnitOfWorkFactory<IIssueContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Issues) {
        }
    }
}