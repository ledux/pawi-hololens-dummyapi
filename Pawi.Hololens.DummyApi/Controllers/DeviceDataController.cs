using System;
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
        private static DateTime _instance = DateTime.UtcNow;

        #region public methods
        /// <summary>
        /// You can get different data for devices 1 through 3 and default values for every other id
        /// </summary>
        /// <param name="device">1, 2, 3 or every other number</param>
        /// <returns>Different data for 1, 2 or three or every other number</returns>
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
            TimeSpan time = DateTime.UtcNow - _instance.Date;
            return new DeviceData
            {
                DeviceDescription = "Non functional Device",
                DisplayData = $"Not functional since {time.Minutes} minutes",
                PositionToDevice = new Vector { XValue = 12, YValue = 12, ZValue = 12 },
                PositionToSource = new Vector { XValue = 12, ZValue = 12, YValue = 12 }
            };
        }

        private DeviceData CreateDeviceThreeData()
        {
            long minutes = (DateTime.UtcNow.Ticks - _instance.Ticks) % 100;
            return new DeviceData
            {
                DeviceDescription = "Evil Device",
                DisplayData = $"This Device is evil. It will destroy all mankind in {minutes} minutes",
                PositionToDevice = new Vector { XValue = 5, YValue = 5, ZValue = 5 },
                PositionToSource = new Vector { XValue = 2, ZValue = 2, YValue = 2 }
            };
        }

        private DeviceData CreateDeviceTwoData()
        {
            long rounds = (DateTime.UtcNow.Ticks - _instance.Ticks) % 100;
            long count = (DateTime.UtcNow.Ticks - _instance.Ticks) % 222;
            return new DeviceData
            {
                DeviceDescription = "Device Two",
                DisplayData = $"Rounds: {rounds}\nCount: {count}",
                PositionToDevice = new Vector { XValue = 8, YValue = 8, ZValue = 8 },
                PositionToSource = new Vector { XValue = 4, ZValue = 4, YValue = 4 }
            };
        }

        private DeviceData CreateDeviceOneData()
        {
            bool workingWell = (DateTime.UtcNow.Ticks - _instance.Ticks) % 2 == 0;
            return new DeviceData
            {
                DeviceDescription = "Device One",
                DisplayData = workingWell ? "This Device is working well" : "FAILURE: ATTENTION REQUIRED",
                PositionToDevice = new Vector { XValue = 10, YValue = 10, ZValue = 10 },
                PositionToSource = new Vector { XValue = 5, ZValue = 5, YValue = 5 }
            };
        }
        #endregion
    }
}