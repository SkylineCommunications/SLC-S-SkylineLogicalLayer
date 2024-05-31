namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.SkylineLogicalLayer.InterAppMessages.MyMessages
{
    using System;

    /// <summary>
    /// InterApp message that will execute the element cell alarm monitor model.
    /// </summary>
    [Serializable]
    public class ElementCellAlarmMonitorModel
    {
        /// <summary>
        /// The message command.
        /// </summary>
        public readonly string Command = "ElementCellAlarmMonitorModel";

        /// <summary>
        /// The cell monitor name.
        /// </summary>
        public string CellMonitorName { get; set; }

        /// <summary>
        /// The element name.
        /// </summary>
        public string ElementName { get; set; }

        /// <summary>
        /// The element dataminer ID.
        /// </summary>
        public int ElementDmaId { get; set; }

        /// <summary>
        /// The element ID.
        /// </summary>
        public int ElementElementId { get; set; }

        /// <summary>
        /// The table ID.
        /// </summary>
        public int TableId { get; set; }

        /// <summary>
        /// The column description.
        /// </summary>
        public string ColumnDescription { get; set; }

        /// <summary>
        /// The column ID.
        /// </summary>
        public int ColumnId { get; set; }

        /// <summary>
        /// The index.
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        /// The display key.
        /// </summary>
        public string DisplayKey { get; set; }
    }
}
