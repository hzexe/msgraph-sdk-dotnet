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
    /// The interface ISettingStateDeviceSummaryRequest.
    /// </summary>
    public partial interface ISettingStateDeviceSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SettingStateDeviceSummary using POST.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToCreate">The SettingStateDeviceSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> CreateAsync(SettingStateDeviceSummary settingStateDeviceSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SettingStateDeviceSummary using POST and returns a <see cref="GraphResponse{SettingStateDeviceSummary}"/> object.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToCreate">The SettingStateDeviceSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SettingStateDeviceSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SettingStateDeviceSummary>> CreateResponseAsync(SettingStateDeviceSummary settingStateDeviceSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SettingStateDeviceSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SettingStateDeviceSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SettingStateDeviceSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SettingStateDeviceSummary and returns a <see cref="GraphResponse{SettingStateDeviceSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SettingStateDeviceSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SettingStateDeviceSummary>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SettingStateDeviceSummary using PATCH.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToUpdate">The SettingStateDeviceSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> UpdateAsync(SettingStateDeviceSummary settingStateDeviceSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SettingStateDeviceSummary using PATCH and returns a <see cref="GraphResponse{SettingStateDeviceSummary}"/> object.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToUpdate">The SettingStateDeviceSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SettingStateDeviceSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SettingStateDeviceSummary>> UpdateResponseAsync(SettingStateDeviceSummary settingStateDeviceSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SettingStateDeviceSummary using PUT.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToUpdate">The SettingStateDeviceSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> PutAsync(SettingStateDeviceSummary settingStateDeviceSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SettingStateDeviceSummary using PUT and returns a <see cref="GraphResponse{SettingStateDeviceSummary}"/> object.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToUpdate">The SettingStateDeviceSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SettingStateDeviceSummary}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SettingStateDeviceSummary>> PutResponseAsync(SettingStateDeviceSummary settingStateDeviceSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Expand(Expression<Func<SettingStateDeviceSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Select(Expression<Func<SettingStateDeviceSummary, object>> selectExpression);

    }
}
