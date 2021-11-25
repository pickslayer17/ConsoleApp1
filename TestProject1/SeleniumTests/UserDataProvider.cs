using TestProject1.Data;

namespace TestProject1.SeleniumTests
{
    internal class UserDataProvider
    {
        public static User GetUserData(UserParser userParser)
        {
            return userParser.ReadUserData();
        }
    }
}