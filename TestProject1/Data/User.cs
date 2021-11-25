using System;

namespace TestProject1.Data
{
    public class User
    {
        private string _email;
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HomePhone { get; set; }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Password { get; set; }
    }
}