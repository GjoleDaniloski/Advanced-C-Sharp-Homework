using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryQuizzApp
{
    public class User
    {
        private int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        static int counter = 0;
        public User()
        {
            counter += 1;
            ID = counter;
        }
        public int GetId()
        {
            return ID;
        }

    }
}
