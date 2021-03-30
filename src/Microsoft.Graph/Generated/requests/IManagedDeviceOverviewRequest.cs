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
    /// The interface IManagedDeviceOverviewRequest.
    /// </summary>
    public partial interface IManagedDeviceOverviewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceOverview using POST.
        /// </summary>
        /// <param name="managedDeviceOverviewToCreate">The ManagedDeviceOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceOverview.</returns>
        System.Threading.Tasks.Task<ManagedDeviceOverview> CreateAsync(ManagedDeviceOverview managedDeviceOverviewToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagedDeviceOverview using POST and returns a <see cref="GraphResponse{ManagedDeviceOverview}"/> object.
        /// </summary>
        /// <param name="managedDeviceOverviewToCreate">The ManagedDeviceOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceOverview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceOverview>> CreateResponseAsync(ManagedDeviceOverview managedDeviceOverviewToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceOverview and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceOverview.</returns>
        System.Threading.Tasks.Task<ManagedDeviceOverview> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedDeviceOverview and returns a <see cref="GraphResponse{ManagedDeviceOverview}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceOverview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceOverview>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceOverview using PATCH.
        /// </summary>
        /// <param name="managedDeviceOverviewToUpdate">The ManagedDeviceOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceOverview.</returns>
        System.Threading.Tasks.Task<ManagedDeviceOverview> UpdateAsync(ManagedDeviceOverview managedDeviceOverviewToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceOverview using PATCH and returns a <see cref="GraphResponse{ManagedDeviceOverview}"/> object.
        /// </summary>
        /// <param name="managedDeviceOverviewToUpdate">The ManagedDeviceOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceOverview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceOverview>> UpdateResponseAsync(ManagedDeviceOverview managedDeviceOverviewToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceOverview using PUT.
        /// </summary>
        /// <param name="managedDeviceOverviewToUpdate">The ManagedDeviceOverview object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedDeviceOverview> PutAsync(ManagedDeviceOverview managedDeviceOverviewToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceOverview using PUT and returns a <see cref="GraphResponse{ManagedDeviceOverview}"/> object.
        /// </summary>
        /// <param name="managedDeviceOverviewToUpdate">The ManagedDeviceOverview object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedDeviceOverview}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceOverview>> PutResponseAsync(ManagedDeviceOverview managedDeviceOverviewToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceOverviewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceOverviewRequest Expand(Expression<Func<ManagedDeviceOverview, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceOverviewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceOverviewRequest Select(Expression<Func<ManagedDeviceOverview, object>> selectExpression);

    }
}
