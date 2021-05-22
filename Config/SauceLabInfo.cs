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
            Info.Add("sauceUser", "timaday");
            Info.Add("sauceAccessKey", "72de811d-a776-4fb2-9394-7ba6a690d46d");
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
