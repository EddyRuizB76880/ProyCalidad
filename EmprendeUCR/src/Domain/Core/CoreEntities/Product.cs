namespace EmprendeUCR.Domain.Core.CoreEntities
{
    public class Product
    {
        public int Code_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Price { get; set; }
        public string Entrepreneur_Email { get; set; }
        public int Category_ID { get; set; }

        public Product(int codeId, string productName, string productDescription, int price, string entrepreneurEmail, int categoryId)
        {
            Code_ID = codeId;
            Product_Name = productName;
            Product_Description = productDescription;
            Price = price;
            Entrepreneur_Email = entrepreneurEmail;
            Category_ID = categoryId;
        }

        public Product()
        {

        }
    }

}
