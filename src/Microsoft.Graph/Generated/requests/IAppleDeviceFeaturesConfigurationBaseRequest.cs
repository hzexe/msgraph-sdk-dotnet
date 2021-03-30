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
    /// The interface IAppleDeviceFeaturesConfigurationBaseRequest.
    /// </summary>
    public partial interface IAppleDeviceFeaturesConfigurationBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppleDeviceFeaturesConfigurationBase using POST.
        /// </summary>
        /// <param name="appleDeviceFeaturesConfigurationBaseToCreate">The AppleDeviceFeaturesConfigurationBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleDeviceFeaturesConfigurationBase.</returns>
        System.Threading.Tasks.Task<AppleDeviceFeaturesConfigurationBase> CreateAsync(AppleDeviceFeaturesConfigurationBase appleDeviceFeaturesConfigurationBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AppleDeviceFeaturesConfigurationBase using POST and returns a <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object.
        /// </summary>
        /// <param name="appleDeviceFeaturesConfigurationBaseToCreate">The AppleDeviceFeaturesConfigurationBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleDeviceFeaturesConfigurationBase>> CreateResponseAsync(AppleDeviceFeaturesConfigurationBase appleDeviceFeaturesConfigurationBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AppleDeviceFeaturesConfigurationBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AppleDeviceFeaturesConfigurationBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AppleDeviceFeaturesConfigurationBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleDeviceFeaturesConfigurationBase.</returns>
        System.Threading.Tasks.Task<AppleDeviceFeaturesConfigurationBase> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AppleDeviceFeaturesConfigurationBase and returns a <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleDeviceFeaturesConfigurationBase>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AppleDeviceFeaturesConfigurationBase using PATCH.
        /// </summary>
        /// <param name="appleDeviceFeaturesConfigurationBaseToUpdate">The AppleDeviceFeaturesConfigurationBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppleDeviceFeaturesConfigurationBase.</returns>
        System.Threading.Tasks.Task<AppleDeviceFeaturesConfigurationBase> UpdateAsync(AppleDeviceFeaturesConfigurationBase appleDeviceFeaturesConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AppleDeviceFeaturesConfigurationBase using PATCH and returns a <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object.
        /// </summary>
        /// <param name="appleDeviceFeaturesConfigurationBaseToUpdate">The AppleDeviceFeaturesConfigurationBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleDeviceFeaturesConfigurationBase>> UpdateResponseAsync(AppleDeviceFeaturesConfigurationBase appleDeviceFeaturesConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AppleDeviceFeaturesConfigurationBase using PUT.
        /// </summary>
        /// <param name="appleDeviceFeaturesConfigurationBaseToUpdate">The AppleDeviceFeaturesConfigurationBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AppleDeviceFeaturesConfigurationBase> PutAsync(AppleDeviceFeaturesConfigurationBase appleDeviceFeaturesConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AppleDeviceFeaturesConfigurationBase using PUT and returns a <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> object.
        /// </summary>
        /// <param name="appleDeviceFeaturesConfigurationBaseToUpdate">The AppleDeviceFeaturesConfigurationBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AppleDeviceFeaturesConfigurationBase}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleDeviceFeaturesConfigurationBase>> PutResponseAsync(AppleDeviceFeaturesConfigurationBase appleDeviceFeaturesConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleDeviceFeaturesConfigurationBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleDeviceFeaturesConfigurationBaseRequest Expand(Expression<Func<AppleDeviceFeaturesConfigurationBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleDeviceFeaturesConfigurationBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleDeviceFeaturesConfigurationBaseRequest Select(Expression<Func<AppleDeviceFeaturesConfigurationBase, object>> selectExpression);

    }
}
