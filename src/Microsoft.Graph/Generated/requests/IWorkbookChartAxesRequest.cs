// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookChartAxesRequest.
    /// </summary>
    public partial interface IWorkbookChartAxesRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAxes using POST.
        /// </summary>
        /// <param name="workbookChartAxesToCreate">The WorkbookChartAxes to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxes.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxes> CreateAsync(WorkbookChartAxes workbookChartAxesToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WorkbookChartAxes using POST and returns a <see cref="GraphResponse{WorkbookChartAxes}"/> object.
        /// </summary>
        /// <param name="workbookChartAxesToCreate">The WorkbookChartAxes to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxes}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxes>> CreateResponseAsync(WorkbookChartAxes workbookChartAxesToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartAxes.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartAxes and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartAxes.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxes.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxes> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartAxes and returns a <see cref="GraphResponse{WorkbookChartAxes}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxes}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxes>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartAxes using PATCH.
        /// </summary>
        /// <param name="workbookChartAxesToUpdate">The WorkbookChartAxes to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAxes.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxes> UpdateAsync(WorkbookChartAxes workbookChartAxesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartAxes using PATCH and returns a <see cref="GraphResponse{WorkbookChartAxes}"/> object.
        /// </summary>
        /// <param name="workbookChartAxesToUpdate">The WorkbookChartAxes to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxes}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxes>> UpdateResponseAsync(WorkbookChartAxes workbookChartAxesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartAxes using PUT.
        /// </summary>
        /// <param name="workbookChartAxesToUpdate">The WorkbookChartAxes object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxes> PutAsync(WorkbookChartAxes workbookChartAxesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartAxes using PUT and returns a <see cref="GraphResponse{WorkbookChartAxes}"/> object.
        /// </summary>
        /// <param name="workbookChartAxesToUpdate">The WorkbookChartAxes object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookChartAxes}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxes>> PutResponseAsync(WorkbookChartAxes workbookChartAxesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxesRequest Expand(Expression<Func<WorkbookChartAxes, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxesRequest Select(Expression<Func<WorkbookChartAxes, object>> selectExpression);

    }
}
