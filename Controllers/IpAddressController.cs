using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IpAddressController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return GetLocalIPAddress();
        }
        private string GetLocalIPAddress()
        {

            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return this.HttpContext.Connection.LocalIpAddress.MapToIPv4().ToString();
            }

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
