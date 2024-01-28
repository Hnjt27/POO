

namespace EX012.Entities
{
    internal class ImportedProduct:Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() 
        { 
        }    

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }


        public override string PriceTag()
        {
            return "Product: " + Name + " $" + totalPrice() + " - (Customs Fee: " + CustomsFee.ToString() + ")";
        }

        public double totalPrice() 
        {
            return CustomsFee + Price;
        }
    }


}
