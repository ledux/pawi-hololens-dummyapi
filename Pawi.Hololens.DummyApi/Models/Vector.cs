namespace Pawi.Hololens.DummyApi.Models
{
    /// <summary>
    /// Represents a point in the cartesian room
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// Value on the X-Axis
        /// </summary>
        public decimal XValue { get; set; }
        /// <summary>
        /// Value on the Y-Axis
        /// </summary>
        public decimal YValue { get; set; }
        /// <summary>
        /// Value on the Z-Axis
        /// </summary>
        public decimal ZValue { get; set; }
    }
}