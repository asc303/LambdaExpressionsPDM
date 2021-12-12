using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management");
            DataManagement data = new DataManagement();
            List<Person> listPersonsInCity = new List<Person>();
            data.AddRecords(listPersonsInCity);
            data.RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(listPersonsInCity);
            data.CheckingForTeenagerPerson(listPersonsInCity);
            data.RetrieveAverageAge(listPersonsInCity);
            data.CheckingForSpecificName(listPersonsInCity);
            data.SkipRecord_ForAge_LessThanSixty(listPersonsInCity);
        }
    }
}