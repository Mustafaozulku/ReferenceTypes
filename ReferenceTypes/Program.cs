using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 20;
            sayı1 = sayı2;
            sayı2 = 100;
            Console.WriteLine("sayı1 :" + sayı1);

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            Console.WriteLine("sayılar1[0] :" + sayılar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FistName = "mustafa";

            person2 = person1;
            person1.FistName = "ahmet";
            Console.WriteLine(person2.FistName);




            Customer customer = new Customer();
            customer.FistName = "salih";
            customer.CreditCardNumber = "1234567890";
            
            Employee employee = new Employee();
            employee.FistName = "başak";
            

            Person person3 = customer;
            customer.FistName = "damla";



             Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonMenager personMenager = new PersonMenager();
            personMenager.Add(employee);
            
            
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonMenager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FistName);
        }
    }

}
