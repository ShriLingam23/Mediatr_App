using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediatr_App.Notification.NotificationService
{
    public interface INotifierMediatorService
    {
        void Notify(string notifyText);
    }
}
