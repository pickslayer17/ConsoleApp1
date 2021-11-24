

namespace TestProject1.Data
{
    public interface UserParser
    {
        User ReadUserData(string path);
        void WriteUserData(string path, User user);
    }
}
