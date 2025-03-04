// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookTableColumnItemAtRequestBuilder.
    /// </summary>
    public partial class WorkbookTableColumnItemAtRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookTableColumnItemAtRequest>, IWorkbookTableColumnItemAtRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableColumnItemAtRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        public WorkbookTableColumnItemAtRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 index)
            : base(requestUrl, client)
        {
            this.SetParameter("index", index, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookTableColumnItemAtRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableColumnItemAtRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnAddRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <param name="values">A values parameter for the OData method call.</param>
        /// <param name="name">A name parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableColumnAddRequestBuilder"/>.</returns>
        public IWorkbookTableColumnAddRequestBuilder Add(
            Int32? index,
            System.Text.Json.JsonDocument values,
            string name)
        {
            return new WorkbookTableColumnAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                index,
                values,
                name);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnCountRequestBuilder"/>.</returns>
        public IWorkbookTableColumnCountRequestBuilder Count()
        {
            return new WorkbookTableColumnCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnDataBodyRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnDataBodyRangeRequestBuilder"/>.</returns>
        public IWorkbookTableColumnDataBodyRangeRequestBuilder DataBodyRange()
        {
            return new WorkbookTableColumnDataBodyRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.dataBodyRange"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnHeaderRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnHeaderRowRangeRequestBuilder"/>.</returns>
        public IWorkbookTableColumnHeaderRowRangeRequestBuilder HeaderRowRange()
        {
            return new WorkbookTableColumnHeaderRowRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.headerRowRange"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableColumnItemAtRequestBuilder"/>.</returns>
        public IWorkbookTableColumnItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookTableColumnItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnRangeRequestBuilder"/>.</returns>
        public IWorkbookTableColumnRangeRequestBuilder Range()
        {
            return new WorkbookTableColumnRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.range"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnTotalRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnTotalRowRangeRequestBuilder"/>.</returns>
        public IWorkbookTableColumnTotalRowRangeRequestBuilder TotalRowRange()
        {
            return new WorkbookTableColumnTotalRowRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.totalRowRange"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for Filter.
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterRequestBuilder Filter
        {
            get
            {
                return new WorkbookFilterRequestBuilder(this.AppendSegmentToRequestUrl("filter"), this.Client);
            }
        }
    }
}
