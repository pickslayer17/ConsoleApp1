using TestProject1.Data;

namespace TestProject1.Tests
{
    class UserDataProvider
    {

        public static User GetUserData(string path, UserParser userParser)
        {
            return userParser.ReadUserData(path);
        }
    }
}
