using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryManager = new DictionaryManager();
            var result = dictionaryManager.Test();

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

          

        }
    }
}
