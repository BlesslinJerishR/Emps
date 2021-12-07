using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emps
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student()
            {
                stdId = 420,
                stdName = "Krishna",
                stdAdd= "Heaven",
                stdContact= 0000000,
                stdMail = "krishna@radha.com",
            };
            Console.WriteLine($"Stduent id {s1.stdId} || Student Name : {s1.stdName} || Student Address : {s1.stdAdd} || Student Contact : {s1.stdContact} || Student Mail : {s1.stdMail}");
            Console.WriteLine("");
            Person p1 = new Person()
            {
                pId = 420,
                pName = "Ram",
                pAge = 99,
                pOcc = "Doubting Wives",
            };

            Console.WriteLine($"Person id {p1.pId} || Person Name : {p1.pName} || Person Age : {p1.pAge} || Person Occupation : {p1.pOcc}");

            Console.ReadLine();
        }
        
        public class Person
        {
            public int pId;
            public string pName;
            public int pAge;
            public string pOcc;

            public Person()
            {
                Console.WriteLine("Default contructor invoked");
            }

            public Person(int _pId, string _pName, int _pAge, string _pOcc)
            {
                pId = _pId;
                pName = _pName;
                pAge = _pAge;
                pOcc = _pOcc;
            }
        }

        public class Student
        {
            public int stdId;
            public string stdName;
            public string stdAdd;
            public int stdContact;
            public string stdMail;

            public Student()
            {
                Console.WriteLine("Default contructor invoked");
            }

            public Student(int _stdId, string _stdName, string _stdAdd, int _stdContact, string _stdMail)
            {
                stdId = _stdId;
                stdName = _stdName;
                stdAdd= _stdAdd;
                stdContact= _stdContact;
                stdMail = _stdMail;
            }   
        }
    }
}
