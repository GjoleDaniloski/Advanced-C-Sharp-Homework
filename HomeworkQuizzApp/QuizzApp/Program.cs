using ClassLibraryQuizzApp;
using ClassLibraryQuizzApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quizz App");
            List<Student> studentList = DbUsers.GetStudent();
            List<Teacher> teacherList = DbUsers.GetTeachers();
            int badChoise = 0;
            bool exit = false;

            while ( badChoise <= 2 && exit == false)
            {
                Console.WriteLine("Press 1 - Student \nPress 2 - Teacher \nPress 3 - Exit");
                string choise = Console.ReadLine();
                Console.Clear();
                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Enter your username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        string password = Console.ReadLine();
                        Student findStudent = studentList.SingleOrDefault(x => x.Username == username);

                        if (findStudent == null || findStudent.Password != password)
                        {
                            badChoise++;
                            Console.WriteLine($"Incorrect username or password, you have {3 - badChoise} more tries");
                        }
                        else if (findStudent.Logged == false && findStudent.Password == password)
                        {
                            findStudent.LogChanger();
                            Console.Clear();
                            Console.WriteLine($"Thanks for loggin student {findStudent.Username} with ID: {findStudent.GetId()}");
                            Console.WriteLine("If you want to start with Quiz press any key");
                            char key = Console.ReadKey(true).KeyChar;
                            Console.Clear();
                            findStudent.Grade = DbQuizQuestion.startQuiz();
                        }
                        else if (findStudent.Logged == true && findStudent.Password == password)
                        {
                            Console.WriteLine("You are alredy did the test");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter your username");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        password = Console.ReadLine();
                        Console.Clear();
                        Teacher findTeacher = teacherList.SingleOrDefault(x => x.Username == username);

                        if (findTeacher == null || findTeacher.Password != password)
                        {
                            badChoise++;
                            Console.WriteLine($"Incorrect username or password, you have {3 - badChoise} more tries");
                        }
                        else if (findTeacher.Password == password)
                        {
                            Console.WriteLine($"Welcome {findTeacher.FirstName} {findTeacher.LastName} ");
                            Console.WriteLine($"You are login in teacher pannel with Username: {findTeacher.Username} with ID: {findTeacher.GetId()}");
                            Console.WriteLine("Student list: ");
                            findTeacher.PrintStudents(studentList);

                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                    default: 
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }
    }
}
