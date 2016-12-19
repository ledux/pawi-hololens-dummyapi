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
                        anchor = new Vector { x = 0.11f, y = 0.027f, z = 0.074f },
                        target = new Vector { x = 0.11f, y = 0.07f, z = 0.074f },
                    },
                    new Information
                    {
                        descriptor = "CPU usage",
                        text = $"CPU usage: { rng.Next(5, 100) }",
                        anchor = new Vector { x = 0.019f, y = 0.23f, z = -0.01f },
                        target = new Vector { x = 0.0f, y = 0.27f, z = -0.01f },
                    },
                    new Information
                    {
                        descriptor = "Local Time",
                        text = $"Time: { DateTime.Now.ToShortTimeString() }",
                        anchor = new Vector { x = 0.282f, y = 0.23f, z = -0.01f },
                        target = new Vector { x = 0.31f, y = 0.27f, z = -0.01f },
                    },
                    new Information
                    {
                        descriptor = "Power Plug",
                        text = $"Power Plug",
                        anchor = new Vector { x = 0.0f, y = 0.01f, z = 0.06f },
                        target = new Vector { x = -0.05f, y = 0.01f, z = 0.06f },
                    },
                    new Information
                    {
                        descriptor = "IP",
                        text = $"{this.ControllerContext.Request.RequestUri.AbsoluteUri}",
                        anchor = new Vector { x = 0.3f, y = 0.015f, z = 0.21f },
                        target = new Vector { x = 0.32f, y = 0.035f, z = 0.21f },
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
                        descriptor = "Coffe nozzle",
                        text = $"Coffe nozzle",
                        anchor = new Vector { x = 0.106f, y = 0.18f, z = 0.3f },
                        target = new Vector { x = 0.05f, y = 0.18f, z = 0.35f },
                    },
                    new Information
                    {
                        descriptor = "Water nozzle",
                        text = $"Hot water nozzle",
                        anchor = new Vector { x = 0.255f, y = 0.21f, z = 0.32f },
                        target = new Vector { x = 0.255f, y = 0.21f, z = 0.4f },
                    },
                    new Information
                    {
                        descriptor = "Fluid Level Left",
                        text = $"Fluid Level: 60%",
                        anchor = new Vector { x = 0.513f, y = 0.34f, z = 0.12f },
                        target = new Vector { x = 0.533f, y = 0.4f, z = 0.12f },
                    },
                    new Information
                    {
                        descriptor = "Fluid Level Right",
                        text = $"Fluid Level: 20%",
                        anchor = new Vector { x = -0.006f, y = 0.34f, z = 0.12f },
                        target = new Vector { x = -0.026f, y = 0.4f, z = 0.12f },
                    },
                    new Information
                    {
                        descriptor = "Capsule Level Left",
                        text = $"Capsule Level: 0%",
                        anchor = new Vector { x = 0.441f, y = 0.08f, z = 0.23f },
                        target = new Vector { x = 0.491f, y = 0.1f, z = 0.35f },
                    },
                    new Information
                    {
                        descriptor = "Capsule Level Right",
                        text = $"Capsule Level: 90%",
                        anchor = new Vector { x = 0.068f, y = 0.08f, z = 0.23f },
                        target = new Vector { x = 0.018f, y = 0.1f, z = 0.35f },
                    },
                    new Information
                    {
                        descriptor = "Coffe Count",
                        text = $"Coffe produced since last maintenance: 323",
                        anchor = new Vector { x = 0.13f, y = 0.14f, z = 0.32f },
                        target = new Vector { x = 0.255f, y = 0.18f, z = 0.45f },
                    },
                    new Information
                    {
                        descriptor = "Temperature",
                        text = $"Temperature: { rng.Next(40, 50) } C",
                        anchor = new Vector { x = 0.255f, y = 0.28f, z = 0.271f },
                        target = new Vector { x = 0.255f, y = 0.31f, z = 0.34f },
                    },
                    new Information
                    {
                        descriptor = "Last Maintenance",
                        text = $"Last Maintenance on \n 3th Dec",
                        anchor = new Vector { x = 0.121f, y = 0.365f, z = 0.252f },
                        target = new Vector { x = 0.121f, y = 0.367f, z = 0.252f },
                    },
                    new Information
                    {
                        descriptor = "Time to Maintenance",
                        text = $"Maintenance due on \n 9th Jan",
                        anchor = new Vector { x = 0.387f, y = 0.365f, z = 0.252f },
                        target = new Vector { x = 0.387f, y = 0.367f, z = 0.252f },
                    },
                },
            };
        }
        #endregion
    }
}