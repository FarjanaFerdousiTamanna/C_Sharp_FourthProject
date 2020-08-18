using System;
using FourthProject.People; // as this is the main class, here we have to add 
                            // every new namespace we creat. we created a namespace named
                            //People so we have written that like "using fourthProject.People"

namespace FourthProject
{


    class Program
    {
        static void Main(string[] args)
        {
            Person person= new Person(); // saving it in the memory // class name 
            person.name = "Tamanna";
            person.age = 23;
            person.haspets = true;

            person.greetings();
        }
    }
}
