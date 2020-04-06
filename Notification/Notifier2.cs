using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr_App.Notification
{
    public class Notifier2 : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Debugging from Notifier 2. Message  : {notification.NotifyText} ");
            return Task.CompletedTask;
        }
    }
}
