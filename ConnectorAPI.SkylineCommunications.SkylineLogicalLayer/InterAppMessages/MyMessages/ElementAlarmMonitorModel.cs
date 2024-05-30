namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    using System;

    /// <summary>
    /// The element parameter options.
    /// </summary>
    public enum ElementParameter
    {
        /// <summary>
        /// No element parameter selected, just normal parameter is selected.
        /// </summary>
        None = 0,

        /// <summary>
        /// The alarm state.
        /// </summary>
        ElementAlarmState = -1,

        /// <summary>
        /// The timeout state.
        /// </summary>
        ElementTimeout = -2,
    }

    /// <summary>
    /// InterApp message that will execute the element alarm monitor model.
    /// </summary>
    [Serializable]
    public class ElementAlarmMonitorModel
    {
        /// <summary>
        /// The message command.
        /// </summary>
        public readonly string Command = "ElementAlarmMonitorModel";

        /// <summary>
        /// The element alarm monitor name.
        /// </summary>
        public string ElementAlarmMonitorName { get; set; }

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
        /// The kind of parameter that is selected.
        /// </summary>
        public ElementParameter ElementParameter { get; set; }
    }
}
