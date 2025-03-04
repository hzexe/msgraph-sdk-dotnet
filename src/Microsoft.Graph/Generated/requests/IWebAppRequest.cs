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
    /// The interface IWebAppRequest.
    /// </summary>
    public partial interface IWebAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WebApp using POST.
        /// </summary>
        /// <param name="webAppToCreate">The WebApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> CreateAsync(WebApp webAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WebApp using POST and returns a <see cref="GraphResponse{WebApp}"/> object.
        /// </summary>
        /// <param name="webAppToCreate">The WebApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WebApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebApp>> CreateResponseAsync(WebApp webAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WebApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WebApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WebApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WebApp and returns a <see cref="GraphResponse{WebApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WebApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebApp using PATCH.
        /// </summary>
        /// <param name="webAppToUpdate">The WebApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> UpdateAsync(WebApp webAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebApp using PATCH and returns a <see cref="GraphResponse{WebApp}"/> object.
        /// </summary>
        /// <param name="webAppToUpdate">The WebApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WebApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebApp>> UpdateResponseAsync(WebApp webAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebApp using PUT.
        /// </summary>
        /// <param name="webAppToUpdate">The WebApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WebApp> PutAsync(WebApp webAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebApp using PUT and returns a <see cref="GraphResponse{WebApp}"/> object.
        /// </summary>
        /// <param name="webAppToUpdate">The WebApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WebApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebApp>> PutResponseAsync(WebApp webAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Expand(Expression<Func<WebApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Select(Expression<Func<WebApp, object>> selectExpression);

    }
}
