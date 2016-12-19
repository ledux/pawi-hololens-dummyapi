using System;
using System.Web.Http;
using Pawi.Hololens.DummyApi.Models;
using System.Collections.Generic;

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
        public InformationCollection Get(int device)
        {
            switch (device)
            {
                case 1:
                    return CreateLaptopDeviceData();
                case 2:
                    return CreateCoffeDeviceData();
                default:
                    return CreateDefaultData();
            }
        }
        #endregion

        #region private methods
        private InformationCollection CreateDefaultData()
        {
            return new InformationCollection
            {
                information = new List<Information> {
                    new Information
                    {
                        descriptor = "Not Available",
                        text = $"The device is not available",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.0f, y = 0.3f, z = 0.0f },
                    }
                }
            };
        }

        private InformationCollection CreateLaptopDeviceData()
        {
            var rng = new Random();

            return new InformationCollection
            {
                information = new List<Information> {
                    new Information
                    {
                        descriptor = "Power Button",
                        text = $"Power Button",
                        anchor = new Vector { x = 0.11f, y = 0.014f, z = 0.085f },
                        target = new Vector { x = 0.11f, y = 0.07f, z = 0.085f },
                    },
                    new Information
                    {
                        descriptor = "CPU usage",
                        text = $"CPU usage: { rng.Next(5, 100) }",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.0f, y = 0.4f, z = 0.0f },
                    },
                    new Information
                    {
                        descriptor = "Local Time",
                        text = $"Time: { DateTime.Now.ToShortTimeString() }",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.1f, y = 0.1f, z = 0.2f },
                    },
                    new Information
                    {
                        descriptor = "Power Plug",
                        text = $"Power Plug",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.1f, y = 0.1f, z = 0.2f },
                    },
                },
            };
        }

        private InformationCollection CreateCoffeDeviceData()
        {
            var rng = new Random();

            return new InformationCollection
            {
                information = new List<Information> {
                    new Information
                    {
                        descriptor = "Power Button",
                        text = $"Power Button",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.1f, y = 0.3f, z = 0.0f },
                    },
                    new Information
                    {
                        descriptor = "Temperature",
                        text = $"Temperature: { rng.Next(40, 50) } C",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.0f, y = 0.4f, z = 0.0f },
                    },
                    new Information
                    {
                        descriptor = "Fluid Level",
                        text = $"Fluid Level: 60%",
                        anchor = new Vector { x = 0, y = 0, z = 0 },
                        target = new Vector { x = 0.1f, y = 0.1f, z = 0.2f },
                    },
                },
            };
        }
        #endregion
    }
}