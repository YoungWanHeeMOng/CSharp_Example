using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_IndexerTest
{
    class Program
    {
        static void Main(string[] args)
        {

            MyCache myCache = new MyCache();
            myCache.Add("ItemId", "1100");
            string dbg=myCache.Get("Debug");
            Console.WriteLine(dbg);

            myCache.Set("Debug", "false");

            string db=myCache["Debug"];
            myCache.Add("Hope", "Dream");
            //myCache["Hope"] = "Dream";

            Console.WriteLine(db);
            Console.WriteLine(myCache["ItemId"]);
            Console.WriteLine(myCache.Get("Logging"));
            Console.WriteLine(myCache.Get("Hope"));
            myCache["Hope"] = "HeeMong";
            Console.WriteLine(myCache.Get("Hope"));


        }
    }
}
