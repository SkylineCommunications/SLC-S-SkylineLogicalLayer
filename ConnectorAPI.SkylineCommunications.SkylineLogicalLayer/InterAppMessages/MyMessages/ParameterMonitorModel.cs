namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    using System;

    /// <summary>
    /// InterApp message that will execute the parameter monitor model.
    /// </summary>
    [Serializable]
    public class ParameterMonitorModel
    {
        /// <summary>
        /// The message command
        /// </summary>
        public readonly string Command = "ParameterMonitorModel";

        /// <summary>
        /// The parameter monitor name.
        /// </summary>
        public string ParameterMonitorName { get; set; }

        /// <summary>
        /// The element name.
        /// </summary>
        public string ElementName { get; set; }

        /// <summary>
        /// The element dataminer ID
        /// </summary>
        public int ElementDmaId { get; set; }

        /// <summary>
        /// The element ID.
        /// </summary>
        public int ElementElementId { get; set; }

        /// <summary>
        /// The parameter description.
        /// </summary>
        public string ParameterDescription { get; set; }

        /// <summary>
        /// The parameter ID.
        /// </summary>
        public int ParameterId { get; set; }

        /// <summary>
        /// Does the parameter has discreet values.
        /// </summary>
        public bool ParameterIsDiscreet { get; set; }
    }
}
