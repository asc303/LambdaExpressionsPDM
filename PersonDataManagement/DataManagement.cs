using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    public class DataManagement
    {
        public void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("173012021", "Ashutosh", "Varanasi, Uttar Pradesh", 24));
            listPersonsInCity.Add(new Person("173022021", "Abhishek", "Varanasi, Uttar Pradesh", 20));
            listPersonsInCity.Add(new Person("173032021", "Sam", "Varanasi, Uttar Pradesh", 55));
            listPersonsInCity.Add(new Person("173042021", "Aditya", "Varanasi, Uttar Pradesh", 30));
            listPersonsInCity.Add(new Person("173052021", "Parth", "Varanasi, Uttar Pradesh", 65));
            listPersonsInCity.Add(new Person("173062021", "Ashish", "Varanasi, Uttar Pradesh", 29));
            listPersonsInCity.Add(new Person("173072021", "Mahendra", "Varanasi, Uttar Pradesh", 17));
            listPersonsInCity.Add(new Person("173082021", "Rajat", "Varanasi, Uttar Pradesh", 87));
            listPersonsInCity.Add(new Person("173092021", "Golu", "Varanasi, Uttar Pradesh", 12));
            listPersonsInCity.Add(new Person("173102021", "Radhe", "Varanasi, Uttar Pradesh", 55));
        }
        public void RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Teenagers Persons in the list are : ");
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age >= 13 && x.Age < 19)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void RetrieveAverageAge(List<Person> listPersonsInCity)
        {
            double averageAge = listPersonsInCity.Average(x => x.Age);
            Console.WriteLine("The Average age of all Persons in the list are : " + averageAge);
        }
    }
}