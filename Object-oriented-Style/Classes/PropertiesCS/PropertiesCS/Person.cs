using System;

namespace PropertiesCS
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 356;
                return years;
            }
        }

        public Person()
        {
            
        }

        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }


    }
}