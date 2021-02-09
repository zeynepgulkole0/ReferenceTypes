using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deger tip { int, decimal, float, enum, boolean..}
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);

            // Referans tip {arrays, class, interface..}
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Zeynep";

            person2 = person1;

            person1.FirstName = "Gül";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Deniz";
            Employee employee = new Employee();

            Person person3 = customer; // Inheritance - Miras
            Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer); //customer, employee, person1-2 (parametre) 
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person // Inheritance - Miras
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person // Inheritance - Miras
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}

//Proje