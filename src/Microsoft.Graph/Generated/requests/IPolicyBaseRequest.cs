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
    /// The interface IPolicyBaseRequest.
    /// </summary>
    public partial interface IPolicyBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PolicyBase using POST.
        /// </summary>
        /// <param name="policyBaseToCreate">The PolicyBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PolicyBase.</returns>
        System.Threading.Tasks.Task<PolicyBase> CreateAsync(PolicyBase policyBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PolicyBase using POST and returns a <see cref="GraphResponse{PolicyBase}"/> object.
        /// </summary>
        /// <param name="policyBaseToCreate">The PolicyBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicyBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PolicyBase>> CreateResponseAsync(PolicyBase policyBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PolicyBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PolicyBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PolicyBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PolicyBase.</returns>
        System.Threading.Tasks.Task<PolicyBase> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PolicyBase and returns a <see cref="GraphResponse{PolicyBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicyBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PolicyBase>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PolicyBase using PATCH.
        /// </summary>
        /// <param name="policyBaseToUpdate">The PolicyBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PolicyBase.</returns>
        System.Threading.Tasks.Task<PolicyBase> UpdateAsync(PolicyBase policyBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PolicyBase using PATCH and returns a <see cref="GraphResponse{PolicyBase}"/> object.
        /// </summary>
        /// <param name="policyBaseToUpdate">The PolicyBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PolicyBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PolicyBase>> UpdateResponseAsync(PolicyBase policyBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PolicyBase using PUT.
        /// </summary>
        /// <param name="policyBaseToUpdate">The PolicyBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PolicyBase> PutAsync(PolicyBase policyBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PolicyBase using PUT and returns a <see cref="GraphResponse{PolicyBase}"/> object.
        /// </summary>
        /// <param name="policyBaseToUpdate">The PolicyBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PolicyBase}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PolicyBase>> PutResponseAsync(PolicyBase policyBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyBaseRequest Expand(Expression<Func<PolicyBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyBaseRequest Select(Expression<Func<PolicyBase, object>> selectExpression);

    }
}
