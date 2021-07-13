using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using System;

namespace EmprendeUCR_WebApplication.Domain.NotificationContext
{
    public partial class Notification
    {
        public DateTime date { get; set; }

        public string url { get; set; }

        public virtual string color { get; set; }
        public byte Type { get; set; }

        public virtual string ToString()
        {
            return "Ha recibido una nueva notificación";
        }

    }
}
