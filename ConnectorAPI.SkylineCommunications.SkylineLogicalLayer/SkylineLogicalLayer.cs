namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
    using Skyline.DataMiner.Net;
    using Skyline.DataMiner.Net.Messages;

    public class SkylineLogicalLayer
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

            try
            {
                var elementInfo = (ElementInfoEventMessage)SLNetConnection.HandleSingleResponseMessage(new GetElementByNameMessage
                {
                    ElementName = elementName,
                });

                if (elementInfo.Protocol != Constants.ProtocolName)
                {
                    throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementName));
                }

                AgentId = elementInfo.DataMinerID;
                ElementId = elementInfo.ElementID;
            }
            catch (Exception)
            {
                throw new ArgumentException($"The element does not exists with name '{elementName}'", nameof(elementName));
            }
        }

        /// <summary>
		/// The SLNet Connection to use.
		/// </summary>
		public IConnection SLNetConnection { get; set; }

        /// <summary>
        /// The id of the DataMiner that is hosting the element.
        /// </summary>
        int AgentId { get; }

        /// <summary>
        /// The id of the element in DataMiner.
        /// </summary>
        int ElementId { get; }
    }
}