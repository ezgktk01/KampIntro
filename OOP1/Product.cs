using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//foreign key'ler primary keyden hemen sonra yazılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }//adet

        //CRUD (Create,Read,Update,Delete)
    }
}
