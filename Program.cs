using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Marilyn" }, { "age", "25" } });
            myFamily.Add("step sister", new Dictionary<string, string>() { { "name", "Mary Ann" }, { "age", "19" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Gilligan" }, { "age", "20" } });
            myFamily.Add("father in law", new Dictionary<string, string>() { { "name", "Skipper" }, { "age", "55" } });

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]}");
            }
        }
    }
}
