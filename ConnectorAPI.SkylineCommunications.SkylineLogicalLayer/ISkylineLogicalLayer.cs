namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages;
    using Skyline.DataMiner.Net;

    /// <summary>
    /// Defines the methods for inter-application communication involving example requests and responses.
    /// </summary>
    public interface ISkylineLogicalLayer
    {
        /// <summary>
		/// The SLNet Connection to use.
		/// </summary>
		IConnection SLNetConnection { get; set; }

        /// <summary>
        /// The id of the DataMiner that is hosting the element.
        /// </summary>
        int AgentId { get; }

        /// <summary>
        /// The id of the element in DataMiner.
        /// </summary>
        int ElementId { get; }

        /// <summary>
        /// Sends the specified messages to the element using InterApp and do not wait for a response.
        /// </summary>
        /// <param name="messages">The messages that need to be send.</param>
        void SendMessageNoResponse(params ISkylineLogicalLayerRequest[] messages);

        /// <summary>
        /// Sends the specified messages to the element using InterApp and wait for the responses.
        /// </summary>
        /// <param name="messages">The messages that need to be send.</param>
        /// <param name="timeout">The time the method needs to wait for a response.</param>
        /// <returns>The response coming from the element</returns>
        IEnumerable<ISkylineLogicalLayerResponse> SendMessages(ISkylineLogicalLayerRequest[] messages, TimeSpan timeout = default);

        /// <summary>
        /// Sends the specified message to the element using InterApp and wait for the responses.
        /// </summary>
        /// <param name="message">The message that needs to be send.</param>
        /// <param name="timeout">The time the method needs to wait for a response.</param>
        /// <returns>The response coming from the element</returns>
        ISkylineLogicalLayerResponse SendSingleResponseMessage(ISkylineLogicalLayerRequest message, TimeSpan timeout = default);

        /// <summary>
        /// Sends the specified message to the element using InterApp and wait for the responses.
        /// </summary>
        /// <param name="message">The message that needs to be send.</param>
        /// <param name="timeout">The time the method needs to wait for a response.</param>
        /// <returns>The response coming from the device</returns>
        /// <typeparam name="T">The type of the expected response, which must implement <see cref="ISkylineLogicalLayerResponse"/>.</typeparam>
        T SendSingleResponseMessage<T>(ISkylineLogicalLayerRequest message, TimeSpan timeout = default) where T : ISkylineLogicalLayerResponse;
    }
}
