using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyBoxTest.Config
{
    class SauceLabsInfo
    {
        private Dictionary<string, string> Info = new Dictionary<string, string>();

        public SauceLabsInfo() 
        {
            Info.Add("sauceUser", "testUser");
            Info.Add("sauceAccessKey", "");
        }

        public string Get(string key)
        {
            if (Info.TryGetValue(key, out string arr))
            {
                return arr;
            }

            return default;
        }
    }
}
