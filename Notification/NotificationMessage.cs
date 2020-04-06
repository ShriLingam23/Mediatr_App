using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediatr_App.Notification
{
    //This is the Message object that is transfered inbetween clients
    public class NotificationMessage : INotification
    {
        public string NotifyText { get; set; }
    }
}
