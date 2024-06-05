namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    using System;


    /// <summary>
    /// InterApp message that will execute the condition model.
    /// </summary>
    [Serializable]
    public class ConditionModel
    {
        /// <summary>
        /// The message command.
        /// </summary>
        public readonly string Command = "ConditionModel";

        /// <summary>
        /// The condition name.
        /// </summary>
        public string ConditionName { get; set; }

        /// <summary>
        /// The condition.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// The visualize option.
        /// </summary>
        public bool Visualize { get; set; }

        /// <summary>
        /// Is the message an update.
        /// </summary>
        public bool IsUpdateMessage { get; set; }
    }
}
