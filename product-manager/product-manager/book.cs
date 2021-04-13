using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager
{
    class book : product
    {
 public string Author { get; set; }

        public book(string code, string desc, double price, string author):
            base(code, desc, price)
        {

            this.Author = author;
        }


        public override string ToString()
        {
            return base.ToString()+$"Book: {Author}";
        }

    }
}
