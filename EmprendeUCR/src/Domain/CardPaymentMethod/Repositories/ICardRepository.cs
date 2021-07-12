using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.CardPaymentMethod.Entitities;

namespace EmprendeUCR.Domain.CardPaymentMethod.Repositories
{
    public interface ICardRepository
    {
        Task SaveAsync(Card card);
        Task<IEnumerable<Card>> GetAllAsync();
        Task<Card?> GetByNameAsync(string name);
    }
}
