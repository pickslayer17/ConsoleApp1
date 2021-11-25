using System;
using System.IO;
using System.Text.Json;

namespace TestProject1.Data
{
    public class JsonUserParser : UserParser
    {
        public const string FILE_NAME = "Resources\\json_user.txt";
        
        public User ReadUserData()
        {
            string json = System.IO.File.ReadAllText(FILE_NAME);
            User restoredUser = JsonSerializer.Deserialize<User>(json);
            return restoredUser;
        }

        public async void WriteUserData(User user)
        {
            string json = JsonSerializer.Serialize<User>(user);
            await File.WriteAllTextAsync(FILE_NAME, json);
        }
    }
}
