using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteFCMAspCore.Models;

namespace TesteFCMAspCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FCMController : ControllerBase
    {
        private readonly ILogger<FCMController> _logger;

        public FCMController(ILogger<FCMController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> SendCustomNotifiation([FromBody] NotificationModel notificationModel)
        {
            try
            {
                Message message = new Message()
                {
                    Notification = new Notification
                    {
                        Title = notificationModel.Title,
                        Body = notificationModel.Message
                    },
                    Token = notificationModel.Token
                };

                FirebaseMessaging messaging = FirebaseMessaging.DefaultInstance;
                string result = await messaging.SendAsync(message);
                Console.WriteLine(result);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
