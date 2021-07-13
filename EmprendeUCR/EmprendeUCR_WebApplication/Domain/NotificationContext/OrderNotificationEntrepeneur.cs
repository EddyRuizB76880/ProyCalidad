using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Domain.NotificationContext
{
    public class OrderNotificationEntrepeneur : Notification
    {
        public string ClientEmail { get; set; }
        public DateTime DateAndHourCreation { get; set; }
        
        public string State { set; get; }
        public string EntrepreneurEmail { get; set; }
        public string nameClient { set; get; }
        public OrderNotificationEntrepeneur() {
            url = "/OrderAcceptance";
            color = "warning"; 
        }

        public override string ToString()
        {
            return "Tiene un nuevo pedido de " + nameClient ;
        }

    }
}
