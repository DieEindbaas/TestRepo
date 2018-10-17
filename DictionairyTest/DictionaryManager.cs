using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class DictionaryManager
    {
        //adding note for testing purposes
        Dictionary<string, string> testDictionary = new Dictionary<string, string>();

        public void Add(string key, string value/*, Dictionary<string, string> dictionary*/)
        {
            if (!testDictionary.ContainsKey(key))
            {
                testDictionary.Add(key, value);
            }

            else { throw new ArgumentException("Dictionary allready contains key"); }
        }


        public IEnumerable<string> Test()
        {
            AutoAdder(testDictionary);
            foreach (var n in testDictionary)
            {
                yield return n.Value;
            }
        }

        public void AutoAdder(Dictionary<string, string> dictionairy)
        {
            for (var i = 0; i < 20; i++)
            {
                Add(Convert.ToString(i), Convert.ToString(i));
            }
        }


    }
}
