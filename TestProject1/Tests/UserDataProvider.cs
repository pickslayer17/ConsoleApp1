using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WomenStoreTests.Data;

namespace WomenStoreTests.Tests
{
    class UserDataProvider
    {

        public static User GetUserData(string path, UserParser userParser)
        {
            return userParser.ReadUserData(path);
        }
    }
}
