using Xunit;
using System;
using EmprendeUCR_WebApplication.Data.Entities;
using System.Collections.Generic;

namespace EmprendeUCR.UnitTests.Domain
{
    public class OfferTest
    {
        [Fact]
        public void testTypeOffer()
        {

            // Actividad asignada 6
            // Se mockean algunos productos y objetos de ofertas, y se prueban algunos metodos sobre esta clase

            // test products
            Product product1 = new();
            Product product2 = new();
            Product product3 = new();
            product1.Code_ID = 1;
            product1.Product_Name = "Cafe";
            product1.Price = 800;
            product2.Code_ID = 2;
            product2.Product_Name = "Queque";
            product2.Price = 500;
            product3.Code_ID = 3;
            product3.Product_Name = "Empanada";
            product3.Price = 700;

            // test isoffers
            // combo
            Is_Offer isoffer1 = new();
            isoffer1.Offer_ID = 1;
            isoffer1.Code_ID = 1;
            isoffer1.Amount = 1;
            Is_Offer isoffer2 = new();
            isoffer2.Offer_ID = 1;
            isoffer2.Code_ID = 2;
            isoffer2.Amount = 1;

            // descuento
            Is_Offer isoffer3 = new();
            isoffer3.Offer_ID = 1;
            isoffer3.Code_ID = 1;
            isoffer3.Amount = 3;


            // test offers
            Offer offer1 = new(); // combo
            Offer offer2 = new(); // descuento

            offer1.Discount = 1000;
            offer2.Discount = 1500;

            List<Is_Offer> relatedIs_Offers = new List<Is_Offer>();
            relatedIs_Offers.Add(isoffer1);
            relatedIs_Offers.Add(isoffer2);

            List<Is_Offer> relatedIs_Offers2 = new List<Is_Offer>();
            relatedIs_Offers.Add(isoffer3);

            Assert.True(offer1.isTypeOfferCombo(relatedIs_Offers));
            Assert.False(offer2.isTypeOfferCombo(relatedIs_Offers2));
        }
    }
}
