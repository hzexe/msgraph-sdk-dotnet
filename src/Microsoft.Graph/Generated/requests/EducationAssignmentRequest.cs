// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EducationAssignmentRequest.
    /// </summary>
    public partial class EducationAssignmentRequest : BaseRequest, IEducationAssignmentRequest
    {
        /// <summary>
        /// Constructs a new EducationAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationAssignment using POST.
        /// </summary>
        /// <param name="educationAssignmentToCreate">The EducationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationAssignment.</returns>
        public async System.Threading.Tasks.Task<EducationAssignment> CreateAsync(EducationAssignment educationAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EducationAssignment>(educationAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EducationAssignment using POST and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="educationAssignmentToCreate">The EducationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> CreateResponseAsync(EducationAssignment educationAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EducationAssignment>(educationAssignmentToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EducationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EducationAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EducationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationAssignment.</returns>
        public async System.Threading.Tasks.Task<EducationAssignment> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EducationAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EducationAssignment and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EducationAssignment>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EducationAssignment using PATCH.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationAssignment.</returns>
        public async System.Threading.Tasks.Task<EducationAssignment> UpdateAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EducationAssignment>(educationAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationAssignment using PATCH and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> UpdateResponseAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EducationAssignment>(educationAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EducationAssignment using PUT.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EducationAssignment> PutAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EducationAssignment>(educationAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationAssignment using PUT and returns a <see cref="GraphResponse{EducationAssignment}"/> object.
        /// </summary>
        /// <param name="educationAssignmentToUpdate">The EducationAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EducationAssignment}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignment>> PutResponseAsync(EducationAssignment educationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EducationAssignment>(educationAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentRequest Expand(Expression<Func<EducationAssignment, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentRequest Select(Expression<Func<EducationAssignment, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="educationAssignmentToInitialize">The <see cref="EducationAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationAssignment educationAssignmentToInitialize)
        {

            if (educationAssignmentToInitialize != null)
            {
                if (educationAssignmentToInitialize.Categories != null && educationAssignmentToInitialize.Categories.CurrentPage != null)
                {
                    educationAssignmentToInitialize.Categories.InitializeNextPageRequest(this.Client, educationAssignmentToInitialize.CategoriesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationAssignmentToInitialize.Categories.AdditionalData = educationAssignmentToInitialize.AdditionalData;
                }
                if (educationAssignmentToInitialize.Resources != null && educationAssignmentToInitialize.Resources.CurrentPage != null)
                {
                    educationAssignmentToInitialize.Resources.InitializeNextPageRequest(this.Client, educationAssignmentToInitialize.ResourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationAssignmentToInitialize.Resources.AdditionalData = educationAssignmentToInitialize.AdditionalData;
                }
                if (educationAssignmentToInitialize.Submissions != null && educationAssignmentToInitialize.Submissions.CurrentPage != null)
                {
                    educationAssignmentToInitialize.Submissions.InitializeNextPageRequest(this.Client, educationAssignmentToInitialize.SubmissionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationAssignmentToInitialize.Submissions.AdditionalData = educationAssignmentToInitialize.AdditionalData;
                }

            }


        }
    }
}
