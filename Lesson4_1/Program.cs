using System;

namespace Lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Vladimir","Putin","Vladimirovich"));
            Console.WriteLine(GetFullName("Tom","Jerry","Disneyovich"));
            Console.WriteLine(GetFullName("George","Bush","Jamesovich"));
            Console.WriteLine(GetFullName("Silvester","Stallone","Jakievich"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName}, {patronymic}";
        }
    }
}
