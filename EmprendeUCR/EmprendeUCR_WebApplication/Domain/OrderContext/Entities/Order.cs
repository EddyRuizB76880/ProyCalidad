using EmprendeUCR_WebApplication.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* This file is used to map the "Order" table and to used as a Order entity.
 */
namespace EmprendeUCR_WebApplication.Domain.OrderContext.Entities
{
    public partial class Order : AggregateRoot
    {
        public DateTime DateAndHourCreation { get; set; }
        public string ClientEmail { get; set; } 
        public string Details { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string EntrepreneurEmail { get; set; }
        public string State { get; set; }

        // To use EF
        public Order() { }
        public Order(DateTime dateAndHourCreation, string clientEmail, 
                string details,DateTime deliveryDate, string entrepreneurEmail,
                string state)
        {
            DateAndHourCreation = dateAndHourCreation;
            ClientEmail = clientEmail;
            Details = details;
            DeliveryDate = deliveryDate;
            EntrepreneurEmail = entrepreneurEmail;
            State = state;
        }

        /* Summary: Set the organized list.
         * Parameters: Receives the new organized list.
         * Return: Nothing.
         * Exceptions: There aren't known exceptions.
        */
        public void setOrganized(List<Organized> organizeds) {
            Organized = organizeds.AsReadOnly();
        }

        /* Summary: Change all the status of the Organized entities, in the 
         *          organized list, to the new status.
         * Parameters: Receives the new status.
         * Return: Nothing.
         * Exceptions: There aren't known exceptions.
        */
        public void changeGlobalStatus(string newStatus) {
            foreach (var orderLine in Organized)
            {
               orderLine.ChangeStatus(newStatus);
            }
            this.State = newStatus;
        }

        // Foreign entities
        private readonly List<Organized> _organizedList;
        public IReadOnlyCollection<Organized> Organized;
    }
}
