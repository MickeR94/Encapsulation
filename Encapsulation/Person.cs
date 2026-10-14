using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class Person
    {

        // Instance variables
        private string firstName;
        private string lastName;
        private int age;


        //Constructor for the person class
        public Person(string firstName, string lastName, int age){
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }

    }
}
