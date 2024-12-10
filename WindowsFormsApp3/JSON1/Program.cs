using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Alice",
                Age = 25,
                Hobbies = new List<string> { "reading", "traveling", "gaming" }
            };

            string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            string jsonString = @"{""Name"":""Bob"",""Age"":30,""Hobbies"":[""cooking"",""swimming""]}";
            var deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonString);
            Console.WriteLine("\nDeserialized Object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; }
    }
}
