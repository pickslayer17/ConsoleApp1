using System;
using WomenStoreTests.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Email = "qwerty10@test.ru";
            user.Gender = "male";
            user.FirstName = "Alex";
            user.LastName = "Ivanov";
            user.Password = "qscwdvefb43215432";
            user.DateOfBirth = new DateTime(1995, 10, 6);
            user.Company = "iTechArt";
            user.Address = "Ocassio av.2";
            user.City = "New-York";
            user.State = "Kanzas";
            user.Zip = "30012";
            user.HomePhone = "78623214541";

            UserParser parser = new JsonUserParser();
            string path = "json_user.txt";
            parser.WriteUserData(path, user);

             

            var user2 = parser.ReadUserData(path);

            Console.Out.WriteLine(user2.Email);
            Console.Out.WriteLine(user2.Password);
            Console.Out.WriteLine();
        }

    }
}
