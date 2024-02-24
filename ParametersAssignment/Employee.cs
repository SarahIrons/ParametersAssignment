using System;
using System.Collections.Generic;
using System.Text;
//PARAMETERS ASSIGNMENT

//Perform these actions and create a console app that includes the following:


//Make the Employee class take a generic type parameter.

//Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.

//Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

//Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.

//Create a loop that prints all of the Things to the Console.
namespace ParametersAssignment
{
    public class Employee<T> //the angle bracket is called a type parameter
    {
        public List<T> Things; //setting up to accept a list of the generic Type
       
        public Employee(List<T> ThingsPassedAsArg)//this is set up to take any data type
        {
            this.Things = ThingsPassedAsArg;
        }
    }

}







