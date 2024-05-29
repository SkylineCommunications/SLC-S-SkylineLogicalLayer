namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer
{
    /// <summary>
    /// Contains constant values used in the ConnectorAPI
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The protocol name to communicate with.
        /// </summary>
        public const string ProtocolName = "Skyline Logical Layer";

        /// <summary>
		/// The ID of the parameter that will receive the InterApp Messages
		/// </summary>
		public const int InterAppReceiverPID = 9000000;

        /// <summary>
        /// The ID of the parameter that will hold the responses for the InterApp Messages
        /// </summary>
        public const int InterAppResponsePID = 9000001;
    }
}
