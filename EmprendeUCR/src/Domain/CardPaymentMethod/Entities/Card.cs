using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.ValueObjects;

namespace EmprendeUCR.Domain.CardPaymentMethod.Entitities
{
    public class Card
    {
        public string Name { get; }
        public bool Status { get; private set; }

        public void ChangeStatus()
        {
            Status = !Status;
        }
    }
}

