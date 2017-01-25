using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        class Student
        {
            public Student() { }
            public Student(string name,string id)
            {
                m_Name = name;
                m_id = id;
   
            }
            private string m_id;
            private string m_Name;
        }
    
        static void Main(string[] args)
        {
            Student Max = new Student("Max", "mg1131");
            Student Donray = new Student("Doray", "dw1178");
            Dictionary<string, Student> tester = new Dictionary<string, Student>();
            tester.Add("Max", Max);
            tester.Add("Donray", Donray);
            Student temp = tester["Max"];
            Console.Read();
        }
    }
}
