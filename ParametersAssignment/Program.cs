using System;
using System.Collections.Generic; //have to import to use "Generic" and idea of list

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Names = new List<string>(); //declare a list of strings and add names(items) to list.
            Names.Add("Tom");
            Names.Add("Dick");
            Names.Add("Harry");

            List<int> Ids = new List<int>(); //declare list of integers
            Ids.Add(101);
            Ids.Add(102);
            Ids.Add(103);

            Employee<string> EmpNames = new Employee<string>(Names); //first instance of generics data "things" using string
            Employee<int> EmpIdNums = new Employee<int>(Ids); //second instance of data type "things" using integer

           foreach (string i in EmpNames.Things)
            {
                Console.WriteLine(i);
            }
            foreach (int i in EmpIdNums.Things)//this is written nearly the same as above loop but just changed out variable id nums instead of names
            {
                Console.WriteLine(i);
            }
        }
    }
    
}


