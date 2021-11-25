

namespace TestProject1.Data
{
    public interface UserParser
    {
        User ReadUserData();
        void WriteUserData(User user);
    }
}
