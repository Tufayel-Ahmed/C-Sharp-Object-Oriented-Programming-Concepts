using System;

namespace ValueandReferenceTypeClassandObjectDataHiding
{
    class Program
    {
        public static void Main(String[] args)
        {
            int num = 10;
            ChangeValueType(num);
            Console.WriteLine(num);

            Person person = new Person();
            person.firstName = "Abul";
            person.middleName = "Kalam";
            person.lastName = "Azad";

            ChangeReferenceType(person);

            Console.WriteLine(person.firstName);
            Console.WriteLine(person.middleName);
            Console.WriteLine(person.lastName);

        }

        public static void ChangeValueType(int n)
        {
            n = 20;
        }

        public static void ChangeReferenceType(Person p)
        {
            p.firstName = "Md";
            p.middleName = "Abul";
            p.lastName = "Kalam";
        }
    }
}
