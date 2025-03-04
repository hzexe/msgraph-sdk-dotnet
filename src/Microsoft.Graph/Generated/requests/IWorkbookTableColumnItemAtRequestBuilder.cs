// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookTableColumnItemAtRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTableColumnItemAtRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookTableColumnItemAtRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnAddRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <param name="values">A values parameter for the OData method call.</param>
        /// <param name="name">A name parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableColumnAddRequestBuilder"/>.</returns>
        IWorkbookTableColumnAddRequestBuilder Add(
            Int32? index,
            System.Text.Json.JsonDocument values,
            string name);
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnCountRequestBuilder"/>.</returns>
        IWorkbookTableColumnCountRequestBuilder Count();
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnDataBodyRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnDataBodyRangeRequestBuilder"/>.</returns>
        IWorkbookTableColumnDataBodyRangeRequestBuilder DataBodyRange();
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnHeaderRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnHeaderRowRangeRequestBuilder"/>.</returns>
        IWorkbookTableColumnHeaderRowRangeRequestBuilder HeaderRowRange();
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableColumnItemAtRequestBuilder"/>.</returns>
        IWorkbookTableColumnItemAtRequestBuilder ItemAt(
            Int32 index);
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnRangeRequestBuilder"/>.</returns>
        IWorkbookTableColumnRangeRequestBuilder Range();
        /// <summary>
        /// Gets the request builder for WorkbookTableColumnTotalRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnTotalRowRangeRequestBuilder"/>.</returns>
        IWorkbookTableColumnTotalRowRangeRequestBuilder TotalRowRange();
        /// <summary>
        /// Gets the request builder for Filter.
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterRequestBuilder"/>.</returns>
        IWorkbookFilterRequestBuilder Filter  { get; }
    }
}
