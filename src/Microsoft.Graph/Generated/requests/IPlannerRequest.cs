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
    /// The interface IPlannerRequest.
    /// </summary>
    public partial interface IPlannerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Planner using POST.
        /// </summary>
        /// <param name="plannerToCreate">The Planner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Planner.</returns>
        System.Threading.Tasks.Task<Planner> CreateAsync(Planner plannerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Planner using POST and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="plannerToCreate">The Planner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Planner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Planner>> CreateResponseAsync(Planner plannerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Planner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Planner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Planner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Planner.</returns>
        System.Threading.Tasks.Task<Planner> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Planner and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Planner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Planner>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Planner using PATCH.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Planner.</returns>
        System.Threading.Tasks.Task<Planner> UpdateAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Planner using PATCH and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Planner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Planner>> UpdateResponseAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Planner using PUT.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Planner> PutAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Planner using PUT and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Planner}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Planner>> PutResponseAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Expand(Expression<Func<Planner, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Select(Expression<Func<Planner, object>> selectExpression);

    }
}
