using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb08
{
    internal class IndexerEx
    {
        class IndexerClass
        {

            private double[] phone_numbers = new double[5];


            public double this[int a]
            {
                get { return phone_numbers[a]; }
                set { phone_numbers[a] = value; }
            }
        }

        public void indexerInput()
        {
            IndexerClass indexer = new IndexerClass();
            indexer[0] = 9100460399;
            indexer[1] = 8142688695;
            indexer[2] = 1236547892;
            indexer[3] = 9136258743;
            indexer[4] = 9563214785;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("phone numbers are :" + indexer[i]);
            }
            Console.WriteLine();
        }
    }
}
