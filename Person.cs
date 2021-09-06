using System;
using System.Collections.Generic;
using System.Text;

namespace DeadOrAlive
{
    class Person
    {
        DateTime now = DateTime.Now; // we need it to compare with death date
        public string Name { get; set; }
        public string Surname { get; set; }
        private DateTime _birthdate;
        private DateTime _deathdate;
        public DateTime BirthDate 
        {
            get { return _birthdate; }
            set
            {
                // here we check Birth Date
                if (value > now)
                {
                    throw new ArgumentException("Birthdate cannot be earlier than 01 Jan 1901 and cannot be in the future");
                }
                _birthdate = value;
            }
        }
        public DateTime DeathDate 
        { 
            get { return _deathdate; }
            set
            {
                //here we check Death Date
                if (value > now || value < BirthDate)
                {
                    throw new ArgumentException("Death cannot be in the future or before Birth Date");
                }
                _deathdate = value;
            }
        }

        //constructor for Person class
        public Person(string name, string surname, DateTime birthdate, DateTime deathdate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            DeathDate = deathdate;
        }
        
    }
}
