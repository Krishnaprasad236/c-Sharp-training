using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb01
{
    internal class StaticAttributes
    {
        string bookName = "";
        string authoreName = "";
        string bookTilte = "";
        int bookCost;
        int saleCost;
        public static int saleCount=0;

        public StaticAttributes(string bookName, string authoreName, string bookTilte, int bookCost, int saleCost)
        {
            this.bookName = bookName;
            this.authoreName = authoreName;
            this.bookTilte = bookTilte;
            this.bookCost = bookCost;
            this.saleCost = saleCost;
        }

        public void profit()
        {
            int profit = saleCost - bookCost;

            if (profit <= 0)
            {
                Console.WriteLine("loss of the book is  :" + profit);
            }
            else if (profit >= 1)
            {
                Console.WriteLine("profit of the book is :" + profit);
                saleCount++;
            }
        }
    }
}
