using System;


namespace EX012.Entities
{
    internal class UsedProduct:Product
    {
        public DateTime ManufacturedDate{ get; set; }


        public UsedProduct() 
        { 
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufacturedDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return  base.PriceTag() + " (Manufactured Date: " + ManufacturedDate.ToString(" dd/MM/yyyy ") + ")"; 
        }
    }
}
