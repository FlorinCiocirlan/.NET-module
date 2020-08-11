using System;

namespace PersonClass
{
    public class Person
    {
        private string name;
        private DateTime birthdate;
        private Genders gender;
        public enum Genders { male,female};
        public override string ToString()
        {
            return name + " was born on " + birthdate + " and is a" + gender;  
        }

        public Person(string fullName, DateTime birthDate,Genders gend) {
            name = fullName;
            birthdate = birthDate;
            gender = gend;
        }
        public static void Main(string[] args)
        {
            Person Andrei = new Person("Andrei", new DateTime(2020, 08, 11),Genders.male);
            Console.WriteLine(Andrei.ToString());
        }
    }
}
