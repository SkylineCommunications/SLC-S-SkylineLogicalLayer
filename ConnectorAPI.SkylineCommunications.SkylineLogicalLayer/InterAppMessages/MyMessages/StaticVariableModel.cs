namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    using System;

    /// <summary>
    /// This is the model for the static variable
    /// </summary>
    [Serializable]
    public class StaticVariableModel
    {
        /// <summary>
        /// This is the name for the static variable.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This is the value for the static variable.
        /// </summary>
        public string Value { get; set; }
    }
}
