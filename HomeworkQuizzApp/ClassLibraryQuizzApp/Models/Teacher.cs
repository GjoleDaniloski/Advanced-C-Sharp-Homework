using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryQuizzApp
{
    public class Teacher : User
    {
        public void PrintStudents(List<Student> listStudent)
        {
            foreach (Student item in listStudent)
            {
                if (item.Logged)
                {
                    Console.WriteLine($"Student {item.FirstName} {item.LastName}, with grade of {item.Grade}");
                }
                else
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}" );
                }
            }
        }
    }
}
