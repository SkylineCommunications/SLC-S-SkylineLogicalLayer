using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    /// <summary>
    /// InterApp Message that will execute the ParameterMonitorModel message.
    /// </summary>
    public class ParameterMonitorModelMessage : ISkylineLogicalLayerRequest
    {
        /// <summary>
        /// The data needed to execute the ParameterMonitorModel message.
        /// </summary>
        public ParameterMonitorModel ParameterMonitorModel { get; set; }
    }

    /// <summary>
    /// InterApp Message that represents the response from the ParameterMonitorModel message.
    /// </summary>
    public class ParameterMonitorModelMessageResult : ISkylineLogicalLayerResponse
    {
        /// <summary>
        /// Indicates if the InterApp Call was successful or not
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A human readable text representing the response of the InterApp Call.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The InterApp Message that triggered this response.
        /// </summary>
        public ISkylineLogicalLayerRequest Request { get; set; }
    }
}
