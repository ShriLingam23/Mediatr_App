using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediatr_App.Notification.NotificationService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediatr_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly INotifierMediatorService _notifierMediatorService;

        public HomeController(INotifierMediatorService notifierMediatorService)
        {
            _notifierMediatorService = notifierMediatorService;
        }

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            _notifierMediatorService.Notify("This is a test notification");
            return "Completed";
        }
    }
}