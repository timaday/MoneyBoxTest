using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyBoxTest.Config
{
    class TestUsers
    {
        private Dictionary<string, string[]> Users = new Dictionary<string, string[]>();

        public TestUsers() 
        {
            Users.Add("Quai", new string[] { "quia@test.com", "Password123" });
        }

        public string[] Get(string key)
        {
            if (Users.TryGetValue(key, out string[] arr))
            {
                return arr;
            }

            return default;
        }
    }
}
