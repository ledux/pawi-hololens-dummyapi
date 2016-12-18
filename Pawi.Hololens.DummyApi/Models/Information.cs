namespace Pawi.Hololens.DummyApi.Models
{
    /// <summary>
    /// Data about a Device and where to Display
    /// </summary>
    public class Information
    {
        /// <summary>
        /// The Information which should be displayed
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// Description about the device
        /// </summary>
        public string descriptor { get; set; }
        /// <summary>
        /// Relative position to the point on the device
        /// </summary>
        public Vector anchor { get; set; }
        /// <summary>
        /// Relative position to the information of the device
        /// </summary>
        public Vector target { get; set; }
    }
}