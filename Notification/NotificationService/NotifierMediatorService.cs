using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediatr_App.Notification.NotificationService
{
    public class NotifierMediatorService : INotifierMediatorService
    {
        private readonly IMediator _mediator;

        public NotifierMediatorService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Notify(string notifyText)
        {
            //This will send the Message object NotificationMessage, 
            //to all the handlers that is supposed to handle it
            _mediator.Publish(new NotificationMessage { NotifyText = notifyText });
        }
    }
}
