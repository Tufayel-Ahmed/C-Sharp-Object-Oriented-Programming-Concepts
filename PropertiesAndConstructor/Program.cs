using System;

namespace PropertiesAndConstructor
{
    class Program
    {
        public static void Main(String[] args)
        {
            Person person = new Person("Tufayel Ahmed", 27, "Dhaka");
            Person person1 = new Person("Tufayel Ahmed", 27);
            Person person2 = new Person();
        }
    }
}
