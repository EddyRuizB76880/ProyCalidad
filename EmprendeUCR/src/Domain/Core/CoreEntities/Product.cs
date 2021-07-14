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
    }
}
