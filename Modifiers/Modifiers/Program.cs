using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
using P507Library;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation, private, protected
            //Person p1 = new Person();
            //Student s = new Student();

            //p1.SetEmail("kenan@mail.ru");
            //Console.WriteLine(p1.GetMail());

            //p1.Name = "sdfghjkl";
            //Console.WriteLine(p1.Name);

            //p1.Email = "kenanmail.com";
            //Console.WriteLine(p1.Email);
            //p1.Phone = "+99444444444";
            //Console.WriteLine(p1.Phone);
            //Test t1 = new Test();
            #endregion

            //Demo.InDemo.Person p1 = new Demo.InDemo.Person();
            //Student s1 = new Student();
            Animal a1 = new Animal();
            a1.Age = 1;
            
            
        }
    }

    class Snake : Animal
    {
        public Snake()
        {
        }
    }

    class Person
    {
        public Person(string n)
        {

        }
    }

    #region Encapsulation, private, protected
    //class Person
    //{
    //    public string Name;
    //    public string Surname;
    //    private string _email;
    //    //public string Phone { get; }
    //    public readonly string Phone;
    //    protected int Age { get; set; }

    //    public Person()
    //    {
    //        Phone = "+99999999999";
    //    }

    //    //public void SetPhone(string p)
    //    //{
    //    //    Phone = p;
    //    //}

    //    //encapsulation
    //    public string Email {

    //        get
    //        {
    //            if (_email == null)
    //            {
    //                return "email set olunmayib";
    //            }
    //            return _email;
    //        }

    //        set
    //        {
    //            if (value.IndexOf('@') == -1)
    //            {
    //                Console.WriteLine("Duzgun email set edin!!!");
    //                return;
    //            }
    //            _email = value;
    //        }
    //    }

    //    //public void SetEmail(string mail)
    //    //{
    //    //    if (mail.IndexOf('@') == -1)
    //    //    {
    //    //        Console.WriteLine("Duzgun email set edin!!!");
    //    //        return;
    //    //    }
    //    //    _email = mail;
    //    //}

    //    //public string GetMail()
    //    //{
    //    //    return _email;
    //    //}

    //}

    //class Student:Person
    //{
    //    public void Info()
    //    {
    //        //Phone = "55555555";
    //        Console.WriteLine($"{Name} {Surname} {Age}");
    //    }
    //}

    ////class Teacher : Person { }

    ////class Engineer : Person { }

    //class Test : Student
    //{
    //    public Test()
    //    {
    //        Console.WriteLine(Age);
    //    }
    //}

    #endregion
}
