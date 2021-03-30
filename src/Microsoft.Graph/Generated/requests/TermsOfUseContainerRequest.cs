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
    /// The type TermsOfUseContainerRequest.
    /// </summary>
    public partial class TermsOfUseContainerRequest : BaseRequest, ITermsOfUseContainerRequest
    {
        /// <summary>
        /// Constructs a new TermsOfUseContainerRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TermsOfUseContainerRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TermsOfUseContainer using POST.
        /// </summary>
        /// <param name="termsOfUseContainerToCreate">The TermsOfUseContainer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TermsOfUseContainer.</returns>
        public async System.Threading.Tasks.Task<TermsOfUseContainer> CreateAsync(TermsOfUseContainer termsOfUseContainerToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<TermsOfUseContainer>(termsOfUseContainerToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TermsOfUseContainer using POST and returns a <see cref="GraphResponse{TermsOfUseContainer}"/> object.
        /// </summary>
        /// <param name="termsOfUseContainerToCreate">The TermsOfUseContainer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TermsOfUseContainer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsOfUseContainer>> CreateResponseAsync(TermsOfUseContainer termsOfUseContainerToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<TermsOfUseContainer>(termsOfUseContainerToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified TermsOfUseContainer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<TermsOfUseContainer>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TermsOfUseContainer and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified TermsOfUseContainer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TermsOfUseContainer.</returns>
        public async System.Threading.Tasks.Task<TermsOfUseContainer> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<TermsOfUseContainer>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TermsOfUseContainer and returns a <see cref="GraphResponse{TermsOfUseContainer}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TermsOfUseContainer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsOfUseContainer>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<TermsOfUseContainer>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TermsOfUseContainer using PATCH.
        /// </summary>
        /// <param name="termsOfUseContainerToUpdate">The TermsOfUseContainer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TermsOfUseContainer.</returns>
        public async System.Threading.Tasks.Task<TermsOfUseContainer> UpdateAsync(TermsOfUseContainer termsOfUseContainerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<TermsOfUseContainer>(termsOfUseContainerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TermsOfUseContainer using PATCH and returns a <see cref="GraphResponse{TermsOfUseContainer}"/> object.
        /// </summary>
        /// <param name="termsOfUseContainerToUpdate">The TermsOfUseContainer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TermsOfUseContainer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsOfUseContainer>> UpdateResponseAsync(TermsOfUseContainer termsOfUseContainerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<TermsOfUseContainer>(termsOfUseContainerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TermsOfUseContainer using PUT.
        /// </summary>
        /// <param name="termsOfUseContainerToUpdate">The TermsOfUseContainer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<TermsOfUseContainer> PutAsync(TermsOfUseContainer termsOfUseContainerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<TermsOfUseContainer>(termsOfUseContainerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TermsOfUseContainer using PUT and returns a <see cref="GraphResponse{TermsOfUseContainer}"/> object.
        /// </summary>
        /// <param name="termsOfUseContainerToUpdate">The TermsOfUseContainer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{TermsOfUseContainer}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsOfUseContainer>> PutResponseAsync(TermsOfUseContainer termsOfUseContainerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<TermsOfUseContainer>(termsOfUseContainerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsOfUseContainerRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsOfUseContainerRequest Expand(Expression<Func<TermsOfUseContainer, object>> expandExpression)
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
        public ITermsOfUseContainerRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsOfUseContainerRequest Select(Expression<Func<TermsOfUseContainer, object>> selectExpression)
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
        /// <param name="termsOfUseContainerToInitialize">The <see cref="TermsOfUseContainer"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TermsOfUseContainer termsOfUseContainerToInitialize)
        {

            if (termsOfUseContainerToInitialize != null && termsOfUseContainerToInitialize.AdditionalData != null)
            {

                if (termsOfUseContainerToInitialize.AgreementAcceptances != null && termsOfUseContainerToInitialize.AgreementAcceptances.CurrentPage != null)
                {
                    termsOfUseContainerToInitialize.AgreementAcceptances.AdditionalData = termsOfUseContainerToInitialize.AdditionalData;

                    object nextPageLink;
                    termsOfUseContainerToInitialize.AdditionalData.TryGetValue("agreementAcceptances@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        termsOfUseContainerToInitialize.AgreementAcceptances.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (termsOfUseContainerToInitialize.Agreements != null && termsOfUseContainerToInitialize.Agreements.CurrentPage != null)
                {
                    termsOfUseContainerToInitialize.Agreements.AdditionalData = termsOfUseContainerToInitialize.AdditionalData;

                    object nextPageLink;
                    termsOfUseContainerToInitialize.AdditionalData.TryGetValue("agreements@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        termsOfUseContainerToInitialize.Agreements.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
