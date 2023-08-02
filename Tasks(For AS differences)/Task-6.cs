using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_For_AS_differences_
{
    internal class Product
    {
        #region props_declaration
        public int Product_id;
        public string Name;
        public int quantity;
        public float price;

        #endregion
    }


    internal class Product_insertion
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product()
            {
                Product_id = 1,
                Name = "Cycle",
                quantity = 1,
                price = 12000
            });

            list.Add(new Product()
            {
                Product_id = 2,
                Name = "Bike",
                quantity = 1,
                price = 200000
            });

            var list_items = list.Select(x => new { x.Product_id, x.Name }).OrderByDescending(x => x.Product_id);

            foreach (var item in list_items)

            {
                Console.WriteLine(item);
                Console.WriteLine(item.Name[0]);
            }
        }
    }
}
