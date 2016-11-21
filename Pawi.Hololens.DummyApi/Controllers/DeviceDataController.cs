using System.Web.Http;
using Pawi.Hololens.DummyApi.Models;

namespace Pawi.Hololens.DummyApi.Controllers
{
    /// <summary>
    /// Returns some dummy data for a proof concept application
    /// </summary>
    [RoutePrefix("api")]
    public class DeviceDataController : ApiController
    {
        /// <summary>
        /// You can get different data for devices 1 through 3 and default values for every other id
        /// </summary>
        /// <param name="device">1, 2, 3 or every other number</param>
        /// <returns>Different data for 1, 2 or three or every other number</returns>
        #region public methods
        [Route("{device:int}")]
        public DeviceData Get(int device)
        {
            switch (device)
            {
                case 1:
                    return CreateDeviceOneData();
                case 2:
                    return CreateDeviceTwoData();
                case 3:
                    return CreateDeviceThreeData();
                default:
                    return CreateDefaultData();
            }
        }
        #endregion

        #region private methods
        private DeviceData CreateDefaultData()
        {
            return new DeviceData
            {
                DeviceDescription = "Generic Device",
                DisplayData = "This device isn't functional. It's just a mockup for a showcase",
                PositionToDevice = new Vector { XValue = 12, YValue = 12, ZValue = 12 },
                PositionToSource = new Vector { XValue = 12, ZValue = 12, YValue = 12 }
            };
        }

        private DeviceData CreateDeviceThreeData()
        {
            return new DeviceData
            {
                DeviceDescription = "Device Three",
                DisplayData = "This Device is evil. It will destroy all mankind. DO NOT INTERACT WITH IT IN ANY KIND!",
                PositionToDevice = new Vector { XValue = 5, YValue = 5, ZValue = 5 },
                PositionToSource = new Vector { XValue = 2, ZValue = 2, YValue = 2 }
            };
        }

        private DeviceData CreateDeviceTwoData()
        {
            return new DeviceData
            {
                DeviceDescription = "Device Two",
                DisplayData = "Some Data for another device. This is broken and cannot be used",
                PositionToDevice = new Vector { XValue = 8, YValue = 8, ZValue = 8 },
                PositionToSource = new Vector { XValue = 4, ZValue = 4, YValue = 4 }
            };
        }

        private DeviceData CreateDeviceOneData()
        {
            return new DeviceData
            {
                DeviceDescription = "Device One",
                DisplayData = "Some Data for this device. It is working well and everything is OK.",
                PositionToDevice = new Vector { XValue = 10, YValue = 10, ZValue = 10 },
                PositionToSource = new Vector { XValue = 5, ZValue = 5, YValue = 5 }
            };
        }
        #endregion
    }
}