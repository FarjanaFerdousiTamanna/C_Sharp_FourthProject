using System;
using System.Collections.Generic;
using System.Text;

namespace FourthProject.People  //thid is the new class we created inside a namespace 
                                // here we have to mention the namespace name so that it can relate. 
{
    class Person
    {
        // mentioning 3 fields
        public string name;
        public int age;
        public bool haspets;

        // creating a method
        public void greetings() 
        {
            Console.WriteLine("My name is " + name + " and my age is " + age + ".");
        
        }
    }
}
