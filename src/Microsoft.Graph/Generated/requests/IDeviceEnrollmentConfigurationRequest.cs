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
    /// The interface IDeviceEnrollmentConfigurationRequest.
    /// </summary>
    public partial interface IDeviceEnrollmentConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceEnrollmentConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToCreate">The DeviceEnrollmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> CreateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceEnrollmentConfiguration using POST and returns a <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToCreate">The DeviceEnrollmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentConfiguration>> CreateResponseAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceEnrollmentConfiguration and returns a <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> UpdateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PATCH and returns a <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentConfiguration>> UpdateResponseAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PUT.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> PutAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PUT and returns a <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceEnrollmentConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentConfiguration>> PutResponseAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Expand(Expression<Func<DeviceEnrollmentConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Select(Expression<Func<DeviceEnrollmentConfiguration, object>> selectExpression);

    }
}
