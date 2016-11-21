namespace Pawi.Hololens.DummyApi.Models
{
    /// <summary>
    /// Data about a Device and where to Display
    /// </summary>
    public class DeviceData
    {
        /// <summary>
        /// The Information which should be displayed
        /// </summary>
        public string DisplayData { get; set; }
        /// <summary>
        /// Description about the device
        /// </summary>
        public string DeviceDescription { get; set; }
        /// <summary>
        /// Relative position to the source of the displayed data
        /// </summary>
        public Vector PositionToSource { get; set; }
        /// <summary>
        /// Relative position to the device of the source
        /// </summary>
        public Vector PositionToDevice { get; set; }
    }
}