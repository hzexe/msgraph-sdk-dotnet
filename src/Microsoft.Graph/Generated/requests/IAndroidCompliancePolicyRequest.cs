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
    /// The interface IAndroidCompliancePolicyRequest.
    /// </summary>
    public partial interface IAndroidCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidCompliancePolicy using POST.
        /// </summary>
        /// <param name="androidCompliancePolicyToCreate">The AndroidCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidCompliancePolicy.</returns>
        System.Threading.Tasks.Task<AndroidCompliancePolicy> CreateAsync(AndroidCompliancePolicy androidCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidCompliancePolicy using POST and returns a <see cref="GraphResponse{AndroidCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="androidCompliancePolicyToCreate">The AndroidCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidCompliancePolicy>> CreateResponseAsync(AndroidCompliancePolicy androidCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidCompliancePolicy.</returns>
        System.Threading.Tasks.Task<AndroidCompliancePolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidCompliancePolicy and returns a <see cref="GraphResponse{AndroidCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="androidCompliancePolicyToUpdate">The AndroidCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidCompliancePolicy.</returns>
        System.Threading.Tasks.Task<AndroidCompliancePolicy> UpdateAsync(AndroidCompliancePolicy androidCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidCompliancePolicy using PATCH and returns a <see cref="GraphResponse{AndroidCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="androidCompliancePolicyToUpdate">The AndroidCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidCompliancePolicy>> UpdateResponseAsync(AndroidCompliancePolicy androidCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidCompliancePolicy using PUT.
        /// </summary>
        /// <param name="androidCompliancePolicyToUpdate">The AndroidCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidCompliancePolicy> PutAsync(AndroidCompliancePolicy androidCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidCompliancePolicy using PUT and returns a <see cref="GraphResponse{AndroidCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="androidCompliancePolicyToUpdate">The AndroidCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidCompliancePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidCompliancePolicy>> PutResponseAsync(AndroidCompliancePolicy androidCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCompliancePolicyRequest Expand(Expression<Func<AndroidCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCompliancePolicyRequest Select(Expression<Func<AndroidCompliancePolicy, object>> selectExpression);

    }
}
