using System.IO;
using System.Text.Json;

namespace TestProject1.Data
{
    public class JsonUserParser : UserParser
    {
        public User ReadUserData(string path)
        {
            string json = System.IO.File.ReadAllText(path).Trim();
            User restoredUser = JsonSerializer.Deserialize<User>(json);
            return restoredUser;
        }

        public async void WriteUserData(string path, User user)
        {
            string json = JsonSerializer.Serialize<User>(user);
            await File.WriteAllTextAsync(path, json);
        }
    }
}
