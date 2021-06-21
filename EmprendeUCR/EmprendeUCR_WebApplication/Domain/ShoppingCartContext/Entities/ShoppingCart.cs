using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities
{
    public partial class ShoppingCart : AggregateRoot
    {

        private readonly List<ShopLine> _shopLines;
        public string Email { get; set; }

        public IReadOnlyCollection<ShopLine> ShopLines => _shopLines.AsReadOnly();

        internal void DeleteProductFromShoppingCart(ShopLine shopLine)
        {
            if (_shopLines.Exists(p => p == shopLine))
            {
                _shopLines.Remove(shopLine);
                //player.AssignTeam(null);
            }
        }
    }
}
