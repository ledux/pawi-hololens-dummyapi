using System.Web.Http;
using Pawi.Hololens.DummyApi.Models;

namespace Pawi.Hololens.DummyApi.Controllers
{
    [RoutePrefix("api")]
    public class DeviceDataController : ApiController
    {
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
            throw new System.NotImplementedException();
        }

        private DeviceData CreateDeviceThreeData()
        {
            throw new System.NotImplementedException();
        }

        private DeviceData CreateDeviceTwoData()
        {
            throw new System.NotImplementedException();
        }

        private DeviceData CreateDeviceOneData()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}