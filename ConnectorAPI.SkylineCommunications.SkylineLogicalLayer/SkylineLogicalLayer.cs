namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
    using Skyline.DataMiner.Net;
    using Skyline.DataMiner.Net.Messages;

    public class SkylineLogicalLayer : ISkylineLogicalLayer
    {
        private TimeSpan defaultTimeout = TimeSpan.FromSeconds(60);

        /// <summary>
		/// Initialize a new instance of the <see cref="SkylineLogicalLayer"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="elementName">The name of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public SkylineLogicalLayer(IConnection connection, string elementName)
        {
            if (String.IsNullOrEmpty(elementName))
            {
                throw new ArgumentException("Please provide a valid Element name.", nameof(elementName));
            }

            SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));

            ElementInfoEventMessage elementInfo;
            try
            {
                elementInfo = (ElementInfoEventMessage)SLNetConnection.HandleSingleResponseMessage(new GetElementByNameMessage
                {
                    ElementName = elementName,
                });
            }
            catch (Exception)
            {
                throw new ArgumentException($"The element does not exists with name '{elementName}'", nameof(elementName));
            }

            if (elementInfo.Protocol != Constants.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementName));
            }

            AgentId = elementInfo.DataMinerID;
            ElementId = elementInfo.ElementID;
        }

        public IConnection SLNetConnection { get; set; }

        /// <inheritdoc/>
        public int AgentId { get; }

        /// <inheritdoc/>
        public int ElementId { get; }

        public void SendMessageNoResponse(params ISkylineLogicalLayerRequest[] messages)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISkylineLogicalLayerResponse> SendMessages(ISkylineLogicalLayerRequest[] messages, TimeSpan timeout = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ISkylineLogicalLayerResponse SendSingleResponseMessage(ISkylineLogicalLayerRequest message, TimeSpan timeout = default)
        {
            var interAppCallTimeout = timeout;
            if (timeout == default)
            {
                interAppCallTimeout = defaultTimeout;
            }

            IInterAppCall myCommand = InterAppCallFactory.CreateNew();
            myCommand.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
            myCommand.Messages.AddMessage(Messages.Types.ToMessage(message));
            var internalResult = myCommand.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Messages.Types.KnownTypes).First();
            return Messages.Types.FromMessage(internalResult);
        }

        public T SendSingleResponseMessage<T>(ISkylineLogicalLayerRequest message, TimeSpan timeout = default) where T : ISkylineLogicalLayerResponse
        {
            throw new NotImplementedException();
        }
    }
}