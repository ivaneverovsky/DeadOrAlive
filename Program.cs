using System;
using System.Collections.Generic;

namespace DeadOrAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            //declare list and add Persons to it, in the class Person we check their BitrhDate and DeathDate
            List<Person> _persons = new List<Person>();
            var p1 = new Person("Ivan", "Petrov", new DateTime(1980, 01, 23), new DateTime(1999, 01, 01));
            _persons.Add(p1);
            var p2 = new Person("Vladimir", "Soloviev", new DateTime(2002, 01, 23), new DateTime(2020, 01, 01));
            _persons.Add(p2);

            //let user to input new person
            try
            {
                Console.Write("Print Name: ");
                string name = Console.ReadLine();

                Console.Write("Print Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Print Birth (YYYY, MM, DD): ");
                string birth = Console.ReadLine();
                DateTime birthDate = DateTime.Parse(birth);

                Console.Write("Print Death (YYYY, MM, DD): ");
                string death = Console.ReadLine();
                DateTime deathDate = DateTime.Parse(death);

                var p5 = new Person(name, surname, birthDate, deathDate);
                _persons.Add(p5);
            }
            catch (Exception e)
            {
                throw new Exception("error", e);
            }
            Console.WriteLine("\nList of our persons.");

            //print in console our list with persons
            foreach (var item in _persons)
            {
                Console.Write("{0} {1} was born on {2}", item.Name, item.Surname, item.BirthDate);
                Console.WriteLine();
            }

            Console.WriteLine("\nWho lived in the 20th century?");

            //print in console list with persons who was born in the 20th century
            foreach (var item in _persons)
            {
                if ((item.BirthDate < new DateTime(2000, 01, 01) && item.DeathDate > new DateTime(1901,01,01) && item.DeathDate < now) || (item.BirthDate >= new DateTime(1901,01 ,01) && item.BirthDate < new DateTime(2000,01,01) && item.DeathDate <= now && item.DeathDate > new DateTime(1901,01,01)))
                {
                    Console.WriteLine("Person {0} {1} lived in the 20th century", item.Name, item.Surname);
                }
            }

            Console.ReadLine();
        }
    }
}
