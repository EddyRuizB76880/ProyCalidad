using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Domain.NotificationContext
{
    public class OrderNotificationClient  : Notification
    {
        public string ClientEmail { get; set; }
        public DateTime DateAndHourCreation { get; set; }
        public string State { set; get; }
        public string NameEntrepenur { set; get; }
        public bool view { get; set; }
        public override string color { get { return State == "Rechazado" ? "danger" : "success"; } }
        public OrderNotificationClient()
        {
            url = "/ClientRequest";
        }

        public override string ToString()
        {
            return "Su pedido a " + NameEntrepenur + " fue " + State;
        }
    }
}
