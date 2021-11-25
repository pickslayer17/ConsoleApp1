using TestProject1.Data;

namespace TestProject1.Tests
{
    class UserDataProvider
    {

        public static User GetUserData(UserParser userParser)
        {
            return userParser.ReadUserData();
        }
    }
}
