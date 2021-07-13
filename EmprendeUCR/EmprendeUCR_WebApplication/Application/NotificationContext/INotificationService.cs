using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.NotificationContext;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;

namespace EmprendeUCR_WebApplication.Application.NotificationContext
{
    interface INotificationService
    {
        void EventsSubscriptions(UserNotification UserNotification);
        void GetNotifications(UserNotification UserNotification);
        void GetNotificationsQuantity(UserNotification UserNotification);
        void Unsubscription(UserNotification UserNotification);
    }
}
