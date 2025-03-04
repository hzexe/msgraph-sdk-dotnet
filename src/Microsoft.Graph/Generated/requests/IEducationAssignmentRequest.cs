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
    /// The interface IEducationAssignmentRequest.
    /// </summary>
    public partial interface IEducationAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationAssignment using POST.
        /// </summary>
        /// <param name="educationAssignmentToCreate">The EducationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationAssignment.</returns>
        System.Threading.Tasks.Task<EducationAssignment> CreateAsync(EducationAssignment educationAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationAssignment using POST and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="educationAssignmentToCreate">The EducationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> CreateResponseAsync(EducationAssignment educationAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationAssignment.</returns>
        System.Threading.Tasks.Task<EducationAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationAssignment and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationAssignment using PATCH.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationAssignment.</returns>
        System.Threading.Tasks.Task<EducationAssignment> UpdateAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationAssignment using PATCH and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> UpdateResponseAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationAssignment using PUT.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationAssignment> PutAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationAssignment using PUT and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> PutResponseAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentRequest Expand(Expression<Func<EducationAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentRequest Select(Expression<Func<EducationAssignment, object>> selectExpression);

    }
}
