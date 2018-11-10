using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Shopping_Spree
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> BagOfProducts { get; set; }

        public override string ToString()
        {
            string products = this.BagOfProducts.Count > 0 ? string.Join(", ", this.BagOfProducts) : "Nothing bought";
            string personStr = $"{this.Name} - {products}";
            return personStr;
        }
    }
}
