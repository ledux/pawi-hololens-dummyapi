using System.Collections.Generic;

namespace Pawi.Hololens.DummyApi.Models
{
    /// <summary>
    /// Containing all information for one device
    /// </summary>
    public class InformationCollection
    {
        /// <summary>
        /// Collection of device information
        /// </summary>
        public List<Information> information { get; set; }
    }
}