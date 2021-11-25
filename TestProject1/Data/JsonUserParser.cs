using System.IO;
using System.Text.Json;

namespace TestProject1.Data
{
    public class JsonUserParser : UserParser
    {
        public const string FILE_NAME = "Resources\\json_user.txt";

        public User ReadUserData()
        {
            var json = File.ReadAllText(FILE_NAME);
            var restoredUser = JsonSerializer.Deserialize<User>(json);
            return restoredUser;
        }

        public async void WriteUserData(User user)
        {
            var json = JsonSerializer.Serialize(user);
            await File.WriteAllTextAsync(FILE_NAME, json);
        }
    }
}