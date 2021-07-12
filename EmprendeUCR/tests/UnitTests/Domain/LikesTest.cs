using EmprendeUCR.Domain.Core.CoreEntities;
using Xunit;

namespace EmprendeUCR.UnitTests.Domain
{
    public class LikesTest
    {
        [Fact]
        public void TryCreateLike()
        {
            string email = "prueba@email.com";
            int category = 0;

            Likes likes = new Likes
            {
                Members_Email = email,
                Category_Id = category
            };

            Assert.True(email == likes.Members_Email, "The member email does not the same");
            Assert.True(category == likes.Category_Id, "The Category id does not the same");
        }
    }
}

/*
Jostyn Delgado - B82568  ___ Pruebas de Unidad e Integración.
Likes tests.
*/
