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
            Console.WriteLine("The Top 2 persons whose age less than 60 are : ");
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Teenagers Persons in the list are : ");
            foreach(Person person in listPersonsInCity.FindAll(x => (x.Age >= 13 && x.Age < 19)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void RetrieveAverageAge(List<Person> listPersonsInCity)
        {
            double averageAge = listPersonsInCity.Average(x => x.Age);
            Console.WriteLine("The Average age of all Persons in the list are : " + averageAge);
        }
        public void CheckingForSpecificName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Enter the name you want to check in the list : ");
            string search = Console.ReadLine();
            if(listPersonsInCity.Exists(e => e.Name == search))
            {
                Console.WriteLine("Yes, The Name {0} is Present in the list",search);
            }
            else
            {
                Console.WriteLine("No, The Name {0} is not Present in the list",search);
            }
        }
        public void SkipRecord_ForAge_LessThanSixty(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The List after Skipping record for age less than 60 : ");
            foreach(Person person in listPersonsInCity.Where(x => x.Age > 60))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void RemoveSpecificName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Enter the name you want to remove from the list : ");
            string delete = Console.ReadLine();
            if (listPersonsInCity.Exists(e => e.Name == delete))
            {
                var removeName = listPersonsInCity.RemoveAll(e => e.Name.Contains(delete));
                Console.WriteLine("The Name {0} is Removed from the list", delete);
            }
            else
            {
                Console.WriteLine("The Entered Name {0} does not exist in the list", delete);
            }
        }
        public void Display(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity)
            {
                Console.WriteLine("SSN : " + person.SSN + "\t\t Name : " + person.Name + "\t\t Address : " + person.Address + "\t\t Age : " + person.Age);
            }
        }
    }
}