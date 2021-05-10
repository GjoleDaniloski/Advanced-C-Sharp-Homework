using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryQuizzApp
{
    public class Student: User
    {
        public int Grade { get; set; }
        public bool Logged = false;

        public bool LogChanger()
        {
            return Logged = true;
        }
    }
}
