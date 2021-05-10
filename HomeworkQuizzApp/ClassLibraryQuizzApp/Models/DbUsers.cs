using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryQuizzApp.Models
{
    public static class DbUsers
    {
        public static List<Student> GetStudent()
        {
            return new List<Student>()
            {
                new Student()
                {
                    FirstName = "Trpe",
                    LastName = "Trpeski",
                    Username = "trpe",
                    Password = "trpe123"
                },

                new Student()
                {
                    FirstName = "Zoran",
                    LastName = "Zoranoski",
                    Username = "zoki",
                    Password = "zoki123"
                },

                new Student()
                {
                    FirstName = "Blazo",
                    LastName = "Blazoski",
                    Username = "blazo",
                    Password = "blazo123"
                },

                new Student()
                {
                    FirstName = "Pero",
                    LastName = "Perovski",
                    Username = "pero",
                    Password = "pero123"
                }
            };
        }

        public static List<Teacher> GetTeachers()
        {
            return new List<Teacher>()
            {
                new Teacher()
                {
                    FirstName = "Anie",
                    LastName = "Kubow",
                    Username = "anie",
                    Password = "anie123"
                },

                new Teacher()
                {
                    FirstName = "Mosh",
                    LastName = "Hamedani",
                    Username = "mosh",
                    Password = "mosh123"
                }
            };
        }
    }
}
