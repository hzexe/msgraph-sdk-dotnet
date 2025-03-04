// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ParticipantRequestBuilder.
    /// </summary>
    public partial class ParticipantRequestBuilder : EntityRequestBuilder, IParticipantRequestBuilder
    {

        /// <summary>
        /// Constructs a new ParticipantRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ParticipantRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IParticipantRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IParticipantRequest Request(IEnumerable<Option> options)
        {
            return new ParticipantRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ParticipantMute.
        /// </summary>
        /// <returns>The <see cref="IParticipantMuteRequestBuilder"/>.</returns>
        public IParticipantMuteRequestBuilder Mute(
            string clientContext = null)
        {
            return new ParticipantMuteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.mute"),
                this.Client,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for ParticipantStartHoldMusic.
        /// </summary>
        /// <returns>The <see cref="IParticipantStartHoldMusicRequestBuilder"/>.</returns>
        public IParticipantStartHoldMusicRequestBuilder StartHoldMusic(
            Prompt customPrompt = null,
            string clientContext = null)
        {
            return new ParticipantStartHoldMusicRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.startHoldMusic"),
                this.Client,
                customPrompt,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for ParticipantStopHoldMusic.
        /// </summary>
        /// <returns>The <see cref="IParticipantStopHoldMusicRequestBuilder"/>.</returns>
        public IParticipantStopHoldMusicRequestBuilder StopHoldMusic(
            string clientContext = null)
        {
            return new ParticipantStopHoldMusicRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.stopHoldMusic"),
                this.Client,
                clientContext);
        }
    
    }
}
