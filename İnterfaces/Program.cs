using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    //interface IPerson
    //{
    //    int Id { get; set; }
    //    string FirstName { get; set; }
    //    string LastName { get; set; }
    //}

    //class Customer : IPerson
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Adress { get; set; }
    //}

    //class Student : IPerson
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Department { get; set; }
    //}

    //class worker : IPerson
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Department { get; set; }
    //}


    //class PersonManager
    //{
    //    public void Add(IPerson person)
    //    {
    //        Console.WriteLine(person.FirstName);
    //        Console.WriteLine(person.LastName);
    //        Console.WriteLine(person.Id);
    //    }
    //}




    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add((new SqlServerDal()));












            //PersonManager manager = new PersonManager();
            //manager.Add(new Customer{Id = 1,FirstName = "Cengo",LastName = "Uyar",Adress = "Tokat"});
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Cengiz",
            //    LastName = "Uyar",
            //    Adress = "Tokat"
            //};
            //Student student = new Student
            //{
            //    Id = 2,
            //    FirstName = "Zeynep",
            //    LastName = "Uyar",
            //    Department = "İngilizce"
            //};
            //manager.Add( student);
            //manager.Add( customer);
            

             Console.ReadLine();
        }

    }




}
