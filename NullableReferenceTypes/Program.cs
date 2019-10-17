using System;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Eric", "De Carufel");
            var length = GetMiddleNameLength(person);
            Console.WriteLine(length);
        }

        private static int GetMiddleNameLength(Person person)
        {
            var middle = person.MiddleName;
            return middle.Length;
        }
    }
}
