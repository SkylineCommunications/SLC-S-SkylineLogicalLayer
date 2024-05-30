namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    using System;

    /// <summary>
    /// InterApp message that will execute the view alarm monitor model.
    /// </summary>
    [Serializable]
    public class ViewAlarmMonitorModel
    {
        /// <summary>
        /// The message command.
        /// </summary>
        public readonly string Command = "ViewAlarmMonitorModel";

        /// <summary>
        /// The view alarm monitor name.
        /// </summary>
        public string ViewAlarmMonitorName { get; set; }

        /// <summary>
        /// The view ID.
        /// </summary>
        public int ViewId { get; set; }

        /// <summary>
        /// The view name.
        /// </summary>
        public string ViewName { get; set; }

        /// <summary>
        /// The parameter.
        /// </summary>
        public string Parameter { get; set; }
    }
}
