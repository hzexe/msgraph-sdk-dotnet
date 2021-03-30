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
    /// The interface IWorkforceIntegrationRequest.
    /// </summary>
    public partial interface IWorkforceIntegrationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkforceIntegration using POST.
        /// </summary>
        /// <param name="workforceIntegrationToCreate">The WorkforceIntegration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkforceIntegration.</returns>
        System.Threading.Tasks.Task<WorkforceIntegration> CreateAsync(WorkforceIntegration workforceIntegrationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WorkforceIntegration using POST and returns a <see cref="GraphResponse{WorkforceIntegration}"/> object.
        /// </summary>
        /// <param name="workforceIntegrationToCreate">The WorkforceIntegration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkforceIntegration>> CreateResponseAsync(WorkforceIntegration workforceIntegrationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkforceIntegration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkforceIntegration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkforceIntegration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkforceIntegration.</returns>
        System.Threading.Tasks.Task<WorkforceIntegration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkforceIntegration and returns a <see cref="GraphResponse{WorkforceIntegration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkforceIntegration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkforceIntegration using PATCH.
        /// </summary>
        /// <param name="workforceIntegrationToUpdate">The WorkforceIntegration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkforceIntegration.</returns>
        System.Threading.Tasks.Task<WorkforceIntegration> UpdateAsync(WorkforceIntegration workforceIntegrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkforceIntegration using PATCH and returns a <see cref="GraphResponse{WorkforceIntegration}"/> object.
        /// </summary>
        /// <param name="workforceIntegrationToUpdate">The WorkforceIntegration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkforceIntegration>> UpdateResponseAsync(WorkforceIntegration workforceIntegrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkforceIntegration using PUT.
        /// </summary>
        /// <param name="workforceIntegrationToUpdate">The WorkforceIntegration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkforceIntegration> PutAsync(WorkforceIntegration workforceIntegrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkforceIntegration using PUT and returns a <see cref="GraphResponse{WorkforceIntegration}"/> object.
        /// </summary>
        /// <param name="workforceIntegrationToUpdate">The WorkforceIntegration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkforceIntegration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkforceIntegration>> PutResponseAsync(WorkforceIntegration workforceIntegrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkforceIntegrationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkforceIntegrationRequest Expand(Expression<Func<WorkforceIntegration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkforceIntegrationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkforceIntegrationRequest Select(Expression<Func<WorkforceIntegration, object>> selectExpression);

    }
}
