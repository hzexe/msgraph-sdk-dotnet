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
    /// The interface IWorkbookRangeSortRequest.
    /// </summary>
    public partial interface IWorkbookRangeSortRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRangeSort using POST.
        /// </summary>
        /// <param name="workbookRangeSortToCreate">The WorkbookRangeSort to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeSort.</returns>
        System.Threading.Tasks.Task<WorkbookRangeSort> CreateAsync(WorkbookRangeSort workbookRangeSortToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookRangeSort using POST and returns a <see cref="GraphResponse{WorkbookRangeSort}"/> object.
        /// </summary>
        /// <param name="workbookRangeSortToCreate">The WorkbookRangeSort to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeSort}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeSort>> CreateResponseAsync(WorkbookRangeSort workbookRangeSortToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeSort.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeSort and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeSort.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeSort.</returns>
        System.Threading.Tasks.Task<WorkbookRangeSort> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeSort and returns a <see cref="GraphResponse{WorkbookRangeSort}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeSort}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeSort>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeSort using PATCH.
        /// </summary>
        /// <param name="workbookRangeSortToUpdate">The WorkbookRangeSort to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeSort.</returns>
        System.Threading.Tasks.Task<WorkbookRangeSort> UpdateAsync(WorkbookRangeSort workbookRangeSortToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeSort using PATCH and returns a <see cref="GraphResponse{WorkbookRangeSort}"/> object.
        /// </summary>
        /// <param name="workbookRangeSortToUpdate">The WorkbookRangeSort to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeSort}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeSort>> UpdateResponseAsync(WorkbookRangeSort workbookRangeSortToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeSort using PUT.
        /// </summary>
        /// <param name="workbookRangeSortToUpdate">The WorkbookRangeSort object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookRangeSort> PutAsync(WorkbookRangeSort workbookRangeSortToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeSort using PUT and returns a <see cref="GraphResponse{WorkbookRangeSort}"/> object.
        /// </summary>
        /// <param name="workbookRangeSortToUpdate">The WorkbookRangeSort object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookRangeSort}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeSort>> PutResponseAsync(WorkbookRangeSort workbookRangeSortToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeSortRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeSortRequest Expand(Expression<Func<WorkbookRangeSort, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeSortRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeSortRequest Select(Expression<Func<WorkbookRangeSort, object>> selectExpression);

    }
}
