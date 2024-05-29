namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Static class holding the types of the InterApp Messages.
    /// </summary>
    public static class Types
    {
        /// <summary>
        /// Gets a list of all the supported InterApp Message Types.
        /// </summary>
        public static List<Type> KnownTypes { get; } = new List<Type>
        {
            typeof(ParameterMonitorModel),
        };

        /// <summary>
        /// Converts an <see cref="IExampleRequest"/> message to a <see cref="Message"/> object.
        /// </summary>
        /// <param name="message">The <see cref="IExampleRequest"/> message to be converted.</param>
        /// <returns>
        /// A <see cref="Message"/> object that represents the specified <see cref="IExampleRequest"/> message.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when the message type is unknown.</exception>
        internal static Message ToMessage(ISkylineLogicalLayerRequest message)
        {
            switch (message)
            {
                case ParameterMonitorModelMessage parameterMonitorModel:
                    return new GenericInterAppMessage<ParameterMonitorModelMessage>(parameterMonitorModel);

                default:
                    throw new InvalidOperationException("Unknown message type");
            }
        }

        /// <summary>
        /// Converts a <see cref="Message"/> object to an <see cref="IExampleResponse"/>.
        /// </summary>
        /// <param name="message">The <see cref="Message"/> to be converted.</param>
        /// <returns>
        /// An <see cref="IExampleResponse"/> object that represents the data from the specified <see cref="Message"/>.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when the message type is unknown.</exception>
        internal static ISkylineLogicalLayerResponse FromMessage(Message message)
        {
            switch (message)
            {
                case GenericInterAppMessage<ParameterMonitorModelMessageResult> parameterMonitorModelResult:
                    return parameterMonitorModelResult.Data;

                default:
                    throw new InvalidOperationException("Unknown message type");
            }
        }
    }
}
